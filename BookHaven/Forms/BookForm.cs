using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using BookHaven.Data;

namespace BookHaven.Forms
{
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void LoadBooks(string searchKeyword = "")
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Books WHERE Title LIKE @Search OR Author LIKE @Search OR ISBN LIKE @Search";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchKeyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBooks.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Invalid stock quantity format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Books (Title, Author, Genre, ISBN, Price, StockQuantity, Category) VALUES (@Title, @Author, @Genre, @ISBN, @Price, @Stock, @Category)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@Price", price);  // Using parsed value
                    cmd.Parameters.AddWithValue("@Stock", stock);  // Using parsed value
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Clear inputs after success
                        LoadBooks(); // Refresh book list
                    }
                    else
                    {
                        MessageBox.Show("Failed to add the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // Method to clear textboxes and reset ComboBox
        private void ClearFields()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
            txtStock.Clear();
            cmbCategory.SelectedIndex = 0; // Reset to the first category
            txtTitle.Focus(); // Set focus back to the first textbox
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected BookID
            int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

            // Validate input fields before updating
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtGenre.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Please fill in all fields before updating.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtStock.Text, out int stock))
            {
                MessageBox.Show("Invalid stock quantity format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Books SET Title=@Title, Author=@Author, Genre=@Genre, ISBN=@ISBN, Price=@Price, StockQuantity=@Stock, Category=@Category WHERE BookID=@BookID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.Parameters.AddWithValue("@Title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@Author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@Genre", txtGenre.Text);
                    cmd.Parameters.AddWithValue("@ISBN", txtISBN.Text);
                    cmd.Parameters.AddWithValue("@Price", price);  // Using parsed value
                    cmd.Parameters.AddWithValue("@Stock", stock);  // Using parsed value
                    cmd.Parameters.AddWithValue("@Category", cmbCategory.SelectedItem.ToString());

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Book updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearFields(); // Clear fields after update
                        LoadBooks();   // Refresh book list
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to delete.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

            // Show confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to delete the selected book?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Proceed with deletion if the user clicks "Yes"
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM Books WHERE BookID=@BookID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookID", bookID);
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadBooks();  // Refresh book list after deletion
                MessageBox.Show("Book deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtSearch.Text);
        }


        private void BookForm_Load(object sender, EventArgs e)
        {
            cmbCategory.Items.AddRange(new string[]
  {
        "Fiction", "Non-fiction", "Academic & Educational",
        "Children’s", "Religious", "Poetry & Drama", "Art & Photography", "Travel & Adventure"
  });
            cmbCategory.SelectedIndex = 0; // Set default to first category
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to update stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUpdateStock.Text))
            {
                MessageBox.Show("Please enter a stock quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtUpdateStock.Text, out int newStock))
            {
                MessageBox.Show("Invalid stock quantity format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Books SET StockQuantity = @Stock WHERE BookID = @BookID";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Stock", newStock);
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Stock updated successfully!\nNew Stock: {newStock}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBooks();   // Refresh book list
                        txtUpdateStock.Clear(); // Clear input field
                    }
                    else
                    {
                        MessageBox.Show("Failed to update stock.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                txtUpdateStock.Clear(); // Clear the textbox when a row is selected
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            cmbCategory.SelectedIndex = 0;
            txtGenre.Clear();
            txtISBN.Clear();
            txtPrice.Clear();
            txtStock.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
