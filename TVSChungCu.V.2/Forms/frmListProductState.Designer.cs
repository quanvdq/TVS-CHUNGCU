namespace TVSChungCu.Forms
{
    partial class frmListProductState
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbZone = new System.Windows.Forms.ComboBox();
            this.dgvProduct1 = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProductConfig = new System.Windows.Forms.Button();
            this.dgvProduct1PossitionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct1)).BeginInit();
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
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbZone);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 70);
            this.groupBox1.TabIndex = 1;
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
            this.dtpDate2.TabIndex = 5;
            // 
            // dtpDate1
            // 
            this.dtpDate1.CustomFormat = "dd/MM/yyyy";
            this.dtpDate1.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate1.Location = new System.Drawing.Point(75, 25);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(100, 24);
            this.dtpDate1.TabIndex = 4;
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
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(601, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(246, 26);
            this.txtSearch.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Khu vực:";
            // 
            // cbbZone
            // 
            this.cbbZone.BackColor = System.Drawing.Color.White;
            this.cbbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbZone.FormattingEnabled = true;
            this.cbbZone.Location = new System.Drawing.Point(345, 24);
            this.cbbZone.Name = "cbbZone";
            this.cbbZone.Size = new System.Drawing.Size(250, 26);
            this.cbbZone.TabIndex = 1;
            this.cbbZone.SelectedIndexChanged += new System.EventHandler(this.cbbZone_SelectedIndexChanged);
            // 
            // dgvProduct1
            // 
            this.dgvProduct1.AllowUserToAddRows = false;
            this.dgvProduct1.AllowUserToDeleteRows = false;
            this.dgvProduct1.AllowUserToResizeColumns = false;
            this.dgvProduct1.AllowUserToResizeRows = false;
            this.dgvProduct1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProduct1.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduct1.ColumnHeadersHeight = 26;
            this.dgvProduct1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProduct1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProduct1PossitionName,
            this.dgvProduct1NameProduct,
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct1.EnableHeadersVisualStyles = false;
            this.dgvProduct1.Location = new System.Drawing.Point(9, 82);
            this.dgvProduct1.Name = "dgvProduct1";
            this.dgvProduct1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct1.RowHeadersWidth = 30;
            this.dgvProduct1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct1.Size = new System.Drawing.Size(866, 391);
            this.dgvProduct1.TabIndex = 5;
            this.dgvProduct1.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvProduct1_RowPrePaint);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(108, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnProductConfig
            // 
            this.btnProductConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProductConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductConfig.Location = new System.Drawing.Point(9, 479);
            this.btnProductConfig.Name = "btnProductConfig";
            this.btnProductConfig.Size = new System.Drawing.Size(96, 26);
            this.btnProductConfig.TabIndex = 8;
            this.btnProductConfig.Text = "Xuất file Excel";
            this.btnProductConfig.UseVisualStyleBackColor = true;
            // 
            // dgvProduct1PossitionName
            // 
            this.dgvProduct1PossitionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvProduct1PossitionName.DataPropertyName = "PossitionName";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct1PossitionName.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct1PossitionName.HeaderText = "Số hiệu, vị trí";
            this.dgvProduct1PossitionName.Name = "dgvProduct1PossitionName";
            this.dgvProduct1PossitionName.ReadOnly = true;
            // 
            // dgvProduct1NameProduct
            // 
            this.dgvProduct1NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvProduct1NameProduct.DataPropertyName = "NameProduct";
            this.dgvProduct1NameProduct.HeaderText = "Tài sản, vật tư";
            this.dgvProduct1NameProduct.Name = "dgvProduct1NameProduct";
            this.dgvProduct1NameProduct.ReadOnly = true;
            this.dgvProduct1NameProduct.Width = 250;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "TypeName";
            this.Column1.HeaderText = "Trạng thái";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Note";
            this.Column2.HeaderText = "Nội dung";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column3.DataPropertyName = "DayCreate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Ngày cập nhật";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 90;
            // 
            // frmListProductState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProductConfig);
            this.Controls.Add(this.dgvProduct1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmListProductState";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo cáo tình trạng tài sản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListProductState_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListProductState_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbZone;
        private System.Windows.Forms.DataGridView dgvProduct1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProductConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1PossitionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}