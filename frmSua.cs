using QLPK.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK.GUI
{
    public partial class frmSua : Form
    {
        public frmSua()
        {
            InitializeComponent();
        }

        private void frmSua_Load(object sender, EventArgs e)
        {
            PKNhaKhoaModel context = new PKNhaKhoaModel();
            List<DichVuTT> ds = context.DichVuTTs.ToList();
            FillDVTTCombobox(ds);
        }
        private void FillDVTTCombobox(List<DichVuTT> listdv)
        {
            cmbDVTT.DataSource = listdv;
            cmbDVTT.DisplayMember = "TenDVTT";
            cmbDVTT.ValueMember = "MADVTT";
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool checkInfo(string mahd,string mabn, string macls, string macddt, string madt)
        {
            if (mahd=="" || mabn == "" || macls == "" || macddt == "" || madt == "")
                return false;
            return true;
        }
        private bool checkMAHD(string mahd)
        {
            PKNhaKhoaModel context = new PKNhaKhoaModel();
            var list = context.Hoadons.ToList();
            foreach (var item in list)
                if (item.MAHD.ToString() == mahd)
                    return true;
            return false;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInfo(txtMaHD.Text,txtMaBN.Text, txtMaCLS.Text, txtMaCDDT.Text, txtMaDT.Text))
                {
                    if(checkMAHD(txtMaHD.Text))
                    {
                        PKNhaKhoaModel context = new PKNhaKhoaModel();
                        int madt = int.Parse(txtMaDT.Text);//lấy mã đơn thuốc
                        int machuandoan = int.Parse(txtMaCDDT.Text);//lấy mã chuẩn đoán
                        Donthuoc donthuoc = context.Donthuocs.FirstOrDefault(p => p.MADT == madt);//lấy mã đơn thuốc
                        Chuandoandieutri cd = context.Chuandoandieutris.FirstOrDefault(p => p.MACDDT == machuandoan);//lấy mã chuẩn đoán
                        int maHD = int.Parse(txtMaHD.Text);
                        Hoadon updatehd = context.Hoadons.FirstOrDefault(p => p.MAHD ==maHD );
                        double tt = (double)cd.Dongia + (double)donthuoc.Tongtien;//tính tiền cho hóa đơn
                        Hoadon hd = updatehd;
                        hd.MAHD = int.Parse(txtMaHD.Text);
                        hd.Ngaylap = DateTime.Now;
                        hd.Tongtien = tt;
                        int.TryParse(txtMaBN.Text, out int mabn);
                        hd.MABN = mabn;
                        int.TryParse(txtMaCLS.Text, out int mc);
                        hd.MACLS = mc;
                        int.TryParse(txtMaCDDT.Text, out int cddt);
                        hd.MACDDT = cddt;
                        int.TryParse(txtMaDT.Text, out int cdt);
                        hd.MADT = cdt;
                        hd.MADVTT = (int)cmbDVTT.SelectedValue;
                        context.SaveChanges();
                        MessageBox.Show("Sửa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                        this.Close();
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
