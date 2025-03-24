namespace BookHaven.Forms
{
    partial class ClerkDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClerkDashboardForm));
            lblWelcome = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox5 = new PictureBox();
            btnSales = new Button();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            btnManageCustomers = new Button();
            btnLogout = new Button();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Maiandra GD", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblWelcome.ForeColor = Color.LightSeaGreen;
            lblWelcome.Location = new Point(21, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 18);
            lblWelcome.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.InactiveCaption;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(31, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 214);
            panel1.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ControlLight;
            panel4.Controls.Add(pictureBox5);
            panel4.Controls.Add(btnSales);
            panel4.Location = new Point(267, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(188, 151);
            panel4.TabIndex = 25;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(50, 8);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(85, 70);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            // 
            // btnSales
            // 
            btnSales.BackColor = SystemColors.ScrollBar;
            btnSales.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSales.ForeColor = Color.DodgerBlue;
            btnSales.Location = new Point(11, 84);
            btnSales.Name = "btnSales";
            btnSales.Size = new Size(165, 57);
            btnSales.TabIndex = 4;
            btnSales.Text = "Sales Transaction";
            btnSales.UseVisualStyleBackColor = false;
            btnSales.Click += btnSales_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLight;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(btnManageCustomers);
            panel3.Location = new Point(33, 28);
            panel3.Name = "panel3";
            panel3.Size = new Size(188, 151);
            panel3.TabIndex = 24;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(48, 8);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 70);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnManageCustomers
            // 
            btnManageCustomers.BackColor = SystemColors.ScrollBar;
            btnManageCustomers.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageCustomers.ForeColor = Color.IndianRed;
            btnManageCustomers.Location = new Point(13, 84);
            btnManageCustomers.Name = "btnManageCustomers";
            btnManageCustomers.Size = new Size(165, 57);
            btnManageCustomers.TabIndex = 3;
            btnManageCustomers.Text = "Manage Customers";
            btnManageCustomers.UseVisualStyleBackColor = false;
            btnManageCustomers.Click += btnManageCustomers_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SteelBlue;
            btnLogout.FlatAppearance.BorderColor = Color.SteelBlue;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(437, 16);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(86, 26);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // ClerkDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(556, 320);
            Controls.Add(btnLogout);
            Controls.Add(panel1);
            Controls.Add(lblWelcome);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "ClerkDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BookHaven";
            Load += ClerkDashboardForm_Load;
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Panel panel1;
        private Panel panel4;
        private PictureBox pictureBox5;
        private Button btnSales;
        private Panel panel3;
        private PictureBox pictureBox3;
        private Button btnManageCustomers;
        private Button btnLogout;
    }
}