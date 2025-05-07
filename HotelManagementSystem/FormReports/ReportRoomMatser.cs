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

    public partial class ReportRoomMatser: Form
    {
        string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public ReportRoomMatser()
        {
            InitializeComponent();
        }

        private void ReportRoomMatser_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Inactive");
            comboBoxStatus.SelectedIndex = 0; // Default selection
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string roomType = txtRoomType.Text.Trim();
            string status = comboBoxStatus.SelectedIndex != -1 ? comboBoxStatus.SelectedItem.ToString() : "";

            // If both fields are empty
            if (string.IsNullOrWhiteSpace(roomType) && string.IsNullOrWhiteSpace(status))
            {
                MessageBox.Show("Please enter Room Type or select Status", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomType, RoomNo, Status FROM RoomMaster WHERE 1=1";

                if (!string.IsNullOrWhiteSpace(roomType))
                    query += " AND RoomType LIKE @RoomType";

                if (!string.IsNullOrWhiteSpace(status))
                    query += " AND Status = @Status";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (!string.IsNullOrWhiteSpace(roomType))
                        cmd.Parameters.AddWithValue("@RoomType", "%" + roomType + "%"); // Partial match

                    if (!string.IsNullOrWhiteSpace(status))
                        cmd.Parameters.AddWithValue("@Status", status);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No records found for the given criteria", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView1.DataSource = null;
                    }
                    else
                    {
                        dataGridView1.DataSource = dt;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.DefaultCellStyle.Font = new Font("Verdana", 10);
                    }
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedIndex = -1; // Clear selection
            txtRoomType.Clear();              // Clear text
            dataGridView1.DataSource = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
