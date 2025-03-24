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
    public partial class LowStockForm : Form
    {
        public LowStockForm()
        {
            InitializeComponent();
        }

        private void LoadLowStockBooks()
        {
            int lowStockThreshold = 2;  // Define low-stock threshold

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT BookID, Title, Author, StockQuantity " +
                               "FROM Books WHERE StockQuantity < @LowStockThreshold";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@LowStockThreshold", lowStockThreshold);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLowStockBooks.DataSource = dt;  // Bind DataTable to DataGridView
            }
        }

        private void dgvLowStockBooks_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            foreach (DataGridViewRow row in dgvLowStockBooks.Rows)
            {
                int stockQuantity = Convert.ToInt32(row.Cells["StockQuantity"].Value);
                if (stockQuantity < 2)  // Low stock threshold
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadLowStockBooks();  // Refresh the DataGridView with updated stock data
        }

        private void btnSupplierDetails_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();

                // Query to fetch supplier details linked to low-stock books
                string query = @"SELECT S.SupplierID, S.Name, S.ContactNo, S.Email, B.Title AS 'Book Title', B.StockQuantity 
                         FROM SupplierBooks SB
                         INNER JOIN Suppliers S ON SB.SupplierID = S.SupplierID
                         INNER JOIN Books B ON SB.BookID = B.BookID
                         WHERE B.StockQuantity < @LowStockThreshold";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@LowStockThreshold", 2);  // Low-stock threshold

                DataTable dt = new DataTable();
                da.Fill(dt);

                // Bind supplier details to DataGridView
                dgvSupplierDetails.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No suppliers found for low-stock books.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void LowStockForm_Load(object sender, EventArgs e)
        {
            dgvSupplierDetails.DataSource = null;  // Start with an empty DataGridView for supplier details
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
    }
}
