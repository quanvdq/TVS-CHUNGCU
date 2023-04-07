namespace TVSSys
{
    partial class FrmupdtUser
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
            this.tSBClose = new System.Windows.Forms.Button();
            this.tSBSave = new System.Windows.Forms.Button();
            this.lsvGroup = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.tSBAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.ckBSActive = new System.Windows.Forms.CheckBox();
            this.txtPassCofirm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbEditServiceParking = new System.Windows.Forms.CheckBox();
            this.ckbEditServiceWater = new System.Windows.Forms.CheckBox();
            this.ckbEditServiceElectric = new System.Windows.Forms.CheckBox();
            this.ckbEditServiceUsed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tSBClose
            // 
            this.tSBClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tSBClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tSBClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tSBClose.Location = new System.Drawing.Point(273, 369);
            this.tSBClose.Name = "tSBClose";
            this.tSBClose.Size = new System.Drawing.Size(80, 28);
            this.tSBClose.TabIndex = 24;
            this.tSBClose.Text = "Th&oát";
            this.tSBClose.UseVisualStyleBackColor = true;
            this.tSBClose.Click += new System.EventHandler(this.tSBClose_Click);
            // 
            // tSBSave
            // 
            this.tSBSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tSBSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tSBSave.Location = new System.Drawing.Point(101, 369);
            this.tSBSave.Name = "tSBSave";
            this.tSBSave.Size = new System.Drawing.Size(80, 28);
            this.tSBSave.TabIndex = 23;
            this.tSBSave.Text = "&Ghi nhận";
            this.tSBSave.UseVisualStyleBackColor = true;
            this.tSBSave.Click += new System.EventHandler(this.tSBSave_Click);
            // 
            // lsvGroup
            // 
            this.lsvGroup.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvGroup.BackColor = System.Drawing.Color.White;
            this.lsvGroup.CheckBoxes = true;
            this.lsvGroup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lsvGroup.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvGroup.FullRowSelect = true;
            this.lsvGroup.GridLines = true;
            this.lsvGroup.Location = new System.Drawing.Point(101, 100);
            this.lsvGroup.Name = "lsvGroup";
            this.lsvGroup.Size = new System.Drawing.Size(471, 103);
            this.lsvGroup.TabIndex = 7;
            this.lsvGroup.UseCompatibleStateImageBehavior = false;
            this.lsvGroup.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "GID";
            this.columnHeader1.Width = 33;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên nhóm";
            this.columnHeader2.Width = 226;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 0;
            // 
            // tSBAdd
            // 
            this.tSBAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tSBAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tSBAdd.Location = new System.Drawing.Point(187, 369);
            this.tSBAdd.Name = "tSBAdd";
            this.tSBAdd.Size = new System.Drawing.Size(80, 28);
            this.tSBAdd.TabIndex = 22;
            this.tSBAdd.Text = "&Thêm mới";
            this.tSBAdd.UseVisualStyleBackColor = true;
            this.tSBAdd.Click += new System.EventHandler(this.tSBAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(43, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ghi chú :";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNote.Location = new System.Drawing.Point(101, 71);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(471, 23);
            this.txtNote.TabIndex = 5;
            this.txtNote.Leave += new System.EventHandler(this.txtLeave);
            this.txtNote.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNote_KeyPress);
            this.txtNote.Enter += new System.EventHandler(this.txtEnter);
            // 
            // ckBSActive
            // 
            this.ckBSActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ckBSActive.AutoSize = true;
            this.ckBSActive.BackColor = System.Drawing.Color.Transparent;
            this.ckBSActive.Location = new System.Drawing.Point(101, 344);
            this.ckBSActive.Name = "ckBSActive";
            this.ckBSActive.Size = new System.Drawing.Size(77, 19);
            this.ckBSActive.TabIndex = 6;
            this.ckBSActive.Text = "Kích hoạt";
            this.ckBSActive.UseVisualStyleBackColor = false;
            // 
            // txtPassCofirm
            // 
            this.txtPassCofirm.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPassCofirm.Location = new System.Drawing.Point(361, 41);
            this.txtPassCofirm.Name = "txtPassCofirm";
            this.txtPassCofirm.Size = new System.Drawing.Size(211, 23);
            this.txtPassCofirm.TabIndex = 4;
            this.txtPassCofirm.Leave += new System.EventHandler(this.txtLeave);
            this.txtPassCofirm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassCofirm_KeyPress);
            this.txtPassCofirm.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(254, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Lặp lại mật khẩu :";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Arial", 10F);
            this.txtPass.Location = new System.Drawing.Point(101, 41);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(150, 23);
            this.txtPass.TabIndex = 3;
            this.txtPass.Leave += new System.EventHandler(this.txtLeave);
            this.txtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPass_KeyPress);
            this.txtPass.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(36, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mật khẩu :";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtFullName.Location = new System.Drawing.Point(361, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(211, 23);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.Leave += new System.EventHandler(this.txtLeave);
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            this.txtFullName.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(281, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên hiển thị :";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Arial", 10F);
            this.txtUserName.Location = new System.Drawing.Point(101, 12);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(150, 23);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Leave += new System.EventHandler(this.txtLeave);
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            this.txtUserName.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên tài khoản :";
            // 
            // ckbEditServiceParking
            // 
            this.ckbEditServiceParking.AutoSize = true;
            this.ckbEditServiceParking.Location = new System.Drawing.Point(101, 210);
            this.ckbEditServiceParking.Name = "ckbEditServiceParking";
            this.ckbEditServiceParking.Size = new System.Drawing.Size(174, 19);
            this.ckbEditServiceParking.TabIndex = 25;
            this.ckbEditServiceParking.Text = "Quản lý phí dịch vụ trông xe";
            this.ckbEditServiceParking.UseVisualStyleBackColor = true;
            // 
            // ckbEditServiceWater
            // 
            this.ckbEditServiceWater.AutoSize = true;
            this.ckbEditServiceWater.Location = new System.Drawing.Point(101, 235);
            this.ckbEditServiceWater.Name = "ckbEditServiceWater";
            this.ckbEditServiceWater.Size = new System.Drawing.Size(214, 19);
            this.ckbEditServiceWater.TabIndex = 26;
            this.ckbEditServiceWater.Text = "Quản lý phí dịch vụ nước sinh hoạt";
            this.ckbEditServiceWater.UseVisualStyleBackColor = true;
            // 
            // ckbEditServiceElectric
            // 
            this.ckbEditServiceElectric.AutoSize = true;
            this.ckbEditServiceElectric.Location = new System.Drawing.Point(101, 260);
            this.ckbEditServiceElectric.Name = "ckbEditServiceElectric";
            this.ckbEditServiceElectric.Size = new System.Drawing.Size(155, 19);
            this.ckbEditServiceElectric.TabIndex = 27;
            this.ckbEditServiceElectric.Text = "Quản lý phí dịch vụ điện";
            this.ckbEditServiceElectric.UseVisualStyleBackColor = true;
            // 
            // ckbEditServiceUsed
            // 
            this.ckbEditServiceUsed.AutoSize = true;
            this.ckbEditServiceUsed.Location = new System.Drawing.Point(101, 285);
            this.ckbEditServiceUsed.Name = "ckbEditServiceUsed";
            this.ckbEditServiceUsed.Size = new System.Drawing.Size(139, 19);
            this.ckbEditServiceUsed.TabIndex = 28;
            this.ckbEditServiceUsed.Text = "Quản lý phí tổng hợp";
            this.ckbEditServiceUsed.UseVisualStyleBackColor = true;
            // 
            // FrmupdtUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.tSBClose;
            this.ClientSize = new System.Drawing.Size(584, 406);
            this.Controls.Add(this.ckbEditServiceUsed);
            this.Controls.Add(this.ckbEditServiceElectric);
            this.Controls.Add(this.ckbEditServiceWater);
            this.Controls.Add(this.ckbEditServiceParking);
            this.Controls.Add(this.tSBClose);
            this.Controls.Add(this.tSBSave);
            this.Controls.Add(this.lsvGroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tSBAdd);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckBSActive);
            this.Controls.Add(this.txtPassCofirm);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 445);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 445);
            this.Name = "FrmupdtUser";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " .: Tài khoản";
            this.Load += new System.EventHandler(this.FrmupdtUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.CheckBox ckBSActive;
        private System.Windows.Forms.TextBox txtPassCofirm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.ListView lsvGroup;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button tSBClose;
        private System.Windows.Forms.Button tSBSave;
        private System.Windows.Forms.Button tSBAdd;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.CheckBox ckbEditServiceParking;
        private System.Windows.Forms.CheckBox ckbEditServiceWater;
        private System.Windows.Forms.CheckBox ckbEditServiceElectric;
        private System.Windows.Forms.CheckBox ckbEditServiceUsed;
    }
}