namespace TVSMain
{
    partial class frmServiceUsed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServiceUsed));
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
            this.ToolStripTop = new System.Windows.Forms.ToolStrip();
            this.ButAdd = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ButEdit = new System.Windows.Forms.ToolStripButton();
            this.ButDelete = new System.Windows.Forms.ToolStripButton();
            this.ButSave = new System.Windows.Forms.ToolStripButton();
            this.ButCancel = new System.Windows.Forms.ToolStripButton();
            this.ButClose = new System.Windows.Forms.ToolStripButton();
            this.ButPrint = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ButPrintPay = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ButPrintList = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSendNotification = new System.Windows.Forms.ToolStripButton();
            this.ButFocus = new System.Windows.Forms.Button();
            this.ToolStripCalc = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComTime = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ComRegion = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButBalances = new System.Windows.Forms.ToolStripButton();
            this.ButCalculator = new System.Windows.Forms.ToolStripButton();
            this.ComReportTitle = new System.Windows.Forms.ToolStripComboBox();
            this.LblMess = new System.Windows.Forms.Label();
            this.chkPrinter = new System.Windows.Forms.CheckBox();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).BeginInit();
            this.bNagGrid.SuspendLayout();
            this.ToolStripTop.SuspendLayout();
            this.ToolStripCalc.SuspendLayout();
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
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.SystemColors.Control;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(40, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(28, 22);
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
            this.bNagGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bNagGrid.BackColor = System.Drawing.Color.Transparent;
            this.bNagGrid.CountItem = this.bindingNavigatorCountItem;
            this.bNagGrid.CountItemFormat = "/ {0}";
            this.bNagGrid.DeleteItem = null;
            this.bNagGrid.Dock = System.Windows.Forms.DockStyle.None;
            this.bNagGrid.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bNagGrid.Location = new System.Drawing.Point(6, 483);
            this.bNagGrid.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNagGrid.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNagGrid.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNagGrid.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNagGrid.Name = "bNagGrid";
            this.bNagGrid.PositionItem = this.bindingNavigatorPositionItem;
            this.bNagGrid.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNagGrid.Size = new System.Drawing.Size(177, 25);
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
            // ToolStripTop
            // 
            this.ToolStripTop.AutoSize = false;
            this.ToolStripTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripTop.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ToolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButAdd,
            this.toolStripSeparator2,
            this.ButEdit,
            this.ButDelete,
            this.ButSave,
            this.ButCancel,
            this.ButClose,
            this.ButPrint,
            this.toolStripSeparator3,
            this.ButPrintPay,
            this.toolStripSeparator4,
            this.ButPrintList,
            this.toolStripSeparator5,
            this.btnSendNotification});
            this.ToolStripTop.Location = new System.Drawing.Point(0, 0);
            this.ToolStripTop.Name = "ToolStripTop";
            this.ToolStripTop.Size = new System.Drawing.Size(934, 35);
            this.ToolStripTop.TabIndex = 20;
            this.ToolStripTop.Text = "toolStrip1";
            // 
            // ButAdd
            // 
            this.ButAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.ButAdd.Image = global::TVSChungCu.Properties.Resources.Add2014;
            this.ButAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(123, 32);
            this.ButAdd.Text = "Cập nhật phòng";
            this.ButAdd.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // ButEdit
            // 
            this.ButEdit.Font = new System.Drawing.Font("Arial", 9F);
            this.ButEdit.Image = global::TVSChungCu.Properties.Resources.Edit2014;
            this.ButEdit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButEdit.Name = "ButEdit";
            this.ButEdit.Size = new System.Drawing.Size(78, 32);
            this.ButEdit.Text = "Sửa đổi";
            this.ButEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ButDelete
            // 
            this.ButDelete.Font = new System.Drawing.Font("Arial", 9F);
            this.ButDelete.Image = global::TVSChungCu.Properties.Resources.Delete2014;
            this.ButDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButDelete.Name = "ButDelete";
            this.ButDelete.Size = new System.Drawing.Size(76, 32);
            this.ButDelete.Text = "Loại bỏ";
            this.ButDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ButSave
            // 
            this.ButSave.Font = new System.Drawing.Font("Arial", 9F);
            this.ButSave.Image = global::TVSChungCu.Properties.Resources.Save2014;
            this.ButSave.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(85, 32);
            this.ButSave.Text = "Ghi nhận";
            this.ButSave.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ButCancel
            // 
            this.ButCancel.Font = new System.Drawing.Font("Arial", 9F);
            this.ButCancel.Image = global::TVSChungCu.Properties.Resources.Load2014;
            this.ButCancel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButCancel.Name = "ButCancel";
            this.ButCancel.Size = new System.Drawing.Size(74, 32);
            this.ButCancel.Text = "Bỏ qua";
            this.ButCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ButClose
            // 
            this.ButClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ButClose.AutoSize = false;
            this.ButClose.Font = new System.Drawing.Font("Arial", 9F);
            this.ButClose.Image = global::TVSChungCu.Properties.Resources.close;
            this.ButClose.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButClose.Name = "ButClose";
            this.ButClose.Size = new System.Drawing.Size(40, 32);
            this.ButClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ButPrint
            // 
            this.ButPrint.Font = new System.Drawing.Font("Arial", 9F);
            this.ButPrint.Image = global::TVSChungCu.Properties.Resources.Print2014;
            this.ButPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButPrint.Name = "ButPrint";
            this.ButPrint.Size = new System.Drawing.Size(94, 32);
            this.ButPrint.Text = "Thông báo";
            this.ButPrint.Click += new System.EventHandler(this.ButPrint_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 35);
            // 
            // ButPrintPay
            // 
            this.ButPrintPay.Font = new System.Drawing.Font("Arial", 9F);
            this.ButPrintPay.Image = global::TVSChungCu.Properties.Resources.Print2014;
            this.ButPrintPay.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButPrintPay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButPrintPay.Name = "ButPrintPay";
            this.ButPrintPay.Size = new System.Drawing.Size(87, 32);
            this.ButPrintPay.Text = "Phiếu thu";
            this.ButPrintPay.Click += new System.EventHandler(this.ButPrintPay_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 35);
            // 
            // ButPrintList
            // 
            this.ButPrintList.Font = new System.Drawing.Font("Arial", 9F);
            this.ButPrintList.Image = global::TVSChungCu.Properties.Resources.Print2014;
            this.ButPrintList.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButPrintList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButPrintList.Name = "ButPrintList";
            this.ButPrintList.Size = new System.Drawing.Size(95, 32);
            this.ButPrintList.Text = "Danh sách";
            this.ButPrintList.Click += new System.EventHandler(this.ButPrintList_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // btnSendNotification
            // 
            this.btnSendNotification.Image = global::TVSChungCu.Properties.Resources.send;
            this.btnSendNotification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSendNotification.Name = "btnSendNotification";
            this.btnSendNotification.Size = new System.Drawing.Size(111, 32);
            this.btnSendNotification.Text = "Gửi thông báo";
            this.btnSendNotification.Click += new System.EventHandler(this.btnSendNotification_Click);
            // 
            // ButFocus
            // 
            this.ButFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButFocus.Location = new System.Drawing.Point(181, 140);
            this.ButFocus.Name = "ButFocus";
            this.ButFocus.Size = new System.Drawing.Size(75, 23);
            this.ButFocus.TabIndex = 21;
            this.ButFocus.Text = "button1";
            this.ButFocus.UseVisualStyleBackColor = true;
            // 
            // ToolStripCalc
            // 
            this.ToolStripCalc.AutoSize = false;
            this.ToolStripCalc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripCalc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ToolStripCalc.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripCalc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ComTime,
            this.toolStripLabel2,
            this.ComRegion,
            this.toolStripSeparator1,
            this.ButBalances,
            this.ButCalculator,
            this.ComReportTitle});
            this.ToolStripCalc.Location = new System.Drawing.Point(0, 35);
            this.ToolStripCalc.Name = "ToolStripCalc";
            this.ToolStripCalc.Size = new System.Drawing.Size(934, 35);
            this.ToolStripCalc.TabIndex = 22;
            this.ToolStripCalc.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 32);
            this.toolStripLabel1.Text = "  Tháng :";
            // 
            // ComTime
            // 
            this.ComTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComTime.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ComTime.Name = "ComTime";
            this.ComTime.Size = new System.Drawing.Size(154, 35);
            this.ComTime.SelectedIndexChanged += new System.EventHandler(this.ComTime_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 32);
            this.toolStripLabel2.Text = " Khu vực";
            // 
            // ComRegion
            // 
            this.ComRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComRegion.Name = "ComRegion";
            this.ComRegion.Size = new System.Drawing.Size(100, 35);
            this.ComRegion.SelectedIndexChanged += new System.EventHandler(this.ComTime_SelectedIndexChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // ButBalances
            // 
            this.ButBalances.Font = new System.Drawing.Font("Arial", 9F);
            this.ButBalances.Image = global::TVSChungCu.Properties.Resources.Summary2004;
            this.ButBalances.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButBalances.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButBalances.Name = "ButBalances";
            this.ButBalances.Size = new System.Drawing.Size(158, 32);
            this.ButBalances.Text = "Cập nhật số dư đầu kỳ";
            this.ButBalances.Click += new System.EventHandler(this.ButBalances_Click);
            // 
            // ButCalculator
            // 
            this.ButCalculator.Font = new System.Drawing.Font("Arial", 9F);
            this.ButCalculator.Image = global::TVSChungCu.Properties.Resources.Calc2004;
            this.ButCalculator.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButCalculator.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButCalculator.Name = "ButCalculator";
            this.ButCalculator.Size = new System.Drawing.Size(82, 32);
            this.ButCalculator.Text = "Tính tiền";
            this.ButCalculator.Click += new System.EventHandler(this.ButCalculator_Click);
            // 
            // ComReportTitle
            // 
            this.ComReportTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComReportTitle.Name = "ComReportTitle";
            this.ComReportTitle.Size = new System.Drawing.Size(236, 35);
            this.ComReportTitle.Visible = false;
            this.ComReportTitle.SelectedIndexChanged += new System.EventHandler(this.ComTime_SelectedIndexChanged);
            // 
            // LblMess
            // 
            this.LblMess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.LblMess.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMess.ForeColor = System.Drawing.Color.Red;
            this.LblMess.Location = new System.Drawing.Point(192, 485);
            this.LblMess.Name = "LblMess";
            this.LblMess.Size = new System.Drawing.Size(732, 22);
            this.LblMess.TabIndex = 23;
            this.LblMess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkPrinter
            // 
            this.chkPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrinter.AutoSize = true;
            this.chkPrinter.BackColor = System.Drawing.Color.Transparent;
            this.chkPrinter.Location = new System.Drawing.Point(814, 44);
            this.chkPrinter.Name = "chkPrinter";
            this.chkPrinter.Size = new System.Drawing.Size(108, 20);
            this.chkPrinter.TabIndex = 24;
            this.chkPrinter.Text = "Chọn In tất cả";
            this.chkPrinter.UseVisualStyleBackColor = false;
            this.chkPrinter.CheckedChanged += new System.EventHandler(this.chkPrinter_CheckedChanged);
            // 
            // c1TrueDBGrid1
            // 
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
            this.c1TrueDBGrid1.FetchRowStyles = true;
            this.c1TrueDBGrid1.FilterBar = true;
            this.c1TrueDBGrid1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(6, 74);
            this.c1TrueDBGrid1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1TrueDBGrid1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.c1TrueDBGrid1.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
            this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
            this.c1TrueDBGrid1.RowHeight = 22;
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(922, 405);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid1.WrapCellPointer = true;
            this.c1TrueDBGrid1.Error += new C1.Win.C1TrueDBGrid.ErrorEventHandler(this.c1TrueDBGrid1_Error);
            this.c1TrueDBGrid1.BeforeColUpdate += new C1.Win.C1TrueDBGrid.BeforeColUpdateEventHandler(this.c1TrueDBGrid1_BeforeColUpdate);
            this.c1TrueDBGrid1.AfterColUpdate += new C1.Win.C1TrueDBGrid.ColEventHandler(this.c1TrueDBGrid1_AfterColUpdate);
            this.c1TrueDBGrid1.FetchRowStyle += new C1.Win.C1TrueDBGrid.FetchRowStyleEventHandler(this.c1TrueDBGrid1_FetchRowStyle);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(195, 485);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(733, 22);
            this.textBox1.TabIndex = 25;
            // 
            // frmServiceUsed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 511);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.chkPrinter);
            this.Controls.Add(this.LblMess);
            this.Controls.Add(this.ToolStripCalc);
            this.Controls.Add(this.ToolStripTop);
            this.Controls.Add(this.bNagGrid);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.ButFocus);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmServiceUsed";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DANH MỤC";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).EndInit();
            this.bNagGrid.ResumeLayout(false);
            this.bNagGrid.PerformLayout();
            this.ToolStripTop.ResumeLayout(false);
            this.ToolStripTop.PerformLayout();
            this.ToolStripCalc.ResumeLayout(false);
            this.ToolStripCalc.PerformLayout();
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
        private System.Windows.Forms.ToolStrip ToolStripTop;
        private System.Windows.Forms.ToolStripButton ButClose;
        private System.Windows.Forms.ToolStripButton ButAdd;
        private System.Windows.Forms.ToolStripButton ButEdit;
        private System.Windows.Forms.ToolStripButton ButDelete;
        private System.Windows.Forms.ToolStripButton ButSave;
        private System.Windows.Forms.ToolStripButton ButCancel;
        private System.Windows.Forms.Button ButFocus;
        private System.Windows.Forms.ToolStrip ToolStripCalc;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ComTime;
        private System.Windows.Forms.ToolStripButton ButBalances;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label LblMess;
        private System.Windows.Forms.ToolStripButton ButCalculator;
        private System.Windows.Forms.CheckBox chkPrinter;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox ComRegion;
        private System.Windows.Forms.ToolStripButton ButPrint;
        private System.Windows.Forms.ToolStripButton ButPrintPay;
        private System.Windows.Forms.ToolStripButton ButPrintList;
        private System.Windows.Forms.ToolStripComboBox ComReportTitle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnSendNotification;
        private System.Windows.Forms.TextBox textBox1;


    }
}

