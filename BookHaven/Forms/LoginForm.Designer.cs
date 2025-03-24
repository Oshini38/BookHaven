namespace BookHaven.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblStart = new Label();
            panel1 = new Panel();
            chkShowPassword = new CheckBox();
            lblMsg = new Label();
            btnClear = new Button();
            btnLogin = new Button();
            txtPw = new TextBox();
            txtName = new TextBox();
            lblPw = new Label();
            lblName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Font = new Font("Maiandra GD", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblStart.Location = new Point(30, 20);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(125, 15);
            lblStart.TabIndex = 0;
            lblStart.Text = "Hi, Welcome Back!";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(chkShowPassword);
            panel1.Controls.Add(lblMsg);
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(txtPw);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblPw);
            panel1.Controls.Add(lblName);
            panel1.Location = new Point(43, 48);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 292);
            panel1.TabIndex = 7;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Font = new Font("Verdana", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkShowPassword.Location = new Point(171, 135);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(101, 16);
            chkShowPassword.TabIndex = 16;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMsg.ForeColor = Color.Red;
            lblMsg.Location = new Point(32, 266);
            lblMsg.Name = "lblMsg";
            lblMsg.RightToLeft = RightToLeft.No;
            lblMsg.Size = new Size(0, 13);
            lblMsg.TabIndex = 15;
            lblMsg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            btnClear.FlatAppearance.BorderColor = SystemColors.ControlLight;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(81, 232);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(155, 35);
            btnClear.TabIndex = 14;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(81, 190);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 35);
            btnLogin.TabIndex = 11;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPw
            // 
            txtPw.BackColor = SystemColors.InactiveBorder;
            txtPw.Font = new Font("Verdana", 9.75F);
            txtPw.Location = new Point(49, 106);
            txtPw.Name = "txtPw";
            txtPw.PasswordChar = '*';
            txtPw.Size = new Size(222, 23);
            txtPw.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.BackColor = SystemColors.InactiveBorder;
            txtName.Font = new Font("Verdana", 9.75F);
            txtName.Location = new Point(49, 51);
            txtName.Name = "txtName";
            txtName.Size = new Size(222, 23);
            txtName.TabIndex = 12;
            // 
            // lblPw
            // 
            lblPw.AutoSize = true;
            lblPw.Font = new Font("Verdana", 9.75F);
            lblPw.Location = new Point(49, 87);
            lblPw.Name = "lblPw";
            lblPw.Size = new Size(69, 16);
            lblPw.TabIndex = 10;
            lblPw.Text = "Password";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Verdana", 9.75F);
            lblName.Location = new Point(49, 32);
            lblName.Name = "lblName";
            lblName.Size = new Size(71, 16);
            lblName.TabIndex = 9;
            lblName.Text = "Username";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(407, 377);
            Controls.Add(panel1);
            Controls.Add(lblStart);
            Font = new Font("Maiandra GD", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStart;
        private Panel panel1;
        private Button btnClear;
        private Button btnLogin;
        private TextBox txtPw;
        private TextBox txtName;
        private Label lblPw;
        private Label lblName;
        private Label lblMsg;
        private CheckBox chkShowPassword;
    }
}