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
    public partial class frmThemHD : Form
    {
        public frmThemHD()
        {
            InitializeComponent();
        }

        private void frmThemHD_Load(object sender, EventArgs e)
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
        private bool checkInfo(string mabn, string macls,string macddt,string madt)
        {
            if (mabn == "" || macls=="" || macddt == "" ||madt=="")
                return false;
            return true;
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInfo(txtMaBN.Text,txtMaCLS.Text,txtMaCDDT.Text, txtMaDT.Text))
                {
                    PKNhaKhoaModel context = new PKNhaKhoaModel();
                    int ma = 0;
                    foreach (var item in context.Hoadons.ToList())
                        ma = item.MAHD;//lấy mã hóa đơn cuối
                    int madt = int.Parse(txtMaDT.Text);//lấy mã đơn thuốc
                    int machuandoan = int.Parse(txtMaCDDT.Text);//lấy mã chuẩn đoán
                    Donthuoc donthuoc = context.Donthuocs.FirstOrDefault(p=>p.MADT==madt);
                    Chuandoandieutri cd = context.Chuandoandieutris.FirstOrDefault(p => p.MACDDT == machuandoan);
                    double tt = (double)cd.Dongia + (double)donthuoc.Tongtien;//tính tiền cho hóa đơn
                    Hoadon hd = new Hoadon();
                    hd.MAHD = (int)(ma+1);
                    hd.Ngaylap = DateTime.Now;
                    hd.Tongtien = tt;
                    int.TryParse(txtMaBN.Text,out int mabn);
                    hd.MABN= mabn;
                    int.TryParse(txtMaCLS.Text,out int mc);
                    hd.MACLS = mc;
                    int.TryParse(txtMaCDDT.Text,out int cddt);
                    hd.MACDDT = cddt;
                    int.TryParse(txtMaDT.Text,out int cdt);
                    hd.MADT = cdt;
                    hd.MADVTT =(int)cmbDVTT.SelectedValue;
                    context.Hoadons.Add(hd);
                    context.SaveChanges();
                    MessageBox.Show("Thêm hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                    this.Close();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
