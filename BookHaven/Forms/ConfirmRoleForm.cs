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
    public partial class ConfirmRoleForm : Form
    {
        public string VerifiedRole { get; private set; }  // Store verified role
        public ConfirmRoleForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';  // Mask the password input
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter your password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT Role FROM Users WHERE Password = @Password";  // Validate password
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Password", SqlDbType.VarBinary).Value = SecurityHelper.HashPassword(password);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        VerifiedRole = result.ToString();  // Store the user's role (Admin/SalesClerk)
                        MessageBox.Show($"Role Verified: {VerifiedRole}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;  // Close the form and return success
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password. Please try again.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;  // Close the form and return failure
            this.Close();
        }
    }
}
