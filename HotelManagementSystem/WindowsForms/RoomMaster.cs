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

namespace HotelManagementSystem
{
    public partial class RoomMaster : Form
    {
        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public RoomMaster()
        {
            InitializeComponent();
        }

        // Populate dropdown on form load

        private void LoadRoomTypes()
        {
            // Establish a connection to the SQL Server database using the connection string
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the database connection
                    conn.Open();

                    // SQL query to select only active room types from the RoomType table
                    string query = "SELECT RoomType FROM RoomType WHERE Status = 'Active'";

                    // Create a SqlCommand object to execute the query
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Execute the query and get the result set
                        SqlDataReader reader = cmd.ExecuteReader();

                        // Clear previous items from the ComboBox to avoid duplicates
                        cmbRoomType.Items.Clear();

                        // Loop through the result set and add each active room type to the ComboBox
                        while (reader.Read())
                        {
                            cmbRoomType.Items.Add(reader["RoomType"].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur during database access
                    // Show an error message to the user
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Add Delete Button in DataGridView on Form Load
        private void RoomMaster_Load(object sender, EventArgs e)
        {
            // Load data into RoomMaster table from hotelManagementDataSet

            // Load data into RoomType table from dataSet1
            //this.roomTypeTableAdapter.Fill(this.dataSet1.RoomType);

            // Load data into RoomMaster table from dataSet3
           // this.roomMasterTableAdapter.Fill(this.dataSet3.RoomMaster);

            // Set the font style for DataGridView column headers
            rm_datagrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 13, FontStyle.Bold);

            // Set the font style for DataGridView rows
            rm_datagrideView.DefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Load active room types into ComboBox
            LoadRoomTypes();

            // Load room master data to bind with DataGridView
            LoadRoomMaster();

            // Add a Delete button column to DataGridView
            AddDeleteButton();

            // Disable adding rows manually by the user
            rm_datagrideView.AllowUserToAddRows = false;
            StyleDataGridView();
            



        }
        /*now add delete btn on datagrideview */
        private void StyleDataGridView()
        {
            rm_datagrideView.EnableHeadersVisualStyles = false;

            // Header style
            rm_datagrideView.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkGreen;
            rm_datagrideView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            rm_datagrideView.ColumnHeadersDefaultCellStyle.Font = new Font("Verdana", 14F,FontStyle.Bold);
            rm_datagrideView.ColumnHeadersHeight = 40;

            // Row style
            rm_datagrideView.DefaultCellStyle.BackColor = Color.White;
            rm_datagrideView.DefaultCellStyle.ForeColor = Color.Black;
            rm_datagrideView.DefaultCellStyle.Font = new Font("Verdana", 10F, FontStyle.Bold);
            rm_datagrideView.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            rm_datagrideView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Grid settings
            rm_datagrideView.RowTemplate.Height = 20;
            rm_datagrideView.GridColor = Color.LightGray;
            rm_datagrideView.BorderStyle = BorderStyle.Fixed3D;
            //dataGridViewBookings.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            rm_datagrideView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //private void btn_rm_save_Click_1(object sender, EventArgs e)
        //{
        //    // Check if Room Type or Room Number fields are empty
        //    if (string.IsNullOrWhiteSpace(cmbRoomType.Text) ||
        //         string.IsNullOrWhiteSpace(txtRoomNo.Text))
        //    {
        //        MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Validate if Room No is a positive integer
        //    if (!int.TryParse(txtRoomNo.Text, out int roomNo) || roomNo <= 0)
        //    {
        //        MessageBox.Show("Room No must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return;
        //    }

        //    // Establish SQL connection
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            // Open the database connection
        //            conn.Open();

        //            // Check if the room number already exists in the RoomMaster table
        //            string checkQuery = "SELECT COUNT(*) FROM RoomMaster WHERE RoomNo = @RoomNo";
        //            using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
        //            {
        //                // Pass Room No as a parameter to prevent SQL Injection
        //                checkCmd.Parameters.AddWithValue("@RoomNo", roomNo);

        //                // Execute the query and get the count of matching records
        //                int count = (int)checkCmd.ExecuteScalar();

        //                // If the room number already exists, show an error message and stop execution
        //                if (count > 0)
        //                {
        //                    MessageBox.Show("Room No already exists!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                    return;
        //                }
        //            }

        //            // Insert the new room record into the RoomMaster table
        //            string insertQuery = @"INSERT INTO RoomMaster (RoomType, RoomNo, CreatedOn, CreatedBy, ModifyOn, ModifyBy, Status) 
        //                           VALUES (@RoomType, @RoomNo, GETDATE(), 'Admin', NULL, NULL, 'Active')";

        //            using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
        //            {
        //                // Pass Room Type and Room No as parameters
        //                insertCmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
        //                insertCmd.Parameters.AddWithValue("@RoomNo", roomNo);

        //                // Execute the insert query
        //                insertCmd.ExecuteNonQuery();
        //            }

        //            // Show success message to the user
        //            MessageBox.Show("Room Details Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //            // Refresh the DataGridView to reflect the new data
        //            LoadRoomMaster();

        //            // Clear the Room No input field after saving
        //            txtRoomNo.Clear();
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle any database-related errors and show an error message
        //            MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void btn_rm_save_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cmbRoomType.Text) ||
                string.IsNullOrWhiteSpace(txtRoomNo.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtRoomNo.Text, out int roomNo) || roomNo <= 0)
            {
                MessageBox.Show("Room No must be a valid positive number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // Step 1: Get the allowed Quantity for the selected RoomType
                    int allowedQuantity = 0;
                    string quantityQuery = "SELECT Quantity FROM RoomType WHERE RoomType = @RoomType";
                    using (SqlCommand quantityCmd = new SqlCommand(quantityQuery, conn))
                    {
                        quantityCmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                        object result = quantityCmd.ExecuteScalar();
                        if (result != null)
                        {
                            allowedQuantity = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Selected Room Type not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    // Step 2: Count current number of rooms of this RoomType in RoomMaster
                    int currentCount = 0;
                    string countQuery = "SELECT COUNT(*) FROM RoomMaster WHERE RoomType = @RoomType";
                    using (SqlCommand countCmd = new SqlCommand(countQuery, conn))
                    {
                        countCmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                        currentCount = (int)countCmd.ExecuteScalar();
                    }

                    // Step 3: Check if adding one more room exceeds the quantity
                    if (currentCount >= allowedQuantity)
                    {
                        MessageBox.Show("Room No exceeded. Kindly check the Quantity limit in RoomType.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // Step 4: Check if the room number already exists
                    string checkQuery = "SELECT COUNT(*) FROM RoomMaster WHERE RoomNo = @RoomNo";
                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                    {
                        checkCmd.Parameters.AddWithValue("@RoomNo", roomNo);
                        int count = (int)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Room No already exists!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    // Step 5: Insert the room
                    string insertQuery = @"INSERT INTO RoomMaster (RoomType, RoomNo, CreatedOn, CreatedBy, ModifyOn, ModifyBy, Status) 
                                   VALUES (@RoomType, @RoomNo, GETDATE(), 'Admin', NULL, NULL, 'Active')";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@RoomType", cmbRoomType.Text);
                        insertCmd.Parameters.AddWithValue("@RoomNo", roomNo);
                        insertCmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Room Details Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadRoomMaster();
                    txtRoomNo.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dashboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Dashboard dashboard = new Dashboard();
            dashboard.Show(); // Show the previous form
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form
        }

        private void roomMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show();
        }

        private void bookingMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void reportMasterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //this.Hide();

        }

        private void btn_rt_logout_Click(object sender, EventArgs e)
        {
           

        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_rm_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();

        }
     
        private void UpdateRoomStatus(string roomType, string roomNo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE RoomMaster SET Status = 'UnderMaintenance' WHERE RoomType = @RoomType AND RoomNo = @RoomNo";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@RoomType", roomType);
                        cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /*Add delete btn on grideview so that it canbe visible every time set prop then */
        private void AddDeleteButton()
        {
            if (!rm_datagrideView.Columns.Contains("btnDelete")) // Prevent multiple buttons
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                btn.HeaderText = "Action";
                btn.Name = "btnDelete";
                btn.Text = "Under Maintance";
                btn.UseColumnTextForButtonValue = true; // Show text in the button
                rm_datagrideView.Columns.Add(btn);
            }
        }

        private void rm_datagrideView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == rm_datagrideView.Columns["btnDelete"].Index && e.RowIndex >= 0)
            {
                string roomType = rm_datagrideView.Rows[e.RowIndex].Cells["RoomType"].Value.ToString();
                string roomNo = rm_datagrideView.Rows[e.RowIndex].Cells["RoomNo"].Value.ToString(); // Fetch Room No
                
                /*Code For MsgBox To Click On Delete Btn To popup  msg */
                DialogResult result = MessageBox.Show("Do You Want To Inactive These Record?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    // Set Status = 'Inactive' in the Database
                    UpdateRoomStatus(roomType, roomNo);

                    // Optionally remove row from DataGridView
                    rm_datagrideView.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void btn_rm_clear_Click(object sender, EventArgs e)
        {

            //txtbox_rm_search.Clear();
            txtRoomNo.Clear();
        }

        private void btn_rt_refresh_Click(object sender, EventArgs e)
        {
            LoadRoomMaster(); // Reload the grid after deletion
        }


        private void LoadRoomMaster()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT RoomType, RoomNo, CreatedOn, CreatedBy, Status FROM RoomMaster WHERE Status = 'Active' ORDER BY CreatedOn DESC";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        rm_datagrideView.DataSource = dt; // Bind data to DataGridView
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        

        private void btn_rt_logout_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SignUpSignIn signUpSignIn = new SignUpSignIn();
                signUpSignIn.WindowState = this.WindowState;
                signUpSignIn.Show();
                this.Close();
            }
        }

        

        private void btn_rm_refresh_Click(object sender, EventArgs e)
        {
            LoadRoomMaster();
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            //dashboard.WindowState = this.WindowState;
            dashboard.Show();
        }

        private void btn_roommaster_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form

        }

        private void btn_roomtype_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show(); // Show the previous form
           
        }

        private void btn_bookingmaster_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomStatusForm roomStatusForm = new RoomStatusForm();
            roomStatusForm.Show(); // Show the previous form

        }

        private void btn_rm_reportmaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show(); // Show the previous form
        }

        private void cmbRoomType_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMaster adminMaster = new AdminMaster();
            adminMaster.Show(); // Show the previous form
        }
    }
}