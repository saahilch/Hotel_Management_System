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
    public partial class AdminMaster: Form
    {

        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";


        public AdminMaster()
        {
            InitializeComponent();
        }

        private void btn_roomtype_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMasterRoomType adminMasterRoomType = new AdminMasterRoomType();
            adminMasterRoomType.Show();

        }

        private void AdminMaster_Load(object sender, EventArgs e)
        {
           

        }

        private void btn_roommaster_Click(object sender, EventArgs e)
        {
        
            this.Hide();
            AdminMasterRoomMaster adminMasterRoomMaster = new AdminMasterRoomMaster();
            adminMasterRoomMaster.Show();
        }

        private void btn_bookingmaster_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMasterBookingMaster adminMasterBookingMaster = new AdminMasterBookingMaster();
            adminMasterBookingMaster.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}
