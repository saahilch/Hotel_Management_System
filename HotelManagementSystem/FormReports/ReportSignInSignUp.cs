using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using HotelManagementSystem.WindowsForms;


namespace HotelManagementSystem.FormReports
{
    public partial class ReportSignInSignUp: Form
    {
        string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public ReportSignInSignUp()
        {
            InitializeComponent();
        }

        private void ReportSignInSignUp_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Name,EmailId,Password FROM SignInSignUp"; // Change table name here
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void lodeButten_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide ();
            Report report = new Report();
            report.Show();
        }
    }
}
