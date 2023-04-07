namespace TVSChungCu.Forms
{
    partial class FeedBack
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvFeedBack = new System.Windows.Forms.DataGridView();
            this.dgvFeedBackId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFeedBackFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFeedBackSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFeedBackDayCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendInformation = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpDate2);
            this.groupBox1.Controls.Add(this.dtpDate1);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 70);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Thời gian:";
            // 
            // dtpDate2
            // 
            this.dtpDate2.CustomFormat = "dd/MM/yyyy";
            this.dtpDate2.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate2.Location = new System.Drawing.Point(181, 25);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(100, 24);
            this.dtpDate2.TabIndex = 2;
            // 
            // dtpDate1
            // 
            this.dtpDate1.CustomFormat = "dd/MM/yyyy";
            this.dtpDate1.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate1.Location = new System.Drawing.Point(75, 25);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(100, 24);
            this.dtpDate1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Blue;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(802, 24);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 26);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(287, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(560, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // dgvFeedBack
            // 
            this.dgvFeedBack.AllowUserToAddRows = false;
            this.dgvFeedBack.AllowUserToDeleteRows = false;
            this.dgvFeedBack.AllowUserToResizeColumns = false;
            this.dgvFeedBack.AllowUserToResizeRows = false;
            this.dgvFeedBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFeedBack.BackgroundColor = System.Drawing.Color.White;
            this.dgvFeedBack.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvFeedBack.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvFeedBack.ColumnHeadersHeight = 26;
            this.dgvFeedBack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFeedBack.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvFeedBackId,
            this.dgvFeedBackFullName,
            this.dgvFeedBackSubject,
            this.dgvFeedBackDayCreate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFeedBack.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFeedBack.EnableHeadersVisualStyles = false;
            this.dgvFeedBack.Location = new System.Drawing.Point(9, 82);
            this.dgvFeedBack.Name = "dgvFeedBack";
            this.dgvFeedBack.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFeedBack.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFeedBack.RowHeadersWidth = 30;
            this.dgvFeedBack.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFeedBack.Size = new System.Drawing.Size(866, 391);
            this.dgvFeedBack.TabIndex = 8;
            this.dgvFeedBack.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedBack_CellDoubleClick);
            this.dgvFeedBack.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFeedBack_CellEnter);
            // 
            // dgvFeedBackId
            // 
            this.dgvFeedBackId.DataPropertyName = "ID";
            this.dgvFeedBackId.HeaderText = "Id";
            this.dgvFeedBackId.Name = "dgvFeedBackId";
            this.dgvFeedBackId.Visible = false;
            // 
            // dgvFeedBackFullName
            // 
            this.dgvFeedBackFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvFeedBackFullName.DataPropertyName = "FullName";
            this.dgvFeedBackFullName.HeaderText = "Người gửi";
            this.dgvFeedBackFullName.Name = "dgvFeedBackFullName";
            this.dgvFeedBackFullName.Width = 250;
            // 
            // dgvFeedBackSubject
            // 
            this.dgvFeedBackSubject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvFeedBackSubject.DataPropertyName = "Subject";
            this.dgvFeedBackSubject.HeaderText = "Tiêu đề";
            this.dgvFeedBackSubject.Name = "dgvFeedBackSubject";
            this.dgvFeedBackSubject.ReadOnly = true;
            // 
            // dgvFeedBackDayCreate
            // 
            this.dgvFeedBackDayCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvFeedBackDayCreate.DataPropertyName = "DayCreate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            this.dgvFeedBackDayCreate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFeedBackDayCreate.HeaderText = "         Ngày tạo";
            this.dgvFeedBackDayCreate.Name = "dgvFeedBackDayCreate";
            this.dgvFeedBackDayCreate.ReadOnly = true;
            this.dgvFeedBackDayCreate.Width = 120;
            // 
            // btnSendInformation
            // 
            this.btnSendInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendInformation.Location = new System.Drawing.Point(9, 479);
            this.btnSendInformation.Name = "btnSendInformation";
            this.btnSendInformation.Size = new System.Drawing.Size(111, 26);
            this.btnSendInformation.TabIndex = 9;
            this.btnSendInformation.Text = "Xem và phản hồi";
            this.btnSendInformation.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(126, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FeedBack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnSendInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvFeedBack);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FeedBack";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phản hồi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FeedBack_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FeedBack_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFeedBack)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvFeedBack;
        private System.Windows.Forms.Button btnSendInformation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFeedBackId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFeedBackFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFeedBackSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvFeedBackDayCreate;
    }
}