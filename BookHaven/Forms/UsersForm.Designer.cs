namespace BookHaven.Forms
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            pictureBox1 = new PictureBox();
            llbUserHeading = new Label();
            dgvUsers = new DataGridView();
            pnlUsers = new Panel();
            panel1 = new Panel();
            chkShowPassword = new CheckBox();
            btnClear = new Button();
            cmbRole = new ComboBox();
            btnAddUser = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblUserRole = new Label();
            lblUserName = new Label();
            lblPassword = new Label();
            btnDeleteUser = new Button();
            label1 = new Label();
            btnUpdateUser = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            pnlUsers.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // llbUserHeading
            // 
            llbUserHeading.AutoSize = true;
            llbUserHeading.Font = new Font("Maiandra GD", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            llbUserHeading.Location = new Point(44, 15);
            llbUserHeading.Name = "llbUserHeading";
            llbUserHeading.Size = new Size(176, 22);
            llbUserHeading.TabIndex = 11;
            llbUserHeading.Text = "User Management";
            // 
            // dgvUsers
            // 
            dgvUsers.BackgroundColor = SystemColors.AppWorkspace;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(47, 276);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.Size = new Size(374, 219);
            dgvUsers.TabIndex = 15;
            // 
            // pnlUsers
            // 
            pnlUsers.BackColor = SystemColors.ControlLight;
            pnlUsers.Controls.Add(panel1);
            pnlUsers.Controls.Add(btnDeleteUser);
            pnlUsers.Controls.Add(label1);
            pnlUsers.Controls.Add(dgvUsers);
            pnlUsers.Controls.Add(btnUpdateUser);
            pnlUsers.Location = new Point(32, 51);
            pnlUsers.Name = "pnlUsers";
            pnlUsers.Size = new Size(472, 566);
            pnlUsers.TabIndex = 14;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(cmbRole);
            panel1.Controls.Add(btnAddUser);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUserName);
            panel1.Controls.Add(lblUserRole);
            panel1.Controls.Add(lblUserName);
            panel1.Controls.Add(lblPassword);
            panel1.Location = new Point(17, 13);
            panel1.Name = "panel1";
            panel1.Size = new Size(440, 218);
            panel1.TabIndex = 17;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(303, 80);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(101, 16);
            chkShowPassword.TabIndex = 25;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ControlLight;
            btnClear.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = SystemColors.ActiveCaptionText;
            btnClear.Location = new Point(232, 172);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(172, 33);
            btnClear.TabIndex = 24;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Admin", "Salesclerk" });
            cmbRole.Location = new Point(122, 106);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(180, 25);
            cmbRole.TabIndex = 23;
            // 
            // btnAddUser
            // 
            btnAddUser.BackColor = SystemColors.ControlLight;
            btnAddUser.FlatAppearance.BorderColor = Color.DarkBlue;
            btnAddUser.FlatAppearance.BorderSize = 0;
            btnAddUser.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddUser.ForeColor = Color.DarkBlue;
            btnAddUser.Location = new Point(30, 172);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(172, 33);
            btnAddUser.TabIndex = 21;
            btnAddUser.Text = "CREATE";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F);
            txtPassword.Location = new Point(122, 49);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(282, 25);
            txtPassword.TabIndex = 20;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 9.75F);
            txtUserName.Location = new Point(122, 17);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(282, 25);
            txtUserName.TabIndex = 19;
            // 
            // lblUserRole
            // 
            lblUserRole.AutoSize = true;
            lblUserRole.Font = new Font("Verdana", 9.75F);
            lblUserRole.Location = new Point(29, 113);
            lblUserRole.Name = "lblUserRole";
            lblUserRole.Size = new Size(74, 16);
            lblUserRole.TabIndex = 18;
            lblUserRole.Text = "User Role:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Verdana", 9.75F);
            lblUserName.Location = new Point(29, 19);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(83, 16);
            lblUserName.TabIndex = 16;
            lblUserName.Text = "User Name:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 9.75F);
            lblPassword.Location = new Point(28, 52);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(75, 16);
            lblPassword.TabIndex = 17;
            lblPassword.Text = "Password:";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.FlatAppearance.BorderColor = Color.Red;
            btnDeleteUser.FlatAppearance.BorderSize = 0;
            btnDeleteUser.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.Red;
            btnDeleteUser.Location = new Point(16, 519);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(172, 33);
            btnDeleteUser.TabIndex = 22;
            btnDeleteUser.Text = "REMOVE";
            btnDeleteUser.UseVisualStyleBackColor = true;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 253);
            label1.Name = "label1";
            label1.Size = new Size(134, 16);
            label1.TabIndex = 16;
            label1.Text = "Current User List:";
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.FlatAppearance.BorderColor = Color.LimeGreen;
            btnUpdateUser.FlatAppearance.BorderSize = 0;
            btnUpdateUser.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateUser.ForeColor = Color.LimeGreen;
            btnUpdateUser.Location = new Point(286, 519);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(172, 33);
            btnUpdateUser.TabIndex = 13;
            btnUpdateUser.Text = "UPDATE";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.SteelBlue;
            btnExit.FlatAppearance.BorderColor = Color.LightSteelBlue;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = SystemColors.ButtonFace;
            btnExit.Location = new Point(30, 625);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(93, 33);
            btnExit.TabIndex = 23;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(535, 664);
            Controls.Add(btnExit);
            Controls.Add(pnlUsers);
            Controls.Add(pictureBox1);
            Controls.Add(llbUserHeading);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            Load += ManageUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            pnlUsers.ResumeLayout(false);
            pnlUsers.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label llbUserHeading;
        private DataGridView dgvUsers;
        private Panel pnlUsers;
        private Button btnUpdateUser;
        private Panel panel1;
        private ComboBox cmbRole;
        private Button btnDeleteUser;
        private Button btnAddUser;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblUserRole;
        private Label lblUserName;
        private Label lblPassword;
        private Label label1;
        private Button btnExit;
        private Button btnClear;
        private CheckBox chkShowPassword;
    }
}