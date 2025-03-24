using BookHaven.Business;
using BookHaven.Data;
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

namespace BookHaven.Forms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblMsg.Text = ""; // Clear previous error messages
            string username = txtName.Text.Trim();
            string password = txtPw.Text.Trim();
            string role = "";  // Declare role at the beginning to avoid scope issues

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblMsg.Text = "Please enter both username and password.";
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Name = @Name AND Password = @Password";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", username);
                    cmd.Parameters.Add("@Password", SqlDbType.VarBinary).Value = SecurityHelper.HashPassword(password);  // Hash input before comparing

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        role = result.ToString();  // Fetch user role from the database
                        MessageBox.Show($"Login Successful! \nWelcome, {role}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Check the role and open the appropriate form
                        this.Hide();
                        if (role == "Admin")
                        {
                            AdminDashboardForm dashboard = new AdminDashboardForm();  // Pass user role to the dashboard form
                            dashboard.Show();
                        }
                        else if (role == "Salesclerk")
                        {
                            ClerkDashboardForm clerkdashnoard = new ClerkDashboardForm();
                            clerkdashnoard.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role. Please contact the administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.Show();
                        }
                    }
                    else
                    {
                        lblMsg.Text = "Invalid username or password.";
                    }
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPw.Text = "";
            lblMsg.Text = "";
            txtName.Focus();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkShowPassword.Checked)
                {
                    txtPw.PasswordChar = '\0'; // Show password
                }
                else
                {
                    txtPw.PasswordChar = '*'; // Hide password
                }
            }
        }
    }
}
