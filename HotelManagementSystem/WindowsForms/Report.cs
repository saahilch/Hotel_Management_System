using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using HotelManagementSystem.Reports;
using HotelManagementSystem.ReportDataset;
using Microsoft.Reporting.WebForms;
using HotelManagementSystem.FormReports;

namespace HotelManagementSystem.WindowsForms
{
    public partial class Report: Form
    {
         string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";
        public Report()
        {
            InitializeComponent();
        }


        private void btn_pannel_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Dashboard dashboard = new Dashboard();
            dashboard.Show(); // Show the previous form
        }

        private void btn_pannel_roomtype_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form

        }

        private void btn_pannel_roommaster_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show();

        }

        private void btn_pannel_bookingmaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomStatusForm roomStatusForm = new RoomStatusForm();
            roomStatusForm.Show();
            
            //this.Hide(); // Hide current form

            //BookingMaster bookingMaster = new BookingMaster();
            //bookingMaster.Show(); // Show the previous form

        }

        private void btn_report_logout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SignIn signIn = new SignIn();
                signIn.WindowState = this.WindowState;
                signIn.Show();
                this.Close();
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void btn_report_siginup_Click(object sender, EventArgs e)
        {
            //SqlConnection conn=new SqlConnection(connectionString);
            //conn.Open();
            //try
            //{
            //    string sql = "SELECT * FROM SignInSignUp";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds, "SignInSignUp");
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    if(dt.Rows.Count > 0)
            //    {
            //        string apppath = Application.StartupPath;
            //        string reportPath = @"Reports/SignInSignUpReport.rdlc";
            //        string fullpath=Path.Combine(apppath, reportPath);
            //        SiginSignUp report = new SiginSignUp();
            //        report.ReportName = fullpath;
            //        report.ReportData = dt;
            //        report.ShowDialog();

            //    }
            //    else
            //    {
            //        MessageBox.Show("No data found in the database.");
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}

            this.Hide(); // Hide current form
            ReportSignInSignUp siginSignUp = new ReportSignInSignUp();
            siginSignUp.Show(); // Show the previous form

            

        }

        private void btn_report_roomtype_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            //try
            //{
            //    string sql = "SELECT * FROM RoomType";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSetRoomType ds = new DataSetRoomType();
            //    da.Fill(ds, "RoomType");
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        string apppath = Application.StartupPath;
            //        string reportPath = @"Reports/RoomTypeReport.rdlc";
            //        string fullpath = Path.Combine(apppath, reportPath);

            //        RoomTypert report = new RoomTypert();
            //        report.ReportName = fullpath;
            //        report.ReportData = dt;
            //        report.ShowDialog();

            //    }
            //    else
            //    {
            //        MessageBox.Show("No data found in the database.");
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            this.Hide();
            ReportRoomType reportRoomType = new ReportRoomType();
            reportRoomType.Show();

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_report_roommaster_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            //try
            //{
            //    string sql = "SELECT * FROM RoomMaster";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSetRoomType ds = new DataSetRoomType();
            //    da.Fill(ds, "RoomMaster");
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        string apppath = Application.StartupPath;
            //        string reportPath = @"Reports/RoomMasterReport.rdlc";
            //        string fullpath = Path.Combine(apppath, reportPath);

            //        RoomMasterrt report = new RoomMasterrt();
            //        report.ReportName = fullpath;
            //        report.ReportData = dt;
            //        report.ShowDialog();

            //    }
            //    else
            //    {
            //        MessageBox.Show("No data found in the database.");
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            this.Hide();
            ReportRoomMatser reportRoomMatser = new ReportRoomMatser();
            reportRoomMatser.Show();

        }

        private void btn_report_bookingmaster_Click(object sender, EventArgs e)
        {
            //SqlConnection conn = new SqlConnection(connectionString);
            //conn.Open();
            //try
            //{
            //    string sql = "SELECT * FROM BookingMaster";
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSetRoomType ds = new DataSetRoomType();
            //    da.Fill(ds, "BookingMaster");
            //    DataTable dt = new DataTable();
            //    da.Fill(dt);
            //    if (dt.Rows.Count > 0)
            //    {
            //        string apppath = Application.StartupPath;
            //        string reportPath = @"Reports/BookingMasterReport.rdlc";
            //        string fullpath = Path.Combine(apppath, reportPath);

            //        BookingMasterrtcs report = new BookingMasterrtcs();
            //        report.ReportName = fullpath;
            //        report.ReportData = dt;
            //        report.ShowDialog();

            //    }
            //    else
            //    {
            //        MessageBox.Show("No data found in the database.");
            //    }


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
            this.Hide();
            ReportBookingMaster reportBookingMaster = new ReportBookingMaster();
            reportBookingMaster.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMaster adminMaster = new AdminMaster();
            adminMaster.Show();
        }
    }
}
