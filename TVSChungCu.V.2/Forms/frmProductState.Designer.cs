namespace TVSChungCu.Forms
{
    partial class frmProductState
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblnfomation = new System.Windows.Forms.Label();
            this.dtpDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtpDate1 = new System.Windows.Forms.DateTimePicker();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductProductReleaseId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductTypeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductDayCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.dtpDayCreate = new System.Windows.Forms.DateTimePicker();
            this.btnState = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblProductCode);
            this.groupBox1.Controls.Add(this.lblnfomation);
            this.groupBox1.Controls.Add(this.dtpDate2);
            this.groupBox1.Controls.Add(this.dtpDate1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
            // 
            // lblProductCode
            // 
            this.lblProductCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductCode.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductCode.Location = new System.Drawing.Point(227, 23);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(100, 23);
            this.lblProductCode.TabIndex = 7;
            this.lblProductCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnfomation
            // 
            this.lblnfomation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblnfomation.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnfomation.Location = new System.Drawing.Point(331, 23);
            this.lblnfomation.Name = "lblnfomation";
            this.lblnfomation.Size = new System.Drawing.Size(331, 23);
            this.lblnfomation.TabIndex = 6;
            this.lblnfomation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtpDate2
            // 
            this.dtpDate2.CustomFormat = "dd/MM/yyyy";
            this.dtpDate2.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate2.Location = new System.Drawing.Point(121, 22);
            this.dtpDate2.Name = "dtpDate2";
            this.dtpDate2.Size = new System.Drawing.Size(100, 24);
            this.dtpDate2.TabIndex = 3;
            // 
            // dtpDate1
            // 
            this.dtpDate1.CustomFormat = "dd/MM/yyyy";
            this.dtpDate1.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate1.Location = new System.Drawing.Point(15, 22);
            this.dtpDate1.Name = "dtpDate1";
            this.dtpDate1.Size = new System.Drawing.Size(100, 24);
            this.dtpDate1.TabIndex = 2;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.AllowUserToResizeColumns = false;
            this.dgvProduct.AllowUserToResizeRows = false;
            this.dgvProduct.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvProduct.BackgroundColor = System.Drawing.Color.White;
            this.dgvProduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvProduct.ColumnHeadersHeight = 26;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductId,
            this.dgvProductProductReleaseId,
            this.dgvProductTypeId,
            this.dgvProductTypeName,
            this.dgvProductNote,
            this.dgvProductDayCreate});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(6, 72);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvProduct.RowHeadersWidth = 30;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(670, 254);
            this.dgvProduct.TabIndex = 3;
            // 
            // dgvProductId
            // 
            this.dgvProductId.DataPropertyName = "Id";
            this.dgvProductId.HeaderText = "Id";
            this.dgvProductId.Name = "dgvProductId";
            this.dgvProductId.Visible = false;
            // 
            // dgvProductProductReleaseId
            // 
            this.dgvProductProductReleaseId.DataPropertyName = "ProductReleaseId";
            this.dgvProductProductReleaseId.HeaderText = "ProductReleaseId";
            this.dgvProductProductReleaseId.Name = "dgvProductProductReleaseId";
            this.dgvProductProductReleaseId.Visible = false;
            // 
            // dgvProductTypeId
            // 
            this.dgvProductTypeId.DataPropertyName = "TypeId";
            this.dgvProductTypeId.HeaderText = "TypeId";
            this.dgvProductTypeId.Name = "dgvProductTypeId";
            this.dgvProductTypeId.Visible = false;
            // 
            // dgvProductTypeName
            // 
            this.dgvProductTypeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvProductTypeName.DataPropertyName = "TypeName";
            this.dgvProductTypeName.HeaderText = "Trạng thái";
            this.dgvProductTypeName.Name = "dgvProductTypeName";
            this.dgvProductTypeName.Width = 120;
            // 
            // dgvProductNote
            // 
            this.dgvProductNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductNote.DataPropertyName = "Note";
            this.dgvProductNote.HeaderText = "Ghi chú";
            this.dgvProductNote.Name = "dgvProductNote";
            // 
            // dgvProductDayCreate
            // 
            this.dgvProductDayCreate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvProductDayCreate.DataPropertyName = "DayCreate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "dd/MM/yyyy";
            this.dgvProductDayCreate.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductDayCreate.HeaderText = "Ngày cập nhật";
            this.dgvProductDayCreate.Name = "dgvProductDayCreate";
            this.dgvProductDayCreate.Width = 95;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.cbbType);
            this.groupBox2.Controls.Add(this.dtpDayCreate);
            this.groupBox2.Location = new System.Drawing.Point(6, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 110);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tình trạng tài sản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ghi chú:";
            // 
            // txtNote
            // 
            this.txtNote.Enabled = false;
            this.txtNote.Location = new System.Drawing.Point(121, 52);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(536, 46);
            this.txtNote.TabIndex = 4;
            // 
            // cbbType
            // 
            this.cbbType.BackColor = System.Drawing.Color.White;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.Enabled = false;
            this.cbbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Tài sản bình thường",
            "Tài sản hỏng",
            "Tài sản được thay",
            "Tài sản được sửa",
            "Tài sản được bảo dưỡng"});
            this.cbbType.Location = new System.Drawing.Point(121, 22);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(536, 26);
            this.cbbType.TabIndex = 3;
            // 
            // dtpDayCreate
            // 
            this.dtpDayCreate.CustomFormat = "dd/MM/yyyy";
            this.dtpDayCreate.Enabled = false;
            this.dtpDayCreate.Font = new System.Drawing.Font("Arial", 11F);
            this.dtpDayCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDayCreate.Location = new System.Drawing.Point(15, 22);
            this.dtpDayCreate.Name = "dtpDayCreate";
            this.dtpDayCreate.Size = new System.Drawing.Size(100, 24);
            this.dtpDayCreate.TabIndex = 2;
            // 
            // btnState
            // 
            this.btnState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnState.Enabled = false;
            this.btnState.Location = new System.Drawing.Point(127, 448);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(80, 26);
            this.btnState.TabIndex = 6;
            this.btnState.Text = "Ghi nhận";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(211, 448);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Location = new System.Drawing.Point(6, 448);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 26);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmProductState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(700, 520);
            this.MinimumSize = new System.Drawing.Size(700, 520);
            this.Name = "frmProductState";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tình trạng vật tư";
            this.Load += new System.EventHandler(this.frmProductState_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductState_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpDate1;
        private System.Windows.Forms.DateTimePicker dtpDate2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpDayCreate;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.Button btnClose;
        public System.Windows.Forms.Label lblnfomation;
        public System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductProductReleaseId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductTypeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductTypeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductDayCreate;
        private System.Windows.Forms.Button btnAdd;
    }
}