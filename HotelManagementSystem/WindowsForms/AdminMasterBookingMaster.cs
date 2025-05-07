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

namespace HotelManagementSystem.WindowsForms
{
    public partial class AdminMasterBookingMaster: Form
    {
        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public AdminMasterBookingMaster()
        {
            InitializeComponent();
        }

        private void AdminMasterBookingMaster_Load(object sender, EventArgs e)
        {
            StyleDataGridView();

        }
        private void StyleDataGridView()
        {
            dgvBookingMaster.EnableHeadersVisualStyles = false;

            // Header style
            dgvBookingMaster.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvBookingMaster.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvBookingMaster.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14F, FontStyle.Bold);
            dgvBookingMaster.ColumnHeadersHeight = 40;

            // Row style
            dgvBookingMaster.DefaultCellStyle.BackColor = Color.White;
            dgvBookingMaster.DefaultCellStyle.ForeColor = Color.Black;
            dgvBookingMaster.DefaultCellStyle.Font = new Font("Verdana", 10F, FontStyle.Bold);
            dgvBookingMaster.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgvBookingMaster.DefaultCellStyle.SelectionForeColor = Color.White;

            // Grid settings
            dgvBookingMaster.RowTemplate.Height = 20;
            dgvBookingMaster.GridColor = Color.LightGray;
            dgvBookingMaster.BorderStyle = BorderStyle.Fixed3D;
            //dataGridViewBookings.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvBookingMaster.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void btnLoadUnderMaintenanceRooms_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadUnderMaintenanceRooms_Click_1(object sender, EventArgs e)
        {
            LoadUnderMaintenanceBookings();
        }

        private void LoadUnderMaintenanceBookings()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT  GuestFirstName, GuestLastName,Gender, RoomType, RoomNumber,BookingDate,CheckoutDate, Status FROM BookingMaster WHERE Status = 'CheckIn'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvBookingMaster.DataSource = dt;

                // Add "Activate" button only once
                if (!dgvBookingMaster.Columns.Contains("Activate"))
                {
                    DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                    btn.Name = "Activate";
                    btn.HeaderText = "Action";
                    btn.Text = "CheckOut";
                    btn.UseColumnTextForButtonValue = true;
                    dgvBookingMaster.Columns.Add(btn);
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBookingMaster.Columns[e.ColumnIndex].Name == "Activate" && e.RowIndex >= 0)
            {
                string guestFirstName = dgvBookingMaster.Rows[e.RowIndex].Cells["GuestFirstName"].Value.ToString();

                DialogResult result = MessageBox.Show($"Activate booking for '{guestFirstName}'?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string updateQuery = @"
                    UPDATE BookingMaster 
                    SET Status = 'CheckOut', 
                        CheckoutDate = @CheckoutDate 
                    WHERE GuestFirstName = @GuestFirstName";

                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@GuestFirstName", guestFirstName);
                        cmd.Parameters.AddWithValue("@CheckoutDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Booking checked out successfully.");
                    LoadUnderMaintenanceBookings(); // Refresh grid
                }
            }
        }

        private void btn_rm_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            //dashboard.WindowState = this.WindowState;
            dashboard.Show();
        }

        private void btn_rm_roomtype_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form
        }

        private void btn_rm_bookingmaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomStatusForm roomStatusForm = new RoomStatusForm();
            roomStatusForm.Show();
        }

        private void btn_rm_reportmaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show(); // Show the previous form
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMaster adminMaster = new AdminMaster();
            adminMaster.Show();
        }

        private void btn_roommaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show();
        }

        private void btn_rt_logout_Click(object sender, EventArgs e)
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
    }
}
