
namespace TVSChungCu.Reports
{
    partial class frmCustomerDebit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKey = new System.Windows.Forms.TextBox();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.NameRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDPartner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePartner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTimeTotalMoneyIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InTimeTotalMoneyOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastTotalMoney = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtSearchKey);
            this.groupBox1.Controls.Add(this.dtpTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpFromDay);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1070, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1018, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "TÌM";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchKey
            // 
            this.txtSearchKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchKey.Font = new System.Drawing.Font("Arial", 10F);
            this.txtSearchKey.Location = new System.Drawing.Point(286, 22);
            this.txtSearchKey.Name = "txtSearchKey";
            this.txtSearchKey.Size = new System.Drawing.Size(773, 23);
            this.txtSearchKey.TabIndex = 4;
            this.txtSearchKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchKey_KeyDown);
            // 
            // dtpTo
            // 
            this.dtpTo.CustomFormat = "dd/MM/yyyy";
            this.dtpTo.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTo.Location = new System.Drawing.Point(176, 22);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(104, 23);
            this.dtpTo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // dtpFromDay
            // 
            this.dtpFromDay.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDay.Font = new System.Drawing.Font("Arial", 10F);
            this.dtpFromDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDay.Location = new System.Drawing.Point(53, 22);
            this.dtpFromDay.Name = "dtpFromDay";
            this.dtpFromDay.Size = new System.Drawing.Size(104, 23);
            this.dtpFromDay.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày:";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.AllowUserToDeleteRows = false;
            this.dgvCustomer.AllowUserToResizeColumns = false;
            this.dgvCustomer.AllowUserToResizeRows = false;
            this.dgvCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustomer.ColumnHeadersHeight = 26;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameRoom,
            this.IDPartner,
            this.CodePartner,
            this.ContactPerson,
            this.ContactPhone,
            this.Address,
            this.FirstTotalMoney,
            this.InTimeTotalMoneyIn,
            this.InTimeTotalMoneyOut,
            this.LastTotalMoney});
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.Location = new System.Drawing.Point(6, 72);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCustomer.RowHeadersWidth = 30;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1070, 403);
            this.dgvCustomer.TabIndex = 1;
            // 
            // NameRoom
            // 
            this.NameRoom.DataPropertyName = "NameRoom";
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRoom.DefaultCellStyle = dataGridViewCellStyle16;
            this.NameRoom.HeaderText = "Phòng";
            this.NameRoom.Name = "NameRoom";
            this.NameRoom.ReadOnly = true;
            this.NameRoom.Width = 50;
            // 
            // IDPartner
            // 
            this.IDPartner.DataPropertyName = "IDPartner";
            this.IDPartner.HeaderText = "IDPartner";
            this.IDPartner.Name = "IDPartner";
            this.IDPartner.ReadOnly = true;
            this.IDPartner.Visible = false;
            // 
            // CodePartner
            // 
            this.CodePartner.DataPropertyName = "CodePartner";
            this.CodePartner.HeaderText = "CodePartner";
            this.CodePartner.Name = "CodePartner";
            this.CodePartner.ReadOnly = true;
            this.CodePartner.Visible = false;
            // 
            // ContactPerson
            // 
            this.ContactPerson.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ContactPerson.DataPropertyName = "ContactPerson";
            this.ContactPerson.HeaderText = "Khách hàng";
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.ReadOnly = true;
            this.ContactPerson.Width = 200;
            // 
            // ContactPhone
            // 
            this.ContactPhone.DataPropertyName = "ContactPhone";
            this.ContactPhone.HeaderText = " Số điện thoại";
            this.ContactPhone.Name = "ContactPhone";
            this.ContactPhone.ReadOnly = true;
            this.ContactPhone.Width = 90;
            // 
            // Address
            // 
            this.Address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Địa chỉ";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // FirstTotalMoney
            // 
            this.FirstTotalMoney.DataPropertyName = "FirstTotalMoney";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle17.Format = "N0";
            dataGridViewCellStyle17.NullValue = null;
            this.FirstTotalMoney.DefaultCellStyle = dataGridViewCellStyle17;
            this.FirstTotalMoney.HeaderText = "   Nợ đầu kỳ";
            this.FirstTotalMoney.Name = "FirstTotalMoney";
            this.FirstTotalMoney.ReadOnly = true;
            this.FirstTotalMoney.Width = 90;
            // 
            // InTimeTotalMoneyIn
            // 
            this.InTimeTotalMoneyIn.DataPropertyName = "InTimeTotalMoneyIn";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.Format = "N0";
            dataGridViewCellStyle18.NullValue = null;
            this.InTimeTotalMoneyIn.DefaultCellStyle = dataGridViewCellStyle18;
            this.InTimeTotalMoneyIn.HeaderText = "Công nợ tăng";
            this.InTimeTotalMoneyIn.Name = "InTimeTotalMoneyIn";
            this.InTimeTotalMoneyIn.ReadOnly = true;
            this.InTimeTotalMoneyIn.Width = 90;
            // 
            // InTimeTotalMoneyOut
            // 
            this.InTimeTotalMoneyOut.DataPropertyName = "InTimeTotalMoneyOut";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle19.Format = "N0";
            dataGridViewCellStyle19.NullValue = null;
            this.InTimeTotalMoneyOut.DefaultCellStyle = dataGridViewCellStyle19;
            this.InTimeTotalMoneyOut.HeaderText = "Công nợ giảm";
            this.InTimeTotalMoneyOut.Name = "InTimeTotalMoneyOut";
            this.InTimeTotalMoneyOut.ReadOnly = true;
            this.InTimeTotalMoneyOut.Width = 95;
            // 
            // LastTotalMoney
            // 
            this.LastTotalMoney.DataPropertyName = "LastTotalMoney";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle20.Format = "N0";
            dataGridViewCellStyle20.NullValue = null;
            this.LastTotalMoney.DefaultCellStyle = dataGridViewCellStyle20;
            this.LastTotalMoney.HeaderText = "   Nợ cuối kỳ";
            this.LastTotalMoney.Name = "LastTotalMoney";
            this.LastTotalMoney.ReadOnly = true;
            this.LastTotalMoney.Width = 90;
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Location = new System.Drawing.Point(6, 481);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 26);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In báo cáo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(83, 481);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 26);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCustomerDebit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.Name = "frmCustomerDebit";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Công nợ khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomerDebit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomerDebit_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDay;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDPartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePartner;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstTotalMoney;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTimeTotalMoneyIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InTimeTotalMoneyOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastTotalMoney;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
    }
}