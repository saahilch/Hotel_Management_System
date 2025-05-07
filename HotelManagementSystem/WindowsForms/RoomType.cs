using HotelManagementSystem.WindowsForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class RoomType : Form
    {
        // Database connection string (Connects to SQL Server)
        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        // Constructor to initialize the form
        public RoomType()
        {
            InitializeComponent();
        }

        /* 1st need to check blank space or empty space is avaliable then disp msg 
         then chekc one by one txt box with for proper validations */
       
        //Save Button Logic for Insert and Update Operation
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check if Room Type already exists
                    string checkQuery = "SELECT COUNT(*) FROM RoomType WHERE RoomType = @RoomType AND Status = 'Active'";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@RoomType", txtRoomType.Text);
                    int count = (int)checkCmd.ExecuteScalar();

                    if (count > 0) // If Room Type Exists -> Update
                    {
                        string updateQuery = @"UPDATE RoomType 
                                              SET Quantity = @Quantity, Capacity = @Capacity, Price = @Price
                                              WHERE RoomType = @RoomType AND Status = 'Active'";
                        SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                        updateCmd.Parameters.AddWithValue("@RoomType", txtRoomType.Text);
                        updateCmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                        updateCmd.Parameters.AddWithValue("@Capacity", int.Parse(txtCapacity.Text));
                        updateCmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Room Details Updated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // If Room Type doesn't exist -> Insert New Data
                    {
                        string insertQuery = @"INSERT INTO RoomType (RoomType, Quantity, Capacity, Price, CreatedBy, CreatedOn, Status) 
                                              VALUES (@RoomType, @Quantity, @Capacity, @Price, 'Admin', GETDATE(), 'Active')";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                        insertCmd.Parameters.AddWithValue("@RoomType", txtRoomType.Text);
                        insertCmd.Parameters.AddWithValue("@Quantity", int.Parse(txtQuantity.Text));
                        insertCmd.Parameters.AddWithValue("@Capacity", int.Parse(txtCapacity.Text));
                        insertCmd.Parameters.AddWithValue("@Price", decimal.Parse(txtPrice.Text));
                        insertCmd.ExecuteNonQuery();

                        MessageBox.Show("Room Details Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                LoadRoomType(); // Reload DataGridView
                ClearFields(); // Clear textboxes
            }
        }

        private void HotelManagementSystem_Load(object sender, EventArgs e)
        {
            
            roomType_dataGrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 13, FontStyle.Bold);
            roomType_dataGrideView.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            LoadRoomType(); // Load Room Type Data
            StyleDataGridView();

        }
        private void StyleDataGridView()
        {
            roomType_dataGrideView.EnableHeadersVisualStyles = false;

            // Header style
            roomType_dataGrideView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            roomType_dataGrideView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            roomType_dataGrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 12F, FontStyle.Bold);
            roomType_dataGrideView.ColumnHeadersHeight = 40;

            // Row style
            roomType_dataGrideView.DefaultCellStyle.BackColor = Color.White;
            roomType_dataGrideView.DefaultCellStyle.ForeColor = Color.Black;
            roomType_dataGrideView.DefaultCellStyle.Font = new Font("Verdana", 10F, FontStyle.Bold);
            roomType_dataGrideView.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            roomType_dataGrideView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Grid settings
            roomType_dataGrideView.RowTemplate.Height = 35;
            roomType_dataGrideView.GridColor = Color.LightGray;
            roomType_dataGrideView.BorderStyle = BorderStyle.Fixed3D;
            //dataGridViewBookings.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            roomType_dataGrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        // Delete Row Logic (Marks Status as Inactive instead of deleting)
        private void roomType_dataGrideView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == roomType_dataGrideView.Columns["Action"].Index && e.RowIndex >= 0)
            {
                //string roomTypeName = roomType_dataGrideView.Rows[e.RowIndex].Cells["GuestFirstName"].Value.ToString();

                string cellValue = roomType_dataGrideView.Rows[e.RowIndex].Cells["RoomType"].Value.ToString();

                if (cellValue == null)
                {
                    MessageBox.Show("Room Type value is empty. Cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string roomType = cellValue.ToString();

                DialogResult result = MessageBox.Show("Do You Want To Inactive These Record?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE RoomType SET Status = 'UnderMaintance' WHERE RoomType = @RoomType";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@RoomType", roomType);
                        cmd.ExecuteNonQuery();

                        roomType_dataGrideView.Rows.RemoveAt(e.RowIndex); // Remove from DataGridView
                    }
                }
            }
        }


        // Load Active RoomType Data from Database
        private void LoadRoomType()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                // string query = "SELECT RoomType, Quantity, Capacity, Price, Status FROM RoomType WHERE Status = 'Active'";
                string query = "SELECT RoomType, Quantity, Capacity, Price, Status FROM RoomType WHERE Status = 'Active'";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                roomType_dataGrideView.DataSource = dt;
                roomType_dataGrideView.AllowUserToAddRows = false;

                // Add Delete Button Column only once
                if (roomType_dataGrideView.Columns["Action"] == null)
                {
                    DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                    deleteButton.Name = "Action";
                    deleteButton.Text = "Under Maintance";
                    deleteButton.UseColumnTextForButtonValue = true;

                    roomType_dataGrideView.Columns.Add(deleteButton);
                }
            }
        }
       
        private void btn_rt_search_Click(object sender, EventArgs e)
        {
            
        }
        
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtRoomType.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out _) || !int.TryParse(txtCapacity.Text, out _) || !decimal.TryParse(txtPrice.Text, out _))
            {
                MessageBox.Show("Invalid Input!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        /*Clear All The Fields txtboxes n all */
        private void ClearFields()
        {
            txtRoomType.Clear();
            txtQuantity.Clear();
            txtCapacity.Clear();
            txtPrice.Clear();
            txtbox_serch.Clear();
        }
    

        /*Set Up logout clk event*/
        private void logout_Click(object sender, EventArgs e)
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


        /* now set every page back*/
        private void dashboard_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.WindowState = this.WindowState;
            dashboard.Show();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Dashboard dashboard= new Dashboard();
            dashboard.Show(); // Show the previous form
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //this.Hide(); // Hide current form
            //BookingMaster bookingMaster = new BookingMaster();
            //bookingMaster.Show(); // Show the previous form
        }

        private void dashRoomMaster_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomMaster roomMaster= new RoomMaster();
            roomMaster.Show(); // Show the previous form

        }

        private void btn_rt_RoomType_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form
        }

        private void btn_rt_refresh_Click(object sender, EventArgs e)
        {
            LoadRoomType();
        }

        private void btn_rt_clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.WindowState = this.WindowState;
            dashboard.Show();
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form
        }

        private void roomMasterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show(); // Show the previous form
        }

        private void bookingMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide(); // Hide current form
            //BookingMaster bookingMaster = new BookingMaster();
            //bookingMaster.Show(); // Show the previous form
        }

        private void btn_rt_reportMaster_Click(object sender, EventArgs e)
        {

        }
        
        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_roomtype_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
        }
         
        private void btn_Serch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_serch.Text))
            {
                MessageBox.Show("Please enter a Room Type to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Quantity, Capacity, Price FROM RoomType WHERE RoomType = @RoomType AND Status = 'Active'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@RoomType", txtbox_serch.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txtRoomType.Text = txtbox_serch.Text;
                    txtQuantity.Text = reader["Quantity"].ToString();
                    txtCapacity.Text = reader["Capacity"].ToString();
                    txtPrice.Text = reader["Price"].ToString();
                }
                else
                {
                    MessageBox.Show("Room Type not found!", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btn_rt_reportmaster_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_rt_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            //dashboard.WindowState = this.WindowState;
            dashboard.Show();
        }

        private void btn_rt_roommaster_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show(); // Show the previous form
        }

        private void btn_rt_bookingmaster_Click(object sender, EventArgs e)
        {

            this.Hide();
            RoomStatusForm roomStatusForm = new RoomStatusForm();
            roomStatusForm.Show();
        }

        private void btn_rt_reportmaster_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show(); // Show the previous form


        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            AdminMaster adminMaster = new AdminMaster();
            adminMaster.Show(); // Show the previous form


        }
    }
}
