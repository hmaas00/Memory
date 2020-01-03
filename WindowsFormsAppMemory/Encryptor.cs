using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppMemory
{
    class Encryptor
    {
        
        static public string LOG_FILE_NAME = (Directory.GetCurrentDirectory() + @"\log.log");

        static public string CONFIG_FILE_NAME = (Directory.GetCurrentDirectory() + @"\config.cfg");

        static public string MAIN_CODE_FILE_NAME = (Directory.GetCurrentDirectory() + @"\config_main.cfg");

        public static bool IsFirstExec()
        {
            if (File.Exists(CONFIG_FILE_NAME))
            {
                return false;
            }
            else return true;
        }

        public static void DefineKIV()
        {
            try
            {
                using (AesCryptoServiceProvider myAes = new AesCryptoServiceProvider())
                {
                    // Encrypt the string to an array of bytes.
                    KIVPair kiv = new KIVPair(myAes.Key, myAes.IV);
                    WriteConfig(kiv);
                }
            }
            catch (Exception e)
            {
                WriteLog(e.Message);
                WriteLog(e.StackTrace);
            }
        }

        public static void WriteConfig(KIVPair kiv)
        {
            try
            {
                // Construct a BinaryFormatter and use it to serialize the data to the stream.

                FileStream fs = null;

                BinaryFormatter formatter = new BinaryFormatter();

                using (fs = new FileStream(CONFIG_FILE_NAME, FileMode.Create))
                {
                    formatter.Serialize(fs, kiv);
                }
            }
            catch (Exception e)
            {
                WriteLog("Falha ao salvar configurações, motivo: " + e.Message + "\n" + e.StackTrace);
            }
        }

        public static void WriteLog(string log)
        {
            using (StreamWriter sw = File.AppendText(LOG_FILE_NAME))
            {
                sw.Write(log + "\n");
            }
        }

        static public KIVPair LoadKeyIV()
        {
            if (!File.Exists(CONFIG_FILE_NAME))
            {
                return null;
            }

            using (FileStream fs = new FileStream(CONFIG_FILE_NAME, FileMode.Open))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                try
                {
                    KIVPair myKIV = (KIVPair)formatter.Deserialize(fs);
                    return myKIV;
                }
                catch (Exception e)
                {
                    WriteLog("Falha no Load do kiv, motivo: " + e.Message);
                    return null;
                }
                finally
                {
                    fs.Close();
                }
            }
        }

        public static byte[] EncryptStringToBytes_Aes(string plainText)
        {
            // Check arguments.
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException("plainText");
            
            byte[] encrypted;

            try
            {
                // Create an AesManaged object
                // with the specified key and IV.
                using (AesManaged aesAlg = new AesManaged())
                {
                    KIVPair kiv = LoadKeyIV();
                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(kiv.K, kiv.IV);

                    // Create the streams used for encryption.
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                //Write all data to the stream.
                                swEncrypt.Write(plainText);
                            }
                            encrypted = msEncrypt.ToArray();
                        }
                    }
                    return encrypted;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static string DecryptStringFromBytes_Aes(byte[] cipherText)
        {
            // Check arguments.
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            

            // Declare the string used to hold
            // the decrypted text.
            string plaintext = null;

            // Create an AesManaged object
            // with the specified key and IV.
            using (AesManaged aesAlg = new AesManaged())
            {

                KIVPair kiv = LoadKeyIV();

                // Create a decryptor to perform the stream transform.
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(kiv.K, kiv.IV);

                // Create the streams used for decryption.
                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {

                            // Read the decrypted bytes from the decrypting stream
                            // and place them in a string.
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }

            }

            return plaintext;

        }
        /*public static void ShowKeyGen()
        {
            using (AesManaged aesAlg = new AesManaged())
            {
                //aesAlg.GenerateKey();
                Console.WriteLine(aesAlg.Key.Length);
                Console.WriteLine(aesAlg.Key.GetValue(1));
            }
        }*/


        static public void CreateMainCode(string code)
        {
            //todo criar main code
            byte[] c = Encryptor.EncryptStringToBytes_Aes(code);
            try
            {
                FileStream fs = null;

                BinaryWriter bw = new BinaryWriter(File.Open(MAIN_CODE_FILE_NAME, FileMode.Create));

                bw.Write(c);
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Falha ao salvar, motivo: " + e.Message);

            }

        }
        static public string ReadMainCode()
        {
            //todo ler main code
            try
            {
                FileStream fs = null;

                StreamReader sr = new StreamReader(File.Open(MAIN_CODE_FILE_NAME, FileMode.Open));

                string s = sr.ReadLine();

                return null;
                //DecryptStringFromBytes_Aes(s.);
            }
            catch (Exception e)
            {
                Console.WriteLine("Falha ao salvar, motivo: " + e.Message);
                return null;
            }

        }

    }

    [Serializable()]
    class KIVPair
    {
        public byte[] k = null;
        public byte[] iv = null;

        public KIVPair(byte[] key, byte[] init_vec)
        {
            K = key;
            IV = init_vec;
        }

        public byte[] K
        {
            get {return k;}
            set {k = value;}
        }
        
        public byte[] IV
        {
            get {return iv;}
            set {iv = value;}
        }
    }

}
