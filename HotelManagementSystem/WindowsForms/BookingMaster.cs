using HotelManagementSystem.WindowsForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class BookingMaster : Form
    {

        /* Set Db Connection String here change it accordngly*/
        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";





        public BookingMaster()
        {
            InitializeComponent();
        }
        private void LoadRoomTypes()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT DISTINCT RoomType FROM RoomMaster WHERE Status = 'Active'"; ; // Assuming table name is RoomMaster
                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    comboBox_roomType.Items.Clear(); // Clear existing items
                    while (reader.Read())
                    {
                        comboBox_roomType.Items.Add(reader["RoomType"].ToString());
                    }
                }
            }
        }



        private void BookingMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet1.BookingMaster' table. You can move, or remove it, as needed.
            // this.bookingMasterTableAdapter.Fill(this.hotelManagementDataSet1.BookingMaster);
            LoadRoomTypes();
            comboBox_roomType.SelectedIndexChanged += comboBox_roomType_SelectedIndexChanged;
            LoadGenderDropDown();
            LoadGuestData();
            if (comboBox_roomType.Items.Count > 0)
            {
                comboBox_roomType.SelectedIndex = 0;
            }
            // to disply tables from db

            // LoadBookingData();

            comboBox_roomType.SelectedIndexChanged += comboBox_roomType_SelectedIndexChanged;

            AddDeleteButtonColumn();
            SetTab();


        }


        public void SetTab()
        {

            txtbox_firstName.TabIndex = 0;
            txtbox_lastName.TabIndex = 1;
            comboBox_gender.TabIndex = 2;
            textbox_amobileNo.TabIndex = 3;
            txtbox_email.TabIndex = 4;
            textBox_document.TabIndex = 5;
            btn_saveClk.TabIndex = 6;
            txtCapacity.TabIndex = 7;
            comboBox_roomType.TabIndex = 8;
            comboBox_roomNumber.TabIndex = 9;
            //textbox_bm.TabIndex = 9;
            
            btn_bm_save.TabIndex = 10;
            btn_update.TabIndex = 11;
            txtbox_search.TabIndex = 12;
            btn_serch.TabIndex = 13;
            btn_bm_refresh.TabIndex = 14;
            btn_Clear.TabIndex = 15;
            
            // Set initial focus to the first field
            txtbox_firstName.Focus();
        }


        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Dashboard dashboard = new Dashboard();
            dashboard.Show(); // Show the previous form
        }

        private void roomTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomType roomType = new RoomType();
            roomType.Show();
        }

        private void roomMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show();
        }

        private void bookingMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            BookingMaster bookingMaster = new BookingMaster();
            bookingMaster.Show();
        }





        private void comboBox_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /*These prop has been add the gender in comboox*/
        private void LoadGenderDropDown()
        {
            comboBox_gender.Items.Add("Male");
            comboBox_gender.Items.Add("Female");
        }


        /*onclick save btn*/

        //private void btn_bm_save_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrWhiteSpace(txtbox_firstName.Text) ||
        //        string.IsNullOrWhiteSpace(txtbox_lastName.Text) ||
        //        string.IsNullOrWhiteSpace(textbox_amobileNo.Text) ||
        //        string.IsNullOrWhiteSpace(txtbox_email.Text) ||
        //        string.IsNullOrWhiteSpace(textBox_document.Text) ||
        //        string.IsNullOrWhiteSpace(comboBox_roomType.Text) ||
        //        string.IsNullOrWhiteSpace(comboBox_roomNumber.Text) ||
        //        string.IsNullOrWhiteSpace(txtCapacity.Text))
        //    {
        //        MessageBox.Show("All fields are required. Please fill in all details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (!Regex.IsMatch(txtbox_firstName.Text, @"^[A-Za-z\s]+$") ||
        //        !Regex.IsMatch(txtbox_lastName.Text, @"^[A-Za-z\s]+$"))
        //    {
        //        MessageBox.Show("First Name and last name must not contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (!Regex.IsMatch(txtbox_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
        //    {
        //        MessageBox.Show("Invalid email format. Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    if (!Regex.IsMatch(textbox_amobileNo.Text, @"^\d{10}$"))
        //    {
        //        MessageBox.Show("Mobile number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    // Capacity Validation
        //    if (!int.TryParse(txtCapacity.Text, out int capacity) || capacity <= 0)
        //    {
        //        MessageBox.Show("Invalid room capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string selectedRoom = comboBox_roomNumber.SelectedItem?.ToString();

        //    if (string.IsNullOrEmpty(selectedRoom))
        //    {
        //        MessageBox.Show("Please select a valid room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(connectionString))
        //        {
        //            conn.Open();

        //            // Step 1: Count guests already booked in selected room
        //            string countQuery = "SELECT COUNT(*) FROM BookingMaster WHERE RoomNumber = @RoomNumber AND Status = 'Active'";
        //            SqlCommand countCmd = new SqlCommand(countQuery, conn);
        //            countCmd.Parameters.AddWithValue("@RoomNumber", selectedRoom);
        //            int currentGuestCount = (int)countCmd.ExecuteScalar();

        //            if (currentGuestCount >= capacity)
        //            {
        //                MessageBox.Show("Room is full. Kindly select another room.", "Room Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //                return;
        //            }

        //            // Step 2: Prepare to insert booking
        //            byte[] documentData = null;
        //            if (!string.IsNullOrEmpty(textBox_document.Text) && File.Exists(textBox_document.Text))
        //            {
        //                documentData = File.ReadAllBytes(textBox_document.Text);
        //            }

        //            string insertQuery = @"INSERT INTO BookingMaster 
        //        (GuestFirstName, GuestLastName, GuestMobileNo, Gender, Email, GovDocument, GovDocumentData, GuestCount, TotalAllocatedRoom, RoomType, RoomNumber, Status, BookingDate)
        //        VALUES (@FirstName, @LastName, @MobileNo, @Gender, @Email, @GovDocument, @GovDocumentData, 1, 1, @RoomType, @RoomNumber, 'Active', @BookingDate)";

        //            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@FirstName", txtbox_firstName.Text);
        //                cmd.Parameters.AddWithValue("@LastName", txtbox_lastName.Text);
        //                cmd.Parameters.AddWithValue("@MobileNo", textbox_amobileNo.Text);
        //                cmd.Parameters.AddWithValue("@Gender", comboBox_gender.SelectedItem?.ToString() ?? "Other");
        //                cmd.Parameters.AddWithValue("@Email", txtbox_email.Text);
        //                cmd.Parameters.AddWithValue("@GovDocument", textBox_document.Text);
        //                cmd.Parameters.AddWithValue("@GovDocumentData", documentData ?? (object)DBNull.Value);
        //                cmd.Parameters.AddWithValue("@RoomType", comboBox_roomType.SelectedItem?.ToString() ?? "Standard");
        //                cmd.Parameters.AddWithValue("@RoomNumber", selectedRoom);
        //                cmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);

        //                cmd.ExecuteNonQuery();
        //            }
        //        }

        //        MessageBox.Show("Guest saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        LoadGuestData();
        //        ClearFields();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}



        private void btn_bm_save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_firstName.Text) ||
                string.IsNullOrWhiteSpace(txtbox_lastName.Text) ||
                string.IsNullOrWhiteSpace(textbox_amobileNo.Text) ||
                string.IsNullOrWhiteSpace(txtbox_email.Text) ||
                string.IsNullOrWhiteSpace(textBox_document.Text) ||
                string.IsNullOrWhiteSpace(comboBox_roomType.Text) ||
                string.IsNullOrWhiteSpace(comboBox_roomNumber.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text))
            {
                MessageBox.Show("All fields are required. Please fill in all details.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtbox_firstName.Text, @"^[A-Za-z\s]+$") ||
                !Regex.IsMatch(txtbox_lastName.Text, @"^[A-Za-z\s]+$"))
            {
                MessageBox.Show("First Name and last name must not contain numbers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(txtbox_email.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Regex.IsMatch(textbox_amobileNo.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Mobile number must be exactly 10 digits.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity) || capacity <= 0)
            {
                MessageBox.Show("Invalid room capacity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedRoom = comboBox_roomNumber.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedRoom))
            {
                MessageBox.Show("Please select a valid room number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Check guest capacity in the room
                    string countQuery = "SELECT COUNT(*) FROM BookingMaster WHERE RoomNumber = @RoomNumber AND Status = 'Active'";
                    SqlCommand countCmd = new SqlCommand(countQuery, conn);
                    countCmd.Parameters.AddWithValue("@RoomNumber", selectedRoom);
                    int currentGuestCount = (int)countCmd.ExecuteScalar();

                    if (currentGuestCount >= capacity)
                    {
                        MessageBox.Show("Room is full. Kindly select another room.", "Room Full", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    // === Save uploaded document to specific folder ===
                    string documentPath = textBox_document.Text;
                    string savedDocPath = null;
                    byte[] documentData = null;

                    if (!string.IsNullOrEmpty(documentPath) && File.Exists(documentPath))
                    {
                        string folderPath = @"C:\Users\saahil's24\Desktop\New folder (2)";
                        Directory.CreateDirectory(folderPath); // Create if not exists

                        string fileName = Path.GetFileName(documentPath);
                        string uniqueFileName = $"{Guid.NewGuid()}_{fileName}";
                        savedDocPath = Path.Combine(folderPath, uniqueFileName);

                        File.Copy(documentPath, savedDocPath, true); // Copy file
                        documentData = File.ReadAllBytes(savedDocPath); // Read new file
                    }

                    string insertQuery = @"INSERT INTO BookingMaster 
            (GuestFirstName, GuestLastName, GuestMobileNo, Gender, Email, GovDocument, GovDocumentData, GuestCount, TotalAllocatedRoom, RoomType, RoomNumber, Status, BookingDate)
            VALUES (@FirstName, @LastName, @MobileNo, @Gender, @Email, @GovDocument, @GovDocumentData, 1, 1, @RoomType, @RoomNumber, 'Active', @BookingDate)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", txtbox_firstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", txtbox_lastName.Text);
                        cmd.Parameters.AddWithValue("@MobileNo", textbox_amobileNo.Text);
                        cmd.Parameters.AddWithValue("@Gender", comboBox_gender.SelectedItem?.ToString() ?? "Other");
                        cmd.Parameters.AddWithValue("@Email", txtbox_email.Text);
                        cmd.Parameters.AddWithValue("@GovDocument", savedDocPath ?? (object)DBNull.Value); // save the new path
                        cmd.Parameters.AddWithValue("@GovDocumentData", documentData ?? (object)DBNull.Value);
                        cmd.Parameters.AddWithValue("@RoomType", comboBox_roomType.SelectedItem?.ToString() ?? "Standard");
                        cmd.Parameters.AddWithValue("@RoomNumber", selectedRoom);
                        cmd.Parameters.AddWithValue("@BookingDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Guest saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGuestData();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /*Load Guest Data & show only Active Rooms*/
        private void LoadGuestData()
        {
            try
            {
                string query = "SELECT * FROM BookingMaster WHERE Status = 'Active'";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridViewBookings.DataSource = dt; // Assign DataTable to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading guest data: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btn_saveClk_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "PDF Files|*.pdf|Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox_document.Text = openFileDialog.FileName;
                }
            }


        }



        private void textbox_mobileNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_bm_refresh_Click(object sender, EventArgs e)
        {
            LoadGuestData();

        }

        private void UpdateRoomStatus(string roomType, string roomNo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE BookingMaster SET Status = 'Inactive' WHERE RoomType = @RoomType AND RoomNo = @RoomNo";
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

        /*DatagrideView All the code like update ,Inactive Record*/
        private void dataGridViewBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewBookings.Columns["Action"].Index && e.RowIndex >= 0)
            {
                string roomTypeName = dataGridViewBookings.Rows[e.RowIndex].Cells["GuestFirstName"].Value.ToString();

                /*Code For MsgBox To Click On Delete Btn To popup  msg */
                DialogResult result = MessageBox.Show("Do You Want To Check Out?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string query = "UPDATE BookingMaster SET Status = 'Inactive',CheckoutDate=@CheckoutDate WHERE GuestFirstName = @GuestFirstName";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@GuestFirstName", roomTypeName);
                        cmd.Parameters.AddWithValue("@CheckoutDate", DateTime.Now);
                        cmd.ExecuteNonQuery();

                        dataGridViewBookings.Rows.RemoveAt(e.RowIndex); // Remove from DataGridView
                    }
                }
            }
        }


        /*Prop For Serch the All The Record From dgv*/
        private void SearchGuest()
        {
            string searchQuery = "SELECT * FROM BookingMaster WHERE Email = @SearchValue OR GuestMobileNo = @SearchValue";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(searchQuery, conn);
                cmd.Parameters.AddWithValue("@SearchValue", txtbox_search.Text.Trim()); // Get value from search TextBox

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // If a record is found, populate the fields
                {
                    txtbox_firstName.Text = reader["GuestFirstName"].ToString();
                    txtbox_lastName.Text = reader["GuestLastName"].ToString();
                    textbox_amobileNo.Text = reader["GuestMobileNo"].ToString();
                    comboBox_gender.SelectedItem = reader["Gender"].ToString();
                    txtbox_email.Text = reader["Email"].ToString();
                    textBox_document.Text = reader["GovDocument"].ToString();
                    comboBox_roomType.SelectedItem = reader["RoomType"].ToString();
                    // textbox_bm.Text = reader["RoomNumber"].ToString();
                }
                else
                {
                    MessageBox.Show("No guest found with this Email or Phone Number.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                conn.Close();
            }
        }

        /*Serch On clk btn*/
        private void btn_serch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_search.Text))
            {
                MessageBox.Show("Please enter Email or Phone Number to search.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchGuest();
        }

        /*Prop To update after serch */
        private void UpdateGuestDetails()
        {
            string updateQuery = @"UPDATE BookingMaster SET 
                            GuestFirstName = @FirstName, 
                            GuestLastName = @LastName, 
                            GuestMobileNo = @MobileNo, 
                            Gender = @Gender, 
                            Email = @Email, 
                            GovDocument = @GovDocument, 
                            
                            RoomType = @RoomType, 
                            RoomNumber = @RoomNumber 
                            WHERE Email = @SearchValue OR GuestMobileNo = @SearchValue";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@FirstName", txtbox_firstName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtbox_lastName.Text);
                cmd.Parameters.AddWithValue("@MobileNo", textbox_amobileNo.Text);
                cmd.Parameters.AddWithValue("@Gender", comboBox_gender.SelectedItem?.ToString() ?? "Other");
                cmd.Parameters.AddWithValue("@Email", txtbox_email.Text);
                cmd.Parameters.AddWithValue("@GovDocument", textBox_document.Text);
                cmd.Parameters.AddWithValue("@RoomType", comboBox_roomType.SelectedItem?.ToString() ?? "Standard");
                cmd.Parameters.AddWithValue("@RoomNumber", comboBox_roomNumber.SelectedItem?.ToString() ?? "Standard");

                // cmd.Parameters.AddWithValue("@RoomNumber", textbox_bm.Text);
                cmd.Parameters.AddWithValue("@SearchValue", txtbox_search.Text.Trim());

                conn.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Guest details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Update failed. Guest not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        /*Update Btn & thir Properties*/
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_search.Text))
            {
                MessageBox.Show("Please search for a guest first.", "Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            UpdateGuestDetails();
            ClearFields();
            LoadGuestData();
        }

        private void comboBox_roomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoomType = comboBox_roomType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedRoomType))
                return;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT RoomNo FROM RoomMaster WHERE RoomType = @RoomType AND Status = 'Active'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RoomType", selectedRoomType);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        comboBox_roomNumber.Items.Clear(); // Clear previous items
                        while (reader.Read())
                        {
                            comboBox_roomNumber.Items.Add(reader["RoomNo"].ToString());
                        }
                    }
                }
            }
        }


        
        /*Onclik Clear btn */
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }


        /*set All the txtBoxes Clear Onclik Clear*/
        private void ClearFields()
        {
            txtbox_firstName.Clear();
            txtbox_lastName.Clear();
            textbox_amobileNo.Clear();
            //comboBox_gender.Clear();
            txtbox_email.Clear();
            textBox_document.Clear();
            //textbox_guestCount.Clear();
            //comboBox_roomType.Clear();
            // textbox_bm.Clear();
            txtbox_search.Clear();
            txtCapacity.Clear();
        }

        /*Add Inactive btn in datgride view & also set the prop to it*/
        private void AddDeleteButtonColumn()
        {
            if (!dataGridViewBookings.Columns.Contains("Action"))
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Action";
                deleteButton.HeaderText = "Action";
                deleteButton.Text = "Check Out";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.DefaultCellStyle.BackColor = Color.Red;
                //deleteButton.DefaultCellStyle.ForeColor = Color.Red;
                deleteButton.DefaultCellStyle.Font = new Font("Verdana", 10, FontStyle.Bold);
                deleteButton.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // dataGridViewBookings.Columns.Add(deleteButton);
                dataGridViewBookings.Columns.Add(deleteButton);
            }
        }

        /*Logout btn */
        private void button1_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //if (result == DialogResult.Yes)
            //{
            //    SignUpSignIn signUpSignIn = new SignUpSignIn();
            //    signUpSignIn.WindowState = this.WindowState;
            //    signUpSignIn.Show();
            //    this.Close();
            //}
            this.Hide(); // Hide current form
            SignIn signIn = new SignIn();
            
            signIn.Show(); // Show the previous form
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            //dashboard.WindowState = this.WindowState;
            dashboard.Show();
        }

        private void roomTypeToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void reportMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show(); // Show the previous form
        }

        private void logutToolStripMenuItem_Click(object sender, EventArgs e)
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



