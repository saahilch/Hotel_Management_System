using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HotelManagementSystem.WindowsForms
{
    public partial class RoomStatusForm : Form
    {
        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";
        private string selectedRoomType = "";

        public RoomStatusForm()
        {
            InitializeComponent();
        }

        private void RoomStatusForm_Load(object sender, EventArgs e)
        {
            CreateRoomTypeButtons();
            
        }
       

        private List<string> GetRoomTypes()
        {
            List<string> roomTypes = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT RoomType FROM RoomType", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    roomTypes.Add(reader["RoomType"].ToString());
                }
            }
            return roomTypes;
        }

        private bool IsRoomTypeActive(string roomType)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Status FROM RoomType WHERE RoomType = @RoomType", conn);
                cmd.Parameters.AddWithValue("@RoomType", roomType);
                var status = cmd.ExecuteScalar()?.ToString();
                return status == "Active";
            }
        }

        private void CreateRoomTypeButtons()
        {
            List<string> roomTypes = GetRoomTypes();

            int buttonWidth = 150;
            int buttonHeight = 45;
            int spacingX = 30;
            int startX = 80;
            int y = 85;
            int x = startX;
            int count = 0;
            int maxButtonsPerRow = 6;

            // Remove any old RoomType buttons
            var oldRoomTypeButtons = this.Controls.OfType<Button>().Where(b => b.Tag?.ToString() == "RoomType").ToList();
            foreach (var btn in oldRoomTypeButtons)
                this.Controls.Remove(btn);

            foreach (var type in roomTypes)
            {
                Button btn = new Button
                {
                    Text = type,
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new Point(x, y),
                    
                    
                    Font = new Font("Verdana", 12F, FontStyle.Bold),
                    BackColor = Color.DodgerBlue,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Tag = "RoomType",
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderSize = 2;
                btn.FlatAppearance.BorderColor= Color.Red;

                btn.Click += (s, e) => RoomTypeButton_Click(s, e, type);
                this.Controls.Add(btn);

                count++;
                if (count % maxButtonsPerRow == 0)
                {
                    x = startX; 
                    y += buttonHeight + 10;
                }
                else
                {
                    x += buttonWidth + spacingX;
                }
            }
        }

        private List<(string roomNo, bool isBooked, bool isActive)> GetRoomNumbers(string roomType)
        {
            List<(string, bool, bool)> roomNumbers = new List<(string, bool, bool)>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT RoomNo, Status FROM RoomMaster WHERE RoomType = @RoomType", conn);
                cmd.Parameters.AddWithValue("@RoomType", roomType);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string roomNo = reader["RoomNo"].ToString();
                    string status = reader["Status"].ToString();
                    bool isActive = status == "Active";
                    bool isBooked = CheckIfRoomIsBooked(roomNo);
                    roomNumbers.Add((roomNo, isBooked, isActive));
                }
            }
            return roomNumbers;
        }

        private bool CheckIfRoomIsBooked(string roomNo)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM BookingMaster WHERE RoomNumber = @RoomNo AND Status = 'CheckIn'", conn);
                cmd.Parameters.AddWithValue("@RoomNo", roomNo);
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        private void RoomTypeButton_Click(object sender, EventArgs e, string roomType)
        {
            selectedRoomType = roomType;
            lblRoomTypeInfo.Text = $"** You Are In Room Type {roomType}. The Room No Green Is Avaliable , Yellow Is Booked & The Red Is UnderMaintance .";
            // Remove old RoomNumber buttons only
            var oldRoomButtons = this.Controls.OfType<Button>().Where(b => b.Tag?.ToString() == "RoomNumber").ToList();
            foreach (var btn in oldRoomButtons)
                this.Controls.Remove(btn);

            List<(string roomNo, bool isBooked, bool isActive)> rooms = GetRoomNumbers(roomType);
            bool roomTypeIsActive = IsRoomTypeActive(roomType);

            // Layout settings
            int buttonWidth = 180;
            int buttonHeight = 50;
            int spacingX = 20;
            int spacingY = 20;
            int maxButtonsPerRow = 6;

            int startX = 40;
            int startY = 100;  // below RoomType buttons

            int x = startX;
            int y = this.ClientSize.Height - 200; 
            int count = 0;

            foreach (var (roomNo, isBooked, isRoomActive) in rooms)
            {
                Color btnColor;

                if (!roomTypeIsActive || !isRoomActive)
                    btnColor = Color.Red;
                else if (isBooked)
                    btnColor = Color.Orange;
                else
                    btnColor = Color.Green;

                Button btn = new Button
                {
                    Text = $"Room {roomNo}",
                    Width = buttonWidth,
                    Height = buttonHeight,
                    Location = new Point(x, y),
                    Font = new Font("Verdana", 12F, FontStyle.Bold),
                    BackColor = btnColor,
                    ForeColor = Color.Black,
                    FlatStyle = FlatStyle.Flat,
                    Tag = "RoomNumber",
                    Cursor = Cursors.Hand
                };
                btn.FlatAppearance.BorderSize = 1;
                btn.FlatAppearance.BorderColor=Color.White;

                btn.Click += (s, ev) => RoomNumberButton_Click(s, ev, roomNo, roomType);
                this.Controls.Add(btn);

                count++;
                if (count % maxButtonsPerRow == 0)
                {
                    x = startX;
                    y += buttonHeight + spacingY;
                }
                else
                {
                    x += buttonWidth + spacingX;
                }
            }
        }

        private void RoomNumberButton_Click(object sender, EventArgs e, string roomNo, string roomType)
        {
            var button = sender as Button;

            // Block booking if room is already booked or inactive
            if (button.BackColor == Color.Red || button.BackColor == Color.Orange)
            {
                MessageBox.Show("Currently this room is booked or inactive.\nPlease check available rooms and book.", "Room Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed to book available room
            BookingMaster bookingForm = new BookingMaster(roomType, roomNo);
            this.Hide();
            bookingForm.ShowDialog();
            this.Show();
            // Refresh button color after booking
            if (CheckIfRoomIsBooked(roomNo))
                button.BackColor = Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshRoomLayout();

        }
        private void RefreshRoomLayout()
        {
            // Remove old RoomType and RoomNumber buttons
            var oldButtons = this.Controls.OfType<Button>()
                .Where(b => b.Tag?.ToString() == "RoomType" || b.Tag?.ToString() == "RoomNumber")
                .ToList();

            foreach (var btn in oldButtons)
                this.Controls.Remove(btn);

            selectedRoomType = "";  // Clear selected type
            CreateRoomTypeButtons();  // Recreate RoomType buttons
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
