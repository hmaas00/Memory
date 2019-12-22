using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMemory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Encryptor.DefineKIV();

            InitializeComponent();

            if (Helper.LoadDict())
            {
                Helper.WriteToTextBox(this.textBoxList);
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            
            int size = Convert.ToInt32(comboBoxSize.SelectedItem);
            int sc = Convert.ToInt32(comboBoxSpecChar.SelectedItem);
            int nq = Convert.ToInt32(comboBoxNumbers.SelectedItem);

            if (Helper.IsKeySizeValid(textBoxName.Text))
            {
                if (Helper.SizeParamsPossible(sc, nq, size))
                {
                    bool res = Helper.AddToDict(textBoxName.Text, size, sc, nq);

                    if (res)
                    {
                        MessageBox.Show($"A chave {textBoxName.Text} foi inserida com sucesso!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Não foi possível criar o par chave valor, provavelmente" +
                            $" a chave ({textBoxName.Text}) já existe", "Alerta!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    Helper.WriteToTextBox(textBoxList);
                }
                else
                {
                    MessageBox.Show($"Requisito impossível: tamanho:{size}, soma especiais:{sc + nq}", "Alerta!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show($"Chave:{textBoxName.Text}, fora do padrão ({Helper.CHAVE_SIZE} caracteres)", "Alerta!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void ButtonSave_Click(object sender, EventArgs e)
        {
            
            DialogResult res = MessageBox.Show($"Está certo disso?", "Confirmação",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
               if (Helper.SaveDict())
                {
                    MessageBox.Show($"O arquivo foi salvo!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Algo deu errado!", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show($"Está certo disso?", "Confirmação",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.OK)
            {
                if (Helper.LoadDict())
                {

                    Helper.WriteToTextBox(textBoxList);

                    MessageBox.Show($"Dados carregados com sucesso!", "Sucesso!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Erro ao carregar o arquivo! Você tem certeza que o arquivo existe?", "Alerta!",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void ButtonAddEscolhido_Click(object sender, EventArgs e)
        {

            if (Helper.IsKeySizeValid(textBoxName.Text))
            {
                bool res = Helper.AddEscolhido(textBoxName.Text, textBoxCodEscolhido.Text);

                if (res)
                {
                    MessageBox.Show($"A chave {textBoxName.Text} foi inserida com sucesso!", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Ocorreu um erro na adição da" +
                        $" chave: ( {textBoxName.Text} ) código: ( {textBoxCodEscolhido.Text} )" +
                        $"\nSeria uma boa ideia se ambos tivessem algum conteúdo! " +
                        $"E o código tivesse o tamanho máximo de {Helper.VALOR_SIZE}", "Alerta!",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Helper.WriteToTextBox(textBoxList);
            }
            else
            {
                MessageBox.Show($"Chave:{textBoxName.Text}, fora do padrão ({Helper.CHAVE_SIZE} caracteres)", "Alerta!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void ButtonDeletePair_Click(object sender, EventArgs e)
        {
            //TODO opção de limpar todo o dicionario
            
            if (comboBoxKeyDeletable.SelectedItem != null)
            {
                string key = comboBoxKeyDeletable.SelectedItem.ToString();
                DialogResult res = MessageBox.Show($"Está certo de deletar a chave {key}?",
                "Confirmação", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (res == DialogResult.OK)
                {
                    Helper.DeletePairByKey(key);
                    Helper.WriteToTextBox(this.textBoxList);
                    MessageBox.Show($"feito!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"Nada foi feito!", "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void ComboBoxKeyDeletable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxKeyDeletable_DropDown(object sender, System.EventArgs e)
        {

            Helper.updateComboDeletable(this.comboBoxKeyDeletable);

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void LabelChave_Click(object sender, EventArgs e)
        {

        }
    }
}
