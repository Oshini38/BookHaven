namespace BookHaven.Forms
{
    partial class LowStockForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LowStockForm));
            llbStockHeading = new Label();
            picStock = new PictureBox();
            panel1 = new Panel();
            dgvLowStockBooks = new DataGridView();
            lblLowStockBooks = new Label();
            btnRefresh = new Button();
            panel2 = new Panel();
            dgvSupplierDetails = new DataGridView();
            lblSupDetails = new Label();
            btnSupplierDetails = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picStock).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockBooks).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierDetails).BeginInit();
            SuspendLayout();
            // 
            // llbStockHeading
            // 
            llbStockHeading.AutoSize = true;
            llbStockHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbStockHeading.Location = new Point(46, 13);
            llbStockHeading.Name = "llbStockHeading";
            llbStockHeading.Size = new Size(237, 22);
            llbStockHeading.TabIndex = 13;
            llbStockHeading.Text = "Book Stock Management\r\n";
            // 
            // picStock
            // 
            picStock.Image = (Image)resources.GetObject("picStock.Image");
            picStock.Location = new Point(6, 5);
            picStock.Name = "picStock";
            picStock.Size = new Size(35, 37);
            picStock.SizeMode = PictureBoxSizeMode.StretchImage;
            picStock.TabIndex = 12;
            picStock.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(dgvLowStockBooks);
            panel1.Controls.Add(lblLowStockBooks);
            panel1.Controls.Add(btnRefresh);
            panel1.Location = new Point(33, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(466, 372);
            panel1.TabIndex = 32;
            // 
            // dgvLowStockBooks
            // 
            dgvLowStockBooks.BackgroundColor = SystemColors.AppWorkspace;
            dgvLowStockBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStockBooks.Location = new Point(11, 96);
            dgvLowStockBooks.Name = "dgvLowStockBooks";
            dgvLowStockBooks.ReadOnly = true;
            dgvLowStockBooks.Size = new Size(440, 254);
            dgvLowStockBooks.TabIndex = 34;
            // 
            // lblLowStockBooks
            // 
            lblLowStockBooks.AutoSize = true;
            lblLowStockBooks.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLowStockBooks.Location = new Point(11, 71);
            lblLowStockBooks.Name = "lblLowStockBooks";
            lblLowStockBooks.Size = new Size(136, 16);
            lblLowStockBooks.TabIndex = 33;
            lblLowStockBooks.Text = "Low-Stock Books:";
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLight;
            btnRefresh.FlatAppearance.BorderColor = Color.DarkBlue;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = SystemColors.ActiveCaptionText;
            btnRefresh.Location = new Point(11, 17);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(168, 33);
            btnRefresh.TabIndex = 32;
            btnRefresh.Text = "Refresh Low Stock";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(dgvSupplierDetails);
            panel2.Controls.Add(lblSupDetails);
            panel2.Controls.Add(btnSupplierDetails);
            panel2.Location = new Point(525, 51);
            panel2.Name = "panel2";
            panel2.Size = new Size(610, 372);
            panel2.TabIndex = 33;
            // 
            // dgvSupplierDetails
            // 
            dgvSupplierDetails.BackgroundColor = SystemColors.AppWorkspace;
            dgvSupplierDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierDetails.Location = new Point(14, 96);
            dgvSupplierDetails.Name = "dgvSupplierDetails";
            dgvSupplierDetails.ReadOnly = true;
            dgvSupplierDetails.Size = new Size(583, 254);
            dgvSupplierDetails.TabIndex = 34;
            // 
            // lblSupDetails
            // 
            lblSupDetails.AutoSize = true;
            lblSupDetails.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupDetails.Location = new Point(11, 71);
            lblSupDetails.Name = "lblSupDetails";
            lblSupDetails.Size = new Size(125, 16);
            lblSupDetails.TabIndex = 33;
            lblSupDetails.Text = "Supplier Details:";
            // 
            // btnSupplierDetails
            // 
            btnSupplierDetails.BackColor = SystemColors.ControlLight;
            btnSupplierDetails.FlatAppearance.BorderColor = Color.DarkBlue;
            btnSupplierDetails.FlatAppearance.BorderSize = 0;
            btnSupplierDetails.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupplierDetails.ForeColor = SystemColors.ActiveCaptionText;
            btnSupplierDetails.Location = new Point(11, 17);
            btnSupplierDetails.Name = "btnSupplierDetails";
            btnSupplierDetails.Size = new Size(168, 33);
            btnSupplierDetails.TabIndex = 32;
            btnSupplierDetails.Text = "Load Supplier Details";
            btnSupplierDetails.UseVisualStyleBackColor = true;
            btnSupplierDetails.Click += btnSupplierDetails_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(32, 432);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 34;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // LowStockForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1159, 470);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(llbStockHeading);
            Controls.Add(picStock);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LowStockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            Load += LowStockForm_Load;
            ((System.ComponentModel.ISupportInitialize)picStock).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockBooks).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llbStockHeading;
        private PictureBox picStock;
        private Panel panel1;
        private DataGridView dgvLowStockBooks;
        private Label lblLowStockBooks;
        private Button btnRefresh;
        private Panel panel2;
        private DataGridView dgvSupplierDetails;
        private Label lblSupDetails;
        private Button btnSupplierDetails;
        private Button btnExit;
    }
}