namespace TVSChungCu.Forms
{
    partial class frmInformation
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
            this.dgvInformation = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSendInformation = new System.Windows.Forms.Button();
            this.dgvInformationId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformationTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformationDayCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformationState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvInformationStateName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).BeginInit();
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
            this.groupBox1.TabIndex = 2;
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
            // 
            // dgvInformation
            // 
            this.dgvInformation.AllowUserToAddRows = false;
            this.dgvInformation.AllowUserToDeleteRows = false;
            this.dgvInformation.AllowUserToResizeColumns = false;
            this.dgvInformation.AllowUserToResizeRows = false;
            this.dgvInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInformation.BackgroundColor = System.Drawing.Color.White;
            this.dgvInformation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvInformation.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInformation.ColumnHeadersHeight = 26;
            this.dgvInformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInformation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvInformationId,
            this.dgvInformationTitle,
            this.dgvInformationDayCreate,
            this.dgvInformationState,
            this.dgvInformationStateName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInformation.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInformation.EnableHeadersVisualStyles = false;
            this.dgvInformation.Location = new System.Drawing.Point(9, 82);
            this.dgvInformation.Name = "dgvInformation";
            this.dgvInformation.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInformation.RowHeadersWidth = 30;
            this.dgvInformation.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInformation.Size = new System.Drawing.Size(866, 391);
            this.dgvInformation.TabIndex = 5;
            this.dgvInformation.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformation_CellDoubleClick);
            this.dgvInformation.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInformation_CellEnter);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(197, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(9, 479);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 26);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSendInformation
            // 
            this.btnSendInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSendInformation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendInformation.Location = new System.Drawing.Point(93, 479);
            this.btnSendInformation.Name = "btnSendInformation";
            this.btnSendInformation.Size = new System.Drawing.Size(100, 26);
            this.btnSendInformation.TabIndex = 7;
            this.btnSendInformation.Text = "Gửi thông báo";
            this.btnSendInformation.UseVisualStyleBackColor = true;
            this.btnSendInformation.Click += new System.EventHandler(this.btnSendInformation_Click);
            // 
            // dgvInformationId
            // 
            this.dgvInformationId.DataPropertyName = "ID";
            this.dgvInformationId.HeaderText = "Id";
            this.dgvInformationId.Name = "dgvInformationId";
            this.dgvInformationId.Visible = false;
            // 
            // dgvInformationTitle
            // 
            this.dgvInformationTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvInformationTitle.DataPropertyName = "Title";
            this.dgvInformationTitle.HeaderText = "Tiêu đề";
            this.dgvInformationTitle.Name = "dgvInformationTitle";
            this.dgvInformationTitle.ReadOnly = true;
            // 
            // dgvInformationDayCreate
            // 
            this.dgvInformationDayCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvInformationDayCreate.DataPropertyName = "DayCreate";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm";
            this.dgvInformationDayCreate.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInformationDayCreate.HeaderText = "         Ngày tạo";
            this.dgvInformationDayCreate.Name = "dgvInformationDayCreate";
            this.dgvInformationDayCreate.ReadOnly = true;
            this.dgvInformationDayCreate.Width = 120;
            // 
            // dgvInformationState
            // 
            this.dgvInformationState.DataPropertyName = "State";
            this.dgvInformationState.HeaderText = "State";
            this.dgvInformationState.Name = "dgvInformationState";
            this.dgvInformationState.Visible = false;
            // 
            // dgvInformationStateName
            // 
            this.dgvInformationStateName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvInformationStateName.DataPropertyName = "StateName";
            this.dgvInformationStateName.HeaderText = "Trạng thái";
            this.dgvInformationStateName.Name = "dgvInformationStateName";
            this.dgvInformationStateName.ReadOnly = true;
            this.dgvInformationStateName.Width = 120;
            // 
            // frmInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnSendInformation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvInformation);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmInformation";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản lý thông tin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmToolInformation_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmToolInformation_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInformation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvInformation;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSendInformation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformationId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformationTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformationDayCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformationState;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvInformationStateName;
    }
}