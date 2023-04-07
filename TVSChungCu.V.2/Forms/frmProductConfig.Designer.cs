namespace TVSChungCu.Forms
{
    partial class frmProductConfig
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.dgvProductIDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductNameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvProduct1 = new System.Windows.Forms.DataGridView();
            this.dgvProduct1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1NameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1PossitionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbbZone = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct1)).BeginInit();
            this.SuspendLayout();
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
            this.dgvProductIDProduct,
            this.dgvProductNameProduct});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(7, 34);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.RowHeadersWidth = 30;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.Size = new System.Drawing.Size(366, 470);
            this.dgvProduct.TabIndex = 2;
            this.dgvProduct.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellEnter);
            // 
            // dgvProductIDProduct
            // 
            this.dgvProductIDProduct.DataPropertyName = "IDProduct";
            this.dgvProductIDProduct.HeaderText = "IDProduct";
            this.dgvProductIDProduct.Name = "dgvProductIDProduct";
            this.dgvProductIDProduct.ReadOnly = true;
            this.dgvProductIDProduct.Visible = false;
            // 
            // dgvProductNameProduct
            // 
            this.dgvProductNameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProductNameProduct.DataPropertyName = "NameProduct";
            this.dgvProductNameProduct.HeaderText = "Tài sản, vật tư";
            this.dgvProductNameProduct.Name = "dgvProductNameProduct";
            this.dgvProductNameProduct.ReadOnly = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Navy;
            this.txtSearch.Location = new System.Drawing.Point(7, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(366, 26);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
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
            this.dgvProduct1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProduct1Id,
            this.dgvProduct1IDProduct,
            this.dgvProduct1NameRegion,
            this.dgvProduct1PossitionName,
            this.dgvProduct1NameProduct});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct1.EnableHeadersVisualStyles = false;
            this.dgvProduct1.Location = new System.Drawing.Point(410, 34);
            this.dgvProduct1.Name = "dgvProduct1";
            this.dgvProduct1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProduct1.RowHeadersWidth = 30;
            this.dgvProduct1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct1.Size = new System.Drawing.Size(466, 470);
            this.dgvProduct1.TabIndex = 4;
            this.dgvProduct1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct1_CellEndEdit);
            this.dgvProduct1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct1_CellEnter);
            // 
            // dgvProduct1Id
            // 
            this.dgvProduct1Id.DataPropertyName = "Id";
            this.dgvProduct1Id.HeaderText = "Id";
            this.dgvProduct1Id.Name = "dgvProduct1Id";
            this.dgvProduct1Id.Visible = false;
            this.dgvProduct1Id.Width = 30;
            // 
            // dgvProduct1IDProduct
            // 
            this.dgvProduct1IDProduct.DataPropertyName = "IDProduct";
            this.dgvProduct1IDProduct.HeaderText = "IDProduct";
            this.dgvProduct1IDProduct.Name = "dgvProduct1IDProduct";
            this.dgvProduct1IDProduct.ReadOnly = true;
            this.dgvProduct1IDProduct.Visible = false;
            // 
            // dgvProduct1NameRegion
            // 
            this.dgvProduct1NameRegion.DataPropertyName = "NameRegion";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct1NameRegion.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct1NameRegion.HeaderText = "Khu vực";
            this.dgvProduct1NameRegion.Name = "dgvProduct1NameRegion";
            this.dgvProduct1NameRegion.ReadOnly = true;
            // 
            // dgvProduct1PossitionName
            // 
            this.dgvProduct1PossitionName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dgvProduct1PossitionName.DataPropertyName = "PossitionName";
            this.dgvProduct1PossitionName.HeaderText = "Vị trí, diễn giải";
            this.dgvProduct1PossitionName.MinimumWidth = 120;
            this.dgvProduct1PossitionName.Name = "dgvProduct1PossitionName";
            this.dgvProduct1PossitionName.Width = 120;
            // 
            // dgvProduct1NameProduct
            // 
            this.dgvProduct1NameProduct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvProduct1NameProduct.DataPropertyName = "NameProduct";
            this.dgvProduct1NameProduct.HeaderText = "Tài sản, vật tư";
            this.dgvProduct1NameProduct.Name = "dgvProduct1NameProduct";
            this.dgvProduct1NameProduct.ReadOnly = true;
            // 
            // cbbZone
            // 
            this.cbbZone.BackColor = System.Drawing.Color.White;
            this.cbbZone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbZone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbZone.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbZone.FormattingEnabled = true;
            this.cbbZone.Location = new System.Drawing.Point(410, 6);
            this.cbbZone.Name = "cbbZone";
            this.cbbZone.Size = new System.Drawing.Size(566, 26);
            this.cbbZone.TabIndex = 5;
            this.cbbZone.SelectedIndexChanged += new System.EventHandler(this.cbbZone_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAdd.Location = new System.Drawing.Point(379, 446);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(26, 26);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnDel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDel.Location = new System.Drawing.Point(379, 478);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(26, 26);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "<";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // frmProductConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbbZone);
            this.Controls.Add(this.dgvProduct1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvProduct);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "frmProductConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cấu hình tài sản";
            this.Load += new System.EventHandler(this.frmProductConfig_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProductConfig_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dgvProduct1;
        private System.Windows.Forms.ComboBox cbbZone;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductIDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductNameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1NameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1PossitionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1NameProduct;
    }
}