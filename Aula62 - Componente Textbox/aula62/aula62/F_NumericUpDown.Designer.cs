namespace aula62
{
    partial class F_NumericUpDown
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
            this.nup_valor = new System.Windows.Forms.NumericUpDown();
            this.tb_valor = new System.Windows.Forms.TextBox();
            this.btn_setar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nup_valor)).BeginInit();
            this.SuspendLayout();
            // 
            // nup_valor
            // 
            this.nup_valor.DecimalPlaces = 2;
            this.nup_valor.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nup_valor.Location = new System.Drawing.Point(198, 14);
            this.nup_valor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup_valor.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nup_valor.Name = "nup_valor";
            this.nup_valor.Size = new System.Drawing.Size(74, 20);
            this.nup_valor.TabIndex = 0;
            this.nup_valor.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.nup_valor.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // tb_valor
            // 
            this.tb_valor.Location = new System.Drawing.Point(12, 14);
            this.tb_valor.Name = "tb_valor";
            this.tb_valor.Size = new System.Drawing.Size(100, 20);
            this.tb_valor.TabIndex = 1;
            // 
            // btn_setar
            // 
            this.btn_setar.Location = new System.Drawing.Point(118, 13);
            this.btn_setar.Name = "btn_setar";
            this.btn_setar.Size = new System.Drawing.Size(75, 23);
            this.btn_setar.TabIndex = 2;
            this.btn_setar.Text = "Setar";
            this.btn_setar.UseVisualStyleBackColor = true;
            this.btn_setar.Click += new System.EventHandler(this.btn_setar_Click);
            // 
            // F_NumericUpDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_setar);
            this.Controls.Add(this.tb_valor);
            this.Controls.Add(this.nup_valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_NumericUpDown";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_NumericUpDown";
            ((System.ComponentModel.ISupportInitialize)(this.nup_valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nup_valor;
        private System.Windows.Forms.TextBox tb_valor;
        private System.Windows.Forms.Button btn_setar;
    }
}