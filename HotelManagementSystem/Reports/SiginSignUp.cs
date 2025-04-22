using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.Reports
{
    public partial class SiginSignUp: Form
    {
        public SiginSignUp()
        {
            InitializeComponent();
        }
        public string ReportName { get; set; }
        public  DataTable ReportData { get; set; }
        private void SiginSignUp_Load(object sender, EventArgs e)
        {
           ReportDataSource reportDataSource = new ReportDataSource("AllSiginSigup",ReportData);
            reportViewer1.LocalReport.ReportPath = ReportName;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.RefreshReport();


            this.reportViewer1.RefreshReport();
        }
    }
}
