namespace WindowsFormsAppMemory
{
    partial class Form1
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
            this.buttonAddKV = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxList = new System.Windows.Forms.TextBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.comboBoxSpecChar = new System.Windows.Forms.ComboBox();
            this.comboBoxNumbers = new System.Windows.Forms.ComboBox();
            this.labelSpecChar = new System.Windows.Forms.Label();
            this.labelQuantidadeNumeros = new System.Windows.Forms.Label();
            this.labelTamanho = new System.Windows.Forms.Label();
            this.labelChave = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.textBoxCodEscolhido = new System.Windows.Forms.TextBox();
            this.labelCodEscolhido = new System.Windows.Forms.Label();
            this.buttonAddEscolhido = new System.Windows.Forms.Button();
            this.buttonDeletePair = new System.Windows.Forms.Button();
            this.comboBoxKeyDeletable = new System.Windows.Forms.ComboBox();
            this.groupBoxModoSeguro = new System.Windows.Forms.GroupBox();
            this.groupBoxModoEstupido = new System.Windows.Forms.GroupBox();
            this.groupBoxModoSeguro.SuspendLayout();
            this.groupBoxModoEstupido.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddKV
            // 
            this.buttonAddKV.BackColor = System.Drawing.Color.Green;
            this.buttonAddKV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonAddKV.Location = new System.Drawing.Point(119, 139);
            this.buttonAddKV.Name = "buttonAddKV";
            this.buttonAddKV.Size = new System.Drawing.Size(218, 40);
            this.buttonAddKV.TabIndex = 9;
            this.buttonAddKV.Text = "Gera Código Parametrizado";
            this.buttonAddKV.UseVisualStyleBackColor = false;
            this.buttonAddKV.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.White;
            this.textBoxName.ForeColor = System.Drawing.Color.Blue;
            this.textBoxName.Location = new System.Drawing.Point(35, 97);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(296, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxList
            // 
            this.textBoxList.BackColor = System.Drawing.Color.Azure;
            this.textBoxList.ForeColor = System.Drawing.Color.Blue;
            this.textBoxList.Location = new System.Drawing.Point(466, 97);
            this.textBoxList.Multiline = true;
            this.textBoxList.Name = "textBoxList";
            this.textBoxList.ReadOnly = true;
            this.textBoxList.Size = new System.Drawing.Size(360, 470);
            this.textBoxList.TabIndex = 0;
            this.textBoxList.TabStop = false;
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSize.ForeColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBoxSize.Location = new System.Drawing.Point(267, 15);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(70, 24);
            this.comboBoxSize.TabIndex = 6;
            // 
            // comboBoxSpecChar
            // 
            this.comboBoxSpecChar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSpecChar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.comboBoxSpecChar.FormattingEnabled = true;
            this.comboBoxSpecChar.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxSpecChar.Location = new System.Drawing.Point(267, 55);
            this.comboBoxSpecChar.Name = "comboBoxSpecChar";
            this.comboBoxSpecChar.Size = new System.Drawing.Size(70, 24);
            this.comboBoxSpecChar.TabIndex = 7;
            // 
            // comboBoxNumbers
            // 
            this.comboBoxNumbers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumbers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.comboBoxNumbers.FormattingEnabled = true;
            this.comboBoxNumbers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxNumbers.Location = new System.Drawing.Point(267, 98);
            this.comboBoxNumbers.Name = "comboBoxNumbers";
            this.comboBoxNumbers.Size = new System.Drawing.Size(70, 24);
            this.comboBoxNumbers.TabIndex = 8;
            // 
            // labelSpecChar
            // 
            this.labelSpecChar.AutoSize = true;
            this.labelSpecChar.Location = new System.Drawing.Point(25, 58);
            this.labelSpecChar.Name = "labelSpecChar";
            this.labelSpecChar.Size = new System.Drawing.Size(236, 17);
            this.labelSpecChar.TabIndex = 7;
            this.labelSpecChar.Text = "Quantidade de caracteres especiais";
            // 
            // labelQuantidadeNumeros
            // 
            this.labelQuantidadeNumeros.AutoSize = true;
            this.labelQuantidadeNumeros.Location = new System.Drawing.Point(100, 101);
            this.labelQuantidadeNumeros.Name = "labelQuantidadeNumeros";
            this.labelQuantidadeNumeros.Size = new System.Drawing.Size(161, 17);
            this.labelQuantidadeNumeros.TabIndex = 8;
            this.labelQuantidadeNumeros.Text = "Quantidade de números";
            // 
            // labelTamanho
            // 
            this.labelTamanho.AutoSize = true;
            this.labelTamanho.Location = new System.Drawing.Point(193, 18);
            this.labelTamanho.Name = "labelTamanho";
            this.labelTamanho.Size = new System.Drawing.Size(68, 17);
            this.labelTamanho.TabIndex = 0;
            this.labelTamanho.Text = "Tamanho";
            // 
            // labelChave
            // 
            this.labelChave.AutoSize = true;
            this.labelChave.Location = new System.Drawing.Point(32, 59);
            this.labelChave.Name = "labelChave";
            this.labelChave.Size = new System.Drawing.Size(426, 17);
            this.labelChave.TabIndex = 12;
            this.labelChave.Text = "Chave (Escolha de modo a lembrar no futuro! Com 20 caracteres.)";
            this.labelChave.Click += new System.EventHandler(this.LabelChave_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Lime;
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonSave.Location = new System.Drawing.Point(738, 582);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 35);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.buttonLoad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonLoad.Location = new System.Drawing.Point(466, 582);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(80, 35);
            this.buttonLoad.TabIndex = 10;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = false;
            this.buttonLoad.Click += new System.EventHandler(this.ButtonLoad_Click);
            // 
            // textBoxCodEscolhido
            // 
            this.textBoxCodEscolhido.ForeColor = System.Drawing.Color.Red;
            this.textBoxCodEscolhido.Location = new System.Drawing.Point(6, 74);
            this.textBoxCodEscolhido.Name = "textBoxCodEscolhido";
            this.textBoxCodEscolhido.Size = new System.Drawing.Size(177, 22);
            this.textBoxCodEscolhido.TabIndex = 3;
            // 
            // labelCodEscolhido
            // 
            this.labelCodEscolhido.AutoSize = true;
            this.labelCodEscolhido.Location = new System.Drawing.Point(12, 37);
            this.labelCodEscolhido.Name = "labelCodEscolhido";
            this.labelCodEscolhido.Size = new System.Drawing.Size(351, 17);
            this.labelCodEscolhido.TabIndex = 0;
            this.labelCodEscolhido.Text = "Código Escolhido (inseguro provavelmente...) Máx. 20!";
            this.labelCodEscolhido.Click += new System.EventHandler(this.Label1_Click);
            // 
            // buttonAddEscolhido
            // 
            this.buttonAddEscolhido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonAddEscolhido.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonAddEscolhido.Location = new System.Drawing.Point(189, 68);
            this.buttonAddEscolhido.Name = "buttonAddEscolhido";
            this.buttonAddEscolhido.Size = new System.Drawing.Size(198, 34);
            this.buttonAddEscolhido.TabIndex = 4;
            this.buttonAddEscolhido.Text = "Adiciona Código Escolhido";
            this.buttonAddEscolhido.UseVisualStyleBackColor = false;
            this.buttonAddEscolhido.Click += new System.EventHandler(this.ButtonAddEscolhido_Click);
            // 
            // buttonDeletePair
            // 
            this.buttonDeletePair.BackColor = System.Drawing.Color.Red;
            this.buttonDeletePair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDeletePair.Location = new System.Drawing.Point(268, 532);
            this.buttonDeletePair.Name = "buttonDeletePair";
            this.buttonDeletePair.Size = new System.Drawing.Size(157, 35);
            this.buttonDeletePair.TabIndex = 13;
            this.buttonDeletePair.Text = "Deletar Par Existente";
            this.buttonDeletePair.UseVisualStyleBackColor = false;
            this.buttonDeletePair.Click += new System.EventHandler(this.ButtonDeletePair_Click);
            // 
            // comboBoxKeyDeletable
            // 
            this.comboBoxKeyDeletable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKeyDeletable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.comboBoxKeyDeletable.FormattingEnabled = true;
            this.comboBoxKeyDeletable.Location = new System.Drawing.Point(35, 538);
            this.comboBoxKeyDeletable.Name = "comboBoxKeyDeletable";
            this.comboBoxKeyDeletable.Size = new System.Drawing.Size(224, 24);
            this.comboBoxKeyDeletable.TabIndex = 12;
            this.comboBoxKeyDeletable.DropDown += new System.EventHandler(this.ComboBoxKeyDeletable_DropDown);
            this.comboBoxKeyDeletable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxKeyDeletable_SelectedIndexChanged);
            // 
            // groupBoxModoSeguro
            // 
            this.groupBoxModoSeguro.Controls.Add(this.labelTamanho);
            this.groupBoxModoSeguro.Controls.Add(this.comboBoxSize);
            this.groupBoxModoSeguro.Controls.Add(this.comboBoxSpecChar);
            this.groupBoxModoSeguro.Controls.Add(this.comboBoxNumbers);
            this.groupBoxModoSeguro.Controls.Add(this.labelSpecChar);
            this.groupBoxModoSeguro.Controls.Add(this.labelQuantidadeNumeros);
            this.groupBoxModoSeguro.Controls.Add(this.buttonAddKV);
            this.groupBoxModoSeguro.Location = new System.Drawing.Point(35, 313);
            this.groupBoxModoSeguro.Name = "groupBoxModoSeguro";
            this.groupBoxModoSeguro.Size = new System.Drawing.Size(390, 188);
            this.groupBoxModoSeguro.TabIndex = 5;
            this.groupBoxModoSeguro.TabStop = false;
            this.groupBoxModoSeguro.Text = "Modo Seguro";
            this.groupBoxModoSeguro.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBoxModoEstupido
            // 
            this.groupBoxModoEstupido.Controls.Add(this.labelCodEscolhido);
            this.groupBoxModoEstupido.Controls.Add(this.textBoxCodEscolhido);
            this.groupBoxModoEstupido.Controls.Add(this.buttonAddEscolhido);
            this.groupBoxModoEstupido.Location = new System.Drawing.Point(35, 151);
            this.groupBoxModoEstupido.Name = "groupBoxModoEstupido";
            this.groupBoxModoEstupido.Size = new System.Drawing.Size(390, 122);
            this.groupBoxModoEstupido.TabIndex = 2;
            this.groupBoxModoEstupido.TabStop = false;
            this.groupBoxModoEstupido.Text = "Modo Estúpido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(858, 633);
            this.Controls.Add(this.groupBoxModoEstupido);
            this.Controls.Add(this.groupBoxModoSeguro);
            this.Controls.Add(this.comboBoxKeyDeletable);
            this.Controls.Add(this.buttonDeletePair);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelChave);
            this.Controls.Add(this.textBoxList);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Agora eu lembro!";
            this.groupBoxModoSeguro.ResumeLayout(false);
            this.groupBoxModoSeguro.PerformLayout();
            this.groupBoxModoEstupido.ResumeLayout(false);
            this.groupBoxModoEstupido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddKV;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxList;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.ComboBox comboBoxSpecChar;
        private System.Windows.Forms.ComboBox comboBoxNumbers;
        private System.Windows.Forms.Label labelSpecChar;
        private System.Windows.Forms.Label labelQuantidadeNumeros;
        private System.Windows.Forms.Label labelTamanho;
        private System.Windows.Forms.Label labelChave;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TextBox textBoxCodEscolhido;
        private System.Windows.Forms.Label labelCodEscolhido;
        private System.Windows.Forms.Button buttonAddEscolhido;
        private System.Windows.Forms.Button buttonDeletePair;
        private System.Windows.Forms.ComboBox comboBoxKeyDeletable;
        private System.Windows.Forms.GroupBox groupBoxModoSeguro;
        private System.Windows.Forms.GroupBox groupBoxModoEstupido;
    }
}

