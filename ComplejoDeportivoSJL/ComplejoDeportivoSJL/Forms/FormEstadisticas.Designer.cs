namespace ComplejoDeportivoSJL.Forms
{
    partial class FormEstadisticas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerarE = new System.Windows.Forms.Button();
            this.comboBoxPeriodoE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUBasket = new System.Windows.Forms.TextBox();
            this.textBoxUFtusal = new System.Windows.Forms.TextBox();
            this.textBoxUVoley = new System.Windows.Forms.TextBox();
            this.textBoxUTennis = new System.Windows.Forms.TextBox();
            this.textBoxUTotal = new System.Windows.Forms.TextBox();
            this.textBoxPTotal = new System.Windows.Forms.TextBox();
            this.textBoxPTennis = new System.Windows.Forms.TextBox();
            this.textBoxPVoley = new System.Windows.Forms.TextBox();
            this.textBoxPFutsal = new System.Windows.Forms.TextBox();
            this.textBoxPBasket = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(55, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTADISTICAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(82, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Periodo";
            // 
            // buttonGenerarE
            // 
            this.buttonGenerarE.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonGenerarE.Location = new System.Drawing.Point(492, 125);
            this.buttonGenerarE.Name = "buttonGenerarE";
            this.buttonGenerarE.Size = new System.Drawing.Size(94, 29);
            this.buttonGenerarE.TabIndex = 3;
            this.buttonGenerarE.Text = "Generar";
            this.buttonGenerarE.UseVisualStyleBackColor = true;
            this.buttonGenerarE.Click += new System.EventHandler(this.buttonGenerarE_Click);
            // 
            // comboBoxPeriodoE
            // 
            this.comboBoxPeriodoE.FormattingEnabled = true;
            this.comboBoxPeriodoE.Items.AddRange(new object[] {
            "Dia",
            "Mes",
            "Año"});
            this.comboBoxPeriodoE.Location = new System.Drawing.Point(226, 125);
            this.comboBoxPeriodoE.Name = "comboBoxPeriodoE";
            this.comboBoxPeriodoE.Size = new System.Drawing.Size(224, 28);
            this.comboBoxPeriodoE.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(133, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "TOTAL ASISTENTES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(133, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Futsal :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(133, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Basket :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(133, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Voley :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(133, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tennis :";
            // 
            // textBoxUBasket
            // 
            this.textBoxUBasket.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUBasket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUBasket.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUBasket.Location = new System.Drawing.Point(401, 291);
            this.textBoxUBasket.Name = "textBoxUBasket";
            this.textBoxUBasket.Size = new System.Drawing.Size(100, 29);
            this.textBoxUBasket.TabIndex = 11;
            this.textBoxUBasket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUFtusal
            // 
            this.textBoxUFtusal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUFtusal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUFtusal.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUFtusal.Location = new System.Drawing.Point(401, 229);
            this.textBoxUFtusal.Name = "textBoxUFtusal";
            this.textBoxUFtusal.Size = new System.Drawing.Size(100, 29);
            this.textBoxUFtusal.TabIndex = 12;
            this.textBoxUFtusal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUVoley
            // 
            this.textBoxUVoley.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUVoley.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUVoley.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUVoley.Location = new System.Drawing.Point(401, 353);
            this.textBoxUVoley.Name = "textBoxUVoley";
            this.textBoxUVoley.Size = new System.Drawing.Size(100, 29);
            this.textBoxUVoley.TabIndex = 13;
            this.textBoxUVoley.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUTennis
            // 
            this.textBoxUTennis.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUTennis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUTennis.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUTennis.Location = new System.Drawing.Point(401, 415);
            this.textBoxUTennis.Name = "textBoxUTennis";
            this.textBoxUTennis.Size = new System.Drawing.Size(100, 29);
            this.textBoxUTennis.TabIndex = 14;
            this.textBoxUTennis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxUTotal
            // 
            this.textBoxUTotal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxUTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUTotal.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUTotal.Location = new System.Drawing.Point(401, 505);
            this.textBoxUTotal.Name = "textBoxUTotal";
            this.textBoxUTotal.Size = new System.Drawing.Size(100, 29);
            this.textBoxUTotal.TabIndex = 15;
            this.textBoxUTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPTotal
            // 
            this.textBoxPTotal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPTotal.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPTotal.Location = new System.Drawing.Point(516, 505);
            this.textBoxPTotal.Name = "textBoxPTotal";
            this.textBoxPTotal.Size = new System.Drawing.Size(70, 29);
            this.textBoxPTotal.TabIndex = 20;
            this.textBoxPTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPTennis
            // 
            this.textBoxPTennis.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPTennis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPTennis.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPTennis.Location = new System.Drawing.Point(516, 415);
            this.textBoxPTennis.Name = "textBoxPTennis";
            this.textBoxPTennis.Size = new System.Drawing.Size(70, 29);
            this.textBoxPTennis.TabIndex = 19;
            this.textBoxPTennis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPVoley
            // 
            this.textBoxPVoley.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPVoley.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPVoley.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPVoley.Location = new System.Drawing.Point(516, 353);
            this.textBoxPVoley.Name = "textBoxPVoley";
            this.textBoxPVoley.Size = new System.Drawing.Size(70, 29);
            this.textBoxPVoley.TabIndex = 18;
            this.textBoxPVoley.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPFutsal
            // 
            this.textBoxPFutsal.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPFutsal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPFutsal.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPFutsal.Location = new System.Drawing.Point(516, 229);
            this.textBoxPFutsal.Name = "textBoxPFutsal";
            this.textBoxPFutsal.Size = new System.Drawing.Size(70, 29);
            this.textBoxPFutsal.TabIndex = 17;
            this.textBoxPFutsal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxPBasket
            // 
            this.textBoxPBasket.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxPBasket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPBasket.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPBasket.Location = new System.Drawing.Point(516, 291);
            this.textBoxPBasket.Name = "textBoxPBasket";
            this.textBoxPBasket.Size = new System.Drawing.Size(70, 29);
            this.textBoxPBasket.TabIndex = 16;
            this.textBoxPBasket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(403, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Usuarios";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(539, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "%";
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 626);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxPTotal);
            this.Controls.Add(this.textBoxPTennis);
            this.Controls.Add(this.textBoxPVoley);
            this.Controls.Add(this.textBoxPFutsal);
            this.Controls.Add(this.textBoxPBasket);
            this.Controls.Add(this.textBoxUTotal);
            this.Controls.Add(this.textBoxUTennis);
            this.Controls.Add(this.textBoxUVoley);
            this.Controls.Add(this.textBoxUFtusal);
            this.Controls.Add(this.textBoxUBasket);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPeriodoE);
            this.Controls.Add(this.buttonGenerarE);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadisticas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonGenerarE;
        private ComboBox comboBoxPeriodoE;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBoxUBasket;
        private TextBox textBoxUFtusal;
        private TextBox textBoxUVoley;
        private TextBox textBoxUTennis;
        private TextBox textBoxUTotal;
        private TextBox textBoxPTotal;
        private TextBox textBoxPTennis;
        private TextBox textBoxPVoley;
        private TextBox textBoxPFutsal;
        private TextBox textBoxPBasket;
        private Label label8;
        private Label label9;
    }
}