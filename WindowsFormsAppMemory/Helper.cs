﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMemory
{
    class Helper
    {
        /*public List<string> names = new List<string>(50);
        public List<string> codes = new List<string>(50);*/


        static public Dictionary<string, StringByteArPair> dict = new Dictionary<string, StringByteArPair>(1000);

        static Random r = new Random();

        public static int CHAVE_SIZE = 20;
        public static int VALOR_SIZE = 20;


        static public bool AddToDict(string k, int codeSize, int quantSpecial, int quantNumerical)
        {

            try
            {
                string s = GenCode(codeSize, quantSpecial, quantNumerical);
                StringByteArPair sbp = new StringByteArPair(s, null);
                dict.Add(k, sbp);
                return true;
            }
            catch (ArgumentException)
            {
                return false;   
            }
        }

        static public bool AddEscolhido(string chave, string codEscolhido)
        {
            try
            {
                if ( (chave != null) && (!chave.Equals("")) && (codEscolhido != null) && (!codEscolhido.Equals("")))
                {
                    if (codEscolhido.Length <= VALOR_SIZE)
                    {
                        StringByteArPair sbp = new StringByteArPair(codEscolhido, null);
                        dict.Add(chave, sbp);
                        return true;
                    }
                    else return false;
                }
                else return false;
                
            }
            catch (Exception)
            {
                return false;
            }
        }

        static public bool SizeParamsPossible(int specChar, int numberQuant, int size)
        {
            return (((specChar + numberQuant) <= size) && (size > 0));
        }

        static public bool IsKeySizeValid(string s)
        {
            if (s == null)
            {
                return false;
            }
            else if (s.Equals("") || s.Length > CHAVE_SIZE)
            {
                return false;
            }
            return true;
        }

        static public void prepareDictToSave()
        {
            foreach (var i in dict.Keys)
            {
                dict[i].ByteAr = Encryptor.EncryptStringToBytes_Aes(dict[i].Str);
                dict[i].Str = null;
            }
        }

        static public void prepareDictAfterLoad()
        {
            foreach (var i in dict.Keys)
            {
                dict[i].Str = Encryptor.DecryptStringFromBytes_Aes(dict[i].ByteAr);
                dict[i].ByteAr = null;
            }
        }

        static public bool SaveDict()
        {
            try
            {
                // Construct a BinaryFormatter and use it to serialize the data to the stream.

                string currDir = Directory.GetCurrentDirectory();

                string FILE_NAME = (currDir + @"\data.dat");

                FileStream fs = null;

                BinaryFormatter formatter = new BinaryFormatter();

                using (fs = new FileStream(FILE_NAME, FileMode.Create))
                {
                    prepareDictToSave();

                    formatter.Serialize(fs, dict);
                }
                
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Falha ao salvar, motivo: " + e.Message);

                return false;
            }
            
        }

        static public bool LoadDict()
        {

            // Construct a BinaryFormatter and use it to serialize the data to the stream.

            string currDir = Directory.GetCurrentDirectory();

            string FILE_NAME = (currDir + @"\data.dat");

            if (!File.Exists(FILE_NAME))
            {
                return false;
            }

            using (FileStream fs = new FileStream(FILE_NAME, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                try
                {
                    dict = (Dictionary<string, StringByteArPair>)formatter.Deserialize(fs);

                    prepareDictAfterLoad();

                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Falha no Load do arquivo, motivo: " + e.Message);
                    return false;
                }
                finally
                {
                    fs.Close();
                }
            }
        }


        public static void DeletePairByKey(string key)
        {
            dict.Remove(key);
        }

        public static void WriteToTextBox(TextBox tb)
        {
            string s = "";

            tb.Text = "";

            //todo formatação - ordenar

            List<KeyValuePair <string, StringByteArPair>> tempList = dict.ToList();

            tempList.Sort(CompareByName);
           
            foreach (var item in tempList)
            {
                tb.AppendText(item.Key + ":" + Helper.dict[item.Key].Str + "\n");
            }

        }
        public static int CompareByName(KeyValuePair<string, StringByteArPair> a, KeyValuePair<string, StringByteArPair> b)
        {
            return String.Compare(a.Key, b.Key);
        }
        public static void updateComboDeletable(ComboBox cb)
        {
            
            cb.Items.Clear();

            List<KeyValuePair<string, StringByteArPair>> tempList = dict.ToList();

            tempList.Sort(CompareByName);
            
            /*
            foreach (var item in dict.Keys)
            {
                cb.Items.Add(item);
            }*/
            foreach (var item in tempList)
            {
                cb.Items.Add(item.Key);
            }

        }





        static private string GenCode(int codeSize, int quantSpecial, int quantNumerical)
        {
            string str = null;

            do
            {
                char[] charAr = new char[codeSize];

                for (int i = 0; i < codeSize; i++)
                {
                    charAr[i] = GetRandomChar();
                }

                str = new string(charAr);
            } while (
                        CheckHasExactSpecialChars(str, quantSpecial) == false ||
                        CheckHasExactNumericalChars(str, quantNumerical) == false);
            

            return str;
        }

        /*
            35	043	23	00100011	#	&#35;	 	Number
            36	044	24	00100100	$	&#36;	 	Dollar
            37	045	25	00100101	%	&#37;	 	Per cent sign
            38	046	26	00100110	&	&#38;	&amp;	Ampersand
            
            48	060	30	00110000	0	&#48;	 	Zero
            49	061	31	00110001	1	&#49;	 	One
            50	062	32	00110010	2	&#50;	 	Two
            51	063	33	00110011	3	&#51;	 	Three
            52	064	34	00110100	4	&#52;	 	Four
            53	065	35	00110101	5	&#53;	 	Five
            54	066	36	00110110	6	&#54;	 	Six
            55	067	37	00110111	7	&#55;	 	Seven
            56	070	38	00111000	8	&#56;	 	Eight
            57	071	39	00111001	9	&#57;	 	Nine

            64	100	40	01000000	@	&#64;	 	At symbol
            65	101	41	01000001	A	&#65;	 	Uppercase A
            66	102	42	01000010	B	&#66;	 	Uppercase B
            67	103	43	01000011	C	&#67;	 	Uppercase C
            68	104	44	01000100	D	&#68;	 	Uppercase D
            69	105	45	01000101	E	&#69;	 	Uppercase E
            70	106	46	01000110	F	&#70;	 	Uppercase F
            71	107	47	01000111	G	&#71;	 	Uppercase G
            72	110	48	01001000	H	&#72;	 	Uppercase H
            73	111	49	01001001	I	&#73;	 	Uppercase I
            74	112	4A	01001010	J	&#74;	 	Uppercase J
            75	113	4B	01001011	K	&#75;	 	Uppercase K
            76	114	4C	01001100	L	&#76;	 	Uppercase L
            77	115	4D	01001101	M	&#77;	 	Uppercase M
            78	116	4E	01001110	N	&#78;	 	Uppercase N
            79	117	4F	01001111	O	&#79;	 	Uppercase O
            80	120	50	01010000	P	&#80;	 	Uppercase P
            81	121	51	01010001	Q	&#81;	 	Uppercase Q
            82	122	52	01010010	R	&#82;	 	Uppercase R
            83	123	53	01010011	S	&#83;	 	Uppercase S
            84	124	54	01010100	T	&#84;	 	Uppercase T
            85	125	55	01010101	U	&#85;	 	Uppercase U
            86	126	56	01010110	V	&#86;	 	Uppercase V
            87	127	57	01010111	W	&#87;	 	Uppercase W
            88	130	58	01011000	X	&#88;	 	Uppercase X
            89	131	59	01011001	Y	&#89;	 	Uppercase Y
            90	132	5A	01011010	Z	&#90;	 	Uppercase Z
            
            97	141	61	01100001	a	&#97;	 	Lowercase a
            98	142	62	01100010	b	&#98;	 	Lowercase b
            99	143	63	01100011	c	&#99;	 	Lowercase c
            100	144	64	01100100	d	&#100;	 	Lowercase d
            101	145	65	01100101	e	&#101;	 	Lowercase e
            102	146	66	01100110	f	&#102;	 	Lowercase f
            103	147	67	01100111	g	&#103;	 	Lowercase g
            104	150	68	01101000	h	&#104;	 	Lowercase h
            105	151	69	01101001	i	&#105;	 	Lowercase i
            106	152	6A	01101010	j	&#106;	 	Lowercase j
            107	153	6B	01101011	k	&#107;	 	Lowercase k
            108	154	6C	01101100	l	&#108;	 	Lowercase l
            109	155	6D	01101101	m	&#109;	 	Lowercase m
            110	156	6E	01101110	n	&#110;	 	Lowercase n
            111	157	6F	01101111	o	&#111;	 	Lowercase o
            112	160	70	01110000	p	&#112;	 	Lowercase p
            113	161	71	01110001	q	&#113;	 	Lowercase q
            114	162	72	01110010	r	&#114;	 	Lowercase r
            115	163	73	01110011	s	&#115;	 	Lowercase s
            116	164	74	01110100	t	&#116;	 	Lowercase t
            117	165	75	01110101	u	&#117;	 	Lowercase u
            118	166	76	01110110	v	&#118;	 	Lowercase v
            119	167	77	01110111	w	&#119;	 	Lowercase w
            120	170	78	01111000	x	&#120;	 	Lowercase x
            121	171	79	01111001	y	&#121;	 	Lowercase y
            122	172	7A	01111010	z	&#122;	 	Lowercase z 
             
             */

        static private char GetRandomChar()
        {
            

            int test = 40;

            while (     
                    (test > 38 && test < 48) ||
                    (test > 57 && test < 64) ||
                    (test > 90 && test < 97)
                    )
            {
                test = r.Next(35, 122);
            }

            return (char)test;
        }

        


        static private bool CheckHasMinSpecialChars(string stringToCheck, int quant)
        {
            Regex rx = new Regex("[@#$%&]");
            MatchCollection mcs = rx.Matches(stringToCheck);
            return (mcs.Count >= quant);
        }
        static private bool CheckHasMinNumericalChars(string stringToCheck, int quant)
        {
            Regex rx = new Regex("[0-9]");
            MatchCollection mcs = rx.Matches(stringToCheck);
            return (mcs.Count >= quant);
        }
        static private bool CheckHasExactSpecialChars(string stringToCheck, int quant)
        {
            Regex rx = new Regex("[@#$%&]");
            MatchCollection mcs = rx.Matches(stringToCheck);
            return (mcs.Count == quant);
        }
        static private bool CheckHasExactNumericalChars(string stringToCheck, int quant)
        {
            Regex rx = new Regex("[0-9]");
            MatchCollection mcs = rx.Matches(stringToCheck);
            return (mcs.Count == quant);
        }

    }
    [Serializable()]
    class StringByteArPair
    {
        
        public string Str { set; get; }
        public byte[] ByteAr { set; get; }

        public StringByteArPair(string argStr, byte[] argByteAr)
        {
            Str = argStr;
            ByteAr = argByteAr;
        }
    }

}
