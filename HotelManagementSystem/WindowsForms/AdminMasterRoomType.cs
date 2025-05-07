using HotelManagementSystem.WindowsForms;
using HotelManagementSystem;
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
    public partial class AdminMasterRoomType: Form
    {
        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public AdminMasterRoomType()
        {
            InitializeComponent();
        }

        private void AdminMasterRoomType_Load(object sender, EventArgs e)
        {
            StyleDataGridView();
        }
        private void StyleDataGridView()
        {
            dgvRoomTypes.EnableHeadersVisualStyles = false;

            // Header style
            dgvRoomTypes.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            dgvRoomTypes.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRoomTypes.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14F, FontStyle.Bold);
            dgvRoomTypes.ColumnHeadersHeight = 40;

            // Row style
            dgvRoomTypes.DefaultCellStyle.BackColor = Color.White;
            dgvRoomTypes.DefaultCellStyle.ForeColor = Color.Black;
            dgvRoomTypes.DefaultCellStyle.Font = new Font("Verdana", 10F, FontStyle.Bold);
            dgvRoomTypes.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgvRoomTypes.DefaultCellStyle.SelectionForeColor = Color.White;

            // Grid settings
            dgvRoomTypes.RowTemplate.Height = 20;
            dgvRoomTypes.GridColor = Color.LightGray;
            dgvRoomTypes.BorderStyle = BorderStyle.Fixed3D;
            //dataGridViewBookings.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dgvRoomTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgvRoomTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvRoomTypes.Columns[e.ColumnIndex].Name == "Activate" && e.RowIndex >= 0)
            {
                string roomType = dgvRoomTypes.Rows[e.RowIndex].Cells["RoomType"].Value.ToString();

                DialogResult result = MessageBox.Show($"Activate RoomType '{roomType}'?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string updateQuery = "UPDATE RoomType SET Status = 'Active' WHERE RoomType = @RoomType";
                        SqlCommand cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@RoomType", roomType);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("RoomType Activated Successfully.");
                    LoadUnderMaintenanceRoomTypes(); // Refresh the grid
                }
            }

        }

        private void LoadUnderMaintenanceRoomTypes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT  RoomType, Quantity, Capacity, Price, Status FROM RoomType WHERE Status = 'UnderMaintance'";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvRoomTypes.DataSource = dt;

                // Add "Active" button column if not already added
                if (!dgvRoomTypes.Columns.Contains("Activate"))
                {
                    DataGridViewButtonColumn btnCol = new DataGridViewButtonColumn();
                    btnCol.HeaderText = "Action";
                    btnCol.Name = "Activate";
                    btnCol.Text = "Activate";
                    btnCol.UseColumnTextForButtonValue = true;
                    dgvRoomTypes.Columns.Add(btnCol);
                }
            }
        }

        private void btnLoadUnderMaintenanceRooms_Click(object sender, EventArgs e)
        {
            LoadUnderMaintenanceRoomTypes();

        }

        private void btn_rm_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btn_rm_roomtype_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form
        }

        private void btn_roommaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show();
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
            report.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMaster adminMaster = new AdminMaster();
            adminMaster.Show();

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



