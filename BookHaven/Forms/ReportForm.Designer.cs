namespace BookHaven.Forms
{
    partial class ReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportForm));
            llbSalesHeading = new Label();
            picReports = new PictureBox();
            lblFrom = new Label();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            lblSalesReportTable = new Label();
            pictureBox1 = new PictureBox();
            dgvSalesReport = new DataGridView();
            lblTSales = new Label();
            lblTotalSales = new Label();
            btnExportToCSV = new Button();
            btnPrintReport = new Button();
            btnGenerateReport = new Button();
            panel2 = new Panel();
            tabControl1 = new TabControl();
            tabSalesReport = new TabPage();
            tabBestSelling = new TabPage();
            btnBestSellers = new Button();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            dgvBestSellers = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picReports).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            panel2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabSalesReport.SuspendLayout();
            tabBestSelling.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellers).BeginInit();
            SuspendLayout();
            // 
            // llbSalesHeading
            // 
            llbSalesHeading.AutoSize = true;
            llbSalesHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbSalesHeading.Location = new Point(45, 13);
            llbSalesHeading.Name = "llbSalesHeading";
            llbSalesHeading.Size = new Size(261, 22);
            llbSalesHeading.TabIndex = 10;
            llbSalesHeading.Text = "Sales Reports and Analytics";
            // 
            // picReports
            // 
            picReports.Image = (Image)resources.GetObject("picReports.Image");
            picReports.Location = new Point(5, 3);
            picReports.Name = "picReports";
            picReports.Size = new Size(35, 38);
            picReports.SizeMode = PictureBoxSizeMode.StretchImage;
            picReports.TabIndex = 11;
            picReports.TabStop = false;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(11, 12);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(83, 16);
            lblFrom.TabIndex = 12;
            lblFrom.Text = "Start Date:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(12, 73);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(73, 16);
            lblTo.TabIndex = 13;
            lblTo.Text = "End Date:";
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "";
            dtpFrom.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpFrom.Location = new Point(12, 31);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(167, 25);
            dtpFrom.TabIndex = 14;
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpTo.Location = new Point(13, 92);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(166, 25);
            dtpTo.TabIndex = 15;
            // 
            // lblSalesReportTable
            // 
            lblSalesReportTable.AutoSize = true;
            lblSalesReportTable.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSalesReportTable.Location = new Point(40, 215);
            lblSalesReportTable.Name = "lblSalesReportTable";
            lblSalesReportTable.Size = new Size(102, 16);
            lblSalesReportTable.TabIndex = 16;
            lblSalesReportTable.Text = "Sales Report ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 213);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(18, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.BackgroundColor = SystemColors.ScrollBar;
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Location = new Point(31, 243);
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.ReadOnly = true;
            dgvSalesReport.Size = new Size(465, 159);
            dgvSalesReport.TabIndex = 18;
            // 
            // lblTSales
            // 
            lblTSales.AutoSize = true;
            lblTSales.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTSales.Location = new Point(18, 418);
            lblTSales.Name = "lblTSales";
            lblTSales.Size = new Size(86, 16);
            lblTSales.TabIndex = 19;
            lblTSales.Text = "Total Sales:";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalSales.Location = new Point(114, 418);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(0, 16);
            lblTotalSales.TabIndex = 20;
            // 
            // btnExportToCSV
            // 
            btnExportToCSV.BackColor = SystemColors.ControlLight;
            btnExportToCSV.FlatAppearance.BorderColor = Color.DarkBlue;
            btnExportToCSV.FlatAppearance.BorderSize = 0;
            btnExportToCSV.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportToCSV.ForeColor = Color.DarkBlue;
            btnExportToCSV.Location = new Point(19, 474);
            btnExportToCSV.Name = "btnExportToCSV";
            btnExportToCSV.Size = new Size(142, 33);
            btnExportToCSV.TabIndex = 21;
            btnExportToCSV.Text = "Export to CSV";
            btnExportToCSV.UseVisualStyleBackColor = true;
            btnExportToCSV.Click += btnExportToCSV_Click;
            // 
            // btnPrintReport
            // 
            btnPrintReport.BackColor = SystemColors.ControlLight;
            btnPrintReport.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnPrintReport.FlatAppearance.BorderSize = 0;
            btnPrintReport.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReport.ForeColor = SystemColors.ActiveCaptionText;
            btnPrintReport.Location = new Point(20, 515);
            btnPrintReport.Name = "btnPrintReport";
            btnPrintReport.Size = new Size(142, 33);
            btnPrintReport.TabIndex = 22;
            btnPrintReport.Text = "Print Report";
            btnPrintReport.UseVisualStyleBackColor = true;
            btnPrintReport.Click += btnPrintReport_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.BackColor = SystemColors.ActiveCaptionText;
            btnGenerateReport.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnGenerateReport.FlatAppearance.BorderSize = 0;
            btnGenerateReport.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerateReport.ForeColor = SystemColors.ButtonFace;
            btnGenerateReport.Location = new Point(18, 155);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(195, 40);
            btnGenerateReport.TabIndex = 23;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = false;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(dtpTo);
            panel2.Controls.Add(dtpFrom);
            panel2.Controls.Add(lblTo);
            panel2.Controls.Add(lblFrom);
            panel2.Location = new Point(18, 15);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 134);
            panel2.TabIndex = 24;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabSalesReport);
            tabControl1.Controls.Add(tabBestSelling);
            tabControl1.Location = new Point(4, 52);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(532, 593);
            tabControl1.TabIndex = 25;
            // 
            // tabSalesReport
            // 
            tabSalesReport.Controls.Add(dgvSalesReport);
            tabSalesReport.Controls.Add(btnPrintReport);
            tabSalesReport.Controls.Add(btnGenerateReport);
            tabSalesReport.Controls.Add(panel2);
            tabSalesReport.Controls.Add(btnExportToCSV);
            tabSalesReport.Controls.Add(pictureBox1);
            tabSalesReport.Controls.Add(lblTotalSales);
            tabSalesReport.Controls.Add(lblSalesReportTable);
            tabSalesReport.Controls.Add(lblTSales);
            tabSalesReport.Location = new Point(4, 25);
            tabSalesReport.Name = "tabSalesReport";
            tabSalesReport.Padding = new Padding(3);
            tabSalesReport.Size = new Size(524, 564);
            tabSalesReport.TabIndex = 0;
            tabSalesReport.Text = "Sales Report                ";
            tabSalesReport.UseVisualStyleBackColor = true;
            // 
            // tabBestSelling
            // 
            tabBestSelling.Controls.Add(btnBestSellers);
            tabBestSelling.Controls.Add(pictureBox2);
            tabBestSelling.Controls.Add(label1);
            tabBestSelling.Controls.Add(dgvBestSellers);
            tabBestSelling.Location = new Point(4, 24);
            tabBestSelling.Name = "tabBestSelling";
            tabBestSelling.Padding = new Padding(3);
            tabBestSelling.Size = new Size(524, 565);
            tabBestSelling.TabIndex = 1;
            tabBestSelling.Text = "Best-Selling Books Report  ";
            tabBestSelling.UseVisualStyleBackColor = true;
            // 
            // btnBestSellers
            // 
            btnBestSellers.BackColor = SystemColors.ActiveCaptionText;
            btnBestSellers.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnBestSellers.FlatAppearance.BorderSize = 0;
            btnBestSellers.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBestSellers.ForeColor = SystemColors.ButtonFace;
            btnBestSellers.Location = new Point(16, 15);
            btnBestSellers.Name = "btnBestSellers";
            btnBestSellers.Size = new Size(189, 53);
            btnBestSellers.TabIndex = 24;
            btnBestSellers.Text = "Generate Report\r\n  (Best Sellers)";
            btnBestSellers.UseVisualStyleBackColor = false;
            btnBestSellers.Click += btnBestSellers_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(15, 89);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 20);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 91);
            label1.Name = "label1";
            label1.Size = new Size(137, 16);
            label1.TabIndex = 18;
            label1.Text = "Best Seller Report";
            // 
            // dgvBestSellers
            // 
            dgvBestSellers.BackgroundColor = SystemColors.ScrollBar;
            dgvBestSellers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBestSellers.Location = new Point(38, 121);
            dgvBestSellers.Name = "dgvBestSellers";
            dgvBestSellers.ReadOnly = true;
            dgvBestSellers.Size = new Size(446, 301);
            dgvBestSellers.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(207, 652);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 26;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // ReportForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(539, 693);
            Controls.Add(btnExit);
            Controls.Add(tabControl1);
            Controls.Add(picReports);
            Controls.Add(llbSalesHeading);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReportForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            ((System.ComponentModel.ISupportInitialize)picReports).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabSalesReport.ResumeLayout(false);
            tabSalesReport.PerformLayout();
            tabBestSelling.ResumeLayout(false);
            tabBestSelling.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBestSellers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llbSalesHeading;
        private PictureBox picReports;
        private Label lblFrom;
        private Label lblTo;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lblSalesReportTable;
        private PictureBox pictureBox1;
        private DataGridView dgvSalesReport;
        private Label lblTSales;
        private Label lblTotalSales;
        private Button btnExportToCSV;
        private Button btnPrintReport;
        private Button btnGenerateReport;
        private Panel panel2;
        private TabControl tabControl1;
        private TabPage tabSalesReport;
        private TabPage tabBestSelling;
        private DataGridView dgvBestSellers;
        private PictureBox pictureBox2;
        private Label label1;
        private Button btnBestSellers;
        private Button btnExit;
    }
}