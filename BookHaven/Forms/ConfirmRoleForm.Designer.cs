namespace BookHaven.Forms
{
    partial class ConfirmRoleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmRoleForm));
            txtPassword = new TextBox();
            lblEnterPw = new Label();
            btnCancel = new Button();
            btnConfirm = new Button();
            SuspendLayout();
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 9.75F);
            txtPassword.Location = new Point(40, 59);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(230, 25);
            txtPassword.TabIndex = 22;
            // 
            // lblEnterPw
            // 
            lblEnterPw.AutoSize = true;
            lblEnterPw.Font = new Font("Verdana", 9.75F);
            lblEnterPw.Location = new Point(40, 31);
            lblEnterPw.Name = "lblEnterPw";
            lblEnterPw.Size = new Size(149, 16);
            lblEnterPw.TabIndex = 21;
            lblEnterPw.Text = "Enter Your Password:";
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.ControlLight;
            btnCancel.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(256, 126);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(151, 33);
            btnCancel.TabIndex = 26;
            btnCancel.Text = "CANCEL";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.SteelBlue;
            btnConfirm.FlatAppearance.BorderColor = Color.DarkBlue;
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.ForeColor = SystemColors.ButtonFace;
            btnConfirm.Location = new Point(38, 126);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(151, 33);
            btnConfirm.TabIndex = 25;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // ConfirmRoleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(450, 195);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(txtPassword);
            Controls.Add(lblEnterPw);
            Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ConfirmRoleForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "BookHaven";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPassword;
        private Label lblEnterPw;
        private Button btnCancel;
        private Button btnConfirm;
    }
}