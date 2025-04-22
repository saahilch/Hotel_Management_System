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
using System.Xml.Linq;

namespace HotelManagementSystem
{
    public partial class SignUpSignIn: Form
    {
        public SignUpSignIn()
        {
            InitializeComponent();
        }

        private void signuUp_Click(object sender, EventArgs e)
        {
           

            string name = txtName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || name.Length < 3)
            {
                MessageBox.Show("Name must be at least 3 characters.");
                return;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Enter a valid email address.");
                return;
            }

            if (password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.");
                return;
            }

            string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO SignInSignUp (Name, EmailId, Password) VALUES (@Name, @Email, @Password)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);

                    con.Open();
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rows > 0)
                    {
                        MessageBox.Show("Sign-up successful!");

                    }
                    else
                    {
                        MessageBox.Show("Sign-up failed.");
                    }
                    
                    txtEmail.Clear();
                    txtName.Clear(); 
                    txtPassword.Clear();
                }
            }
        }
        

        private void SignUpSignIn_Load(object sender, EventArgs e)
        {

        }

        private void signIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignIn signIn = new SignIn();
            signIn.WindowState = this.WindowState;
            signIn.Show();
            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
