namespace BookHaven.Forms
{
    partial class BookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookForm));
            lblTitle = new Label();
            lblAuthor = new Label();
            lblGenre = new Label();
            lblISBN = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            panel1 = new Panel();
            btnClear = new Button();
            pictureBox2 = new PictureBox();
            pnlUpdateStock = new Panel();
            lblNewStock = new Label();
            btnUpdateStock = new Button();
            txtUpdateStock = new TextBox();
            cmbCategory = new ComboBox();
            lblCategory = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            txtISBN = new TextBox();
            txtGenre = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            panel2 = new Panel();
            txtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            llbBookHeading = new Label();
            dgvBooks = new DataGridView();
            pictureBox3 = new PictureBox();
            btnExit = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlUpdateStock.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 9.75F);
            lblTitle.Location = new Point(32, 26);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(42, 16);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Font = new Font("Verdana", 9.75F);
            lblAuthor.Location = new Point(32, 58);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(57, 16);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "Author:";
            // 
            // lblGenre
            // 
            lblGenre.AutoSize = true;
            lblGenre.Font = new Font("Verdana", 9.75F);
            lblGenre.Location = new Point(32, 122);
            lblGenre.Name = "lblGenre";
            lblGenre.Size = new Size(51, 16);
            lblGenre.TabIndex = 2;
            lblGenre.Text = "Genre:";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.Font = new Font("Verdana", 9.75F);
            lblISBN.Location = new Point(32, 153);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(44, 16);
            lblISBN.TabIndex = 3;
            lblISBN.Text = "ISBN:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Verdana", 9.75F);
            lblPrice.Location = new Point(32, 183);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(45, 16);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Font = new Font("Verdana", 9.75F);
            lblStock.Location = new Point(32, 215);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(51, 16);
            lblStock.TabIndex = 5;
            lblStock.Text = "Stock:";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pnlUpdateStock);
            panel1.Controls.Add(cmbCategory);
            panel1.Controls.Add(lblCategory);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtStock);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtISBN);
            panel1.Controls.Add(txtGenre);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(lblGenre);
            panel1.Controls.Add(lblStock);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(lblPrice);
            panel1.Controls.Add(lblAuthor);
            panel1.Controls.Add(lblISBN);
            panel1.Location = new Point(30, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 471);
            panel1.TabIndex = 6;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(32, 316);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(172, 33);
            btnClear.TabIndex = 25;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 396);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(133, 63);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pnlUpdateStock
            // 
            pnlUpdateStock.BackColor = SystemColors.ScrollBar;
            pnlUpdateStock.Controls.Add(lblNewStock);
            pnlUpdateStock.Controls.Add(btnUpdateStock);
            pnlUpdateStock.Controls.Add(txtUpdateStock);
            pnlUpdateStock.Location = new Point(235, 322);
            pnlUpdateStock.Name = "pnlUpdateStock";
            pnlUpdateStock.Size = new Size(172, 118);
            pnlUpdateStock.TabIndex = 17;
            // 
            // lblNewStock
            // 
            lblNewStock.AutoSize = true;
            lblNewStock.Font = new Font("Verdana", 9.75F);
            lblNewStock.Location = new Point(13, 10);
            lblNewStock.Name = "lblNewStock";
            lblNewStock.Size = new Size(84, 16);
            lblNewStock.TabIndex = 15;
            lblNewStock.Text = "New Stock:";
            // 
            // btnUpdateStock
            // 
            btnUpdateStock.FlatAppearance.BorderColor = Color.Green;
            btnUpdateStock.FlatAppearance.BorderSize = 0;
            btnUpdateStock.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateStock.ForeColor = Color.Green;
            btnUpdateStock.Location = new Point(13, 73);
            btnUpdateStock.Margin = new Padding(0);
            btnUpdateStock.Name = "btnUpdateStock";
            btnUpdateStock.Size = new Size(149, 33);
            btnUpdateStock.TabIndex = 14;
            btnUpdateStock.Text = "UPDATE STOCK";
            btnUpdateStock.UseVisualStyleBackColor = true;
            btnUpdateStock.Click += btnUpdateStock_Click;
            // 
            // txtUpdateStock
            // 
            txtUpdateStock.Font = new Font("Segoe UI", 9.75F);
            txtUpdateStock.Location = new Point(13, 30);
            txtUpdateStock.Name = "txtUpdateStock";
            txtUpdateStock.Size = new Size(106, 25);
            txtUpdateStock.TabIndex = 12;
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Segoe UI", 9.75F);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(125, 86);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(282, 25);
            cmbCategory.TabIndex = 16;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(32, 91);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(70, 14);
            lblCategory.TabIndex = 15;
            lblCategory.Text = "Category:";
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(32, 356);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(172, 33);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatAppearance.BorderColor = Color.LimeGreen;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.ForeColor = Color.LimeGreen;
            btnUpdate.Location = new Point(235, 277);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(172, 33);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.FlatAppearance.BorderColor = Color.DarkBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.DarkBlue;
            btnAdd.Location = new Point(32, 277);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 33);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Segoe UI", 9.75F);
            txtStock.Location = new Point(125, 211);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(106, 25);
            txtStock.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 9.75F);
            txtPrice.Location = new Point(125, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(159, 25);
            txtPrice.TabIndex = 10;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 9.75F);
            txtISBN.Location = new Point(125, 150);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(282, 25);
            txtISBN.TabIndex = 9;
            // 
            // txtGenre
            // 
            txtGenre.Font = new Font("Segoe UI", 9.75F);
            txtGenre.Location = new Point(125, 118);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(282, 25);
            txtGenre.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Segoe UI", 9.75F);
            txtAuthor.Location = new Point(125, 55);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(282, 25);
            txtAuthor.TabIndex = 7;
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 9.75F);
            txtTitle.Location = new Point(125, 24);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(282, 25);
            txtTitle.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(510, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(497, 33);
            panel2.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveBorder;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(46, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Books by Title/Author/ISBN";
            txtSearch.Size = new Size(438, 23);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // llbBookHeading
            // 
            llbBookHeading.AutoSize = true;
            llbBookHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbBookHeading.Location = new Point(42, 14);
            llbBookHeading.Name = "llbBookHeading";
            llbBookHeading.Size = new Size(182, 22);
            llbBookHeading.TabIndex = 8;
            llbBookHeading.Text = "Book Management";
            // 
            // dgvBooks
            // 
            dgvBooks.BackgroundColor = SystemColors.AppWorkspace;
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(510, 50);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.ReadOnly = true;
            dgvBooks.Size = new Size(543, 471);
            dgvBooks.TabIndex = 9;
            dgvBooks.SelectionChanged += dgvBooks_SelectionChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 6);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(30, 531);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 27;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // BookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1077, 571);
            Controls.Add(btnExit);
            Controls.Add(pictureBox3);
            Controls.Add(dgvBooks);
            Controls.Add(llbBookHeading);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BookForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            Load += BookForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlUpdateStock.ResumeLayout(false);
            pnlUpdateStock.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblAuthor;
        private Label lblGenre;
        private Label lblISBN;
        private Label lblPrice;
        private Label lblStock;
        private Panel panel1;
        private TextBox txtPrice;
        private TextBox txtISBN;
        private TextBox txtGenre;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private Button btnAdd;
        private TextBox txtStock;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label llbBookHeading;
        private DataGridView dgvBooks;
        private TextBox txtSearch;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Panel pnlUpdateStock;
        private TextBox txtUpdateStock;
        private Button btnUpdateStock;
        private Label lblNewStock;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnClear;
        private Button btnExit;
    }
}