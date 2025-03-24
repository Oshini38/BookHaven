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
using System.Globalization;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace BookHaven.Forms
{
    public partial class SalesForm : Form
    {
        private int selectedCustomerID = 0; // Stores selected CustomerID
        public SalesForm()
        {
            InitializeComponent();
            InitializeCartGrid();
            LoadBooks();  // Load books when form opens
        }

        private void LoadBooks(string searchKeyword = "")
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT BookID, Title, Author, Price, StockQuantity FROM Books WHERE StockQuantity > 0 AND (Title LIKE @Search OR ISBN LIKE @Search)";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@Search", "%" + searchKeyword + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBookList.DataSource = dt;  // Inhabit book selection grid
            }
        }

        private void txtBookSearch_TextChanged(object sender, EventArgs e)
        {
            LoadBooks(txtBookSearch.Text);  // Filter books based on search
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT CustomerID, Name FROM Customers";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Add an empty row at the top
                DataRow emptyRow = dt.NewRow();
                emptyRow["CustomerID"] = DBNull.Value;
                emptyRow["Name"] = "-- Select a Customer --";
                dt.Rows.InsertAt(emptyRow, 0);

                cmbCustomer.DisplayMember = "Name";
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.DataSource = dt;
                cmbCustomer.SelectedIndex = 0; // Set to the empty row by default
            }
        }

        private void InitializeCartGrid()
        {
            // Check if columns already exist to prevent adding them again
            if (dgvCart.Columns.Count == 0)
            {
                // Define columns for the Cart DataGridView
                dgvCart.Columns.Add("BookID", "Book ID");
                dgvCart.Columns.Add("Title", "Title");
                dgvCart.Columns.Add("Quantity", "Quantity");
                dgvCart.Columns.Add("Price", "Price");
                dgvCart.Columns.Add("TotalPrice", "Total Price");

                // Configure column properties
                dgvCart.Columns[0].Visible = false;  // Hide BookID column (used for reference)
                dgvCart.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvCart.Columns[2].Width = 80;
                dgvCart.Columns[3].Width = 100;
                dgvCart.Columns[4].Width = 120;
            }

            // Ensure only the Quantity column is editable
            dgvCart.Columns["Quantity"].ReadOnly = false;
            dgvCart.Columns["Title"].ReadOnly = true;
            dgvCart.Columns["Price"].ReadOnly = true;
            dgvCart.Columns["TotalPrice"].ReadOnly = true;
        }

        private void CalculateSubTotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                // Make sure the TotalPrice cell is not empty
                if (row.Cells["TotalPrice"].Value != DBNull.Value)
                {
                    subtotal += Convert.ToDecimal(row.Cells["TotalPrice"].Value);
                }
            }

            txtSubTotal.Text = subtotal.ToString("C");
        }

        private void cbPaymentMethod_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox selectedCheckBox && selectedCheckBox.Checked)
            {
                foreach (CheckBox cb in new CheckBox[] { cbCash, cbCard})
                {
                    if (cb != selectedCheckBox)
                        cb.Checked = false;
                }
            }
        }


        private string GenerateReceiptDetails()
        {
            StringBuilder receiptDetails = new StringBuilder();

            receiptDetails.AppendLine("Book Title\tQty\tPrice\tTotal");
            receiptDetails.AppendLine("--------------------------------------------------------");

            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Title"].Value != null)
                {
                    // Format each row in the cart with the corresponding book details
                    receiptDetails.AppendLine($"{row.Cells["Title"].Value}\t{row.Cells["Quantity"].Value}\t{row.Cells["Price"].Value}\t{row.Cells["TotalPrice"].Value}");
                }
            }

            // Calculate discount and grand total (optional)
            decimal discount = 0;
            decimal grandTotal = 0;

            if (decimal.TryParse(txtDiscount.Text, out decimal discountPercentage) && decimal.TryParse(txtSubTotal.Text, out decimal subtotal))
            {
                discount = (subtotal * discountPercentage) / 100;
                grandTotal = subtotal - discount;
            }

            receiptDetails.AppendLine("\n--------------------------------------------------------");
            receiptDetails.AppendLine($"Subtotal: {txtSubTotal.Text}");


            return receiptDetails.ToString();
        }


        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a book to add to the cart.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int bookID = Convert.ToInt32(dgvBookList.SelectedRows[0].Cells["BookID"].Value);
            string bookTitle = dgvBookList.SelectedRows[0].Cells["Title"].Value.ToString();

            string priceStr = dgvBookList.SelectedRows[0].Cells["Price"].Value.ToString().Trim();
            decimal price;

            // Remove currency symbols before parsing
            if (!decimal.TryParse(priceStr, NumberStyles.Any, CultureInfo.CurrentCulture, out price))
            {
                MessageBox.Show($"Invalid price format: {priceStr}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int stock = Convert.ToInt32(dgvBookList.SelectedRows[0].Cells["StockQuantity"].Value);

            if (stock <= 0)
            {
                MessageBox.Show("This book is out of stock!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure columns exist before adding rows
            if (dgvCart.Columns.Count == 0)
            {
                InitializeCartGrid();
            }

            // Check if the book is already in the cart
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (Convert.ToInt32(row.Cells["BookID"].Value) == bookID)
                {
                    MessageBox.Show("This book is already in the cart. Update quantity instead.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Add book to cart with default quantity = 1
            decimal totalPrice = price * 1; // Initial total price = price * 1
            dgvCart.Rows.Add(bookID, bookTitle, 1, price, totalPrice);  // Columns: BookID, Title, Quantity, Price, Total
            nupQuantity.Value = 1;  // Set the quantity to 1 after adding to the cart
            CalculateSubTotal();  // Recalculate total after adding
        }


        private void nupQuantity_ValueChanged(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvCart.SelectedRows[0];

                // Update the quantity in the cart
                selectedRow.Cells["Quantity"].Value = nupQuantity.Value;

                // Recalculate the total for the selected row
                decimal price = Convert.ToDecimal(selectedRow.Cells["Price"].Value);
                selectedRow.Cells["TotalPrice"].Value = price * nupQuantity.Value;

                CalculateSubTotal();  // Recalculate total after quantity change
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                dgvCart.Rows.RemoveAt(dgvCart.SelectedRows[0].Index);
                CalculateSubTotal();  // Update subtotal after removal
            }
            else
            {
                MessageBox.Show("Please select an item to remove.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btcClearCart_Click(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();
            txtSubTotal.Text = "0.00";
            txtDiscount.Clear();
            txtTotalAmount.Text = "0.00";
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                MessageBox.Show("Please enter a discount percentage or code.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal subtotal;
            if (!decimal.TryParse(txtSubTotal.Text, NumberStyles.Any, CultureInfo.CurrentCulture, out subtotal))
            {
                MessageBox.Show("Invalid subtotal format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal discountPercentage = 0;

            // Try parsing discount as a percentage
            if (!decimal.TryParse(txtDiscount.Text, out discountPercentage) || discountPercentage < 0 || discountPercentage > 100)
            {
                MessageBox.Show("Invalid discount! Enter a percentage between 0 and 100.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate the discount amount and new total
            decimal totalDiscount = (subtotal * discountPercentage) / 100;
            decimal grandTotal = subtotal - totalDiscount;

            // Update UI
            txtTotalAmount.Text = grandTotal.ToString("F2");
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("The cart is empty! Add books before checking out.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ensure that a customer is selected from the ComboBox
            if (cmbCustomer.SelectedValue == null || cmbCustomer.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a customer from the list.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get selected payment method
            string paymentMethod = "";
            if (cbCash.Checked) paymentMethod = "Cash";
            else if (cbCard.Checked) paymentMethod = "Card";
            else
            {
                MessageBox.Show("Please select a payment method.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal totalAmount = 0;

            try
            {
                using (SqlConnection conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    // Insert new order (ONLY ONCE) and get the OrderID
                    string orderQuery = "INSERT INTO Orders (CustomerID, OrderDate, TotalAmount, Status) VALUES (@CustomerID, GETDATE(), @TotalAmount, 'Completed'); SELECT SCOPE_IDENTITY();";
                    SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                    orderCmd.Parameters.AddWithValue("@CustomerID", Convert.ToInt32(cmbCustomer.SelectedValue));
                    orderCmd.Parameters.AddWithValue("@TotalAmount", 0);  // Initially 0, will update after inserting OrderDetails

                    int orderID = Convert.ToInt32(orderCmd.ExecuteScalar());  // Get newly generated OrderID

                    // Insert OrderDetails and update stock (loop through cart)
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        if (row.IsNewRow) continue;  // Skip empty new rows

                        int bookID = Convert.ToInt32(row.Cells["BookID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        // Insert order details
                        string orderDetailsQuery = "INSERT INTO OrderDetails (OrderID, BookID, Quantity, Price) VALUES (@OrderID, @BookID, @Quantity, @Price)";
                        SqlCommand detailsCmd = new SqlCommand(orderDetailsQuery, conn, transaction);
                        detailsCmd.Parameters.AddWithValue("@OrderID", orderID);
                        detailsCmd.Parameters.AddWithValue("@BookID", bookID);
                        detailsCmd.Parameters.AddWithValue("@Quantity", quantity);
                        detailsCmd.Parameters.AddWithValue("@Price", price);
                        detailsCmd.ExecuteNonQuery();

                        // Update stock in Books table
                        string updateStockQuery = "UPDATE Books SET StockQuantity = StockQuantity - @Quantity WHERE BookID = @BookID";
                        SqlCommand stockCmd = new SqlCommand(updateStockQuery, conn, transaction);
                        stockCmd.Parameters.AddWithValue("@Quantity", quantity);
                        stockCmd.Parameters.AddWithValue("@BookID", bookID);
                        stockCmd.ExecuteNonQuery();

                        totalAmount += price * quantity;  // Calculate total amount for the order
                    }

                    // Update the TotalAmount in the Orders table after calculating total
                    string updateOrderAmountQuery = "UPDATE Orders SET TotalAmount = @TotalAmount WHERE OrderID = @OrderID";
                    SqlCommand updateAmountCmd = new SqlCommand(updateOrderAmountQuery, conn, transaction);
                    updateAmountCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    updateAmountCmd.Parameters.AddWithValue("@OrderID", orderID);
                    updateAmountCmd.ExecuteNonQuery();

                    transaction.Commit();  // Commit the transaction

                    MessageBox.Show("Sale completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Show receipt after successful order placement
                    string receiptDetails = GenerateReceiptDetails();  // method to generate receipt details
                    ReceiptForm receiptForm = new ReceiptForm(receiptDetails, 0, totalAmount, paymentMethod, orderID);
                    receiptForm.ShowDialog();

                    // Clear cart and reset form after checkout
                    dgvCart.Rows.Clear();
                    txtSubTotal.Text = "0.00";
                    txtDiscount.Clear();
                    txtTotalAmount.Text = "0.00";
                    cmbCustomer.SelectedIndex = -1;
                    txtBookSearch.Clear();
                    nupQuantity.Value = 0;
                    cbCash.Checked = false;
                    cbCard.Checked = false;
                    
                    LoadBooks();  // Refresh books to reflect updated stock
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Transaction failed: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtBookSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a book title to search.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool found = false;

            // Loop through all the rows in the DataGridView (dgvBookList)
            foreach (DataGridViewRow row in dgvBookList.Rows)
            {
                // Check if the Title or ISBN column contains the search term
                string bookTitle = row.Cells["Title"].Value.ToString().ToLower();

                if (bookTitle.Contains(searchTerm.ToLower()))
                {
                    // Select the found row
                    row.Selected = true;
                    found = true;
                    break;  // Exit the loop once we find the first match
                }
                else
                {
                    // Deselect the row if it doesn't match the search
                    row.Selected = false;
                }
            }

            if (!found)
            {
                MessageBox.Show("No book found with the given title.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void SalesForm_Load(object sender, EventArgs e)
        {
            nupQuantity.Value = 0;  // Initialize quantity to 0
            InitializeCartGrid();
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList; // Ensure it's dropdown-only
            LoadCustomers();

        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dgvCart.SelectedRows[0];

                // Set nupQuantity to the quantity of the selected book
                nupQuantity.Value = Convert.ToDecimal(selectedRow.Cells["Quantity"].Value);
            }
        }

        private void cbCash_CheckedChanged(object sender, EventArgs e)
        {
            cbCash.CheckedChanged += cbPaymentMethod_CheckedChanged;
        }

        private void cbCard_CheckedChanged(object sender, EventArgs e)
        {
            cbCard.CheckedChanged += cbPaymentMethod_CheckedChanged;
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel the sales transaction?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Clear cart
                dgvCart.Rows.Clear();

                // Reset customer selection
                cmbCustomer.SelectedIndex = 0;

                // Clear text fields
                txtSubTotal.Text = "0.00";
                txtDiscount.Clear();
                txtTotalAmount.Text = "0.00";
                txtBookSearch.Clear();
                nupQuantity.Value = 0;

                // Unselect selected row in book list
                dgvBookList.ClearSelection();

                // Uncheck payment method checkboxes
                cbCash.Checked = false;
                cbCard.Checked = false;
                }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ConfirmRoleForm confirmRoleForm = new ConfirmRoleForm();

            // Show the confirmation popup as a dialog
            if (confirmRoleForm.ShowDialog() == DialogResult.OK)
            {
                // Check the verified role and navigate accordingly
                if (confirmRoleForm.VerifiedRole == "Admin")
                {
                    AdminDashboardForm dashboard = new AdminDashboardForm();
                    dashboard.Show();
                }
                else if (confirmRoleForm.VerifiedRole == "Salesclerk")
                {
                    ClerkDashboardForm clerkdashboard = new ClerkDashboardForm();
                    clerkdashboard.Show();
                }

                this.Close();  
            }
        }
    }
}
