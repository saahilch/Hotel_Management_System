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
    public partial class SignIn: Form
    {
        private string connectionString = "Server=DESKTOP-F7V7TOJ\\SQLEXPRESS;Database=HotelManagement;Integrated Security=True;";

        public SignIn()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = false;
            SetTab();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if(string.IsNullOrEmpty(email)||string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Email & Password Is Required ", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            using (SqlConnection conn = new SqlConnection(connectionString)) 
            {
                try
                {
                    // db connection 1) open comectim then use query then check parameters with actual db entities
                    conn.Open();
                    string query= "SELECT COUNT(*) FROM SignInSignUp WHERE EmailId = @Email AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = (int)cmd.ExecuteScalar();
                        //  if cnt is> 0 then review msg login success then got to dashboard if not throw error
                        if (count > 0)
                        {
                            MessageBox.Show("Login Successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Open Dashboard Form and close the Sign In Form
                            Dashboard dashboard = new Dashboard();
                            dashboard.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Email or Password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void SignIn_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            SignUpSignIn signUpSignIn = new SignUpSignIn();
            signUpSignIn.WindowState = this.WindowState;
            signUpSignIn.Show();
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                txtPassword.UseSystemPasswordChar = true; // show password
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false; // hide password
            }
        }
        
        private void SetTab()
        {
            txtEmail.TabIndex = 0;
            txtPassword.TabIndex = 1;
            showPasswordCheckBox.TabIndex = 2;
            btn_signIn_SignIn.TabIndex = 3;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
