using Microsoft.Reporting.WinForms;
using QLPK.DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLPK.GUI
{
    public partial class frmThongKeNam : Form
    {
        public frmThongKeNam()
        {
            InitializeComponent();
        }

        private void frmThongKeNam_Load(object sender, EventArgs e)
        {
            for(int i = 2000;i<=2023;i++)
                comboBox1.Items.Add(i.ToString());
            this.reportViewer1.RefreshReport();
        }
        PKNhaKhoaModel context = new PKNhaKhoaModel();
        private void tbnTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    int nam = int.Parse(comboBox1.SelectedItem.ToString());
                    List<Hoadon> dshd = context.Hoadons.Where(p => p.Ngaylap.Value.Year == nam).ToList();
                    this.reportViewer1.LocalReport.ReportPath = "./ReportTKNam.rdlc";
                    ReportDataSource rds = new ReportDataSource("DataSet1", dshd);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                }
                else
                    MessageBox.Show("Chọn Năm!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
