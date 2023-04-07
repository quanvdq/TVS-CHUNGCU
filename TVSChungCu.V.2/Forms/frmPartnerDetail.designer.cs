namespace TVSMain
{
    partial class frmPartnerDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartnerDetail));
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.picCadre = new System.Windows.Forms.PictureBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl5 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl6 = new System.Windows.Forms.Label();
            this.Lbl7 = new System.Windows.Forms.Label();
            this.Lbl8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCadre)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(8, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Lưu ảnh";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(614, 289);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(82, 30);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Thoát [ESC]";
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // picCadre
            // 
            this.picCadre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picCadre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCadre.Location = new System.Drawing.Point(8, 9);
            this.picCadre.Name = "picCadre";
            this.picCadre.Size = new System.Drawing.Size(180, 240);
            this.picCadre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCadre.TabIndex = 8;
            this.picCadre.TabStop = false;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowser.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowser.Location = new System.Drawing.Point(8, 255);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(88, 30);
            this.btnBrowser.TabIndex = 9;
            this.btnBrowser.Text = "Chọn ảnh";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(196, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "Họ và Tên :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(196, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ngày sinh :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(407, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Giới tính :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(196, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Địa chỉ :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(196, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 26);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số CMND :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(196, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 26);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quê quán :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Lbl1
            // 
            this.Lbl1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(286, 9);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(296, 26);
            this.Lbl1.TabIndex = 19;
            this.Lbl1.Text = "...";
            this.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl3
            // 
            this.Lbl3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl3.Font = new System.Drawing.Font("Arial", 9F);
            this.Lbl3.Location = new System.Drawing.Point(286, 40);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(115, 26);
            this.Lbl3.TabIndex = 21;
            this.Lbl3.Text = "...";
            this.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl5
            // 
            this.Lbl5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl5.Font = new System.Drawing.Font("Arial", 9F);
            this.Lbl5.Location = new System.Drawing.Point(286, 71);
            this.Lbl5.Name = "Lbl5";
            this.Lbl5.Size = new System.Drawing.Size(410, 26);
            this.Lbl5.TabIndex = 23;
            this.Lbl5.Text = "...";
            this.Lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl4
            // 
            this.Lbl4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl4.Font = new System.Drawing.Font("Arial", 9F);
            this.Lbl4.Location = new System.Drawing.Point(482, 40);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(100, 26);
            this.Lbl4.TabIndex = 22;
            this.Lbl4.Text = "...";
            this.Lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl6
            // 
            this.Lbl6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl6.Font = new System.Drawing.Font("Arial", 9F);
            this.Lbl6.Location = new System.Drawing.Point(286, 133);
            this.Lbl6.Name = "Lbl6";
            this.Lbl6.Size = new System.Drawing.Size(115, 26);
            this.Lbl6.TabIndex = 24;
            this.Lbl6.Text = "...";
            this.Lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl7
            // 
            this.Lbl7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl7.Font = new System.Drawing.Font("Arial", 9F);
            this.Lbl7.Location = new System.Drawing.Point(286, 102);
            this.Lbl7.Name = "Lbl7";
            this.Lbl7.Size = new System.Drawing.Size(410, 26);
            this.Lbl7.TabIndex = 25;
            this.Lbl7.Text = "...";
            this.Lbl7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbl8
            // 
            this.Lbl8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl8.Font = new System.Drawing.Font("Arial", 9F);
            this.Lbl8.Location = new System.Drawing.Point(482, 133);
            this.Lbl8.Name = "Lbl8";
            this.Lbl8.Size = new System.Drawing.Size(100, 26);
            this.Lbl8.TabIndex = 27;
            this.Lbl8.Text = "...";
            this.Lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(407, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 26);
            this.label10.TabIndex = 26;
            this.label10.Text = "Ngày cấp :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(100, 255);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 30);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa ảnh";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl2.Font = new System.Drawing.Font("Arial", 9F);
            this.Lbl2.Location = new System.Drawing.Point(286, 164);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(410, 26);
            this.Lbl2.TabIndex = 20;
            this.Lbl2.Text = "...";
            this.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(196, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nơi cấp :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPartnerDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 326);
            this.ControlBox = false;
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.Lbl8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Lbl7);
            this.Controls.Add(this.Lbl6);
            this.Controls.Add(this.Lbl5);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picCadre);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 365);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 365);
            this.Name = "frmPartnerDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG TIN KHÁCH HÀNG - ĐỐI TÁC";
            this.Load += new System.EventHandler(this.frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picCadre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox picCadre;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl5;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl6;
        private System.Windows.Forms.Label Lbl7;
        private System.Windows.Forms.Label Lbl8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label label3; 


    }
}

