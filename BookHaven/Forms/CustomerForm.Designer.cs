namespace BookHaven.Forms
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            llbCustomerHeading = new Label();
            pictureBox1 = new PictureBox();
            pnlCustomer = new Panel();
            panel1 = new Panel();
            btnClear = new Button();
            btnAdd = new Button();
            txtAddress = new TextBox();
            txtCusEmail = new TextBox();
            txtCusContact = new TextBox();
            txtCusName = new TextBox();
            lblCusEmail = new Label();
            lblCusName = new Label();
            lblCusContact = new Label();
            lblAddress = new Label();
            btnDelete = new Button();
            btnUpdate = new Button();
            panel2 = new Panel();
            txtSearch = new TextBox();
            pictureBox3 = new PictureBox();
            dgvCustomers = new DataGridView();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlCustomer.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // llbCustomerHeading
            // 
            llbCustomerHeading.AutoSize = true;
            llbCustomerHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbCustomerHeading.Location = new Point(43, 14);
            llbCustomerHeading.Name = "llbCustomerHeading";
            llbCustomerHeading.Size = new Size(221, 22);
            llbCustomerHeading.TabIndex = 9;
            llbCustomerHeading.Text = "Customer Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pnlCustomer
            // 
            pnlCustomer.BackColor = SystemColors.ControlLight;
            pnlCustomer.Controls.Add(panel1);
            pnlCustomer.Controls.Add(btnDelete);
            pnlCustomer.Controls.Add(btnUpdate);
            pnlCustomer.Location = new Point(34, 49);
            pnlCustomer.Name = "pnlCustomer";
            pnlCustomer.Size = new Size(448, 321);
            pnlCustomer.TabIndex = 11;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtAddress);
            panel1.Controls.Add(txtCusEmail);
            panel1.Controls.Add(txtCusContact);
            panel1.Controls.Add(txtCusName);
            panel1.Controls.Add(lblCusEmail);
            panel1.Controls.Add(lblCusName);
            panel1.Controls.Add(lblCusContact);
            panel1.Controls.Add(lblAddress);
            panel1.Location = new Point(18, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 237);
            panel1.TabIndex = 26;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(223, 189);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(172, 33);
            btnClear.TabIndex = 35;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.ControlLight;
            btnAdd.FlatAppearance.BorderColor = Color.DarkBlue;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.ForeColor = Color.DarkBlue;
            btnAdd.Location = new Point(20, 189);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(172, 33);
            btnAdd.TabIndex = 34;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 9.75F);
            txtAddress.Location = new Point(113, 118);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(282, 25);
            txtAddress.TabIndex = 33;
            // 
            // txtCusEmail
            // 
            txtCusEmail.Font = new Font("Segoe UI", 9.75F);
            txtCusEmail.Location = new Point(113, 85);
            txtCusEmail.Name = "txtCusEmail";
            txtCusEmail.Size = new Size(282, 25);
            txtCusEmail.TabIndex = 32;
            // 
            // txtCusContact
            // 
            txtCusContact.Font = new Font("Segoe UI", 9.75F);
            txtCusContact.Location = new Point(113, 51);
            txtCusContact.Name = "txtCusContact";
            txtCusContact.Size = new Size(282, 25);
            txtCusContact.TabIndex = 31;
            // 
            // txtCusName
            // 
            txtCusName.Font = new Font("Segoe UI", 9.75F);
            txtCusName.Location = new Point(113, 19);
            txtCusName.Name = "txtCusName";
            txtCusName.Size = new Size(282, 25);
            txtCusName.TabIndex = 30;
            // 
            // lblCusEmail
            // 
            lblCusEmail.AutoSize = true;
            lblCusEmail.Font = new Font("Verdana", 9.75F);
            lblCusEmail.Location = new Point(20, 89);
            lblCusEmail.Name = "lblCusEmail";
            lblCusEmail.Size = new Size(46, 16);
            lblCusEmail.TabIndex = 28;
            lblCusEmail.Text = "Email:";
            // 
            // lblCusName
            // 
            lblCusName.AutoSize = true;
            lblCusName.Font = new Font("Verdana", 9.75F);
            lblCusName.Location = new Point(20, 21);
            lblCusName.Name = "lblCusName";
            lblCusName.Size = new Size(49, 16);
            lblCusName.TabIndex = 26;
            lblCusName.Text = "Name:";
            // 
            // lblCusContact
            // 
            lblCusContact.AutoSize = true;
            lblCusContact.Font = new Font("Verdana", 9.75F);
            lblCusContact.Location = new Point(19, 54);
            lblCusContact.Name = "lblCusContact";
            lblCusContact.Size = new Size(88, 16);
            lblCusContact.TabIndex = 27;
            lblCusContact.Text = "Contact No:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Verdana", 9.75F);
            lblAddress.Location = new Point(20, 121);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 16);
            lblAddress.TabIndex = 29;
            lblAddress.Text = "Address:";
            // 
            // btnDelete
            // 
            btnDelete.FlatAppearance.BorderColor = Color.Red;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.ForeColor = Color.Red;
            btnDelete.Location = new Point(37, 272);
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
            btnUpdate.Location = new Point(241, 272);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(172, 33);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLight;
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(506, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(445, 33);
            panel2.TabIndex = 12;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = SystemColors.InactiveBorder;
            txtSearch.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(46, 5);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search Customers by Name/Contact no.";
            txtSearch.Size = new Size(389, 23);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(11, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 19);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = SystemColors.AppWorkspace;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(506, 49);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.Size = new Size(445, 362);
            dgvCustomers.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(206, 382);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 28;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(980, 423);
            Controls.Add(btnExit);
            Controls.Add(dgvCustomers);
            Controls.Add(panel2);
            Controls.Add(pnlCustomer);
            Controls.Add(pictureBox1);
            Controls.Add(llbCustomerHeading);
            Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlCustomer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label llbCustomerHeading;
        private PictureBox pictureBox1;
        private Panel pnlCustomer;
        private ComboBox cmbCategory;
        private Label lblCategory;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel2;
        private TextBox txtSearch;
        private PictureBox pictureBox3;
        private DataGridView dgvCustomers;
        private Button btnExit;
        private Panel panel1;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtAddress;
        private TextBox txtCusEmail;
        private TextBox txtCusContact;
        private TextBox txtCusName;
        private Label lblCusEmail;
        private Label lblCusName;
        private Label lblCusContact;
        private Label lblAddress;
    }
}