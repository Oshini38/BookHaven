namespace BookHaven.Forms
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            rtbDetails = new RichTextBox();
            lblGrantTotal = new Label();
            txtGrandTotal = new TextBox();
            btnPrintReceipt = new Button();
            btnClose = new Button();
            lblRecieptNo = new Label();
            lblDate = new Label();
            lblTime = new Label();
            txtReceiptNo = new TextBox();
            lblDateShow = new Label();
            lblTimeShow = new Label();
            lblPayementMethod = new Label();
            lblPayMethodShow = new Label();
            SuspendLayout();
            // 
            // rtbDetails
            // 
            rtbDetails.BackColor = SystemColors.ControlLight;
            rtbDetails.BorderStyle = BorderStyle.FixedSingle;
            rtbDetails.Location = new Point(38, 106);
            rtbDetails.Name = "rtbDetails";
            rtbDetails.ReadOnly = true;
            rtbDetails.Size = new Size(324, 172);
            rtbDetails.TabIndex = 1;
            rtbDetails.Text = "";
            // 
            // lblGrantTotal
            // 
            lblGrantTotal.AutoSize = true;
            lblGrantTotal.Location = new Point(38, 307);
            lblGrantTotal.Name = "lblGrantTotal";
            lblGrantTotal.Size = new Size(75, 17);
            lblGrantTotal.TabIndex = 3;
            lblGrantTotal.Text = "Grant Total:";
            // 
            // txtGrandTotal
            // 
            txtGrandTotal.Location = new Point(154, 304);
            txtGrandTotal.Name = "txtGrandTotal";
            txtGrandTotal.ReadOnly = true;
            txtGrandTotal.Size = new Size(183, 25);
            txtGrandTotal.TabIndex = 5;
            // 
            // btnPrintReceipt
            // 
            btnPrintReceipt.BackColor = SystemColors.ControlLight;
            btnPrintReceipt.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnPrintReceipt.FlatAppearance.BorderSize = 0;
            btnPrintReceipt.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrintReceipt.ForeColor = SystemColors.WindowText;
            btnPrintReceipt.Location = new Point(38, 403);
            btnPrintReceipt.Name = "btnPrintReceipt";
            btnPrintReceipt.Size = new Size(142, 33);
            btnPrintReceipt.TabIndex = 24;
            btnPrintReceipt.Text = "PRINT RECEIPT";
            btnPrintReceipt.UseVisualStyleBackColor = true;
            btnPrintReceipt.Click += btnPrintReceipt_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = SystemColors.ControlDarkDark;
            btnClose.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = SystemColors.ButtonHighlight;
            btnClose.Location = new Point(220, 403);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 33);
            btnClose.TabIndex = 25;
            btnClose.Text = "CLOSE";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // lblRecieptNo
            // 
            lblRecieptNo.AutoSize = true;
            lblRecieptNo.Location = new Point(38, 30);
            lblRecieptNo.Name = "lblRecieptNo";
            lblRecieptNo.Size = new Size(76, 17);
            lblRecieptNo.TabIndex = 28;
            lblRecieptNo.Text = "Reciept No:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(38, 53);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(38, 17);
            lblDate.TabIndex = 29;
            lblDate.Text = "Date:";
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(38, 76);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(39, 17);
            lblTime.TabIndex = 30;
            lblTime.Text = "Time:";
            // 
            // txtReceiptNo
            // 
            txtReceiptNo.Location = new Point(120, 27);
            txtReceiptNo.Name = "txtReceiptNo";
            txtReceiptNo.ReadOnly = true;
            txtReceiptNo.Size = new Size(78, 25);
            txtReceiptNo.TabIndex = 31;
            // 
            // lblDateShow
            // 
            lblDateShow.AutoSize = true;
            lblDateShow.Location = new Point(88, 55);
            lblDateShow.Name = "lblDateShow";
            lblDateShow.Size = new Size(0, 17);
            lblDateShow.TabIndex = 32;
            // 
            // lblTimeShow
            // 
            lblTimeShow.AutoSize = true;
            lblTimeShow.Location = new Point(88, 76);
            lblTimeShow.Name = "lblTimeShow";
            lblTimeShow.Size = new Size(0, 17);
            lblTimeShow.TabIndex = 33;
            // 
            // lblPayementMethod
            // 
            lblPayementMethod.AutoSize = true;
            lblPayementMethod.Location = new Point(37, 341);
            lblPayementMethod.Name = "lblPayementMethod";
            lblPayementMethod.Size = new Size(110, 17);
            lblPayementMethod.TabIndex = 34;
            lblPayementMethod.Text = "Payment Method:";
            // 
            // lblPayMethodShow
            // 
            lblPayMethodShow.AutoSize = true;
            lblPayMethodShow.Location = new Point(154, 341);
            lblPayMethodShow.Name = "lblPayMethodShow";
            lblPayMethodShow.Size = new Size(0, 17);
            lblPayMethodShow.TabIndex = 35;
            // 
            // ReceiptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            ClientSize = new Size(402, 460);
            Controls.Add(lblPayMethodShow);
            Controls.Add(lblPayementMethod);
            Controls.Add(lblTimeShow);
            Controls.Add(lblDateShow);
            Controls.Add(txtReceiptNo);
            Controls.Add(lblTime);
            Controls.Add(lblDate);
            Controls.Add(lblRecieptNo);
            Controls.Add(btnClose);
            Controls.Add(btnPrintReceipt);
            Controls.Add(txtGrandTotal);
            Controls.Add(lblGrantTotal);
            Controls.Add(rtbDetails);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "ReceiptForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "BookHaven";
            Load += ReceiptForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbDetails;
        private Label lblGrantTotal;
        private TextBox txtGrandTotal;
        private Button btnPrintReceipt;
        private Button btnClose;
        private Label lblRecieptNo;
        private Label lblDate;
        private Label lblTime;
        private TextBox txtReceiptNo;
        private Label lblDateShow;
        private Label lblTimeShow;
        private Label lblPayementMethod;
        private Label lblPayMethodShow;
    }
}