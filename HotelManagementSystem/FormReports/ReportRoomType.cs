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
    public partial class ReportRoomType: Form
    {
        string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public ReportRoomType()
        {
            InitializeComponent();
        }

        private void ReportRoomType_Load(object sender, EventArgs e)
        {
            comboBoxStatus.Items.Add("Active");
            comboBoxStatus.Items.Add("Inactive");
            comboBoxStatus.SelectedIndex = 0; // Default selection
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

            string selectedStatus = comboBoxStatus.SelectedItem.ToString();
            string priceText = textBoxPrice.Text.Trim();

            decimal priceFilter = 0;
            bool isPriceValid = decimal.TryParse(priceText, out priceFilter);

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT RoomType, Quantity, Capacity, Price, CreatedOn, Status \r\nFROM RoomType \r\nWHERE Status = @Status";

                if (isPriceValid)
                {
                    query += " AND Price <= @Price"; // You can change condition as needed
                }

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", selectedStatus);

                    if (isPriceValid)
                    {
                        cmd.Parameters.AddWithValue("@Price", priceFilter);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.RowHeadersVisible = false;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            comboBoxStatus.SelectedIndex = -1; // Clear selection
            textBoxPrice.Clear();              // Clear text
            dataGridView1.DataSource = null;   // Clear data grid
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show();
        }
    }
}
