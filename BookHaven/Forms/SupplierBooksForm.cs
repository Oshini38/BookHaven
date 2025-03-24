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
    public partial class SupplierBooksForm : Form
    {
        public SupplierBooksForm()
        {
            InitializeComponent();
        }

        private void LoadSuppliersAndBooks()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Load suppliers into ComboBox
                string supplierQuery = "SELECT SupplierID, Name FROM Suppliers";
                SqlDataAdapter supplierAdapter = new SqlDataAdapter(supplierQuery, conn);
                DataTable supplierTable = new DataTable();
                supplierAdapter.Fill(supplierTable);

                // Add placeholder row at the top for "Select Supplier"
                DataRow emptySupplierRow = supplierTable.NewRow();
                emptySupplierRow["SupplierID"] = DBNull.Value;
                emptySupplierRow["Name"] = "        --- Select Supplier ---";
                supplierTable.Rows.InsertAt(emptySupplierRow, 0);

                cmbSupplier.DisplayMember = "Name";
                cmbSupplier.ValueMember = "SupplierID";
                cmbSupplier.DataSource = supplierTable;  // Bind ComboBox to the modified DataTable

                // Load books into ComboBox
                string bookQuery = "SELECT BookID, Title FROM Books";
                SqlDataAdapter bookAdapter = new SqlDataAdapter(bookQuery, conn);
                DataTable bookTable = new DataTable();
                bookAdapter.Fill(bookTable);

                // Add placeholder row at the top for "Select Book"
                DataRow emptyBookRow = bookTable.NewRow();
                emptyBookRow["BookID"] = DBNull.Value;
                emptyBookRow["Title"] = "       --- Select Book ---";
                bookTable.Rows.InsertAt(emptyBookRow, 0);

                cmbBook.DisplayMember = "Title";
                cmbBook.ValueMember = "BookID";
                cmbBook.DataSource = bookTable;  // Bind ComboBox to the modified DataTable
            }

            // Set default selected index to the placeholder (first row)
            cmbSupplier.SelectedIndex = 0;
            cmbBook.SelectedIndex = 0;
        }



        private void btnLinkSupplierBook_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
            int bookID = Convert.ToInt32(cmbBook.SelectedValue);

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO SupplierBooks (SupplierID, BookID) VALUES (@SupplierID, @BookID)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    cmd.Parameters.AddWithValue("@BookID", bookID);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Supplier linked to book successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSupplierBooks();  // Refresh DataGridView

                    // Reset ComboBoxes to "Select Supplier" and "Select Book"
                    cmbSupplier.SelectedIndex = 0;
                    cmbBook.SelectedIndex = 0;
                }
            }
        }

        private void LoadSupplierBooks()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT SB.SupplierBookID, S.Name AS Supplier, B.Title AS Book " +
                               "FROM SupplierBooks SB " +
                               "INNER JOIN Suppliers S ON SB.SupplierID = S.SupplierID " +
                               "INNER JOIN Books B ON SB.BookID = B.BookID";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSupplierBooks.DataSource = dt;  // Bind DataTable to DataGridView
            }
        }

        private void btnRemoveLink_Click(object sender, EventArgs e)
        {
            if (dgvSupplierBooks.SelectedRows.Count > 0)
            {
                int supplierBookID = Convert.ToInt32(dgvSupplierBooks.SelectedRows[0].Cells["SupplierBookID"].Value);

                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = "DELETE FROM SupplierBooks WHERE SupplierBookID = @SupplierBookID";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierBookID", supplierBookID);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Supplier-Book link removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSupplierBooks();  // Refresh DataGridView
                    }
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

        private void SupplierBooksForm_Load(object sender, EventArgs e)
        {
            LoadSuppliersAndBooks();  // Populate cmbSupplier and cmbBook with data
            LoadSupplierBooks();  // Load existing supplier-book relationships in the DataGridView
        }
    }
}
