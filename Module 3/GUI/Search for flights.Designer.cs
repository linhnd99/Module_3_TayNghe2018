namespace Module_3
{
    partial class frmSearchForLights
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
            this.grbSearchParameters = new System.Windows.Forms.GroupBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.rdOneWay = new System.Windows.Forms.RadioButton();
            this.rdReturn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dpkReturn = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dpkOutbound = new System.Windows.Forms.DateTimePicker();
            this.cbCabinType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvOutboundFlight = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.chkThreeDaysOutbound = new System.Windows.Forms.CheckBox();
            this.chkThreeDaysReturn = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvReturnFlight = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBookingFlight = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbSearchParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundFlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnFlight)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSearchParameters
            // 
            this.grbSearchParameters.Controls.Add(this.btnApply);
            this.grbSearchParameters.Controls.Add(this.rdOneWay);
            this.grbSearchParameters.Controls.Add(this.rdReturn);
            this.grbSearchParameters.Controls.Add(this.label5);
            this.grbSearchParameters.Controls.Add(this.dpkReturn);
            this.grbSearchParameters.Controls.Add(this.label4);
            this.grbSearchParameters.Controls.Add(this.dpkOutbound);
            this.grbSearchParameters.Controls.Add(this.cbCabinType);
            this.grbSearchParameters.Controls.Add(this.label3);
            this.grbSearchParameters.Controls.Add(this.cbTo);
            this.grbSearchParameters.Controls.Add(this.label2);
            this.grbSearchParameters.Controls.Add(this.cbFrom);
            this.grbSearchParameters.Controls.Add(this.label1);
            this.grbSearchParameters.Location = new System.Drawing.Point(12, 12);
            this.grbSearchParameters.Name = "grbSearchParameters";
            this.grbSearchParameters.Size = new System.Drawing.Size(776, 97);
            this.grbSearchParameters.TabIndex = 0;
            this.grbSearchParameters.TabStop = false;
            this.grbSearchParameters.Text = "Search Parameters";
            // 
            // btnApply
            // 
            this.btnApply.Image = global::Module_3.Properties.Resources.search16px;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(682, 56);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 12;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // rdOneWay
            // 
            this.rdOneWay.AutoSize = true;
            this.rdOneWay.Location = new System.Drawing.Point(119, 58);
            this.rdOneWay.Name = "rdOneWay";
            this.rdOneWay.Size = new System.Drawing.Size(67, 17);
            this.rdOneWay.TabIndex = 11;
            this.rdOneWay.TabStop = true;
            this.rdOneWay.Text = "One way";
            this.rdOneWay.UseVisualStyleBackColor = true;
            this.rdOneWay.Click += new System.EventHandler(this.RdOneWay_Click);
            // 
            // rdReturn
            // 
            this.rdReturn.AutoSize = true;
            this.rdReturn.Location = new System.Drawing.Point(9, 58);
            this.rdReturn.Name = "rdReturn";
            this.rdReturn.Size = new System.Drawing.Size(57, 17);
            this.rdReturn.TabIndex = 10;
            this.rdReturn.TabStop = true;
            this.rdReturn.Text = "Return";
            this.rdReturn.UseVisualStyleBackColor = true;
            this.rdReturn.CheckedChanged += new System.EventHandler(this.RdReturn_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(462, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Return";
            // 
            // dpkReturn
            // 
            this.dpkReturn.CustomFormat = "dd/MM/yyyy";
            this.dpkReturn.Location = new System.Drawing.Point(507, 58);
            this.dpkReturn.Name = "dpkReturn";
            this.dpkReturn.Size = new System.Drawing.Size(145, 20);
            this.dpkReturn.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Outbound";
            // 
            // dpkOutbound
            // 
            this.dpkOutbound.CustomFormat = "dd/MM/yyyy";
            this.dpkOutbound.Location = new System.Drawing.Point(285, 58);
            this.dpkOutbound.Name = "dpkOutbound";
            this.dpkOutbound.Size = new System.Drawing.Size(145, 20);
            this.dpkOutbound.TabIndex = 6;
            this.dpkOutbound.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // cbCabinType
            // 
            this.cbCabinType.FormattingEnabled = true;
            this.cbCabinType.Location = new System.Drawing.Point(556, 19);
            this.cbCabinType.Name = "cbCabinType";
            this.cbCabinType.Size = new System.Drawing.Size(121, 21);
            this.cbCabinType.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cabin Type";
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(286, 19);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(121, 21);
            this.cbTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(259, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "To";
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(47, 19);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(121, 21);
            this.cbFrom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // dgvOutboundFlight
            // 
            this.dgvOutboundFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutboundFlight.Location = new System.Drawing.Point(12, 139);
            this.dgvOutboundFlight.Name = "dgvOutboundFlight";
            this.dgvOutboundFlight.ReadOnly = true;
            this.dgvOutboundFlight.Size = new System.Drawing.Size(776, 150);
            this.dgvOutboundFlight.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Outbound flight details:";
            // 
            // chkThreeDaysOutbound
            // 
            this.chkThreeDaysOutbound.AutoSize = true;
            this.chkThreeDaysOutbound.Location = new System.Drawing.Point(595, 115);
            this.chkThreeDaysOutbound.Name = "chkThreeDaysOutbound";
            this.chkThreeDaysOutbound.Size = new System.Drawing.Size(190, 17);
            this.chkThreeDaysOutbound.TabIndex = 3;
            this.chkThreeDaysOutbound.Text = "Display three days before and after";
            this.chkThreeDaysOutbound.UseVisualStyleBackColor = true;
            // 
            // chkThreeDaysReturn
            // 
            this.chkThreeDaysReturn.AutoSize = true;
            this.chkThreeDaysReturn.Location = new System.Drawing.Point(595, 306);
            this.chkThreeDaysReturn.Name = "chkThreeDaysReturn";
            this.chkThreeDaysReturn.Size = new System.Drawing.Size(190, 17);
            this.chkThreeDaysReturn.TabIndex = 6;
            this.chkThreeDaysReturn.Text = "Display three days before and after";
            this.chkThreeDaysReturn.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Return flight details:";
            // 
            // dgvReturnFlight
            // 
            this.dgvReturnFlight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReturnFlight.Location = new System.Drawing.Point(12, 330);
            this.dgvReturnFlight.Name = "dgvReturnFlight";
            this.dgvReturnFlight.ReadOnly = true;
            this.dgvReturnFlight.Size = new System.Drawing.Size(776, 150);
            this.dgvReturnFlight.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBookingFlight);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(234, 493);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Confirm booking for";
            // 
            // btnBookingFlight
            // 
            this.btnBookingFlight.Location = new System.Drawing.Point(128, 27);
            this.btnBookingFlight.Name = "btnBookingFlight";
            this.btnBookingFlight.Size = new System.Drawing.Size(120, 23);
            this.btnBookingFlight.TabIndex = 1;
            this.btnBookingFlight.Text = "Booking Flight";
            this.btnBookingFlight.UseVisualStyleBackColor = true;
            this.btnBookingFlight.Click += new System.EventHandler(this.BtnBookingFlight_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(532, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmSearchForLights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkThreeDaysReturn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvReturnFlight);
            this.Controls.Add(this.chkThreeDaysOutbound);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvOutboundFlight);
            this.Controls.Add(this.grbSearchParameters);
            this.MaximizeBox = false;
            this.Name = "frmSearchForLights";
            this.Text = "Search for flights";
            this.Load += new System.EventHandler(this.FrmSearchForLights_Load);
            this.grbSearchParameters.ResumeLayout(false);
            this.grbSearchParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutboundFlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReturnFlight)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSearchParameters;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rdOneWay;
        private System.Windows.Forms.RadioButton rdReturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpkReturn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpkOutbound;
        private System.Windows.Forms.ComboBox cbCabinType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOutboundFlight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkThreeDaysOutbound;
        private System.Windows.Forms.CheckBox chkThreeDaysReturn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvReturnFlight;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBookingFlight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnExit;
    }
}

