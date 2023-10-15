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
    public partial class frmQLHoaDon : Form
    {
        public frmQLHoaDon()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmQLHoaDon_Load(object sender, EventArgs e)
        {
            try
            {
                PKNhaKhoaModel context = new PKNhaKhoaModel();
                List<Hoadon> listHoadon = context.Hoadons.ToList();
                List<DichVuTT> listDVTT = context.DichVuTTs.ToList();
                BindGrid(listHoadon);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BindGrid(List<Hoadon> dshd)
        {
            txtMaHD.Text =txtMaBN.Text =txtCLamSang.Text =txtCDDT.Text=txtMaDonThuoc.Text=txtTongTien.Text= txtTenBN.Text = txtNamSinh.Text =
                txtDiaChi.Text = "";
            dgvHoaDon.Rows.Clear();
            foreach (var item in dshd)
            {
                int index = dgvHoaDon.Rows.Add();
                dgvHoaDon.Rows[index].Cells[0].Value = item.MAHD;
                dgvHoaDon.Rows[index].Cells[1].Value = item.Ngaylap;
                dgvHoaDon.Rows[index].Cells[2].Value = item.MABN;
                dgvHoaDon.Rows[index].Cells[3].Value = item.CanLamSang.TenCLS;
                dgvHoaDon.Rows[index].Cells[4].Value = item.Chuandoandieutri.TenCDDT;
                dgvHoaDon.Rows[index].Cells[5].Value = item.MADT;
                dgvHoaDon.Rows[index].Cells[6].Value = item.DichVuTT.TenDVTT;
                dgvHoaDon.Rows[index].Cells[7].Value = item.Tongtien;
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvHoaDon.SelectedRows.Count > 0 && dgvHoaDon.SelectedRows[0].Cells[0].Value != null)
                {
                    txtMaHD.Text = dgvHoaDon.SelectedRows[0].Cells[0].Value.ToString();
                    txtMaBN.Text = dgvHoaDon.SelectedRows[0].Cells[2].Value.ToString();
                    txtCLamSang.Text = dgvHoaDon.SelectedRows[0].Cells[3].Value.ToString();
                    txtCDDT.Text = dgvHoaDon.SelectedRows[0].Cells[4].Value.ToString();
                    txtMaDonThuoc.Text = dgvHoaDon.SelectedRows[0].Cells[5].Value.ToString();
                    txtDVTT.Text = dgvHoaDon.SelectedRows[0].Cells[6].Value.ToString();
                    txtTongTien.Text = dgvHoaDon.SelectedRows[0].Cells[7].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtMaBN_TextChanged(object sender, EventArgs e)
        {
            PKNhaKhoaModel context = new PKNhaKhoaModel();
            var bn = context.Benhnhans.FirstOrDefault(p => p.MABN.ToString() == txtMaBN.Text);
            if (bn != null)
            {
                txtTenBN.Text = bn.TenBN;
                txtNamSinh.Text = bn.Namsinh.ToString();
                txtDiaChi.Text = bn.Diachi.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
                this.Close();
        }
        
        private void btnInsertUpdate_Click(object sender, EventArgs e)
        {
            PKNhaKhoaModel context = new PKNhaKhoaModel();
            frmThemHD frm = new frmThemHD();
            frm.ShowDialog();
            BindGrid(context.Hoadons.ToList());
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            PKNhaKhoaModel context = new PKNhaKhoaModel();
            frmSua frm = new frmSua();
            frm.ShowDialog();
            BindGrid(context.Hoadons.ToList());
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
        private bool checkMaHD(string ma)
        {
            if (ma == "" )
                return false;
            return true;
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkMAHD(txtMaHD.Text))
                {
                    if (checkMAHD(txtMaHD.Text))
                    {
                        PKNhaKhoaModel context = new PKNhaKhoaModel();
                        var rm = context.Hoadons.FirstOrDefault(p => p.MAHD.ToString() == txtMaHD.Text);
                        if (rm != null)
                        {
                            DialogResult dr = MessageBox.Show("Bạn có muốn xóa hóa đơn?", "Thông báo", MessageBoxButtons.YesNo);
                            if (dr == DialogResult.Yes)
                            {
                                context.Hoadons.Remove(rm);
                                context.SaveChanges();
                                MessageBox.Show("Xóa hóa đơn thành công!", "Thông báo", MessageBoxButtons.OK);
                                BindGrid(context.Hoadons.ToList());
                            }
                        }
                    }
                }
                else
                    MessageBox.Show("Không tìm thấy mã hóa đơn!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void frmQLHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Quản Lý Hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmInHD frm = new frmInHD();
            frm.ShowDialog();
        }

        private void theoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongkeThang frm = new frmThongkeThang();
            frm.ShowDialog();
        }

        private void theoQuýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeQuy frm = new frmThongKeQuy();
            frm.ShowDialog();
        }

        private void theoNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKeNam frm = new frmThongKeNam();
            frm.ShowDialog();
        }
    }

}

