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
    public partial class frmThongKeQuy : Form
    {
        public frmThongKeQuy()
        {
            InitializeComponent();
        }
        PKNhaKhoaModel context = new PKNhaKhoaModel();

        private void btnTK_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem != null)
                {
                    this.reportViewer1.Visible = true;
                    int quy = int.Parse(comboBox1.SelectedItem.ToString());
                    List<Hoadon> dshd = new List<Hoadon>();
                    if(quy ==1)
                    {
                        dshd = context.Hoadons.Where(p => p.Ngaylap.Value.Month >= 1 &&
                        p.Ngaylap.Value.Month <= 3).ToList();
                    }
                    if(quy ==2)
                    {
                        dshd = context.Hoadons.Where(p => p.Ngaylap.Value.Month >= 4 &&
                                p.Ngaylap.Value.Month <= 6).ToList();
                    }
                    if(quy==3)
                    {
                        dshd = context.Hoadons.Where(p => p.Ngaylap.Value.Month >= 7 &&
                                p.Ngaylap.Value.Month <= 9).ToList();
                    }
                    if(quy==4)
                    {
                        dshd = context.Hoadons.Where(p => p.Ngaylap.Value.Month >= 10 &&
                                p.Ngaylap.Value.Month <= 12).ToList();
                    }
                    this.reportViewer1.LocalReport.ReportPath = "./ReportTKQuy.rdlc";
                    ReportDataSource rds = new ReportDataSource("DataSetTKQuy", dshd);
                    reportViewer1.LocalReport.DataSources.Clear();
                    reportViewer1.LocalReport.DataSources.Add(rds);
                    this.reportViewer1.RefreshReport();
                }
                else
                    MessageBox.Show("Chọn quý!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmThongKeQuy_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
