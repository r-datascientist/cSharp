namespace aula62
{
    partial class F_monthCalendar
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
            this.mc_data = new System.Windows.Forms.MonthCalendar();
            this.btn_pegarData = new System.Windows.Forms.Button();
            this.tb_start = new System.Windows.Forms.TextBox();
            this.tb_end = new System.Windows.Forms.TextBox();
            this.tb_hoje = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_hojeChange = new System.Windows.Forms.TextBox();
            this.tb_endChange = new System.Windows.Forms.TextBox();
            this.tb_startChange = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mc_data
            // 
            this.mc_data.Location = new System.Drawing.Point(13, 13);
            this.mc_data.MaxSelectionCount = 30;
            this.mc_data.Name = "mc_data";
            this.mc_data.TabIndex = 0;
            this.mc_data.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mc_data_DateChanged);
            // 
            // btn_pegarData
            // 
            this.btn_pegarData.Location = new System.Drawing.Point(253, 13);
            this.btn_pegarData.Name = "btn_pegarData";
            this.btn_pegarData.Size = new System.Drawing.Size(100, 23);
            this.btn_pegarData.TabIndex = 1;
            this.btn_pegarData.Text = "Pegar Data";
            this.btn_pegarData.UseVisualStyleBackColor = true;
            this.btn_pegarData.Click += new System.EventHandler(this.btn_pegarData_Click);
            // 
            // tb_start
            // 
            this.tb_start.Location = new System.Drawing.Point(253, 72);
            this.tb_start.Name = "tb_start";
            this.tb_start.Size = new System.Drawing.Size(100, 20);
            this.tb_start.TabIndex = 2;
            // 
            // tb_end
            // 
            this.tb_end.Location = new System.Drawing.Point(253, 114);
            this.tb_end.Name = "tb_end";
            this.tb_end.Size = new System.Drawing.Size(100, 20);
            this.tb_end.TabIndex = 3;
            // 
            // tb_hoje
            // 
            this.tb_hoje.Location = new System.Drawing.Point(253, 153);
            this.tb_hoje.Name = "tb_hoje";
            this.tb_hoje.Size = new System.Drawing.Size(100, 20);
            this.tb_hoje.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Data início:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data fim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data atual:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Data atual:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data fim:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Data início:";
            // 
            // tb_hojeChange
            // 
            this.tb_hojeChange.Location = new System.Drawing.Point(223, 247);
            this.tb_hojeChange.Name = "tb_hojeChange";
            this.tb_hojeChange.Size = new System.Drawing.Size(100, 20);
            this.tb_hojeChange.TabIndex = 10;
            // 
            // tb_endChange
            // 
            this.tb_endChange.Location = new System.Drawing.Point(117, 247);
            this.tb_endChange.Name = "tb_endChange";
            this.tb_endChange.Size = new System.Drawing.Size(100, 20);
            this.tb_endChange.TabIndex = 9;
            // 
            // tb_startChange
            // 
            this.tb_startChange.Location = new System.Drawing.Point(11, 247);
            this.tb_startChange.Name = "tb_startChange";
            this.tb_startChange.Size = new System.Drawing.Size(100, 20);
            this.tb_startChange.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Coleta dinâmica automática:";
            // 
            // F_monthCalendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 284);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_hojeChange);
            this.Controls.Add(this.tb_endChange);
            this.Controls.Add(this.tb_startChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_hoje);
            this.Controls.Add(this.tb_end);
            this.Controls.Add(this.tb_start);
            this.Controls.Add(this.btn_pegarData);
            this.Controls.Add(this.mc_data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "F_monthCalendar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "F_monthCalendar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mc_data;
        private System.Windows.Forms.Button btn_pegarData;
        private System.Windows.Forms.TextBox tb_start;
        private System.Windows.Forms.TextBox tb_end;
        private System.Windows.Forms.TextBox tb_hoje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_hojeChange;
        private System.Windows.Forms.TextBox tb_endChange;
        private System.Windows.Forms.TextBox tb_startChange;
        private System.Windows.Forms.Label label7;
    }
}