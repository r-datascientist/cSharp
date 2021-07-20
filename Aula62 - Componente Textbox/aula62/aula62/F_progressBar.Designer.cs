namespace aula62
{
    partial class F_progressBar
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
            this.pb_carregar = new System.Windows.Forms.ProgressBar();
            this.btn_setar = new System.Windows.Forms.Button();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.pb_temporizador = new System.Windows.Forms.ProgressBar();
            this.tb_setarMinimo = new System.Windows.Forms.TextBox();
            this.tb_setarMaximo = new System.Windows.Forms.TextBox();
            this.btn_setarMinimo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_contagem = new System.Windows.Forms.Label();
            this.lbl_temporizador = new System.Windows.Forms.Label();
            this.tb_valorContagem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pb_carregar
            // 
            this.pb_carregar.Location = new System.Drawing.Point(7, 259);
            this.pb_carregar.Name = "pb_carregar";
            this.pb_carregar.Size = new System.Drawing.Size(260, 15);
            this.pb_carregar.TabIndex = 0;
            // 
            // btn_setar
            // 
            this.btn_setar.Location = new System.Drawing.Point(12, 114);
            this.btn_setar.Name = "btn_setar";
            this.btn_setar.Size = new System.Drawing.Size(100, 23);
            this.btn_setar.TabIndex = 1;
            this.btn_setar.Text = "Setar Valor";
            this.btn_setar.UseVisualStyleBackColor = true;
            this.btn_setar.Click += new System.EventHandler(this.btn_setar_Click);
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(12, 88);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 2;
            this.tb_valor.Text = "0";
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(12, 165);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(75, 23);
            this.btn_iniciar.TabIndex = 3;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // pb_temporizador
            // 
            this.pb_temporizador.Location = new System.Drawing.Point(9, 212);
            this.pb_temporizador.Name = "pb_temporizador";
            this.pb_temporizador.Size = new System.Drawing.Size(260, 17);
            this.pb_temporizador.TabIndex = 5;
            // 
            // tb_setarMinimo
            // 
            this.tb_setarMinimo.Location = new System.Drawing.Point(12, 16);
            this.tb_setarMinimo.Name = "tb_setarMinimo";
            this.tb_setarMinimo.Size = new System.Drawing.Size(100, 20);
            this.tb_setarMinimo.TabIndex = 6;
            // 
            // tb_setarMaximo
            // 
            this.tb_setarMaximo.Location = new System.Drawing.Point(147, 16);
            this.tb_setarMaximo.Name = "tb_setarMaximo";
            this.tb_setarMaximo.Size = new System.Drawing.Size(100, 20);
            this.tb_setarMaximo.TabIndex = 7;
            // 
            // btn_setarMinimo
            // 
            this.btn_setarMinimo.Location = new System.Drawing.Point(12, 42);
            this.btn_setarMinimo.Name = "btn_setarMinimo";
            this.btn_setarMinimo.Size = new System.Drawing.Size(100, 23);
            this.btn_setarMinimo.TabIndex = 8;
            this.btn_setarMinimo.Text = "Setar Min.";
            this.btn_setarMinimo.UseVisualStyleBackColor = true;
            this.btn_setarMinimo.Click += new System.EventHandler(this.btn_setarMinimo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Setar Max.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_contagem
            // 
            this.lbl_contagem.AutoSize = true;
            this.lbl_contagem.Location = new System.Drawing.Point(7, 243);
            this.lbl_contagem.Name = "lbl_contagem";
            this.lbl_contagem.Size = new System.Drawing.Size(58, 13);
            this.lbl_contagem.TabIndex = 10;
            this.lbl_contagem.Text = "Contagem:";
            // 
            // lbl_temporizador
            // 
            this.lbl_temporizador.AutoSize = true;
            this.lbl_temporizador.Location = new System.Drawing.Point(7, 196);
            this.lbl_temporizador.Name = "lbl_temporizador";
            this.lbl_temporizador.Size = new System.Drawing.Size(74, 13);
            this.lbl_temporizador.TabIndex = 11;
            this.lbl_temporizador.Text = "Temporizador:";
            // 
            // tb_valorContagem
            // 
            this.tb_valorContagem.Location = new System.Drawing.Point(181, 165);
            this.tb_valorContagem.Name = "tb_valorContagem";
            this.tb_valorContagem.Size = new System.Drawing.Size(91, 20);
            this.tb_valorContagem.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Valor Contagem:";
            // 
            // F_progressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 291);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_valorContagem);
            this.Controls.Add(this.lbl_temporizador);
            this.Controls.Add(this.lbl_contagem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_setarMinimo);
            this.Controls.Add(this.tb_setarMaximo);
            this.Controls.Add(this.tb_setarMinimo);
            this.Controls.Add(this.pb_temporizador);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.btn_setar);
            this.Controls.Add(this.pb_carregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_progressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_progressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pb_carregar;
        private System.Windows.Forms.Button btn_setar;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.ProgressBar pb_temporizador;
        private System.Windows.Forms.TextBox tb_setarMinimo;
        private System.Windows.Forms.TextBox tb_setarMaximo;
        private System.Windows.Forms.Button btn_setarMinimo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_contagem;
        private System.Windows.Forms.Label lbl_temporizador;
        private System.Windows.Forms.TextBox tb_valorContagem;
        private System.Windows.Forms.Label label1;
    }
}