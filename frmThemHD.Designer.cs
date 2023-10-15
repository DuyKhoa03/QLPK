namespace QLPK.GUI
{
    partial class frmThemHD
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.txtMaDT = new System.Windows.Forms.TextBox();
            this.txtMaCDDT = new System.Windows.Forms.TextBox();
            this.txtMaCLS = new System.Windows.Forms.TextBox();
            this.cmbDVTT = new System.Windows.Forms.ComboBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thêm hóa đơn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã bệnh nhân";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã cận lâm sàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã CD - DT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Mã đơn thuốc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Dịch vụ thanh toán";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(122, 85);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(100, 20);
            this.txtMaBN.TabIndex = 8;
            // 
            // txtMaDT
            // 
            this.txtMaDT.Location = new System.Drawing.Point(391, 89);
            this.txtMaDT.Name = "txtMaDT";
            this.txtMaDT.Size = new System.Drawing.Size(100, 20);
            this.txtMaDT.TabIndex = 9;
            // 
            // txtMaCDDT
            // 
            this.txtMaCDDT.Location = new System.Drawing.Point(122, 165);
            this.txtMaCDDT.Name = "txtMaCDDT";
            this.txtMaCDDT.Size = new System.Drawing.Size(100, 20);
            this.txtMaCDDT.TabIndex = 10;
            // 
            // txtMaCLS
            // 
            this.txtMaCLS.Location = new System.Drawing.Point(122, 125);
            this.txtMaCLS.Name = "txtMaCLS";
            this.txtMaCLS.Size = new System.Drawing.Size(100, 20);
            this.txtMaCLS.TabIndex = 11;
            // 
            // cmbDVTT
            // 
            this.cmbDVTT.FormattingEnabled = true;
            this.cmbDVTT.Location = new System.Drawing.Point(391, 124);
            this.cmbDVTT.Name = "cmbDVTT";
            this.cmbDVTT.Size = new System.Drawing.Size(121, 21);
            this.cmbDVTT.TabIndex = 12;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(147, 219);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(75, 23);
            this.btnDongY.TabIndex = 13;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(286, 219);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 254);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.cmbDVTT);
            this.Controls.Add(this.txtMaCLS);
            this.Controls.Add(this.txtMaCDDT);
            this.Controls.Add(this.txtMaDT);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "frmThemHD";
            this.Text = "Thêm hóa đơn";
            this.Load += new System.EventHandler(this.frmThemHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.TextBox txtMaDT;
        private System.Windows.Forms.TextBox txtMaCDDT;
        private System.Windows.Forms.TextBox txtMaCLS;
        private System.Windows.Forms.ComboBox cmbDVTT;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnHuy;
    }
}