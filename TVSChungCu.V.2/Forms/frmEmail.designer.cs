namespace TVSMain
{
    partial class frmEmail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmail));
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
            this.BtnUpdateEmailInfo = new System.Windows.Forms.Button();
            this.TxtEmailPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmailAddressFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBalance = new System.Windows.Forms.CheckBox();
            this.BtnUpdateContent = new System.Windows.Forms.Button();
            this.BtnSend = new System.Windows.Forms.Button();
            this.TxtContent0 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtContent2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtContent1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtTitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.BtnUpdateEmailInfo);
            this.groupBox1.Controls.Add(this.TxtEmailPassword);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtEmailAddressFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(465, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 100);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "THÔNG SỐ NGƯỜI GỬI   ";
            // 
            // BtnUpdateEmailInfo
            // 
            this.BtnUpdateEmailInfo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateEmailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateEmailInfo.Location = new System.Drawing.Point(390, 58);
            this.BtnUpdateEmailInfo.Name = "BtnUpdateEmailInfo";
            this.BtnUpdateEmailInfo.Size = new System.Drawing.Size(113, 32);
            this.BtnUpdateEmailInfo.TabIndex = 53;
            this.BtnUpdateEmailInfo.Text = "Lưu thông tin gửi";
            this.BtnUpdateEmailInfo.UseVisualStyleBackColor = true;
            this.BtnUpdateEmailInfo.Click += new System.EventHandler(this.BtnUpdateEmailInfo_Click);
            // 
            // TxtEmailPassword
            // 
            this.TxtEmailPassword.Location = new System.Drawing.Point(390, 31);
            this.TxtEmailPassword.Name = "TxtEmailPassword";
            this.TxtEmailPassword.PasswordChar = '*';
            this.TxtEmailPassword.Size = new System.Drawing.Size(113, 22);
            this.TxtEmailPassword.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mật khẩu :";
            // 
            // TxtEmailAddressFrom
            // 
            this.TxtEmailAddressFrom.Location = new System.Drawing.Point(127, 31);
            this.TxtEmailAddressFrom.Name = "TxtEmailAddressFrom";
            this.TxtEmailAddressFrom.Size = new System.Drawing.Size(183, 22);
            this.TxtEmailAddressFrom.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 50;
            this.label4.Text = "Email người gửi :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkBalance);
            this.groupBox2.Controls.Add(this.BtnUpdateContent);
            this.groupBox2.Controls.Add(this.BtnSend);
            this.groupBox2.Controls.Add(this.TxtContent0);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.TxtContent2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TxtContent1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TxtTitle);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(465, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 345);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NỘI DUNG GỬI TIN NHẮN   ";
            // 
            // chkBalance
            // 
            this.chkBalance.AutoSize = true;
            this.chkBalance.Location = new System.Drawing.Point(127, 116);
            this.chkBalance.Name = "chkBalance";
            this.chkBalance.Size = new System.Drawing.Size(123, 20);
            this.chkBalance.TabIndex = 62;
            this.chkBalance.Text = "Hiện thị công nợ";
            this.chkBalance.UseVisualStyleBackColor = true;
            this.chkBalance.CheckedChanged += new System.EventHandler(this.TxtContent1_TextChanged);
            // 
            // BtnUpdateContent
            // 
            this.BtnUpdateContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnUpdateContent.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateContent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateContent.Location = new System.Drawing.Point(224, 307);
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
            this.BtnSend.Location = new System.Drawing.Point(127, 307);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(91, 32);
            this.BtnSend.TabIndex = 59;
            this.BtnSend.Text = "Gửi Email";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.ButSend_Click);
            // 
            // TxtContent0
            // 
            this.TxtContent0.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtContent0.Location = new System.Drawing.Point(127, 201);
            this.TxtContent0.Multiline = true;
            this.TxtContent0.Name = "TxtContent0";
            this.TxtContent0.Size = new System.Drawing.Size(376, 96);
            this.TxtContent0.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "Nội dung gửi :";
            // 
            // TxtContent2
            // 
            this.TxtContent2.Location = new System.Drawing.Point(127, 140);
            this.TxtContent2.Multiline = true;
            this.TxtContent2.Name = "TxtContent2";
            this.TxtContent2.Size = new System.Drawing.Size(376, 55);
            this.TxtContent2.TabIndex = 55;
            this.TxtContent2.TextChanged += new System.EventHandler(this.TxtContent1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nội dung 2 :";
            // 
            // TxtContent1
            // 
            this.TxtContent1.Location = new System.Drawing.Point(127, 55);
            this.TxtContent1.Multiline = true;
            this.TxtContent1.Name = "TxtContent1";
            this.TxtContent1.Size = new System.Drawing.Size(376, 55);
            this.TxtContent1.TabIndex = 53;
            this.TxtContent1.TextChanged += new System.EventHandler(this.TxtContent1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 54;
            this.label3.Text = "Nội dung 1 :";
            // 
            // TxtTitle
            // 
            this.TxtTitle.Location = new System.Drawing.Point(127, 27);
            this.TxtTitle.Name = "TxtTitle";
            this.TxtTitle.Size = new System.Drawing.Size(376, 22);
            this.TxtTitle.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tiêu đề :";
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
            this.chkAll.Location = new System.Drawing.Point(8, 484);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(94, 20);
            this.chkAll.TabIndex = 63;
            this.chkAll.Text = "Chọn tất cả";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // frmEmail
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
            this.Name = "frmEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GỬI EMAIL TỚI KHÁCH HÀNG - ĐỐI TÁC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Load);
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
        private System.Windows.Forms.TextBox TxtEmailPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEmailAddressFrom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnUpdateEmailInfo;
        private System.Windows.Forms.TextBox TxtContent0;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtContent2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtContent1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnUpdateContent;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.ToolStripButton ButClose;
        private System.Windows.Forms.ToolStrip ToolStripTop;
        private System.Windows.Forms.CheckBox chkBalance;
        private System.Windows.Forms.CheckBox chkAll;


    }
}

