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
    public partial class frmThongkeThang : Form
    {

        public frmThongkeThang()
        {
            InitializeComponent();
        }

        private void frmThongkeThang_Load(object sender, EventArgs e)
        {
            this.reportViewer1.Visible=false;
            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
        PKNhaKhoaModel context = new PKNhaKhoaModel();
        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                if(comboBox1.SelectedItem!=null)
                {
                    this.reportViewer1.Visible = true;
                    int thang = int.Parse(comboBox1.SelectedItem.ToString());
                    List<Hoadon> dshd = context.Hoadons.Where(p => p.Ngaylap.Value.Month == thang).ToList();
                    this.reportViewer1.LocalReport.ReportPath = "./ReportTK.rdlc";
                    ReportDataSource rds = new ReportDataSource("DataSetTK", dshd);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                }
                else
                    MessageBox.Show("Chọn tháng!!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
