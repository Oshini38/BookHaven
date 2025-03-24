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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void LoadUsers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT UserID, Name, Role FROM Users";  // Load users (excluding passwords)
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsers.DataSource = dt;
            }
        }

        private void LoadRoles()
        {
            // Clear any existing items in case the method is called multiple times
            cmbRole.Items.Clear();

            // Add the roles to the combo box
            cmbRole.Items.Add("---- Select User Role ----");
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Salesclerk");

            // Optionally, set the default selected item to none
            cmbRole.SelectedIndex = 0;
        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            LoadUsers();
            LoadRoles();
            txtUserName.Focus();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbRole.SelectedItem.ToString();  // Get selected role

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || cmbRole.SelectedIndex == 0)
            {
                MessageBox.Show("Please fill all fields and select a role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Users (Name, Password, Role) VALUES (@Name, @Password, @Role)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", username);
                    cmd.Parameters.Add("@Password", SqlDbType.VarBinary).Value = SecurityHelper.HashPassword(password);  // Hash the password
                    cmd.Parameters.AddWithValue("@Role", role);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User profile created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();  // Refresh the user list
                        ClearFields();  // Clear text fields after adding
                    }
                    else
                    {
                        MessageBox.Show("Failed to add user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void ClearFields()
        {
            txtUserName.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);

            if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Users WHERE UserID = @UserID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserID", userID);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadUsers();  // Refresh the user list
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int userID = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);  // Get the selected user's UserID
            string updatedUsername = txtUserName.Text.Trim();  // Updated username from the textbox
            string newRole = cmbRole.SelectedItem?.ToString();  // New role from the ComboBox

            // Validation to ensure valid inputs for Username and Role
            if (string.IsNullOrEmpty(updatedUsername))
            {
                MessageBox.Show("Please enter a valid username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cmbRole.SelectedIndex == 0 || string.IsNullOrEmpty(newRole))
            {
                MessageBox.Show("Please select a valid role.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Update query to change both Username and Role
                string query = "UPDATE Users SET Name = @Username, Role = @Role WHERE UserID = @UserID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", updatedUsername);  // Update username
                    cmd.Parameters.AddWithValue("@Role", newRole);              // Update role
                    cmd.Parameters.AddWithValue("@UserID", userID);             // Update for the selected UserID

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();   // Refresh DataGridView after updating the user
                        ClearFields(); // Clear text fields after update
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user details. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (chkShowPassword.Checked)
                {
                    txtPassword.PasswordChar = '\0'; // Show password
                }
                else
                {
                    txtPassword.PasswordChar = '*'; // Hide password
                }
            }
        }
    }

}
