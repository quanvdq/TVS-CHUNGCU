namespace TVSMain
{
    partial class frmSMS
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSMS));
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bNagGrid = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.ButFocus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnPhoneNo = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtWriteTimeOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtReadTimeOut = new System.Windows.Forms.TextBox();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbDataBits = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbbParity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbBaudRate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbPortName = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnUpdateInfo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblMess = new System.Windows.Forms.Label();
            this.chkBalance = new System.Windows.Forms.CheckBox();
            this.BtnUpdateContent = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtContent0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtContent2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtContent1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ToolStripTop = new System.Windows.Forms.ToolStrip();
            this.ButClose = new System.Windows.Forms.ToolStripButton();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.chkAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).BeginInit();
            this.bNagGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.ToolStripTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(40, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorCountItem.Text = "/ {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            this.bindingNavigatorSeparator2.Visible = false;
            // 
            // bNagGrid
            // 
            this.bNagGrid.AddNewItem = null;
            this.bNagGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNagGrid.BackColor = System.Drawing.Color.Transparent;
            this.bNagGrid.CountItem = this.bindingNavigatorCountItem;
            this.bNagGrid.CountItemFormat = "/ {0}";
            this.bNagGrid.DeleteItem = null;
            this.bNagGrid.Dock = System.Windows.Forms.DockStyle.None;
            this.bNagGrid.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bNagGrid.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bNagGrid.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.bNagGrid.Location = new System.Drawing.Point(312, 483);
            this.bNagGrid.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNagGrid.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNagGrid.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNagGrid.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNagGrid.Name = "bNagGrid";
            this.bNagGrid.PositionItem = this.bindingNavigatorPositionItem;
            this.bNagGrid.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNagGrid.Size = new System.Drawing.Size(178, 25);
            this.bNagGrid.TabIndex = 1;
            this.bNagGrid.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // ButFocus
            // 
            this.ButFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButFocus.Location = new System.Drawing.Point(231, 89);
            this.ButFocus.Name = "ButFocus";
            this.ButFocus.Size = new System.Drawing.Size(75, 23);
            this.ButFocus.TabIndex = 21;
            this.ButFocus.Text = "button1";
            this.ButFocus.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.BtnPhoneNo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TxtWriteTimeOut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtReadTimeOut);
            this.groupBox1.Controls.Add(this.cbbStopBits);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbDataBits);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbbParity);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbBaudRate);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbbPortName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.BtnUpdateInfo);
            this.groupBox1.Location = new System.Drawing.Point(465, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 135);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG SỐ GỬI   ";
            // 
            // BtnPhoneNo
            // 
            this.BtnPhoneNo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPhoneNo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPhoneNo.Location = new System.Drawing.Point(420, 48);
            this.BtnPhoneNo.Name = "BtnPhoneNo";
            this.BtnPhoneNo.Size = new System.Drawing.Size(83, 35);
            this.BtnPhoneNo.TabIndex = 68;
            this.BtnPhoneNo.Text = "Đầu số";
            this.BtnPhoneNo.UseVisualStyleBackColor = true;
            this.BtnPhoneNo.Click += new System.EventHandler(this.BtnPhoneNo_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(217, 102);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 67;
            this.label7.Text = "Thời gian chờ viết :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtWriteTimeOut
            // 
            this.TxtWriteTimeOut.Location = new System.Drawing.Point(332, 101);
            this.TxtWriteTimeOut.Name = "TxtWriteTimeOut";
            this.TxtWriteTimeOut.Size = new System.Drawing.Size(82, 22);
            this.TxtWriteTimeOut.TabIndex = 66;
            this.TxtWriteTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(5, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 65;
            this.label1.Text = "Thời gian chờ đọc :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtReadTimeOut
            // 
            this.TxtReadTimeOut.Location = new System.Drawing.Point(127, 102);
            this.TxtReadTimeOut.Name = "TxtReadTimeOut";
            this.TxtReadTimeOut.Size = new System.Drawing.Size(82, 22);
            this.TxtReadTimeOut.TabIndex = 64;
            this.TxtReadTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Location = new System.Drawing.Point(332, 75);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(82, 24);
            this.cbbStopBits.TabIndex = 63;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(274, 75);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Dừng :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbDataBits
            // 
            this.cbbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDataBits.FormattingEnabled = true;
            this.cbbDataBits.Location = new System.Drawing.Point(332, 48);
            this.cbbDataBits.Name = "cbbDataBits";
            this.cbbDataBits.Size = new System.Drawing.Size(82, 24);
            this.cbbDataBits.TabIndex = 61;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(274, 49);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 60;
            this.label8.Text = "Dữ liệu :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbParity
            // 
            this.cbbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbParity.FormattingEnabled = true;
            this.cbbParity.Location = new System.Drawing.Point(127, 75);
            this.cbbParity.Name = "cbbParity";
            this.cbbParity.Size = new System.Drawing.Size(82, 24);
            this.cbbParity.TabIndex = 59;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(51, 75);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(72, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Chẵn lẻ :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbBaudRate
            // 
            this.cbbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBaudRate.FormattingEnabled = true;
            this.cbbBaudRate.Location = new System.Drawing.Point(127, 48);
            this.cbbBaudRate.Name = "cbbBaudRate";
            this.cbbBaudRate.Size = new System.Drawing.Size(82, 24);
            this.cbbBaudRate.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(69, 49);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 56;
            this.label10.Text = "Tần số :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbbPortName
            // 
            this.cbbPortName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPortName.FormattingEnabled = true;
            this.cbbPortName.Location = new System.Drawing.Point(127, 21);
            this.cbbPortName.Name = "cbbPortName";
            this.cbbPortName.Size = new System.Drawing.Size(82, 24);
            this.cbbPortName.TabIndex = 55;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(69, 21);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 54;
            this.label11.Text = "Cổng :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnUpdateInfo
            // 
            this.BtnUpdateInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateInfo.Location = new System.Drawing.Point(420, 88);
            this.BtnUpdateInfo.Name = "BtnUpdateInfo";
            this.BtnUpdateInfo.Size = new System.Drawing.Size(83, 35);
            this.BtnUpdateInfo.TabIndex = 53;
            this.BtnUpdateInfo.Text = "Ghi nhận";
            this.BtnUpdateInfo.UseVisualStyleBackColor = true;
            this.BtnUpdateInfo.Click += new System.EventHandler(this.BtnUpdateInfo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LblMess);
            this.groupBox2.Controls.Add(this.chkBalance);
            this.groupBox2.Controls.Add(this.BtnUpdateContent);
            this.groupBox2.Controls.Add(this.BtnSend);
            this.groupBox2.Controls.Add(this.TxtContent0);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtContent2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtContent1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(465, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 310);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NỘI DUNG GỬI TIN NHẮN   ";
            // 
            // LblMess
            // 
            this.LblMess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblMess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LblMess.Location = new System.Drawing.Point(129, 236);
            this.LblMess.Name = "LblMess";
            this.LblMess.Size = new System.Drawing.Size(374, 33);
            this.LblMess.TabIndex = 62;
            // 
            // chkBalance
            // 
            this.chkBalance.AutoSize = true;
            this.chkBalance.Location = new System.Drawing.Point(127, 71);
            this.chkBalance.Name = "chkBalance";
            this.chkBalance.Size = new System.Drawing.Size(123, 20);
            this.chkBalance.TabIndex = 61;
            this.chkBalance.Text = "Hiện thị công nợ";
            this.chkBalance.UseVisualStyleBackColor = true;
            this.chkBalance.CheckedChanged += new System.EventHandler(this.TxtContent2_TextChanged);
            // 
            // BtnUpdateContent
            // 
            this.BtnUpdateContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdateContent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateContent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateContent.Location = new System.Drawing.Point(224, 272);
            this.BtnUpdateContent.Name = "BtnUpdateContent";
            this.BtnUpdateContent.Size = new System.Drawing.Size(91, 32);
            this.BtnUpdateContent.TabIndex = 60;
            this.BtnUpdateContent.Text = "Lưu tin mẫu";
            this.BtnUpdateContent.UseVisualStyleBackColor = true;
            this.BtnUpdateContent.Click += new System.EventHandler(this.BtnUpdateContent_Click);
            // 
            // BtnSend
            // 
            this.BtnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnSend.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSend.Location = new System.Drawing.Point(127, 272);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(91, 32);
            this.BtnSend.TabIndex = 59;
            this.BtnSend.Text = "Gửi SMS";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.ButSend_Click);
            // 
            // TxtContent0
            // 
            this.TxtContent0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtContent0.BackColor = System.Drawing.Color.White;
            this.TxtContent0.Location = new System.Drawing.Point(127, 142);
            this.TxtContent0.Multiline = true;
            this.TxtContent0.Name = "TxtContent0";
            this.TxtContent0.ReadOnly = true;
            this.TxtContent0.Size = new System.Drawing.Size(376, 84);
            this.TxtContent0.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nội dung gửi :";
            // 
            // TxtContent2
            // 
            this.TxtContent2.Location = new System.Drawing.Point(127, 95);
            this.TxtContent2.Multiline = true;
            this.TxtContent2.Name = "TxtContent2";
            this.TxtContent2.Size = new System.Drawing.Size(376, 41);
            this.TxtContent2.TabIndex = 55;
            this.TxtContent2.TextChanged += new System.EventHandler(this.TxtContent2_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nội dung 2 :";
            // 
            // TxtContent1
            // 
            this.TxtContent1.Location = new System.Drawing.Point(127, 23);
            this.TxtContent1.Multiline = true;
            this.TxtContent1.Name = "TxtContent1";
            this.TxtContent1.Size = new System.Drawing.Size(376, 44);
            this.TxtContent1.TabIndex = 53;
            this.TxtContent1.TextChanged += new System.EventHandler(this.TxtContent2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Nội dung 1 :";
            // 
            // ToolStripTop
            // 
            this.ToolStripTop.AutoSize = false;
            this.ToolStripTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripTop.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ToolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButClose});
            this.ToolStripTop.Location = new System.Drawing.Point(0, 0);
            this.ToolStripTop.Name = "ToolStripTop";
            this.ToolStripTop.Size = new System.Drawing.Size(984, 35);
            this.ToolStripTop.TabIndex = 20;
            this.ToolStripTop.Text = "toolStrip1";
            // 
            // ButClose
            // 
            this.ButClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButClose.Font = new System.Drawing.Font("Arial", 9F);
            this.ButClose.Image = global::TVSChungCu.Properties.Resources.Close2014;
            this.ButClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(66, 32);
            this.ButClose.Text = "Thoát";
            this.ButClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowFilter = false;
            this.c1TrueDBGrid1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.c1TrueDBGrid1.AllowUpdate = false;
            this.c1TrueDBGrid1.AlternatingRows = true;
            this.c1TrueDBGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TrueDBGrid1.BackColor = System.Drawing.Color.White;
            this.c1TrueDBGrid1.CaptionHeight = 17;
            this.c1TrueDBGrid1.CollapseColor = System.Drawing.Color.Empty;
            this.c1TrueDBGrid1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c1TrueDBGrid1.ExpandColor = System.Drawing.Color.Empty;
            this.c1TrueDBGrid1.ExtendRightColumn = true;
            this.c1TrueDBGrid1.FilterBar = true;
            this.c1TrueDBGrid1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(6, 35);
            this.c1TrueDBGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.c1TrueDBGrid1.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.RecordSelectors = false;
            this.c1TrueDBGrid1.RowHeight = 22;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(453, 444);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid1.WrapCellPointer = true;
            this.c1TrueDBGrid1.Error += new C1.Win.C1TrueDBGrid.ErrorEventHandler(this.c1TrueDBGrid1_Error);
            this.c1TrueDBGrid1.FilterChange += new System.EventHandler(this.c1TrueDBGrid1_FilterChange);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // chkAll
            // 
            this.chkAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAll.AutoSize = true;
            this.chkAll.Location = new System.Drawing.Point(6, 485);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(94, 20);
            this.chkAll.TabIndex = 64;
            this.chkAll.Text = "Chọn tất cả";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // frmSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 511);
            this.ControlBox = false;
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ToolStripTop);
            this.Controls.Add(this.bNagGrid);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.ButFocus);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GỬI SMS TỚI KHÁCH HÀNG - ĐỐI TÁC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).EndInit();
            this.bNagGrid.ResumeLayout(false);
            this.bNagGrid.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ToolStripTop.ResumeLayout(false);
            this.ToolStripTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingNavigator bNagGrid;
        public C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
        private System.Windows.Forms.Button ButFocus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnUpdateInfo;
        private System.Windows.Forms.TextBox TxtContent0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtContent2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtContent1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnUpdateContent;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.ToolStripButton ButClose;
        private System.Windows.Forms.ToolStrip ToolStripTop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtWriteTimeOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReadTimeOut;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbDataBits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbParity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbBaudRate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbPortName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtnPhoneNo;
        private System.Windows.Forms.CheckBox chkBalance;
        private System.Windows.Forms.Label LblMess;
        private System.Windows.Forms.CheckBox chkAll;


    }
}

