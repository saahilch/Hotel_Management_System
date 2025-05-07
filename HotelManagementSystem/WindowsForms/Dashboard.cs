using HotelManagementSystem.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Dashboard: Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard1_Load(object sender, EventArgs e)
        {

        }
        private void dashRoomType_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Dashboard dashboard = new Dashboard();
            dashboard.Show(); // Show the previous form
        }

        private void dashRoomMaster_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show(); // Show the previous form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            SignUpSignIn signUpSignIn = new SignUpSignIn();
            signUpSignIn.Show(); // Show the previous form
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            Dashboard dashboard = new Dashboard();
            dashboard.Show(); // Show the previous form
        }

        private void dashRoomType_Click_1(object sender, EventArgs e)
        {

            this.Hide(); // Hide current form
            RoomType roomType = new RoomType();
            roomType.Show(); // Show the previous form
        }

        private void dashRoomMaster_Click_1(object sender, EventArgs e)
        {
            this.Hide(); // Hide current form
            RoomMaster roomMaster = new RoomMaster();
            roomMaster.Show(); // Show the previous form
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Report report = new Report();
            report.Show(); // Show the previous form
        }

        private void btn_dash_bookingMaster_Click(object sender, EventArgs e)
        {
            //this.Hide(); // Hide current form
            //BookingMaster bookingMaster = new BookingMaster();
            //bookingMaster.Show(); // Show the previous form
            this.Hide();
            RoomStatusForm roomStatusForm = new RoomStatusForm();
            roomStatusForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            AdminMaster adminMaster = new AdminMaster();
            adminMaster.Show();

        }
    }
}
