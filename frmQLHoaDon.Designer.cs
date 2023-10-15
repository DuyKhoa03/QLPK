namespace QLPK.GUI
{
    partial class frmQLHoaDon
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenBN = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.txtCDDT = new System.Windows.Forms.TextBox();
            this.txtCLamSang = new System.Windows.Forms.TextBox();
            this.txtDVTT = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngKhácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoThángToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoQuýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNămToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý Hóa đơn";
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvHoaDon.Location = new System.Drawing.Point(15, 344);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoaDon.Size = new System.Drawing.Size(846, 232);
            this.dgvHoaDon.TabIndex = 11;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Hóa đơn";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Lập";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mã bệnh nhân";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cận lâm sàng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chuẩn đoán điều trị";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Mã đơn thuốc";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Dịch vụ thanh toán";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tổng tiền";
            this.Column8.Name = "Column8";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "MÃ BỆNH NHÂN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DỊCH VỤ THANH TOÁN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "MÃ ĐƠN THUỐC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "CHUẨN ĐOÁN - ĐIỀU TRỊ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "CẬN LÂM SÀNG";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(607, 246);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "TỔNG TIỀN";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(679, 239);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(150, 20);
            this.txtTongTien.TabIndex = 6;
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.Location = new System.Drawing.Point(167, 243);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(100, 20);
            this.txtMaDonThuoc.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tên bệnh nhân";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Năm sinh";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Địa chỉ";
            // 
            // txtTenBN
            // 
            this.txtTenBN.Location = new System.Drawing.Point(127, 45);
            this.txtTenBN.Name = "txtTenBN";
            this.txtTenBN.Size = new System.Drawing.Size(155, 20);
            this.txtTenBN.TabIndex = 20;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.Location = new System.Drawing.Point(127, 89);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.Size = new System.Drawing.Size(155, 20);
            this.txtNamSinh.TabIndex = 21;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(127, 133);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(155, 20);
            this.txtDiaChi.TabIndex = 22;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtNamSinh);
            this.panel1.Controls.Add(this.txtTenBN);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(547, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 170);
            this.panel1.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(79, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "Thông tin cơ bản";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(10, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(840, 2);
            this.label12.TabIndex = 7;
            this.label12.Text = "label12";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(10, 281);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 40);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnInsertUpdate_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(202, 281);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(92, 40);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Xóa";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(774, 588);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "MÃ HÓA ĐƠN";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(167, 68);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(165, 20);
            this.txtMaHD.TabIndex = 0;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(104, 281);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 40);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtMaBN
            // 
            this.txtMaBN.Location = new System.Drawing.Point(167, 107);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(165, 20);
            this.txtMaBN.TabIndex = 1;
            this.txtMaBN.TextChanged += new System.EventHandler(this.txtMaBN_TextChanged);
            // 
            // txtCDDT
            // 
            this.txtCDDT.Location = new System.Drawing.Point(167, 195);
            this.txtCDDT.Name = "txtCDDT";
            this.txtCDDT.Size = new System.Drawing.Size(249, 20);
            this.txtCDDT.TabIndex = 3;
            // 
            // txtCLamSang
            // 
            this.txtCLamSang.Location = new System.Drawing.Point(167, 151);
            this.txtCLamSang.Name = "txtCLamSang";
            this.txtCLamSang.Size = new System.Drawing.Size(249, 20);
            this.txtCLamSang.TabIndex = 2;
            // 
            // txtDVTT
            // 
            this.txtDVTT.Location = new System.Drawing.Point(414, 243);
            this.txtDVTT.Name = "txtDVTT";
            this.txtDVTT.Size = new System.Drawing.Size(187, 20);
            this.txtDVTT.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngKhácToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 32;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngKhácToolStripMenuItem
            // 
            this.chứcNăngKhácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inHóaĐơnToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.chứcNăngKhácToolStripMenuItem.Name = "chứcNăngKhácToolStripMenuItem";
            this.chứcNăngKhácToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngKhácToolStripMenuItem.Text = "Chức năng";
            // 
            // inHóaĐơnToolStripMenuItem
            // 
            this.inHóaĐơnToolStripMenuItem.Name = "inHóaĐơnToolStripMenuItem";
            this.inHóaĐơnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.inHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inHóaĐơnToolStripMenuItem.Text = "In Hóa đơn";
            this.inHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.inHóaĐơnToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theoThángToolStripMenuItem,
            this.theoQuýToolStripMenuItem,
            this.theoNămToolStripMenuItem});
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            // 
            // theoThángToolStripMenuItem
            // 
            this.theoThángToolStripMenuItem.Name = "theoThángToolStripMenuItem";
            this.theoThángToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.theoThángToolStripMenuItem.Text = "Theo tháng";
            this.theoThángToolStripMenuItem.Click += new System.EventHandler(this.theoThángToolStripMenuItem_Click);
            // 
            // theoQuýToolStripMenuItem
            // 
            this.theoQuýToolStripMenuItem.Name = "theoQuýToolStripMenuItem";
            this.theoQuýToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.theoQuýToolStripMenuItem.Text = "Theo quý";
            this.theoQuýToolStripMenuItem.Click += new System.EventHandler(this.theoQuýToolStripMenuItem_Click);
            // 
            // theoNămToolStripMenuItem
            // 
            this.theoNămToolStripMenuItem.Name = "theoNămToolStripMenuItem";
            this.theoNămToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.theoNămToolStripMenuItem.Text = "Theo năm";
            this.theoNămToolStripMenuItem.Click += new System.EventHandler(this.theoNămToolStripMenuItem_Click);
            // 
            // frmQLHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 623);
            this.Controls.Add(this.txtDVTT);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMaBN);
            this.Controls.Add(this.txtCLamSang);
            this.Controls.Add(this.txtCDDT);
            this.Controls.Add(this.txtMaDonThuoc);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmQLHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQLHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmQLHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenBN;
        private System.Windows.Forms.TextBox txtNamSinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.TextBox txtCDDT;
        private System.Windows.Forms.TextBox txtCLamSang;
        private System.Windows.Forms.TextBox txtDVTT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngKhácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoThángToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoQuýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoNămToolStripMenuItem;
    }
}