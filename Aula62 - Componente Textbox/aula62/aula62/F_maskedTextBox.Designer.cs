namespace aula62
{
    partial class F_maskedTextBox
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
            this.mtb_senha = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.cb_revelarSenha = new System.Windows.Forms.CheckBox();
            this.cb_somenteTexto = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // mtb_senha
            // 
            this.mtb_senha.Location = new System.Drawing.Point(12, 70);
            this.mtb_senha.Name = "mtb_senha";
            this.mtb_senha.PasswordChar = '*';
            this.mtb_senha.Size = new System.Drawing.Size(63, 20);
            this.mtb_senha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Senha:";
            // 
            // mtb_cep
            // 
            this.mtb_cep.Location = new System.Drawing.Point(12, 113);
            this.mtb_cep.Mask = "00000-000";
            this.mtb_cep.Name = "mtb_cep";
            this.mtb_cep.Size = new System.Drawing.Size(63, 20);
            this.mtb_cep.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CEP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "CPF:";
            // 
            // mtb_cpf
            // 
            this.mtb_cpf.Location = new System.Drawing.Point(12, 156);
            this.mtb_cpf.Mask = "000.000.000-00";
            this.mtb_cpf.Name = "mtb_cpf";
            this.mtb_cpf.Size = new System.Drawing.Size(83, 20);
            this.mtb_cpf.TabIndex = 4;
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(201, 155);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(75, 23);
            this.btn_mostrar.TabIndex = 6;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // cb_revelarSenha
            // 
            this.cb_revelarSenha.AutoSize = true;
            this.cb_revelarSenha.Location = new System.Drawing.Point(103, 72);
            this.cb_revelarSenha.Name = "cb_revelarSenha";
            this.cb_revelarSenha.Size = new System.Drawing.Size(63, 17);
            this.cb_revelarSenha.TabIndex = 7;
            this.cb_revelarSenha.Text = "Revelar";
            this.cb_revelarSenha.UseVisualStyleBackColor = true;
            this.cb_revelarSenha.CheckedChanged += new System.EventHandler(this.cb_revelarSenha_CheckedChanged);
            // 
            // cb_somenteTexto
            // 
            this.cb_somenteTexto.AutoSize = true;
            this.cb_somenteTexto.Location = new System.Drawing.Point(103, 159);
            this.cb_somenteTexto.Name = "cb_somenteTexto";
            this.cb_somenteTexto.Size = new System.Drawing.Size(98, 17);
            this.cb_somenteTexto.TabIndex = 8;
            this.cb_somenteTexto.Text = "Somente Texto";
            this.cb_somenteTexto.UseVisualStyleBackColor = true;
            // 
            // F_maskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cb_somenteTexto);
            this.Controls.Add(this.cb_revelarSenha);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtb_cpf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtb_cep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtb_senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_maskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_maskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mtb_senha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtb_cep;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_cpf;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.CheckBox cb_revelarSenha;
        private System.Windows.Forms.CheckBox cb_somenteTexto;
    }
}