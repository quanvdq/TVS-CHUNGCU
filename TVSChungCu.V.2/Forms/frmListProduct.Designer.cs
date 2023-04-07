namespace TVSChungCu.Forms
{
    partial class frmListProduct
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbZone = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBuilding = new System.Windows.Forms.ComboBox();
            this.btnProductConfig = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvProduct1 = new System.Windows.Forms.DataGridView();
            this.btnState = new System.Windows.Forms.Button();
            this.ctmProduct = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctmProduct_State = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmProduct_Config = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProduct1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1IDProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1NameRegion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1PossitionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProduct1NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct1)).BeginInit();
            this.ctmProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbbZone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbBuilding);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(866, 70);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm";
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
            this.txtSearch.Location = new System.Drawing.Point(570, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRoom_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 30);
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
            this.cbbZone.Location = new System.Drawing.Point(314, 24);
            this.cbbZone.Name = "cbbZone";
            this.cbbZone.Size = new System.Drawing.Size(250, 26);
            this.cbbZone.TabIndex = 1;
            this.cbbZone.SelectedIndexChanged += new System.EventHandler(this.cbbZone_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tòa nhà:";
            // 
            // cbbBuilding
            // 
            this.cbbBuilding.BackColor = System.Drawing.Color.White;
            this.cbbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbBuilding.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBuilding.FormattingEnabled = true;
            this.cbbBuilding.Items.AddRange(new object[] {
            "Mặc định"});
            this.cbbBuilding.Location = new System.Drawing.Point(86, 24);
            this.cbbBuilding.Name = "cbbBuilding";
            this.cbbBuilding.Size = new System.Drawing.Size(164, 26);
            this.cbbBuilding.TabIndex = 0;
            // 
            // btnProductConfig
            // 
            this.btnProductConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnProductConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductConfig.Location = new System.Drawing.Point(9, 479);
            this.btnProductConfig.Name = "btnProductConfig";
            this.btnProductConfig.Size = new System.Drawing.Size(75, 26);
            this.btnProductConfig.TabIndex = 5;
            this.btnProductConfig.Text = "Cấu hình";
            this.btnProductConfig.UseVisualStyleBackColor = true;
            this.btnProductConfig.Click += new System.EventHandler(this.btnProductConfig_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(165, 479);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.dgvProduct1Id,
            this.dgvProduct1IDProduct,
            this.dgvProduct1NameRegion,
            this.dgvProduct1PossitionName,
            this.dgvProduct1NameProduct});
            this.dgvProduct1.ContextMenuStrip = this.ctmProduct;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct1.EnableHeadersVisualStyles = false;
            this.dgvProduct1.Location = new System.Drawing.Point(9, 82);
            this.dgvProduct1.Name = "dgvProduct1";
            this.dgvProduct1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct1.RowHeadersWidth = 30;
            this.dgvProduct1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct1.Size = new System.Drawing.Size(866, 391);
            this.dgvProduct1.TabIndex = 4;
            this.dgvProduct1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct1_CellEnter);
            // 
            // btnState
            // 
            this.btnState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnState.Location = new System.Drawing.Point(87, 479);
            this.btnState.Name = "btnState";
            this.btnState.Size = new System.Drawing.Size(75, 26);
            this.btnState.TabIndex = 6;
            this.btnState.Text = "Tình trạng";
            this.btnState.UseVisualStyleBackColor = true;
            this.btnState.Click += new System.EventHandler(this.btnState_Click);
            // 
            // ctmProduct
            // 
            this.ctmProduct.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctmProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctmProduct_State,
            this.ctmProduct_Config});
            this.ctmProduct.Name = "ctmProduct";
            this.ctmProduct.Size = new System.Drawing.Size(130, 48);
            // 
            // ctmProduct_State
            // 
            this.ctmProduct_State.Name = "ctmProduct_State";
            this.ctmProduct_State.Size = new System.Drawing.Size(129, 22);
            this.ctmProduct_State.Text = "Trạng thái";
            this.ctmProduct_State.Click += new System.EventHandler(this.ctmProduct_State_Click);
            // 
            // ctmProduct_Config
            // 
            this.ctmProduct_Config.Name = "ctmProduct_Config";
            this.ctmProduct_Config.Size = new System.Drawing.Size(129, 22);
            this.ctmProduct_Config.Text = "Cấu hình";
            this.ctmProduct_Config.Click += new System.EventHandler(this.ctmProduct_Config_Click);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProduct1NameRegion.DefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvProduct1PossitionName.ReadOnly = true;
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
            // frmListProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnState);
            this.Controls.Add(this.dgvProduct1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnProductConfig);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmListProduct";
            this.ShowInTaskbar = false;
            this.Text = "Danh sánh tài sản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmListProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmListProduct_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct1)).EndInit();
            this.ctmProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBuilding;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbZone;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProductConfig;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvProduct1;
        private System.Windows.Forms.Button btnState;
        private System.Windows.Forms.ContextMenuStrip ctmProduct;
        private System.Windows.Forms.ToolStripMenuItem ctmProduct_State;
        private System.Windows.Forms.ToolStripMenuItem ctmProduct_Config;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1IDProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1NameRegion;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1PossitionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProduct1NameProduct;
    }
}