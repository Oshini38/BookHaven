using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms
{
    public partial class ClerkDashboardForm : Form
    {
        public ClerkDashboardForm()
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, SalesClerk!!";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            
        }

        private void btnManageCustomers_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            this.Hide();
            SalesForm salesForm = new SalesForm();
            salesForm.Show();
        }

        private void ClerkDashboardForm_Load(object sender, EventArgs e)
        {
        }
    }
}
