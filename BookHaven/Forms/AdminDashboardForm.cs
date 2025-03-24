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
    public partial class AdminDashboardForm : Form
    {
        public AdminDashboardForm()
        {
            InitializeComponent();
            LoadTotalSales();
            LoadTotalCustomers();
            LoadTotalInventory();
            lblWelcome.Text = $"Welcome, Admin!!";
        }

        private void AdminDashboardNewForm_Load(object sender, EventArgs e)
        {
        }

        private void LoadTotalSales()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT SUM(TotalAmount) AS TotalSales FROM Orders";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();
                lblTotalSales.Text = $"Total Sales: $. {result?.ToString() ?? "0"}";
            }
        }

        private void LoadTotalCustomers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM Customers";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalCustomers = (int)cmd.ExecuteScalar();
                lblTotalCustomers.Text = $"Total Customers: {totalCustomers}";
            }
        }

        private void LoadTotalInventory()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT SUM(StockQuantity) FROM Books";
                SqlCommand cmd = new SqlCommand(query, conn);
                int totalInventory = Convert.ToInt32(cmd.ExecuteScalar());
                lblTotalInventory.Text = $"Total Books in Inventory: {totalInventory}";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm loginForm = new LoginForm();
            loginForm.Show();

        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UsersForm manageUsersForm = new UsersForm();
            manageUsersForm.Show();
        }

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.Show();
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersForm manageSuppliersForm = new SuppliersForm();
            manageSuppliersForm.Show();
        }

        private void btnManageStock_Click(object sender, EventArgs e)
        {
            LowStockForm manageLowStockForm = new LowStockForm();
            manageLowStockForm.Show();
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm salesForm = new SalesForm();
            salesForm.Show();
            
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm();
            reportForm.Show();  
        }

        private void btnManageSupplierAndBook_Click(object sender, EventArgs e)
        {
            SupplierBooksForm manageSupplierBooksForm = new SupplierBooksForm();
            manageSupplierBooksForm.Show();
        }
    }
}
