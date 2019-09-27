namespace Module_3.GUI
{
    partial class frmBookingConfirmation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFlightNumberOutboundValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDateOutboundValue = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCabinTypeOutboundValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblToOutboundValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFromOutboundValue = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFlightNumberReturnValue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDateReturnValue = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCabinTypeReturnValue = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblToReturnValue = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblFromReturnValue = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAddPassenger = new System.Windows.Forms.Button();
            this.cbPassportCountry = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassportNumber = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dgvPassgengersList = new System.Windows.Forms.DataGridView();
            this.btnRemovePassenger = new System.Windows.Forms.Button();
            this.btnBackToSearchForFlights = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassgengersList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFlightNumberOutboundValue);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblDateOutboundValue);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCabinTypeOutboundValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblToOutboundValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblFromOutboundValue);
            this.groupBox1.Controls.Add(this.lblFrom);
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(783, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Outbound flight details";
            // 
            // lblFlightNumberOutboundValue
            // 
            this.lblFlightNumberOutboundValue.AutoSize = true;
            this.lblFlightNumberOutboundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberOutboundValue.Location = new System.Drawing.Point(626, 26);
            this.lblFlightNumberOutboundValue.Name = "lblFlightNumberOutboundValue";
            this.lblFlightNumberOutboundValue.Size = new System.Drawing.Size(35, 13);
            this.lblFlightNumberOutboundValue.TabIndex = 5;
            this.lblFlightNumberOutboundValue.Text = "1908";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(550, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Flight number:";
            // 
            // lblDateOutboundValue
            // 
            this.lblDateOutboundValue.AutoSize = true;
            this.lblDateOutboundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateOutboundValue.Location = new System.Drawing.Point(421, 25);
            this.lblDateOutboundValue.Name = "lblDateOutboundValue";
            this.lblDateOutboundValue.Size = new System.Drawing.Size(75, 13);
            this.lblDateOutboundValue.TabIndex = 7;
            this.lblDateOutboundValue.Text = "11/10/2017";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Date:";
            // 
            // lblCabinTypeOutboundValue
            // 
            this.lblCabinTypeOutboundValue.AutoSize = true;
            this.lblCabinTypeOutboundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinTypeOutboundValue.Location = new System.Drawing.Point(243, 25);
            this.lblCabinTypeOutboundValue.Name = "lblCabinTypeOutboundValue";
            this.lblCabinTypeOutboundValue.Size = new System.Drawing.Size(58, 13);
            this.lblCabinTypeOutboundValue.TabIndex = 5;
            this.lblCabinTypeOutboundValue.Text = "Economy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cabin Type:";
            // 
            // lblToOutboundValue
            // 
            this.lblToOutboundValue.AutoSize = true;
            this.lblToOutboundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToOutboundValue.Location = new System.Drawing.Point(117, 26);
            this.lblToOutboundValue.Name = "lblToOutboundValue";
            this.lblToOutboundValue.Size = new System.Drawing.Size(33, 13);
            this.lblToOutboundValue.TabIndex = 3;
            this.lblToOutboundValue.Text = "AUH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To:";
            // 
            // lblFromOutboundValue
            // 
            this.lblFromOutboundValue.AutoSize = true;
            this.lblFromOutboundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromOutboundValue.Location = new System.Drawing.Point(41, 26);
            this.lblFromOutboundValue.Name = "lblFromOutboundValue";
            this.lblFromOutboundValue.Size = new System.Drawing.Size(27, 13);
            this.lblFromOutboundValue.TabIndex = 1;
            this.lblFromOutboundValue.Text = "CAI";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(6, 25);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(33, 13);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFlightNumberReturnValue);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblDateReturnValue);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblCabinTypeReturnValue);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblToReturnValue);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblFromReturnValue);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(5, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Return flight details";
            // 
            // lblFlightNumberReturnValue
            // 
            this.lblFlightNumberReturnValue.AutoSize = true;
            this.lblFlightNumberReturnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightNumberReturnValue.Location = new System.Drawing.Point(626, 26);
            this.lblFlightNumberReturnValue.Name = "lblFlightNumberReturnValue";
            this.lblFlightNumberReturnValue.Size = new System.Drawing.Size(35, 13);
            this.lblFlightNumberReturnValue.TabIndex = 5;
            this.lblFlightNumberReturnValue.Text = "1908";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(550, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Flight number:";
            // 
            // lblDateReturnValue
            // 
            this.lblDateReturnValue.AutoSize = true;
            this.lblDateReturnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateReturnValue.Location = new System.Drawing.Point(421, 25);
            this.lblDateReturnValue.Name = "lblDateReturnValue";
            this.lblDateReturnValue.Size = new System.Drawing.Size(75, 13);
            this.lblDateReturnValue.TabIndex = 7;
            this.lblDateReturnValue.Text = "11/10/2017";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Date:";
            // 
            // lblCabinTypeReturnValue
            // 
            this.lblCabinTypeReturnValue.AutoSize = true;
            this.lblCabinTypeReturnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCabinTypeReturnValue.Location = new System.Drawing.Point(243, 25);
            this.lblCabinTypeReturnValue.Name = "lblCabinTypeReturnValue";
            this.lblCabinTypeReturnValue.Size = new System.Drawing.Size(58, 13);
            this.lblCabinTypeReturnValue.TabIndex = 5;
            this.lblCabinTypeReturnValue.Text = "Economy";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(173, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Cabin Type:";
            // 
            // lblToReturnValue
            // 
            this.lblToReturnValue.AutoSize = true;
            this.lblToReturnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToReturnValue.Location = new System.Drawing.Point(117, 26);
            this.lblToReturnValue.Name = "lblToReturnValue";
            this.lblToReturnValue.Size = new System.Drawing.Size(33, 13);
            this.lblToReturnValue.TabIndex = 3;
            this.lblToReturnValue.Text = "AUH";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(88, 25);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "To:";
            // 
            // lblFromReturnValue
            // 
            this.lblFromReturnValue.AutoSize = true;
            this.lblFromReturnValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromReturnValue.Location = new System.Drawing.Point(41, 26);
            this.lblFromReturnValue.Name = "lblFromReturnValue";
            this.lblFromReturnValue.Size = new System.Drawing.Size(27, 13);
            this.lblFromReturnValue.TabIndex = 1;
            this.lblFromReturnValue.Text = "CAI";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "From:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAddPassenger);
            this.groupBox3.Controls.Add(this.cbPassportCountry);
            this.groupBox3.Controls.Add(this.txtPhone);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtPassportNumber);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txtBirthday);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtLastname);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtFirstname);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(5, 141);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(783, 125);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Passenger details";
            // 
            // btnAddPassenger
            // 
            this.btnAddPassenger.Location = new System.Drawing.Point(576, 96);
            this.btnAddPassenger.Name = "btnAddPassenger";
            this.btnAddPassenger.Size = new System.Drawing.Size(125, 23);
            this.btnAddPassenger.TabIndex = 13;
            this.btnAddPassenger.Text = "Add passenger";
            this.btnAddPassenger.UseVisualStyleBackColor = true;
            this.btnAddPassenger.Click += new System.EventHandler(this.BtnAddPassenger_Click);
            // 
            // cbPassportCountry
            // 
            this.cbPassportCountry.FormattingEnabled = true;
            this.cbPassportCountry.Location = new System.Drawing.Point(344, 60);
            this.cbPassportCountry.Name = "cbPassportCountry";
            this.cbPassportCountry.Size = new System.Drawing.Size(98, 21);
            this.cbPassportCountry.TabIndex = 12;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(576, 62);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(125, 20);
            this.txtPhone.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(254, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Passport country";
            // 
            // txtPassportNumber
            // 
            this.txtPassportNumber.Location = new System.Drawing.Point(114, 62);
            this.txtPassportNumber.Name = "txtPassportNumber";
            this.txtPassportNumber.Size = new System.Drawing.Size(99, 20);
            this.txtPassportNumber.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Passport number";
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(576, 26);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(125, 20);
            this.txtBirthday.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(518, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Birthdate";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(317, 26);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(125, 20);
            this.txtLastname.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Lastname";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(88, 26);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(125, 20);
            this.txtFirstname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Passengers list";
            // 
            // dgvPassgengersList
            // 
            this.dgvPassgengersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPassgengersList.Location = new System.Drawing.Point(14, 296);
            this.dgvPassgengersList.Name = "dgvPassgengersList";
            this.dgvPassgengersList.Size = new System.Drawing.Size(774, 191);
            this.dgvPassgengersList.TabIndex = 11;
            // 
            // btnRemovePassenger
            // 
            this.btnRemovePassenger.Location = new System.Drawing.Point(662, 493);
            this.btnRemovePassenger.Name = "btnRemovePassenger";
            this.btnRemovePassenger.Size = new System.Drawing.Size(124, 23);
            this.btnRemovePassenger.TabIndex = 12;
            this.btnRemovePassenger.Text = "Remove passenger";
            this.btnRemovePassenger.UseVisualStyleBackColor = true;
            // 
            // btnBackToSearchForFlights
            // 
            this.btnBackToSearchForFlights.Location = new System.Drawing.Point(219, 530);
            this.btnBackToSearchForFlights.Name = "btnBackToSearchForFlights";
            this.btnBackToSearchForFlights.Size = new System.Drawing.Size(178, 23);
            this.btnBackToSearchForFlights.TabIndex = 13;
            this.btnBackToSearchForFlights.Text = "Back to search for flights";
            this.btnBackToSearchForFlights.UseVisualStyleBackColor = true;
            this.btnBackToSearchForFlights.Click += new System.EventHandler(this.BtnBackToSearchForFlights_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Location = new System.Drawing.Point(416, 530);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(179, 23);
            this.btnConfirmBooking.TabIndex = 14;
            this.btnConfirmBooking.Text = "Confirm booking";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.BtnConfirmBooking_Click);
            // 
            // frmBookingConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnConfirmBooking);
            this.Controls.Add(this.btnBackToSearchForFlights);
            this.Controls.Add(this.btnRemovePassenger);
            this.Controls.Add(this.dgvPassgengersList);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBookingConfirmation";
            this.Text = "Booking Confirmation";
            this.Load += new System.EventHandler(this.FrmBookingConfirmation_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPassgengersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFlightNumberOutboundValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblDateOutboundValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCabinTypeOutboundValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToOutboundValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFromOutboundValue;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFlightNumberReturnValue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDateReturnValue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCabinTypeReturnValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblToReturnValue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblFromReturnValue;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAddPassenger;
        private System.Windows.Forms.ComboBox cbPassportCountry;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassportNumber;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvPassgengersList;
        private System.Windows.Forms.Button btnRemovePassenger;
        private System.Windows.Forms.Button btnBackToSearchForFlights;
        private System.Windows.Forms.Button btnConfirmBooking;
    }
}