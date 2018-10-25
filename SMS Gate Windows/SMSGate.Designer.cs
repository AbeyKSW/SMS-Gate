namespace SMS_Gate_Windows
{
    partial class SMSGate
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
            this.lblMessage = new System.Windows.Forms.Label();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.cmbDivCode = new System.Windows.Forms.ComboBox();
            this.lblDivCode = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.grpContactLst = new System.Windows.Forms.GroupBox();
            this.chkContactLst = new System.Windows.Forms.CheckedListBox();
            this.chkGrpSelect = new System.Windows.Forms.CheckedListBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.prBar = new System.Windows.Forms.ProgressBar();
            this.btnSelectDeSelect = new System.Windows.Forms.Button();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.grpContactLst.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(813, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Com Port";
            this.label1.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 148);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(50, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "Message";
            // 
            // cmbPort
            // 
            this.cmbPort.Enabled = false;
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(884, 477);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(177, 21);
            this.cmbPort.TabIndex = 3;
            this.cmbPort.Visible = false;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(92, 145);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(161, 110);
            this.txtMessage.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(415, 230);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(41, 25);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // cmbDivCode
            // 
            this.cmbDivCode.FormattingEnabled = true;
            this.cmbDivCode.Items.AddRange(new object[] {
            "15 Consumer",
            "16 Backery",
            "17 Hardware",
            "18 Pharma",
            "19 Confactionary"});
            this.cmbDivCode.Location = new System.Drawing.Point(92, 11);
            this.cmbDivCode.Name = "cmbDivCode";
            this.cmbDivCode.Size = new System.Drawing.Size(161, 21);
            this.cmbDivCode.TabIndex = 48;
            this.cmbDivCode.SelectedIndexChanged += new System.EventHandler(this.cmbDivCode_SelectedIndexChanged);
            // 
            // lblDivCode
            // 
            this.lblDivCode.AutoSize = true;
            this.lblDivCode.Location = new System.Drawing.Point(9, 14);
            this.lblDivCode.Name = "lblDivCode";
            this.lblDivCode.Size = new System.Drawing.Size(44, 13);
            this.lblDivCode.TabIndex = 47;
            this.lblDivCode.Text = "Division";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(259, 75);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(35, 25);
            this.btnLoad.TabIndex = 46;
            this.btnLoad.Text = ">";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // grpContactLst
            // 
            this.grpContactLst.BackColor = System.Drawing.Color.White;
            this.grpContactLst.Controls.Add(this.chkContactLst);
            this.grpContactLst.Cursor = System.Windows.Forms.Cursors.Default;
            this.grpContactLst.Location = new System.Drawing.Point(300, 11);
            this.grpContactLst.Name = "grpContactLst";
            this.grpContactLst.Size = new System.Drawing.Size(156, 213);
            this.grpContactLst.TabIndex = 45;
            this.grpContactLst.TabStop = false;
            this.grpContactLst.Text = "Contact List";
            // 
            // chkContactLst
            // 
            this.chkContactLst.CheckOnClick = true;
            this.chkContactLst.FormattingEnabled = true;
            this.chkContactLst.Location = new System.Drawing.Point(9, 19);
            this.chkContactLst.Name = "chkContactLst";
            this.chkContactLst.Size = new System.Drawing.Size(141, 184);
            this.chkContactLst.TabIndex = 0;
            // 
            // chkGrpSelect
            // 
            this.chkGrpSelect.CheckOnClick = true;
            this.chkGrpSelect.FormattingEnabled = true;
            this.chkGrpSelect.Items.AddRange(new object[] {
            "Area Manager",
            "Brand Manager",
            "Regional Manager",
            "Test"});
            this.chkGrpSelect.Location = new System.Drawing.Point(92, 75);
            this.chkGrpSelect.Name = "chkGrpSelect";
            this.chkGrpSelect.Size = new System.Drawing.Size(161, 64);
            this.chkGrpSelect.TabIndex = 44;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(9, 75);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(74, 13);
            this.lblGroup.TabIndex = 43;
            this.lblGroup.Text = "Select Groups";
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Location = new System.Drawing.Point(9, 47);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(63, 13);
            this.lblSelectDate.TabIndex = 42;
            this.lblSelectDate.Text = "Select Date";
            // 
            // prBar
            // 
            this.prBar.Location = new System.Drawing.Point(12, 274);
            this.prBar.Name = "prBar";
            this.prBar.Size = new System.Drawing.Size(444, 10);
            this.prBar.TabIndex = 49;
            // 
            // btnSelectDeSelect
            // 
            this.btnSelectDeSelect.Location = new System.Drawing.Point(300, 230);
            this.btnSelectDeSelect.Name = "btnSelectDeSelect";
            this.btnSelectDeSelect.Size = new System.Drawing.Size(109, 25);
            this.btnSelectDeSelect.TabIndex = 41;
            this.btnSelectDeSelect.Text = "Select/Deselect All";
            this.btnSelectDeSelect.UseVisualStyleBackColor = true;
            this.btnSelectDeSelect.Click += new System.EventHandler(this.btnSelectDeSelect_Click);
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(92, 41);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(161, 20);
            this.dtDate.TabIndex = 50;
            this.dtDate.ValueChanged += new System.EventHandler(this.dtDate_ValueChanged);
            // 
            // SMSGate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 298);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.cmbDivCode);
            this.Controls.Add(this.lblDivCode);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.grpContactLst);
            this.Controls.Add(this.chkGrpSelect);
            this.Controls.Add(this.lblGroup);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.prBar);
            this.Controls.Add(this.btnSelectDeSelect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.label1);
            this.Name = "SMSGate";
            this.Text = "SMS Gate";
            this.grpContactLst.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ComboBox cmbDivCode;
        private System.Windows.Forms.Label lblDivCode;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox grpContactLst;
        private System.Windows.Forms.CheckedListBox chkContactLst;
        private System.Windows.Forms.CheckedListBox chkGrpSelect;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.ProgressBar prBar;
        private System.Windows.Forms.Button btnSelectDeSelect;
        private System.Windows.Forms.DateTimePicker dtDate;
    }
}

