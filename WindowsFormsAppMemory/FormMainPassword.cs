using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMemory
{
    public partial class FormMainPassword : Form
    {
        public FormMainPassword()
        {
            InitializeComponent();
        }

        private void ButtonMainPassword_Click(object sender, EventArgs e)
        {
            if (textBoxMainPassword.Text.Length > 0)
            {
                Helper.dict.Remove("Main");
                Helper.AddEscolhido("Main", textBoxMainPassword.Text);
                this.DialogResult = DialogResult.OK;
                
            }
            
        }
    }
}
