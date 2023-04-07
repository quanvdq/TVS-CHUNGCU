namespace TVSSys
{
    partial class FrmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConfig));
            this.btnAllExit = new System.Windows.Forms.Button();
            this.btnAllUpdate = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkWarningRoom = new System.Windows.Forms.CheckBox();
            this.TxtWarningRoomStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbbReportPayment = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbbReportNotify = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAutobackup = new System.Windows.Forms.CheckBox();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabCodeID = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabCodeID.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAllExit
            // 
            this.btnAllExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAllExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllExit.Location = new System.Drawing.Point(394, 262);
            this.btnAllExit.Name = "btnAllExit";
            this.btnAllExit.Size = new System.Drawing.Size(80, 28);
            this.btnAllExit.TabIndex = 1;
            this.btnAllExit.Text = "Th&oát";
            this.btnAllExit.UseVisualStyleBackColor = true;
            this.btnAllExit.Click += new System.EventHandler(this.btnAllExit_Click);
            // 
            // btnAllUpdate
            // 
            this.btnAllUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAllUpdate.Location = new System.Drawing.Point(308, 262);
            this.btnAllUpdate.Name = "btnAllUpdate";
            this.btnAllUpdate.Size = new System.Drawing.Size(80, 28);
            this.btnAllUpdate.TabIndex = 2;
            this.btnAllUpdate.Text = "Cập nhật";
            this.btnAllUpdate.UseVisualStyleBackColor = true;
            this.btnAllUpdate.Click += new System.EventHandler(this.btnAllUpdate_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(456, 216);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cấu hình chung";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkWarningRoom);
            this.groupBox4.Controls.Add(this.TxtWarningRoomStatus);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(6, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(444, 63);
            this.groupBox4.TabIndex = 99;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sao lưu dữ liệu  ";
            // 
            // chkWarningRoom
            // 
            this.chkWarningRoom.AutoSize = true;
            this.chkWarningRoom.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkWarningRoom.Location = new System.Drawing.Point(37, 29);
            this.chkWarningRoom.Name = "chkWarningRoom";
            this.chkWarningRoom.Size = new System.Drawing.Size(201, 19);
            this.chkWarningRoom.TabIndex = 93;
            this.chkWarningRoom.Text = "Hiện cảnh báo trạng thái phòng";
            this.chkWarningRoom.UseVisualStyleBackColor = true;
            // 
            // TxtWarningRoomStatus
            // 
            this.TxtWarningRoomStatus.Location = new System.Drawing.Point(341, 27);
            this.TxtWarningRoomStatus.Name = "TxtWarningRoomStatus";
            this.TxtWarningRoomStatus.Size = new System.Drawing.Size(95, 21);
            this.TxtWarningRoomStatus.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(263, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 95;
            this.label1.Text = "Nội dung : ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbbReportPayment);
            this.groupBox3.Location = new System.Drawing.Point(235, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 63);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mẫu phiếu thu chi   ";
            // 
            // cbbReportPayment
            // 
            this.cbbReportPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReportPayment.FormattingEnabled = true;
            this.cbbReportPayment.Items.AddRange(new object[] {
            "Mẫu A5",
            "Mẫu A5 2 liên",
            "Mẫu A4",
            "Mẫu A4 2 liên"});
            this.cbbReportPayment.Location = new System.Drawing.Point(37, 30);
            this.cbbReportPayment.Name = "cbbReportPayment";
            this.cbbReportPayment.Size = new System.Drawing.Size(170, 23);
            this.cbbReportPayment.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbReportNotify);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 63);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mẫu giấy thông báo   ";
            // 
            // cbbReportNotify
            // 
            this.cbbReportNotify.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbReportNotify.FormattingEnabled = true;
            this.cbbReportNotify.Items.AddRange(new object[] {
            "Mẫu A5",
            "Mẫu A4"});
            this.cbbReportNotify.Location = new System.Drawing.Point(37, 30);
            this.cbbReportNotify.Name = "cbbReportNotify";
            this.cbbReportNotify.Size = new System.Drawing.Size(170, 23);
            this.cbbReportNotify.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAutobackup);
            this.groupBox1.Controls.Add(this.txtCount);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(6, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 63);
            this.groupBox1.TabIndex = 96;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sao lưu dữ liệu  ";
            // 
            // chkAutobackup
            // 
            this.chkAutobackup.AutoSize = true;
            this.chkAutobackup.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAutobackup.Location = new System.Drawing.Point(37, 29);
            this.chkAutobackup.Name = "chkAutobackup";
            this.chkAutobackup.Size = new System.Drawing.Size(199, 19);
            this.chkAutobackup.TabIndex = 93;
            this.chkAutobackup.Text = "Tự động sao lưu khi khởi động";
            this.chkAutobackup.UseVisualStyleBackColor = true;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(341, 28);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(95, 21);
            this.txtCount.TabIndex = 94;
            this.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label15.Location = new System.Drawing.Point(263, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 15);
            this.label15.TabIndex = 95;
            this.label15.Text = "Số file lưu : ";
            // 
            // tabCodeID
            // 
            this.tabCodeID.Controls.Add(this.tabPage1);
            this.tabCodeID.Controls.Add(this.tabPage2);
            this.tabCodeID.Location = new System.Drawing.Point(10, 12);
            this.tabCodeID.Name = "tabCodeID";
            this.tabCodeID.SelectedIndex = 0;
            this.tabCodeID.Size = new System.Drawing.Size(464, 244);
            this.tabCodeID.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.c1TrueDBGrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(456, 216);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cấu hình thông số";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.c1TrueDBGrid1.AlternatingRows = true;
            this.c1TrueDBGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TrueDBGrid1.BackColor = System.Drawing.Color.White;
            this.c1TrueDBGrid1.CaptionHeight = 17;
            this.c1TrueDBGrid1.CollapseColor = System.Drawing.Color.Empty;
            this.c1TrueDBGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c1TrueDBGrid1.ExpandColor = System.Drawing.Color.Empty;
            this.c1TrueDBGrid1.ExtendRightColumn = true;
            this.c1TrueDBGrid1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(3, 4);
            this.c1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.c1TrueDBGrid1.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.RecordSelectors = false;
            this.c1TrueDBGrid1.RowHeight = 45;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(450, 209);
            this.c1TrueDBGrid1.TabIndex = 1;
            this.c1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid1.WrapCellPointer = true;
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // FrmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAllExit;
            this.ClientSize = new System.Drawing.Size(481, 299);
            this.ControlBox = false;
            this.Controls.Add(this.btnAllUpdate);
            this.Controls.Add(this.btnAllExit);
            this.Controls.Add(this.tabCodeID);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(497, 338);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(497, 338);
            this.Name = "FrmConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " .:: CẤU HÌNH HỆ THỐNG ::.";
            this.Load += new System.EventHandler(this.FrmCongif_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCongif_KeyDown);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabCodeID.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAllExit;
        private System.Windows.Forms.Button btnAllUpdate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabCodeID;
        private System.Windows.Forms.TabPage tabPage2;
        public C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.CheckBox chkAutobackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbbReportPayment;
        private System.Windows.Forms.ComboBox cbbReportNotify;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkWarningRoom;
        private System.Windows.Forms.TextBox TxtWarningRoomStatus;
        private System.Windows.Forms.Label label1;

    }
}