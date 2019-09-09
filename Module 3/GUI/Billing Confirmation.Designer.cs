namespace Module_3.GUI
{
    partial class frmBillingConfirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalMountValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdCreaditCard = new System.Windows.Forms.RadioButton();
            this.rdCash = new System.Windows.Forms.RadioButton();
            this.rdVoucher = new System.Windows.Forms.RadioButton();
            this.btnIssueTickets = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total amount:";
            // 
            // lblTotalMountValue
            // 
            this.lblTotalMountValue.AutoSize = true;
            this.lblTotalMountValue.Location = new System.Drawing.Point(171, 44);
            this.lblTotalMountValue.Name = "lblTotalMountValue";
            this.lblTotalMountValue.Size = new System.Drawing.Size(73, 13);
            this.lblTotalMountValue.TabIndex = 1;
            this.lblTotalMountValue.Text = "[ $ xxxxxxxxx ]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Paid using:";
            // 
            // rdCreaditCard
            // 
            this.rdCreaditCard.AutoSize = true;
            this.rdCreaditCard.Location = new System.Drawing.Point(118, 108);
            this.rdCreaditCard.Name = "rdCreaditCard";
            this.rdCreaditCard.Size = new System.Drawing.Size(83, 17);
            this.rdCreaditCard.TabIndex = 3;
            this.rdCreaditCard.TabStop = true;
            this.rdCreaditCard.Text = "Creadit Card";
            this.rdCreaditCard.UseVisualStyleBackColor = true;
            // 
            // rdCash
            // 
            this.rdCash.AutoSize = true;
            this.rdCash.Location = new System.Drawing.Point(118, 131);
            this.rdCash.Name = "rdCash";
            this.rdCash.Size = new System.Drawing.Size(49, 17);
            this.rdCash.TabIndex = 4;
            this.rdCash.TabStop = true;
            this.rdCash.Text = "Cash";
            this.rdCash.UseVisualStyleBackColor = true;
            // 
            // rdVoucher
            // 
            this.rdVoucher.AutoSize = true;
            this.rdVoucher.Location = new System.Drawing.Point(118, 154);
            this.rdVoucher.Name = "rdVoucher";
            this.rdVoucher.Size = new System.Drawing.Size(65, 17);
            this.rdVoucher.TabIndex = 5;
            this.rdVoucher.TabStop = true;
            this.rdVoucher.Text = "Voucher";
            this.rdVoucher.UseVisualStyleBackColor = true;
            // 
            // btnIssueTickets
            // 
            this.btnIssueTickets.Location = new System.Drawing.Point(53, 194);
            this.btnIssueTickets.Name = "btnIssueTickets";
            this.btnIssueTickets.Size = new System.Drawing.Size(99, 23);
            this.btnIssueTickets.TabIndex = 6;
            this.btnIssueTickets.Text = "Issue tickets";
            this.btnIssueTickets.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(158, 194);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // frmBillingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnIssueTickets);
            this.Controls.Add(this.rdVoucher);
            this.Controls.Add(this.rdCash);
            this.Controls.Add(this.rdCreaditCard);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTotalMountValue);
            this.Controls.Add(this.label1);
            this.Name = "frmBillingConfirmation";
            this.Text = "Billing Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalMountValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdCreaditCard;
        private System.Windows.Forms.RadioButton rdCash;
        private System.Windows.Forms.RadioButton rdVoucher;
        private System.Windows.Forms.Button btnIssueTickets;
        private System.Windows.Forms.Button btnCancel;
    }
}