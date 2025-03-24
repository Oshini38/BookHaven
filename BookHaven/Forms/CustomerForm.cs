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
using System.Xml.Linq;

namespace BookHaven.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void LoadCustomers(string searchKeyword = "")
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Customers WHERE Name LIKE @Search OR ContactNo LIKE @Search OR Email LIKE @Search";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchKeyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvCustomers.DataSource = dt;
            }
        }


        // Method to clear textboxes
        private void ClearFields()
        {
            txtCusName.Clear();
            txtCusContact.Clear();
            txtCusEmail.Clear();
            txtAddress.Clear();
            txtCusName.Focus(); // Set focus back to the first textbox
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);

            // Get the existing values from the selected row
            string currentName = dgvCustomers.SelectedRows[0].Cells["Name"].Value.ToString();
            string currentContact = dgvCustomers.SelectedRows[0].Cells["ContactNo"].Value.ToString();
            string currentEmail = dgvCustomers.SelectedRows[0].Cells["Email"].Value.ToString();
            string currentAddress = dgvCustomers.SelectedRows[0].Cells["Address"].Value.ToString();

            // Use the existing values if the textboxes are empty
            string newName = string.IsNullOrWhiteSpace(txtCusName.Text) ? currentName : txtCusName.Text;
            string newContact = string.IsNullOrWhiteSpace(txtCusContact.Text) ? currentContact : txtCusContact.Text;
            string newEmail = string.IsNullOrWhiteSpace(txtCusEmail.Text) ? currentEmail : txtCusEmail.Text;
            string newAddress = string.IsNullOrWhiteSpace(txtAddress.Text) ? currentAddress : txtAddress.Text;

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Customers SET Name=@Name, ContactNo=@ContactNo, Email=@Email, Address=@Address WHERE CustomerID=@CustomerID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@Name", newName);
                    cmd.Parameters.AddWithValue("@ContactNo", newContact);
                    cmd.Parameters.AddWithValue("@Email", newEmail);
                    cmd.Parameters.AddWithValue("@Address", newAddress);
                    cmd.ExecuteNonQuery();
                }
            }

            MessageBox.Show("Customer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCustomers();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a customer to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int customerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);
            string customerName = dgvCustomers.SelectedRows[0].Cells["Name"].Value.ToString();

            // Show confirmation message to delete 
            DialogResult result = MessageBox.Show($"Are you sure you want to delete {customerName}?",
                                                  "Confirm Deletion",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Customers WHERE CustomerID=@CustomerID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerID);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Customer deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCustomers();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadCustomers(txtSearch.Text);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();  // Hide the current form
            SalesForm salesForm = new SalesForm();  // Create a new instance of SalesForm
            salesForm.Show();
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCusName.Text) ||
            string.IsNullOrWhiteSpace(txtCusContact.Text) ||
            string.IsNullOrWhiteSpace(txtCusEmail.Text) ||
            string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Customers (Name, ContactNo, Email, Address) VALUES (@Name, @ContactNo, @Email, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", txtCusName.Text);
                    cmd.Parameters.AddWithValue("@ContactNo", txtCusContact.Text);
                    cmd.Parameters.AddWithValue("@Email", txtCusEmail.Text);
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Customer added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadCustomers();
            ClearFields();
        }
    }
}
