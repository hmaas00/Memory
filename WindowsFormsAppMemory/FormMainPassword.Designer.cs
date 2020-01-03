namespace WindowsFormsAppMemory
{
    partial class FormMainPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMainPassword = new System.Windows.Forms.TextBox();
            this.labelMainPassword = new System.Windows.Forms.Label();
            this.buttonMainPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMainPassword
            // 
            this.textBoxMainPassword.Location = new System.Drawing.Point(16, 76);
            this.textBoxMainPassword.Name = "textBoxMainPassword";
            this.textBoxMainPassword.Size = new System.Drawing.Size(291, 22);
            this.textBoxMainPassword.TabIndex = 0;
            // 
            // labelMainPassword
            // 
            this.labelMainPassword.AutoSize = true;
            this.labelMainPassword.Location = new System.Drawing.Point(77, 42);
            this.labelMainPassword.Name = "labelMainPassword";
            this.labelMainPassword.Size = new System.Drawing.Size(170, 17);
            this.labelMainPassword.TabIndex = 3;
            this.labelMainPassword.Text = "Escolha a senha principal";
            // 
            // buttonMainPassword
            // 
            this.buttonMainPassword.BackColor = System.Drawing.Color.LightCyan;
            this.buttonMainPassword.ForeColor = System.Drawing.Color.Green;
            this.buttonMainPassword.Location = new System.Drawing.Point(122, 127);
            this.buttonMainPassword.Name = "buttonMainPassword";
            this.buttonMainPassword.Size = new System.Drawing.Size(75, 23);
            this.buttonMainPassword.TabIndex = 1;
            this.buttonMainPassword.Text = "Ok";
            this.buttonMainPassword.UseVisualStyleBackColor = false;
            this.buttonMainPassword.Click += new System.EventHandler(this.ButtonMainPassword_Click);
            // 
            // FormMainPassword
            // 
            this.AcceptButton = this.buttonMainPassword;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(324, 191);
            this.Controls.Add(this.buttonMainPassword);
            this.Controls.Add(this.labelMainPassword);
            this.Controls.Add(this.textBoxMainPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainPassword";
            this.ShowIcon = false;
            this.Text = "Main password";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMainPassword;
        private System.Windows.Forms.Label labelMainPassword;
        private System.Windows.Forms.Button buttonMainPassword;
    }
}