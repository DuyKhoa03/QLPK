using Microsoft.Reporting.WinForms;
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
    public partial class frmInHD : Form
    {
        public frmInHD()
        {
            InitializeComponent();
        }
        private void frmInHD_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Visible= false;
            this.reportViewer1.RefreshReport();
        }
        private bool checkMaHD(int ma)
        {
            foreach(var i in context.Hoadons.ToList())
                if(i.MAHD==ma)
                    return true;
            return false;
        }
        PKNhaKhoaModel context = new PKNhaKhoaModel();
        private void btnInHD_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaHD.Text!="")
                {
                    if(checkMaHD(int.Parse(txtMaHD.Text)))
                    {
                        this.reportViewer1.Visible= true;
                        int ma = int.Parse(txtMaHD.Text);
                        Hoadon hoad = context.Hoadons.FirstOrDefault(p => p.MAHD == ma);
                        DichVuTT tt = context.DichVuTTs.FirstOrDefault(p => p.MADVTT == hoad.MADVTT);
                        Benhnhan benhnhan = context.Benhnhans.FirstOrDefault(p => p.MABN == hoad.MABN);
                        List<Hoadon> hd = context.Hoadons.Where(p => p.MAHD == ma).ToList();
                        List<Benhnhan> bn = context.Benhnhans.Where(p => p.MABN == benhnhan.MABN).ToList();
                        List<DichVuTT> dsdv = context.DichVuTTs.Where(p => p.MADVTT == tt.MADVTT).ToList();
                        this.reportViewer1.LocalReport.ReportPath = "./ReportHDon.rdlc";
                        ReportDataSource rds1 = new ReportDataSource("DataSet1", bn);
                        ReportDataSource rds = new ReportDataSource("DataSetHD", hd);
                        ReportDataSource rds2 = new ReportDataSource("DataSetDVTT", dsdv);
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.LocalReport.DataSources.Add(rds1);
                        reportViewer1.LocalReport.DataSources.Add(rds2);
                        this.reportViewer1.RefreshReport();
                    }
                    else
                        MessageBox.Show("Không tìm thấy hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Vui lòng nhập mã hóa đơn!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            /*PKNhaKhoaModel context = new PKNhaKhoaModel();
            int ma = int.Parse(txtMaHD.Text);
            Hoadon hd = context.Hoadons.FirstOrDefault(p => p.MAHD == ma);
            if (hd != null)
            {
                //rpvInHD.LocalReport.DataSources.Add();
            }*/
        }
    }
}
