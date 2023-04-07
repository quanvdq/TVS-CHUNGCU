namespace TVSMain
{
    partial class frmRoomConfig
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
            this.ButColor0 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButColor3 = new System.Windows.Forms.Button();
            this.ButColor4 = new System.Windows.Forms.Button();
            this.ButColor2 = new System.Windows.Forms.Button();
            this.ButColor1 = new System.Windows.Forms.Button();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtRoomColumn = new System.Windows.Forms.TextBox();
            this.TxtRoomLeft = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtRoomTop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtRoomExpirationDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButColor0
            // 
            this.ButColor0.Location = new System.Drawing.Point(13, 25);
            this.ButColor0.Name = "ButColor0";
            this.ButColor0.Size = new System.Drawing.Size(104, 107);
            this.ButColor0.TabIndex = 1;
            this.ButColor0.Text = "Khu vực";
            this.ButColor0.UseVisualStyleBackColor = true;
            this.ButColor0.Click += new System.EventHandler(this.ButColor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ButColor3);
            this.groupBox1.Controls.Add(this.ButColor4);
            this.groupBox1.Controls.Add(this.ButColor2);
            this.groupBox1.Controls.Add(this.ButColor1);
            this.groupBox1.Controls.Add(this.ButColor0);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 143);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Màu sắc ";
            // 
            // ButColor3
            // 
            this.ButColor3.Location = new System.Drawing.Point(123, 82);
            this.ButColor3.Name = "ButColor3";
            this.ButColor3.Size = new System.Drawing.Size(104, 50);
            this.ButColor3.TabIndex = 5;
            this.ButColor3.Text = "Gần hết hạn";
            this.ButColor3.UseVisualStyleBackColor = true;
            this.ButColor3.Click += new System.EventHandler(this.ButColor_Click);
            // 
            // ButColor4
            // 
            this.ButColor4.Location = new System.Drawing.Point(233, 82);
            this.ButColor4.Name = "ButColor4";
            this.ButColor4.Size = new System.Drawing.Size(104, 50);
            this.ButColor4.TabIndex = 4;
            this.ButColor4.Text = "Quá hạn";
            this.ButColor4.UseVisualStyleBackColor = true;
            this.ButColor4.Click += new System.EventHandler(this.ButColor_Click);
            // 
            // ButColor2
            // 
            this.ButColor2.Location = new System.Drawing.Point(233, 25);
            this.ButColor2.Name = "ButColor2";
            this.ButColor2.Size = new System.Drawing.Size(104, 50);
            this.ButColor2.TabIndex = 3;
            this.ButColor2.Text = "Đang sử dụng";
            this.ButColor2.UseVisualStyleBackColor = true;
            this.ButColor2.Click += new System.EventHandler(this.ButColor_Click);
            // 
            // ButColor1
            // 
            this.ButColor1.Location = new System.Drawing.Point(123, 25);
            this.ButColor1.Name = "ButColor1";
            this.ButColor1.Size = new System.Drawing.Size(104, 50);
            this.ButColor1.TabIndex = 2;
            this.ButColor1.Text = "Chưa sử dụng";
            this.ButColor1.UseVisualStyleBackColor = true;
            this.ButColor1.Click += new System.EventHandler(this.ButColor_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Location = new System.Drawing.Point(233, 21);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(104, 32);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "Thoát [ESC]";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(123, 21);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(104, 32);
            this.BtnUpdate.TabIndex = 4;
            this.BtnUpdate.Text = "Ghi nhận [F6]";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtRoomExpirationDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.TxtRoomColumn);
            this.groupBox2.Controls.Add(this.TxtRoomLeft);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtRoomTop);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 140);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kích thước";
            // 
            // TxtRoomColumn
            // 
            this.TxtRoomColumn.Location = new System.Drawing.Point(233, 78);
            this.TxtRoomColumn.Name = "TxtRoomColumn";
            this.TxtRoomColumn.Size = new System.Drawing.Size(104, 22);
            this.TxtRoomColumn.TabIndex = 3;
            this.TxtRoomColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRoomColumn.Leave += new System.EventHandler(this.TxtLeave);
            this.TxtRoomColumn.Enter += new System.EventHandler(this.TxtEnter);
            // 
            // TxtRoomLeft
            // 
            this.TxtRoomLeft.Location = new System.Drawing.Point(233, 51);
            this.TxtRoomLeft.Name = "TxtRoomLeft";
            this.TxtRoomLeft.Size = new System.Drawing.Size(104, 22);
            this.TxtRoomLeft.TabIndex = 2;
            this.TxtRoomLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRoomLeft.Leave += new System.EventHandler(this.TxtLeave);
            this.TxtRoomLeft.Enter += new System.EventHandler(this.TxtEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số phòng / hàng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lề trái :";
            // 
            // TxtRoomTop
            // 
            this.TxtRoomTop.Location = new System.Drawing.Point(233, 23);
            this.TxtRoomTop.Name = "TxtRoomTop";
            this.TxtRoomTop.Size = new System.Drawing.Size(104, 22);
            this.TxtRoomTop.TabIndex = 1;
            this.TxtRoomTop.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtRoomTop.Leave += new System.EventHandler(this.TxtLeave);
            this.TxtRoomTop.Enter += new System.EventHandler(this.TxtEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lề trên :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnClose);
            this.groupBox3.Controls.Add(this.BtnUpdate);
            this.groupBox3.Location = new System.Drawing.Point(9, 301);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 68);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // TxtRoomExpirationDate
            // 
            this.TxtRoomExpirationDate.Location = new System.Drawing.Point(233, 106);
            this.TxtRoomExpirationDate.Name = "TxtRoomExpirationDate";
            this.TxtRoomExpirationDate.Size = new System.Drawing.Size(104, 22);
            this.TxtRoomExpirationDate.TabIndex = 5;
            this.TxtRoomExpirationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Số ngày gần hết hạn :";
            // 
            // frmRoomConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 380);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(382, 419);
            this.MinimumSize = new System.Drawing.Size(382, 419);
            this.Name = "frmRoomConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CẤU HÌNH THÔNG SỐ SƠ ĐỒ";
            this.Load += new System.EventHandler(this.frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButColor0;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButColor3;
        private System.Windows.Forms.Button ButColor4;
        private System.Windows.Forms.Button ButColor2;
        private System.Windows.Forms.Button ButColor1;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtRoomColumn;
        private System.Windows.Forms.TextBox TxtRoomLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRoomTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtRoomExpirationDate;
        private System.Windows.Forms.Label label4;

    }
}