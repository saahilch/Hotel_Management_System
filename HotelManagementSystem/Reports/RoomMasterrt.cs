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
    public partial class RoomMasterrt: Form
    {
        public RoomMasterrt()
        {
            InitializeComponent();
        }
        public string ReportName { get; set; }
        public DataTable ReportData { get; set; }
        private void RoomMasterrt_Load(object sender, EventArgs e)
        {
            ReportDataSource reportDataSource = new ReportDataSource("RoomMasterDataset", ReportData);
            reportViewer1.LocalReport.ReportPath = ReportName;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
           
        }
    }
}
