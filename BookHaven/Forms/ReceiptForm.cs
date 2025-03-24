using BookHaven.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms
{
    public partial class ReceiptForm : Form
    {
        public ReceiptForm(string receiptDetails, decimal discount, decimal grandTotal, string paymentMethod, int orderID)
        {
            InitializeComponent();
            GenerateReceiptNumber(orderID);

            // Set event handler for form load
            this.Load += ReceiptForm_Load;

            // Set values in ReceiptForm UI
            rtbDetails.Text = receiptDetails;
            rtbDetails.AppendText($"Discount Amount: -{discount:C}\n");
            txtGrandTotal.Text = grandTotal.ToString("C");  // Format as currency
            lblPayMethodShow.Text = paymentMethod;  // Display payment method

            // Set initial Date and Time
            lblDateShow.Text = DateTime.Now.ToString("MM/dd/yyyy");  // Date format (Month/Day/Year)
            lblTimeShow.Text = DateTime.Now.ToString("hh:mm:ss tt");    // Time format (12-hour format with AM/PM)

            // Start the timer for real-time updating of the time
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Update every 1 second
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            lblTimeShow.Text = DateTime.Now.ToString("hh:mm:ss tt");  // Update time in 12-hour format (AM/PM)
        }

        private void GenerateReceiptNumber(int orderID)
        {
            string newReceiptNo = "#0000001"; // Default starting receipt number

            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = "SELECT TOP 1 ReceiptNo FROM Receipts ORDER BY ReceiptID DESC";
                SqlCommand cmd = new SqlCommand(query, conn);
                object result = cmd.ExecuteScalar();

                if (result != null)
                {
                    string lastReceipt = result.ToString();
                    int lastNumber = int.Parse(lastReceipt.Substring(1)); // Remove '#' and convert to integer
                    newReceiptNo = $"#{(lastNumber + 1):D7}"; // Format with leading zeros
                }

                // Insert new receipt into database
                string insertQuery = "INSERT INTO Receipts (ReceiptNo, OrderID) VALUES (@ReceiptNo, @OrderID)";
                SqlCommand insertCmd = new SqlCommand(insertQuery, conn);
                insertCmd.Parameters.AddWithValue("@ReceiptNo", newReceiptNo);
                insertCmd.Parameters.AddWithValue("@OrderID", orderID);
                insertCmd.ExecuteNonQuery();
            }

            // Set the generated receipt number in the text box
            txtReceiptNo.Text = newReceiptNo;
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            btnPrintReceipt.Focus(); //To keep the curse point focus away from the rtbDetails
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();  // Close the receipt window
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocument_PrintPage;

            // Event for handling printing completion
            printDocument.EndPrint += (s, ev) =>
            {
                MessageBox.Show("Receipt printed successfully!", "Print Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };

            // Handle any exceptions during printing
            printDocument.PrintController = new StandardPrintController();  // Prevents the "Printing..." dialog from hiding errors
            try
            {
                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to print receipt: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            int startX = 50;
            int startY = 50;
            int lineHeight = 20;

            // Business Details
            e.Graphics.DrawString("BOOKHAVEN BOOK SHOP", headerFont, Brushes.Black, startX + 20, startY);
            startY += lineHeight;
            e.Graphics.DrawString("De Fonseka Place, Colombo 4", regularFont, Brushes.Black, startX + 30, startY);
            startY += lineHeight;
            e.Graphics.DrawString("+94 117 555 545", regularFont, Brushes.Black, startX + 65, startY);
            startY += lineHeight;
            e.Graphics.DrawString("--------------------------------------------------------", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            // Receipt Details
            e.Graphics.DrawString($"Receipt No: {txtReceiptNo.Text}", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Date: {lblDateShow.Text}", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Time: {lblTimeShow.Text}", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString("--------------------------------------------------------", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            // Print receipt details from rtbDetails
            string[] lines = rtbDetails.Text.Split('\n');
            foreach (string line in lines)
            {
                e.Graphics.DrawString(line, regularFont, Brushes.Black, startX, startY);
                startY += lineHeight;
            }

            // Summary Section
            e.Graphics.DrawString("--------------------------------------------------------", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Grand Total:", headerFont, Brushes.Black, startX, startY);
            e.Graphics.DrawString($"{txtGrandTotal.Text}", headerFont, Brushes.Black, startX + 200, startY);
            startY += lineHeight;
            e.Graphics.DrawString("--------------------------------------------------------", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Payment Method: {lblPayMethodShow.Text}", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString("--------------------------------------------------------", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;

            // Thank You & Return Policy
            e.Graphics.DrawString("THANK YOU FOR SHOPPING WITH US!", boldFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString("Returns accepted within 30 days with receipt.", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString("Defective items returnable within 14 days.", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString("No returning of opened/used products.", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString("Refunds issued to original payment method.", regularFont, Brushes.Black, startX, startY);
        }

    }
}
