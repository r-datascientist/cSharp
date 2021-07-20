namespace aula62
{
    partial class F_pictureBox
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
            this.l_nome = new System.Windows.Forms.Label();
            this.l_url = new System.Windows.Forms.Label();
            this.pb_imagem = new System.Windows.Forms.PictureBox();
            this.btn_imagem1 = new System.Windows.Forms.Button();
            this.btn_imagem2 = new System.Windows.Forms.Button();
            this.btn_imagem3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).BeginInit();
            this.SuspendLayout();
            // 
            // l_nome
            // 
            this.l_nome.AutoSize = true;
            this.l_nome.Location = new System.Drawing.Point(68, 15);
            this.l_nome.Name = "l_nome";
            this.l_nome.Size = new System.Drawing.Size(35, 13);
            this.l_nome.TabIndex = 0;
            this.l_nome.Text = "label1";
            // 
            // l_url
            // 
            this.l_url.AutoSize = true;
            this.l_url.Location = new System.Drawing.Point(170, 15);
            this.l_url.Name = "l_url";
            this.l_url.Size = new System.Drawing.Size(35, 13);
            this.l_url.TabIndex = 1;
            this.l_url.Text = "label2";
            // 
            // pb_imagem
            // 
            this.pb_imagem.Image = global::aula62.Properties.Resources.localDeProjetosVisualStudioAutoneum;
            this.pb_imagem.Location = new System.Drawing.Point(19, 44);
            this.pb_imagem.Name = "pb_imagem";
            this.pb_imagem.Size = new System.Drawing.Size(250, 181);
            this.pb_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_imagem.TabIndex = 2;
            this.pb_imagem.TabStop = false;
            // 
            // btn_imagem1
            // 
            this.btn_imagem1.Location = new System.Drawing.Point(194, 240);
            this.btn_imagem1.Name = "btn_imagem1";
            this.btn_imagem1.Size = new System.Drawing.Size(75, 23);
            this.btn_imagem1.TabIndex = 3;
            this.btn_imagem1.Text = "Imagem 1";
            this.btn_imagem1.UseVisualStyleBackColor = true;
            this.btn_imagem1.Click += new System.EventHandler(this.btn_imagem1_Click);
            // 
            // btn_imagem2
            // 
            this.btn_imagem2.Location = new System.Drawing.Point(113, 240);
            this.btn_imagem2.Name = "btn_imagem2";
            this.btn_imagem2.Size = new System.Drawing.Size(75, 23);
            this.btn_imagem2.TabIndex = 4;
            this.btn_imagem2.Text = "Imagem 2";
            this.btn_imagem2.UseVisualStyleBackColor = true;
            this.btn_imagem2.Click += new System.EventHandler(this.btn_imagem2_Click);
            // 
            // btn_imagem3
            // 
            this.btn_imagem3.Location = new System.Drawing.Point(32, 239);
            this.btn_imagem3.Name = "btn_imagem3";
            this.btn_imagem3.Size = new System.Drawing.Size(75, 23);
            this.btn_imagem3.TabIndex = 5;
            this.btn_imagem3.Text = "Imagem 3";
            this.btn_imagem3.UseVisualStyleBackColor = true;
            this.btn_imagem3.Click += new System.EventHandler(this.btn_imagem3_Click);
            // 
            // F_pictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 275);
            this.Controls.Add(this.btn_imagem3);
            this.Controls.Add(this.btn_imagem2);
            this.Controls.Add(this.btn_imagem1);
            this.Controls.Add(this.pb_imagem);
            this.Controls.Add(this.l_url);
            this.Controls.Add(this.l_nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_pictureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_pictureBox";
            this.Load += new System.EventHandler(this.F_pictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_nome;
        private System.Windows.Forms.Label l_url;
        private System.Windows.Forms.PictureBox pb_imagem;
        private System.Windows.Forms.Button btn_imagem1;
        private System.Windows.Forms.Button btn_imagem2;
        private System.Windows.Forms.Button btn_imagem3;
    }
}