using BookHaven.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookHaven.Forms
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }

        private void LoadSalesReport(DateTime startDate, DateTime endDate)
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                       SELECT Orders.OrderID, Customers.Name AS Customer, Orders.OrderDate, Orders.TotalAmount
                       FROM Orders
                       INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID
                       WHERE Orders.OrderDate BETWEEN @StartDate AND @EndDate
                       ORDER BY Orders.OrderDate DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@StartDate", startDate);
                da.SelectCommand.Parameters.AddWithValue("@EndDate", endDate);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSalesReport.DataSource = dt;

                // Calculate total sales
                decimal totalSales = dt.AsEnumerable().Sum(row => row.Field<decimal>("TotalAmount"));
                lblTotalSales.Text = $"Total Sales: {totalSales:C}";
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpFrom.Value.Date;
            DateTime endDate = dtpTo.Value.Date;
            LoadSalesReport(startDate, endDate);
        }

        private void btnExportToCSV_Click(object sender, EventArgs e)
        {
            if (dgvSalesReport.Rows.Count == 0)
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV files (*.csv)|*.csv", FileName = "SalesReport.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        // Write column headers
                        var headers = dgvSalesReport.Columns.Cast<DataGridViewColumn>().Select(col => col.HeaderText);
                        sw.WriteLine(string.Join(",", headers));

                        // Write row data
                        foreach (DataGridViewRow row in dgvSalesReport.Rows)
                        {
                            var values = row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value?.ToString() ?? "");
                            sw.WriteLine(string.Join(",", values));
                        }
                    }
                    MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += (s, e) =>
            {
                try
                {
                    // Call your PrintDocument_PrintPage logic here inside try block
                    PrintDocument_PrintPage(s, e);
                }
                catch (Exception ex)
                {
                    e.Cancel = true;  // Cancel the print process if error occurs
                    MessageBox.Show($"Printing failed: {ex.Message}", "Print Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            };

            // Add a simple EndPrint event for success message if printing finishes without error
            printDocument.EndPrint += (s, args) =>
            {
                if (!args.Cancel)
                {
                    MessageBox.Show("Report printed successfully!", "Print Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };

            // Set page margins to 1 inch (100 hundredths of an inch)
            printDocument.DefaultPageSettings.Margins = new Margins(100, 100, 100, 100);

            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Set 1-inch margins
            int margin = 100; // 1 inch = 100 hundredths of an inch
            int pageWidth = e.PageBounds.Width - margin * 2;
            int startX = margin;
            int startY = margin;
            int lineHeight = 20;

            Font headerFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 8);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);

            // 1️⃣ Load and draw PNG image (Center logo horizontally)
            Image bookstoreImage;
            using (Stream imageStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("BookHaven.love_book.png"))
            {
                bookstoreImage = Image.FromStream(imageStream);
            }
            e.Graphics.DrawImage(bookstoreImage, new Rectangle((e.PageBounds.Width / 2) - 40, startY - 80, 80, 80));  // Center the logo
            startY += lineHeight + 4;

            // 2️⃣ Draw Bookstore Name (Centered)
            string bookstoreName = "BookHaven Book Shop";
            SizeF textSize = e.Graphics.MeasureString(bookstoreName, headerFont);
            e.Graphics.DrawString(bookstoreName, headerFont, Brushes.Black, (e.PageBounds.Width - textSize.Width) / 2, startY - 30);

            startY += lineHeight * 2;  // Move down after logo and name

            e.Graphics.DrawString("Sales Report", headerFont, Brushes.Black, startX, startY);
            startY += lineHeight;
            e.Graphics.DrawString($"Date Range: {dtpFrom.Value.ToShortDateString()} - {dtpTo.Value.ToShortDateString()}", regularFont, Brushes.Black, startX, startY);
            startY += lineHeight * 2;

            // 3️⃣ Draw Table Headers with Borders
            string[] headers = { "OrderID", "Customer", "OrderDate", "TotalAmount" };
            int[] columnWidths = { 100, 200, 150, 150 };
            int tableWidth = columnWidths.Sum();
            int xPosition = (e.PageBounds.Width - tableWidth) / 2;  // Center table horizontally

            for (int i = 0; i < headers.Length; i++)
            {
                e.Graphics.DrawRectangle(Pens.Black, xPosition, startY, columnWidths[i], lineHeight);  // Draw table cell border
                e.Graphics.DrawString(headers[i], boldFont, Brushes.Black, xPosition + 5, startY + 5);  // Add some padding
                xPosition += columnWidths[i];
            }

            startY += lineHeight;

            // 4️⃣ Draw Table Rows with Borders
            foreach (DataGridViewRow row in dgvSalesReport.Rows)
            {
                if (!row.IsNewRow)
                {
                    xPosition = (e.PageBounds.Width - tableWidth) / 2;

                    string orderID = row.Cells["OrderID"].Value.ToString();
                    string customer = row.Cells["Customer"].Value.ToString();
                    string orderDate = Convert.ToDateTime(row.Cells["OrderDate"].Value).ToShortDateString();
                    string totalAmount = Convert.ToDecimal(row.Cells["TotalAmount"].Value).ToString("C");
                    string[] rowData = { orderID, customer, orderDate, totalAmount };

                    for (int i = 0; i < rowData.Length; i++)
                    {
                        e.Graphics.DrawRectangle(Pens.Black, xPosition, startY, columnWidths[i], lineHeight);  // Draw table cell border
                        e.Graphics.DrawString(rowData[i], regularFont, Brushes.Black, xPosition + 5, startY + 5);  // Add some padding
                        xPosition += columnWidths[i];
                    }

                    startY += lineHeight;
                }
            }

            // 5️⃣ Draw Footer (Total Sales)
            startY += lineHeight;
            e.Graphics.DrawString($"Total Sales: {lblTotalSales.Text}", boldFont, Brushes.Black, (e.PageBounds.Width - tableWidth) / 2, startY);
        }



        private void LoadBestSellers()
        {
            using (SqlConnection conn = DatabaseHelper.GetConnection())
            {
                conn.Open();
                string query = @"
                       SELECT Books.Title, SUM(OrderDetails.Quantity) AS TotalSold, SUM(OrderDetails.Quantity * OrderDetails.Price) AS TotalRevenue
                       FROM OrderDetails
                       INNER JOIN Books ON OrderDetails.BookID = Books.BookID
                       GROUP BY Books.Title
                       ORDER BY TotalSold DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvBestSellers.DataSource = dt;

                HighlightMostSoldBook();  // Highlight the top-selling book after loading data
            }
        }

        private void btnBestSellers_Click(object sender, EventArgs e)
        {
            LoadBestSellers();
        }

        private void HighlightMostSoldBook()
        {
            int maxSales = 0;
            int maxSalesRowIndex = -1;

            // Loop through DataGridView rows to find the book with the most sales
            foreach (DataGridViewRow row in dgvBestSellers.Rows)
            {
                if (row.Cells["TotalSold"].Value != null && int.TryParse(row.Cells["TotalSold"].Value.ToString(), out int sales))
                {
                    if (sales > maxSales)
                    {
                        maxSales = sales;
                        maxSalesRowIndex = row.Index;  // Save the index of the row with the most sales
                    }
                }
            }

            // Highlight the row with the highest sales if found
            if (maxSalesRowIndex != -1)
            {
                dgvBestSellers.Rows[maxSalesRowIndex].DefaultCellStyle.BackColor = Color.Yellow;  // Highlight with yellow color
                dgvBestSellers.Rows[maxSalesRowIndex].DefaultCellStyle.Font = new Font(dgvBestSellers.Font, FontStyle.Bold);  // Set font to bold
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
