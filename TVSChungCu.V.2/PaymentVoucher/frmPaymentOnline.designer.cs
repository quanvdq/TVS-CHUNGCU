namespace TVSMain
{
    partial class frmPaymentOnline
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
        /// 


        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPaymentOnline));
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillNameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillMoneyService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillMoneyPayService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillMoneyDebtBalancer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillPaymentByMomoTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBillNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtDaThanhToan = new System.Windows.Forms.TextBox();
            this.txtTienNo = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBill
            // 
            this.dgvBill.AllowUserToAddRows = false;
            this.dgvBill.AllowUserToDeleteRows = false;
            this.dgvBill.AllowUserToResizeColumns = false;
            this.dgvBill.AllowUserToResizeRows = false;
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.BackgroundColor = System.Drawing.Color.White;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBill.ColumnHeadersHeight = 26;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.dgvBillNameRoom,
            this.dgvBillContactPerson,
            this.dgvBillMoneyService,
            this.dgvBillMoneyPayService,
            this.dgvBillMoneyDebtBalancer,
            this.dgvBillPaymentByMomoTime,
            this.dgvBillNote});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBill.EnableHeadersVisualStyles = false;
            this.dgvBill.Location = new System.Drawing.Point(6, 72);
            this.dgvBill.MultiSelect = false;
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvBill.RowHeadersWidth = 30;
            this.dgvBill.RowTemplate.Height = 24;
            this.dgvBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBill.Size = new System.Drawing.Size(972, 399);
            this.dgvBill.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dtpFrom);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(972, 60);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Thời gian:";
            // 
            // dtpTo
            // 
            this.dtpTo.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpTo.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpTo.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(248, 21);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(150, 23);
            this.dtpTo.TabIndex = 6;
            // 
            // dtpFrom
            // 
            this.dtpFrom.CalendarFont = new System.Drawing.Font("Arial", 10F);
            this.dtpFrom.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFrom.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFrom.Location = new System.Drawing.Point(83, 21);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(150, 23);
            this.dtpFrom.TabIndex = 5;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(919, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 19);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "TÌM";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.txtSearch.Location = new System.Drawing.Point(516, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(445, 23);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(110, 477);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 28);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportExcel.Location = new System.Drawing.Point(6, 477);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(102, 28);
            this.btnExportExcel.TabIndex = 19;
            this.btnExportExcel.Text = "Xuất file Excel";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MyIndex";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column1.HeaderText = "  STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // dgvBillNameRoom
            // 
            this.dgvBillNameRoom.DataPropertyName = "NameRoom";
            this.dgvBillNameRoom.HeaderText = "Phòng, căn hộ";
            this.dgvBillNameRoom.Name = "dgvBillNameRoom";
            this.dgvBillNameRoom.ReadOnly = true;
            // 
            // dgvBillContactPerson
            // 
            this.dgvBillContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvBillContactPerson.DataPropertyName = "ContactPerson";
            this.dgvBillContactPerson.HeaderText = "Khách hàng";
            this.dgvBillContactPerson.Name = "dgvBillContactPerson";
            this.dgvBillContactPerson.ReadOnly = true;
            this.dgvBillContactPerson.Width = 235;
            // 
            // dgvBillMoneyService
            // 
            this.dgvBillMoneyService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvBillMoneyService.DataPropertyName = "MoneyService";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.dgvBillMoneyService.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBillMoneyService.HeaderText = "       Tổng tiền";
            this.dgvBillMoneyService.Name = "dgvBillMoneyService";
            this.dgvBillMoneyService.ReadOnly = true;
            // 
            // dgvBillMoneyPayService
            // 
            this.dgvBillMoneyPayService.DataPropertyName = "MoneyPayService";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.dgvBillMoneyPayService.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvBillMoneyPayService.HeaderText = "  Đã thanh toán";
            this.dgvBillMoneyPayService.Name = "dgvBillMoneyPayService";
            this.dgvBillMoneyPayService.ReadOnly = true;
            // 
            // dgvBillMoneyDebtBalancer
            // 
            this.dgvBillMoneyDebtBalancer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvBillMoneyDebtBalancer.DataPropertyName = "MoneyDebtBalancer";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.Format = "N0";
            dataGridViewCellStyle4.NullValue = null;
            this.dgvBillMoneyDebtBalancer.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBillMoneyDebtBalancer.HeaderText = "       Tiền nợ";
            this.dgvBillMoneyDebtBalancer.Name = "dgvBillMoneyDebtBalancer";
            this.dgvBillMoneyDebtBalancer.ReadOnly = true;
            // 
            // dgvBillPaymentByMomoTime
            // 
            this.dgvBillPaymentByMomoTime.DataPropertyName = "PaymentByMomoTime";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "dd/MM/yyyy HH:mm:ss";
            this.dgvBillPaymentByMomoTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBillPaymentByMomoTime.HeaderText = "Ngày thanh toán";
            this.dgvBillPaymentByMomoTime.Name = "dgvBillPaymentByMomoTime";
            this.dgvBillPaymentByMomoTime.ReadOnly = true;
            this.dgvBillPaymentByMomoTime.Width = 125;
            // 
            // dgvBillNote
            // 
            this.dgvBillNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvBillNote.DataPropertyName = "Note";
            this.dgvBillNote.HeaderText = "Ghi chú";
            this.dgvBillNote.Name = "dgvBillNote";
            this.dgvBillNote.ReadOnly = true;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTongTien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(421, 481);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(100, 21);
            this.txtTongTien.TabIndex = 20;
            this.txtTongTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDaThanhToan
            // 
            this.txtDaThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDaThanhToan.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDaThanhToan.Location = new System.Drawing.Point(522, 481);
            this.txtDaThanhToan.Name = "txtDaThanhToan";
            this.txtDaThanhToan.ReadOnly = true;
            this.txtDaThanhToan.Size = new System.Drawing.Size(100, 21);
            this.txtDaThanhToan.TabIndex = 21;
            this.txtDaThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTienNo
            // 
            this.txtTienNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtTienNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienNo.Location = new System.Drawing.Point(623, 481);
            this.txtTienNo.Name = "txtTienNo";
            this.txtTienNo.ReadOnly = true;
            this.txtTienNo.Size = new System.Drawing.Size(99, 21);
            this.txtTienNo.TabIndex = 22;
            this.txtTienNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(723, 481);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(255, 21);
            this.textBox1.TabIndex = 23;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(187, 481);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(232, 21);
            this.textBox2.TabIndex = 24;
            this.textBox2.Text = "TỔNG";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(402, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Nội dung tìm kiếm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "-";
            // 
            // frmPaymentOnline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.ControlBox = false;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtTienNo);
            this.Controls.Add(this.txtDaThanhToan);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvBill);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPaymentOnline";
            this.Text = "QUẢN LÝ THU CHI TIỀN MẶT";
            this.Load += new System.EventHandler(this.frmPaymentOnline_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPaymentOnline_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillNameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillMoneyService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillMoneyPayService;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillMoneyDebtBalancer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillPaymentByMomoTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvBillNote;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtDaThanhToan;
        private System.Windows.Forms.TextBox txtTienNo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

