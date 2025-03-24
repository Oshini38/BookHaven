namespace BookHaven.Forms
{
    partial class SalesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesForm));
            picSales = new PictureBox();
            llbSalesHeading = new Label();
            pnlBook = new Panel();
            cmbCustomer = new ComboBox();
            gbBookSearch = new GroupBox();
            txtBookSearch = new TextBox();
            btnBookSearch = new Button();
            label2 = new Label();
            btnAddToCart = new Button();
            dgvBookList = new DataGridView();
            lblBookList = new Label();
            pnlCart = new Panel();
            lblQuantity = new Label();
            nupQuantity = new NumericUpDown();
            btnRemoveFromCart = new Button();
            btcClearCart = new Button();
            dgvCart = new DataGridView();
            picCart = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            lblPayM = new Label();
            panel2 = new Panel();
            cbCard = new CheckBox();
            cbCash = new CheckBox();
            btnCancel = new Button();
            btnCheckout = new Button();
            txtTotalAmount = new TextBox();
            btnDiscount = new Button();
            txtDiscount = new TextBox();
            txtSubTotal = new TextBox();
            lblTotal = new Label();
            lblDiscount = new Label();
            lblSubTotal = new Label();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)picSales).BeginInit();
            pnlBook.SuspendLayout();
            gbBookSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).BeginInit();
            pnlCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCart).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // picSales
            // 
            picSales.Image = (Image)resources.GetObject("picSales.Image");
            picSales.Location = new Point(4, 4);
            picSales.Name = "picSales";
            picSales.Size = new Size(35, 38);
            picSales.SizeMode = PictureBoxSizeMode.StretchImage;
            picSales.TabIndex = 0;
            picSales.TabStop = false;
            // 
            // llbSalesHeading
            // 
            llbSalesHeading.AutoSize = true;
            llbSalesHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbSalesHeading.Location = new Point(44, 12);
            llbSalesHeading.Name = "llbSalesHeading";
            llbSalesHeading.Size = new Size(166, 22);
            llbSalesHeading.TabIndex = 9;
            llbSalesHeading.Text = "Sales Transaction";
            // 
            // pnlBook
            // 
            pnlBook.BackColor = SystemColors.ControlLight;
            pnlBook.Controls.Add(cmbCustomer);
            pnlBook.Controls.Add(gbBookSearch);
            pnlBook.Controls.Add(label2);
            pnlBook.Controls.Add(btnAddToCart);
            pnlBook.Controls.Add(dgvBookList);
            pnlBook.Controls.Add(lblBookList);
            pnlBook.Location = new Point(31, 50);
            pnlBook.Name = "pnlBook";
            pnlBook.Size = new Size(600, 325);
            pnlBook.TabIndex = 10;
            // 
            // cmbCustomer
            // 
            cmbCustomer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCustomer.FormattingEnabled = true;
            cmbCustomer.Location = new Point(101, 16);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.Size = new Size(301, 25);
            cmbCustomer.TabIndex = 20;
            // 
            // gbBookSearch
            // 
            gbBookSearch.BackColor = SystemColors.ControlLight;
            gbBookSearch.Controls.Add(txtBookSearch);
            gbBookSearch.Controls.Add(btnBookSearch);
            gbBookSearch.FlatStyle = FlatStyle.Popup;
            gbBookSearch.Location = new Point(16, 51);
            gbBookSearch.Name = "gbBookSearch";
            gbBookSearch.Size = new Size(405, 53);
            gbBookSearch.TabIndex = 19;
            gbBookSearch.TabStop = false;
            gbBookSearch.Text = "Search by Name";
            // 
            // txtBookSearch
            // 
            txtBookSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookSearch.Location = new Point(28, 18);
            txtBookSearch.Name = "txtBookSearch";
            txtBookSearch.PlaceholderText = "Search book";
            txtBookSearch.Size = new Size(238, 25);
            txtBookSearch.TabIndex = 12;
            txtBookSearch.TextChanged += txtBookSearch_TextChanged;
            // 
            // btnBookSearch
            // 
            btnBookSearch.BackColor = Color.RoyalBlue;
            btnBookSearch.FlatAppearance.BorderColor = Color.RoyalBlue;
            btnBookSearch.FlatAppearance.BorderSize = 0;
            btnBookSearch.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBookSearch.ForeColor = SystemColors.Window;
            btnBookSearch.Location = new Point(266, 17);
            btnBookSearch.Name = "btnBookSearch";
            btnBookSearch.Size = new Size(120, 27);
            btnBookSearch.TabIndex = 13;
            btnBookSearch.Text = "Search";
            btnBookSearch.UseVisualStyleBackColor = false;
            btnBookSearch.Click += btnBookSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(75, 16);
            label2.TabIndex = 17;
            label2.Text = "Customer:";
            // 
            // btnAddToCart
            // 
            btnAddToCart.BackColor = SystemColors.ControlLight;
            btnAddToCart.FlatAppearance.BorderColor = Color.DarkBlue;
            btnAddToCart.FlatAppearance.BorderSize = 0;
            btnAddToCart.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToCart.ForeColor = Color.DarkBlue;
            btnAddToCart.Location = new Point(434, 283);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.Size = new Size(142, 33);
            btnAddToCart.TabIndex = 16;
            btnAddToCart.Text = "ADD TO CART";
            btnAddToCart.UseVisualStyleBackColor = true;
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvBookList
            // 
            dgvBookList.BackgroundColor = SystemColors.ScrollBar;
            dgvBookList.BorderStyle = BorderStyle.None;
            dgvBookList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookList.Location = new Point(20, 134);
            dgvBookList.Name = "dgvBookList";
            dgvBookList.ReadOnly = true;
            dgvBookList.ScrollBars = ScrollBars.Horizontal;
            dgvBookList.Size = new Size(556, 136);
            dgvBookList.TabIndex = 15;
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBookList.Location = new Point(20, 115);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(66, 16);
            lblBookList.TabIndex = 14;
            lblBookList.Text = "Book List";
            // 
            // pnlCart
            // 
            pnlCart.BackColor = SystemColors.ControlLight;
            pnlCart.Controls.Add(lblQuantity);
            pnlCart.Controls.Add(nupQuantity);
            pnlCart.Controls.Add(btnRemoveFromCart);
            pnlCart.Controls.Add(btcClearCart);
            pnlCart.Controls.Add(dgvCart);
            pnlCart.Controls.Add(picCart);
            pnlCart.Controls.Add(label1);
            pnlCart.Location = new Point(647, 29);
            pnlCart.Name = "pnlCart";
            pnlCart.Size = new Size(485, 295);
            pnlCart.TabIndex = 11;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(43, 208);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(51, 13);
            lblQuantity.TabIndex = 21;
            lblQuantity.Text = "Quantity";
            // 
            // nupQuantity
            // 
            nupQuantity.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nupQuantity.Location = new Point(43, 224);
            nupQuantity.Name = "nupQuantity";
            nupQuantity.Size = new Size(80, 23);
            nupQuantity.TabIndex = 20;
            nupQuantity.ValueChanged += nupQuantity_ValueChanged;
            // 
            // btnRemoveFromCart
            // 
            btnRemoveFromCart.BackColor = SystemColors.ActiveCaptionText;
            btnRemoveFromCart.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnRemoveFromCart.FlatAppearance.BorderSize = 0;
            btnRemoveFromCart.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveFromCart.ForeColor = SystemColors.ButtonFace;
            btnRemoveFromCart.Location = new Point(301, 206);
            btnRemoveFromCart.Name = "btnRemoveFromCart";
            btnRemoveFromCart.Size = new Size(142, 33);
            btnRemoveFromCart.TabIndex = 19;
            btnRemoveFromCart.Text = "REMOVE";
            btnRemoveFromCart.UseVisualStyleBackColor = false;
            btnRemoveFromCart.Click += btnRemoveFromCart_Click;
            // 
            // btcClearCart
            // 
            btcClearCart.BackColor = SystemColors.ControlLight;
            btcClearCart.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btcClearCart.FlatAppearance.BorderSize = 0;
            btcClearCart.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btcClearCart.ForeColor = SystemColors.ActiveCaptionText;
            btcClearCart.Location = new Point(301, 245);
            btcClearCart.Name = "btcClearCart";
            btcClearCart.Size = new Size(142, 33);
            btcClearCart.TabIndex = 18;
            btcClearCart.Text = "CLEAR CART";
            btcClearCart.UseVisualStyleBackColor = true;
            btcClearCart.Click += btcClearCart_Click;
            // 
            // dgvCart
            // 
            dgvCart.BackgroundColor = SystemColors.ScrollBar;
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(42, 43);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.Size = new Size(401, 150);
            dgvCart.TabIndex = 17;
            dgvCart.SelectionChanged += dgvCart_SelectionChanged;
            // 
            // picCart
            // 
            picCart.Image = (Image)resources.GetObject("picCart.Image");
            picCart.Location = new Point(16, 20);
            picCart.Name = "picCart";
            picCart.Size = new Size(20, 15);
            picCart.SizeMode = PictureBoxSizeMode.StretchImage;
            picCart.TabIndex = 16;
            picCart.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 19);
            label1.Name = "label1";
            label1.Size = new Size(100, 16);
            label1.TabIndex = 15;
            label1.Text = "Shopping Cart";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(lblPayM);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnCancel);
            panel1.Controls.Add(btnCheckout);
            panel1.Controls.Add(txtTotalAmount);
            panel1.Controls.Add(btnDiscount);
            panel1.Controls.Add(txtDiscount);
            panel1.Controls.Add(txtSubTotal);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblSubTotal);
            panel1.Location = new Point(648, 333);
            panel1.Name = "panel1";
            panel1.Size = new Size(399, 245);
            panel1.TabIndex = 12;
            // 
            // lblPayM
            // 
            lblPayM.AutoSize = true;
            lblPayM.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPayM.Location = new Point(37, 133);
            lblPayM.Name = "lblPayM";
            lblPayM.Size = new Size(64, 32);
            lblPayM.TabIndex = 25;
            lblPayM.Text = "Payment\r\nMethod:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbCard);
            panel2.Controls.Add(cbCash);
            panel2.Location = new Point(114, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 35);
            panel2.TabIndex = 24;
            // 
            // cbCard
            // 
            cbCard.AutoSize = true;
            cbCard.Location = new Point(91, 9);
            cbCard.Name = "cbCard";
            cbCard.Size = new Size(56, 18);
            cbCard.TabIndex = 14;
            cbCard.Text = "Card";
            cbCard.UseVisualStyleBackColor = true;
            cbCard.CheckedChanged += cbCard_CheckedChanged;
            // 
            // cbCash
            // 
            cbCash.AutoSize = true;
            cbCash.Location = new Point(3, 9);
            cbCash.Name = "cbCash";
            cbCash.Size = new Size(58, 18);
            cbCash.TabIndex = 13;
            cbCash.Text = "Cash";
            cbCash.UseVisualStyleBackColor = true;
            cbCash.CheckedChanged += cbCash_CheckedChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLight;
            btnCancel.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(222, 196);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(142, 33);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = SystemColors.ActiveCaptionText;
            btnCheckout.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = SystemColors.ButtonFace;
            btnCheckout.Location = new Point(37, 196);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(142, 33);
            btnCheckout.TabIndex = 22;
            btnCheckout.Text = "CHECKOUT";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTotalAmount.Location = new Point(114, 99);
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.ReadOnly = true;
            txtTotalAmount.Size = new Size(250, 25);
            txtTotalAmount.TabIndex = 0;
            // 
            // btnDiscount
            // 
            btnDiscount.BackColor = SystemColors.ControlLight;
            btnDiscount.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnDiscount.FlatAppearance.BorderSize = 0;
            btnDiscount.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDiscount.ForeColor = SystemColors.ControlDarkDark;
            btnDiscount.Location = new Point(222, 58);
            btnDiscount.Name = "btnDiscount";
            btnDiscount.Size = new Size(142, 27);
            btnDiscount.TabIndex = 21;
            btnDiscount.Text = "Apply Discount";
            btnDiscount.UseVisualStyleBackColor = true;
            btnDiscount.Click += btnDiscount_Click;
            // 
            // txtDiscount
            // 
            txtDiscount.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDiscount.Location = new Point(114, 60);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(102, 25);
            txtDiscount.TabIndex = 20;
            // 
            // txtSubTotal
            // 
            txtSubTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSubTotal.Location = new Point(114, 22);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(250, 25);
            txtSubTotal.TabIndex = 19;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(37, 103);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(46, 16);
            lblTotal.TabIndex = 17;
            lblTotal.Text = "Total:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDiscount.Location = new Point(37, 65);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(70, 16);
            lblDiscount.TabIndex = 16;
            lblDiscount.Text = "Discount:";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubTotal.Location = new Point(33, 26);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(76, 16);
            lblSubTotal.TabIndex = 15;
            lblSubTotal.Text = "Sub Total:";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(1056, 544);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 28;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // SalesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(1159, 588);
            Controls.Add(btnExit);
            Controls.Add(panel1);
            Controls.Add(pnlCart);
            Controls.Add(pnlBook);
            Controls.Add(llbSalesHeading);
            Controls.Add(picSales);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SalesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            Load += SalesForm_Load;
            ((System.ComponentModel.ISupportInitialize)picSales).EndInit();
            pnlBook.ResumeLayout(false);
            pnlBook.PerformLayout();
            gbBookSearch.ResumeLayout(false);
            gbBookSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookList).EndInit();
            pnlCart.ResumeLayout(false);
            pnlCart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picSales;
        private Label llbSalesHeading;
        private Panel pnlBook;
        private TextBox txtBookSearch;
        private Button btnBookSearch;
        private Label lblBookList;
        private DataGridView dgvBookList;
        private Button btnAddToCart;
        private Panel pnlCart;
        private PictureBox picCart;
        private Label label1;
        private DataGridView dgvCart;
        private Button btnRemoveFromCart;
        private Button btcClearCart;
        private NumericUpDown nupQuantity;
        private Label lblQuantity;
        private Label label2;
        private GroupBox gbBookSearch;
        private Panel panel1;
        private Label lblTotal;
        private Label lblDiscount;
        private Label lblSubTotal;
        private TextBox txtTotalAmount;
        private Button btnDiscount;
        private TextBox txtDiscount;
        private TextBox txtSubTotal;
        private Button btnCheckout;
        private ComboBox cmbCustomer;
        private Button btnCancel;
        private Panel panel2;
        private Label lblPayM;
        private CheckBox cbCard;
        private CheckBox cbCash;
        private Button btnExit;
    }
}