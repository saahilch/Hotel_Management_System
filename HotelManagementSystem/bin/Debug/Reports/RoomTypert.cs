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
    public partial class RoomTypert: Form
    {
       
        public RoomTypert()
        {
            InitializeComponent();
        }
        public string ReportName { get; set; }
        public DataTable ReportData { get; set; }
        private void RoomType_Load(object sender, EventArgs e)
        {
            
            ReportDataSource reportDataSource = new ReportDataSource("RoomTypeDataSet", ReportData);
            reportViewer1.LocalReport.ReportPath = ReportName;
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();





        }
    }
}
