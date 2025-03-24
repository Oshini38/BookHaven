namespace BookHaven.Forms
{
    partial class SuppliersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersForm));
            btnExit = new Button();
            btnDeleteSupplier = new Button();
            lblSupList = new Label();
            btnUpdateSupplier = new Button();
            btnClear = new Button();
            btnAddSupplier = new Button();
            txtSupplierContact = new TextBox();
            pnlSuppliers = new Panel();
            panel1 = new Panel();
            txtSupplierEmail = new TextBox();
            txtSupplierName = new TextBox();
            lblSupEmail = new Label();
            lblSupName = new Label();
            lblSupContact = new Label();
            dgvSuppliers = new DataGridView();
            llbSupHeading = new Label();
            pictureBox1 = new PictureBox();
            pnlSuppliers.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(30, 601);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 27;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDeleteSupplier
            // 
            btnDeleteSupplier.FlatAppearance.BorderColor = Color.Red;
            btnDeleteSupplier.FlatAppearance.BorderSize = 0;
            btnDeleteSupplier.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteSupplier.ForeColor = Color.Red;
            btnDeleteSupplier.Location = new Point(64, 490);
            btnDeleteSupplier.Name = "btnDeleteSupplier";
            btnDeleteSupplier.Size = new Size(172, 33);
            btnDeleteSupplier.TabIndex = 22;
            btnDeleteSupplier.Text = "REMOVE";
            btnDeleteSupplier.UseVisualStyleBackColor = true;
            btnDeleteSupplier.Click += btnDeleteSupplier_Click;
            // 
            // lblSupList
            // 
            lblSupList.AutoSize = true;
            lblSupList.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSupList.Location = new Point(18, 223);
            lblSupList.Name = "lblSupList";
            lblSupList.Size = new Size(159, 16);
            lblSupList.TabIndex = 16;
            lblSupList.Text = "Current Sppliers List:";
            // 
            // btnUpdateSupplier
            // 
            btnUpdateSupplier.FlatAppearance.BorderColor = Color.LimeGreen;
            btnUpdateSupplier.FlatAppearance.BorderSize = 0;
            btnUpdateSupplier.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateSupplier.ForeColor = Color.LimeGreen;
            btnUpdateSupplier.Location = new Point(332, 490);
            btnUpdateSupplier.Name = "btnUpdateSupplier";
            btnUpdateSupplier.Size = new Size(172, 33);
            btnUpdateSupplier.TabIndex = 13;
            btnUpdateSupplier.Text = "UPDATE";
            btnUpdateSupplier.UseVisualStyleBackColor = true;
            btnUpdateSupplier.Click += btnUpdateSupplier_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(242, 145);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(172, 33);
            btnClear.TabIndex = 24;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.BackColor = SystemColors.ControlLight;
            btnAddSupplier.FlatAppearance.BorderColor = Color.DarkBlue;
            btnAddSupplier.FlatAppearance.BorderSize = 0;
            btnAddSupplier.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddSupplier.ForeColor = Color.DarkBlue;
            btnAddSupplier.Location = new Point(24, 145);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(172, 33);
            btnAddSupplier.TabIndex = 21;
            btnAddSupplier.Text = "ADD";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
            // 
            // txtSupplierContact
            // 
            txtSupplierContact.Font = new Font("Segoe UI", 9.75F);
            txtSupplierContact.Location = new Point(132, 51);
            txtSupplierContact.Name = "txtSupplierContact";
            txtSupplierContact.Size = new Size(282, 25);
            txtSupplierContact.TabIndex = 20;
            // 
            // pnlSuppliers
            // 
            pnlSuppliers.BackColor = SystemColors.ControlLight;
            pnlSuppliers.Controls.Add(panel1);
            pnlSuppliers.Controls.Add(btnDeleteSupplier);
            pnlSuppliers.Controls.Add(lblSupList);
            pnlSuppliers.Controls.Add(dgvSuppliers);
            pnlSuppliers.Controls.Add(btnUpdateSupplier);
            pnlSuppliers.Location = new Point(32, 52);
            pnlSuppliers.Name = "pnlSuppliers";
            pnlSuppliers.Size = new Size(580, 536);
            pnlSuppliers.TabIndex = 26;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(txtSupplierEmail);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnAddSupplier);
            panel1.Controls.Add(txtSupplierContact);
            panel1.Controls.Add(txtSupplierName);
            panel1.Controls.Add(lblSupEmail);
            panel1.Controls.Add(lblSupName);
            panel1.Controls.Add(lblSupContact);
            panel1.Location = new Point(64, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 193);
            panel1.TabIndex = 17;
            // 
            // txtSupplierEmail
            // 
            txtSupplierEmail.Font = new Font("Segoe UI", 9.75F);
            txtSupplierEmail.Location = new Point(132, 87);
            txtSupplierEmail.Name = "txtSupplierEmail";
            txtSupplierEmail.Size = new Size(282, 25);
            txtSupplierEmail.TabIndex = 25;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Font = new Font("Segoe UI", 9.75F);
            txtSupplierName.Location = new Point(132, 17);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(282, 25);
            txtSupplierName.TabIndex = 19;
            // 
            // lblSupEmail
            // 
            lblSupEmail.AutoSize = true;
            lblSupEmail.Font = new Font("Verdana", 9.75F);
            lblSupEmail.Location = new Point(24, 91);
            lblSupEmail.Name = "lblSupEmail";
            lblSupEmail.Size = new Size(46, 16);
            lblSupEmail.TabIndex = 18;
            lblSupEmail.Text = "Email:";
            // 
            // lblSupName
            // 
            lblSupName.AutoSize = true;
            lblSupName.Font = new Font("Verdana", 9.75F);
            lblSupName.Location = new Point(23, 19);
            lblSupName.Name = "lblSupName";
            lblSupName.Size = new Size(106, 16);
            lblSupName.TabIndex = 16;
            lblSupName.Text = "Supplier Name:";
            // 
            // lblSupContact
            // 
            lblSupContact.AutoSize = true;
            lblSupContact.Font = new Font("Verdana", 9.75F);
            lblSupContact.Location = new Point(23, 55);
            lblSupContact.Name = "lblSupContact";
            lblSupContact.Size = new Size(88, 16);
            lblSupContact.TabIndex = 17;
            lblSupContact.Text = "Contact No:";
            // 
            // dgvSuppliers
            // 
            dgvSuppliers.BackgroundColor = SystemColors.AppWorkspace;
            dgvSuppliers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSuppliers.Location = new Point(18, 246);
            dgvSuppliers.Name = "dgvSuppliers";
            dgvSuppliers.ReadOnly = true;
            dgvSuppliers.Size = new Size(541, 219);
            dgvSuppliers.TabIndex = 15;
            // 
            // llbSupHeading
            // 
            llbSupHeading.AutoSize = true;
            llbSupHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbSupHeading.Location = new Point(44, 15);
            llbSupHeading.Name = "llbSupHeading";
            llbSupHeading.Size = new Size(209, 22);
            llbSupHeading.TabIndex = 24;
            llbSupHeading.Text = "Supplier Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // SuppliersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(640, 639);
            Controls.Add(btnExit);
            Controls.Add(pnlSuppliers);
            Controls.Add(llbSupHeading);
            Controls.Add(pictureBox1);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SuppliersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            Load += SuppliersForm_Load;
            pnlSuppliers.ResumeLayout(false);
            pnlSuppliers.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSuppliers).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnDeleteSupplier;
        private Label lblSupList;
        private Button btnUpdateSupplier;
        private Button btnClear;
        private Button btnAddSupplier;
        private TextBox txtSupplierContact;
        private ComboBox cmbRole;
        private Button btnAddUser;
        private TextBox txtPassword;
        private Panel pnlSuppliers;
        private Panel panel1;
        private TextBox txtSupplierName;
        private TextBox txtUserName;
        private Label lblSupEmail;
        private Label lblSupName;
        private Label lblSupContact;
        private DataGridView dgvSuppliers;
        private Label llbSupHeading;
        private PictureBox pictureBox1;
        private TextBox txtSupplierEmail;
    }
}