using HotelManagementSystem.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem.FormReports
{
    public partial class ReportBookingMaster: Form
    {
        string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public ReportBookingMaster()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string mobileNo = txtMobile.Text.Trim();

            if (string.IsNullOrWhiteSpace(mobileNo))
            {
                MessageBox.Show("Please enter a mobile number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT GuestFirstName, GuestLastName, GuestMobileNo, Gender, Email, 
                                GuestCount, TotalAllocatedRoom, RoomType, RoomNumber, 
                                BookingDate, CheckoutDate, Status
                         FROM BookingMaster 
                         WHERE GuestMobileNo = @Mobile";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Mobile", mobileNo);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No booking found for this mobile number.", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 10);
                        dataGridView1.RowHeadersVisible = false;
                    }
                }
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT GuestFirstName, GuestLastName, GuestMobileNo, Gender, Email, 
                                GuestCount, TotalAllocatedRoom, RoomType, RoomNumber, 
                                BookingDate, CheckoutDate, Status
                         FROM BookingMaster";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No booking data found in the system.", "No Records", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 10);
                        dataGridView1.RowHeadersVisible = false;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=null;
            txtMobile.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show();

        }
    }
}
