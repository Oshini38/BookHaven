namespace BookHaven.Forms
{
    partial class SupplierBooksForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupplierBooksForm));
            llbSupBookHeading = new Label();
            picSupBooks = new PictureBox();
            btnExit = new Button();
            dgvSupplierBooks = new DataGridView();
            panel1 = new Panel();
            btnRemoveLink = new Button();
            btnLinkSupplierBook = new Button();
            cmbBook = new ComboBox();
            cmbSupplier = new ComboBox();
            lblBook = new Label();
            lblSupplier = new Label();
            ((System.ComponentModel.ISupportInitialize)picSupBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierBooks).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // llbSupBookHeading
            // 
            llbSupBookHeading.AutoSize = true;
            llbSupBookHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbSupBookHeading.Location = new Point(47, 13);
            llbSupBookHeading.Name = "llbSupBookHeading";
            llbSupBookHeading.Size = new Size(345, 22);
            llbSupBookHeading.TabIndex = 11;
            llbSupBookHeading.Text = "Manage Supplier-Book Relationships";
            // 
            // picSupBooks
            // 
            picSupBooks.Image = (Image)resources.GetObject("picSupBooks.Image");
            picSupBooks.Location = new Point(7, 5);
            picSupBooks.Name = "picSupBooks";
            picSupBooks.Size = new Size(35, 38);
            picSupBooks.SizeMode = PictureBoxSizeMode.StretchImage;
            picSupBooks.TabIndex = 10;
            picSupBooks.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(33, 497);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 29;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // dgvSupplierBooks
            // 
            dgvSupplierBooks.BackgroundColor = SystemColors.AppWorkspace;
            dgvSupplierBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierBooks.Location = new Point(33, 250);
            dgvSupplierBooks.Name = "dgvSupplierBooks";
            dgvSupplierBooks.ReadOnly = true;
            dgvSupplierBooks.Size = new Size(418, 235);
            dgvSupplierBooks.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnRemoveLink);
            panel1.Controls.Add(btnLinkSupplierBook);
            panel1.Controls.Add(cmbBook);
            panel1.Controls.Add(cmbSupplier);
            panel1.Controls.Add(lblBook);
            panel1.Controls.Add(lblSupplier);
            panel1.Location = new Point(33, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(418, 182);
            panel1.TabIndex = 31;
            // 
            // btnRemoveLink
            // 
            btnRemoveLink.BackColor = SystemColors.ControlLight;
            btnRemoveLink.FlatAppearance.BorderColor = Color.Red;
            btnRemoveLink.FlatAppearance.BorderSize = 0;
            btnRemoveLink.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveLink.ForeColor = Color.Red;
            btnRemoveLink.Location = new Point(249, 123);
            btnRemoveLink.Name = "btnRemoveLink";
            btnRemoveLink.Size = new Size(142, 43);
            btnRemoveLink.TabIndex = 24;
            btnRemoveLink.Text = "Remove Link";
            btnRemoveLink.UseVisualStyleBackColor = true;
            btnRemoveLink.Click += btnRemoveLink_Click;
            // 
            // btnLinkSupplierBook
            // 
            btnLinkSupplierBook.BackColor = SystemColors.ControlLight;
            btnLinkSupplierBook.FlatAppearance.BorderColor = Color.DarkBlue;
            btnLinkSupplierBook.FlatAppearance.BorderSize = 0;
            btnLinkSupplierBook.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLinkSupplierBook.ForeColor = Color.DarkBlue;
            btnLinkSupplierBook.Location = new Point(20, 123);
            btnLinkSupplierBook.Name = "btnLinkSupplierBook";
            btnLinkSupplierBook.Size = new Size(142, 43);
            btnLinkSupplierBook.TabIndex = 23;
            btnLinkSupplierBook.Text = "Link Supplier and Book";
            btnLinkSupplierBook.UseVisualStyleBackColor = true;
            btnLinkSupplierBook.Click += btnLinkSupplierBook_Click;
            // 
            // cmbBook
            // 
            cmbBook.FormattingEnabled = true;
            cmbBook.Location = new Point(91, 57);
            cmbBook.Name = "cmbBook";
            cmbBook.Size = new Size(300, 24);
            cmbBook.TabIndex = 22;
            // 
            // cmbSupplier
            // 
            cmbSupplier.FormattingEnabled = true;
            cmbSupplier.Location = new Point(91, 20);
            cmbSupplier.Name = "cmbSupplier";
            cmbSupplier.Size = new Size(300, 24);
            cmbSupplier.TabIndex = 21;
            // 
            // lblBook
            // 
            lblBook.AutoSize = true;
            lblBook.Location = new Point(20, 60);
            lblBook.Name = "lblBook";
            lblBook.Size = new Size(44, 16);
            lblBook.TabIndex = 20;
            lblBook.Text = "Book:";
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(20, 23);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(65, 16);
            lblSupplier.TabIndex = 19;
            lblSupplier.Text = "Supplier:";
            // 
            // SupplierBooksForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(484, 536);
            Controls.Add(panel1);
            Controls.Add(dgvSupplierBooks);
            Controls.Add(btnExit);
            Controls.Add(llbSupBookHeading);
            Controls.Add(picSupBooks);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SupplierBooksForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            Load += SupplierBooksForm_Load;
            ((System.ComponentModel.ISupportInitialize)picSupBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llbSupBookHeading;
        private PictureBox picSupBooks;
        private Button btnExit;
        private DataGridView dgvSupplierBooks;
        private Panel panel1;
        private Button btnRemoveLink;
        private Button btnLinkSupplierBook;
        private ComboBox cmbBook;
        private ComboBox cmbSupplier;
        private Label lblBook;
        private Label lblSupplier;
    }
}