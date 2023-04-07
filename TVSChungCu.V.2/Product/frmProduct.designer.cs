namespace TVSMain
{
    partial class frmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bNagGrid = new System.Windows.Forms.BindingNavigator(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDateOption1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtMoney = new System.Windows.Forms.TextBox();
            this.c1TrueDBGrid2 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnDAddNew = new System.Windows.Forms.Button();
            this.btnDEdit = new System.Windows.Forms.Button();
            this.btnDCancel = new System.Windows.Forms.Button();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.btnDDelete = new System.Windows.Forms.Button();
            this.btnDUpdate = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.btnPrinter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).BeginInit();
            this.bNagGrid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).BeginInit();
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
            this.bNagGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.bNagGrid.Location = new System.Drawing.Point(3, 26);
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnPrinter);
            this.groupBox1.Controls.Add(this.btnAddNew);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Location = new System.Drawing.Point(252, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(726, 63);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.textBox5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpDateOption1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(252, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 102);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(99, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(609, 22);
            this.textBox5.TabIndex = 5;
            this.textBox5.Leave += new System.EventHandler(this.txtLeave);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.textBox5.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 52;
            this.label6.Text = "Ghi chú :";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.Location = new System.Drawing.Point(505, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(203, 22);
            this.textBox4.TabIndex = 4;
            this.textBox4.Leave += new System.EventHandler(this.txtLeave);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.textBox4.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Điện thoại :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(99, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(316, 22);
            this.textBox3.TabIndex = 3;
            this.textBox3.Leave += new System.EventHandler(this.txtLeave);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.textBox3.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "Địa chỉ :";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(505, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 22);
            this.textBox2.TabIndex = 2;
            this.textBox2.Leave += new System.EventHandler(this.txtLeave);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.textBox2.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 46;
            this.label3.Text = "Đối tác :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 23);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(72, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Ngày nhập :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpDateOption1
            // 
            this.dtpDateOption1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpDateOption1.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOption1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOption1.Location = new System.Drawing.Point(312, 20);
            this.dtpDateOption1.Name = "dtpDateOption1";
            this.dtpDateOption1.Size = new System.Drawing.Size(103, 22);
            this.dtpDateOption1.TabIndex = 1;
            this.dtpDateOption1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "NH/20141128-1530";
            this.textBox1.Leave += new System.EventHandler(this.txtLeave);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            this.textBox1.Enter += new System.EventHandler(this.txtEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số hóa đơn :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TxtMoney);
            this.groupBox2.Controls.Add(this.btnDAddNew);
            this.groupBox2.Controls.Add(this.btnDEdit);
            this.groupBox2.Controls.Add(this.btnDCancel);
            this.groupBox2.Controls.Add(this.bNagGrid);
            this.groupBox2.Controls.Add(this.btnDDelete);
            this.groupBox2.Controls.Add(this.btnDUpdate);
            this.groupBox2.Location = new System.Drawing.Point(6, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(972, 63);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            // 
            // TxtMoney
            // 
            this.TxtMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.TxtMoney.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMoney.ForeColor = System.Drawing.Color.Red;
            this.TxtMoney.Location = new System.Drawing.Point(844, 21);
            this.TxtMoney.Name = "TxtMoney";
            this.TxtMoney.ReadOnly = true;
            this.TxtMoney.Size = new System.Drawing.Size(110, 29);
            this.TxtMoney.TabIndex = 17;
            this.TxtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // c1TrueDBGrid2
            // 
            this.c1TrueDBGrid2.AllowFilter = false;
            this.c1TrueDBGrid2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.c1TrueDBGrid2.AllowUpdate = false;
            this.c1TrueDBGrid2.AlternatingRows = true;
            this.c1TrueDBGrid2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.c1TrueDBGrid2.BackColor = System.Drawing.Color.White;
            this.c1TrueDBGrid2.CaptionHeight = 17;
            this.c1TrueDBGrid2.CollapseColor = System.Drawing.Color.Empty;
            this.c1TrueDBGrid2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.c1TrueDBGrid2.ExpandColor = System.Drawing.Color.Empty;
            this.c1TrueDBGrid2.ExtendRightColumn = true;
            this.c1TrueDBGrid2.FilterBar = true;
            this.c1TrueDBGrid2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TrueDBGrid2.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid2.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid2.Images"))));
            this.c1TrueDBGrid2.Location = new System.Drawing.Point(252, 178);
            this.c1TrueDBGrid2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.c1TrueDBGrid2.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.c1TrueDBGrid2.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.c1TrueDBGrid2.Name = "c1TrueDBGrid2";
            this.c1TrueDBGrid2.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.c1TrueDBGrid2.PreviewInfo.ZoomFactor = 75;
            this.c1TrueDBGrid2.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid2.PrintInfo.PageSettings")));
            this.c1TrueDBGrid2.RecordSelectors = false;
            this.c1TrueDBGrid2.RowHeight = 22;
            this.c1TrueDBGrid2.Size = new System.Drawing.Size(726, 264);
            this.c1TrueDBGrid2.TabIndex = 35;
            this.c1TrueDBGrid2.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid2.WrapCellPointer = true;
            this.c1TrueDBGrid2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1TrueDBGrid2_KeyDown);
            this.c1TrueDBGrid2.AfterColUpdate += new C1.Win.C1TrueDBGrid.ColEventHandler(this.c1TrueDBGrid2_AfterColUpdate);
            this.c1TrueDBGrid2.PropBag = resources.GetString("c1TrueDBGrid2.PropBag");
            // 
            // btnDAddNew
            // 
            this.btnDAddNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnDAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnDAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnDAddNew.Image")));
            this.btnDAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDAddNew.Location = new System.Drawing.Point(256, 18);
            this.btnDAddNew.Name = "btnDAddNew";
            this.btnDAddNew.Size = new System.Drawing.Size(104, 35);
            this.btnDAddNew.TabIndex = 12;
            this.btnDAddNew.Text = "Thêm mới";
            this.btnDAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDAddNew.UseVisualStyleBackColor = true;
            this.btnDAddNew.Click += new System.EventHandler(this.btnDAddNew_Click);
            // 
            // btnDEdit
            // 
            this.btnDEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnDEdit.Enabled = false;
            this.btnDEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnDEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnDEdit.Image")));
            this.btnDEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDEdit.Location = new System.Drawing.Point(365, 18);
            this.btnDEdit.Name = "btnDEdit";
            this.btnDEdit.Size = new System.Drawing.Size(90, 35);
            this.btnDEdit.TabIndex = 13;
            this.btnDEdit.Text = "  Sửa đổi";
            this.btnDEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDEdit.UseVisualStyleBackColor = true;
            this.btnDEdit.Click += new System.EventHandler(this.btnDEdit_Click);
            // 
            // btnDCancel
            // 
            this.btnDCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnDCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnDCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnDCancel.Image")));
            this.btnDCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDCancel.Location = new System.Drawing.Point(655, 18);
            this.btnDCancel.Name = "btnDCancel";
            this.btnDCancel.Size = new System.Drawing.Size(90, 35);
            this.btnDCancel.TabIndex = 16;
            this.btnDCancel.Text = "   Bỏ qua ";
            this.btnDCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDCancel.UseVisualStyleBackColor = true;
            this.btnDCancel.Click += new System.EventHandler(this.btnDCancel_Click);
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
            // btnDDelete
            // 
            this.btnDDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDDelete.Enabled = false;
            this.btnDDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnDDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDDelete.Image")));
            this.btnDDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDDelete.Location = new System.Drawing.Point(459, 18);
            this.btnDDelete.Name = "btnDDelete";
            this.btnDDelete.Size = new System.Drawing.Size(93, 35);
            this.btnDDelete.TabIndex = 14;
            this.btnDDelete.Text = "   Loại bỏ";
            this.btnDDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDDelete.UseVisualStyleBackColor = true;
            this.btnDDelete.Click += new System.EventHandler(this.btnDDelete_Click);
            // 
            // btnDUpdate
            // 
            this.btnDUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnDUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnDUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnDUpdate.Image")));
            this.btnDUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDUpdate.Location = new System.Drawing.Point(556, 18);
            this.btnDUpdate.Name = "btnDUpdate";
            this.btnDUpdate.Size = new System.Drawing.Size(95, 35);
            this.btnDUpdate.TabIndex = 15;
            this.btnDUpdate.Text = "  Ghi nhận";
            this.btnDUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDUpdate.UseVisualStyleBackColor = true;
            this.btnDUpdate.Click += new System.EventHandler(this.btnDUpdate_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnAddNew.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNew.Image")));
            this.btnAddNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNew.Location = new System.Drawing.Point(10, 19);
            this.btnAddNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(104, 35);
            this.btnAddNew.TabIndex = 12;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(119, 19);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(90, 35);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "  Sửa đổi";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.SystemColors.Control;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::TVSChungCu.Properties.Resources.Close2014;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(598, 19);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(110, 35);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = " Thoát [ESC]";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnDelete.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(213, 19);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 35);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "    Loại bỏ";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(409, 19);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 35);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "   Bỏ qua";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(310, 19);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 35);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "  Ghi nhận";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // c1TrueDBGrid1
            // 
            this.c1TrueDBGrid1.AllowFilter = false;
            this.c1TrueDBGrid1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.c1TrueDBGrid1.AllowUpdate = false;
            this.c1TrueDBGrid1.AlternatingRows = true;
            this.c1TrueDBGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
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
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(6, 6);
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
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(240, 436);
            this.c1TrueDBGrid1.TabIndex = 7;
            this.c1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid1.WrapCellPointer = true;
            this.c1TrueDBGrid1.Error += new C1.Win.C1TrueDBGrid.ErrorEventHandler(this.c1TrueDBGrid1_Error);
            this.c1TrueDBGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1TrueDBGrid1_KeyDown);
            this.c1TrueDBGrid1.FilterChange += new System.EventHandler(this.c1TrueDBGrid1_FilterChange);
            this.c1TrueDBGrid1.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.c1TrueDBGrid1_RowColChange);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // btnPrinter
            // 
            this.btnPrinter.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrinter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.btnPrinter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(224)))), ((int)(((byte)(255)))));
            this.btnPrinter.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrinter.Image = global::TVSChungCu.Properties.Resources.Print2014;
            this.btnPrinter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrinter.Location = new System.Drawing.Point(502, 19);
            this.btnPrinter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrinter.Name = "btnPrinter";
            this.btnPrinter.Size = new System.Drawing.Size(90, 35);
            this.btnPrinter.TabIndex = 18;
            this.btnPrinter.Text = "In phiếu";
            this.btnPrinter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPrinter.UseVisualStyleBackColor = true;
            this.btnPrinter.Click += new System.EventHandler(this.btnPrinter_Click);
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 512);
            this.ControlBox = false;
            this.Controls.Add(this.c1TrueDBGrid2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ NHẬP VẬT TƯ, NHIÊN LIỆU";
            this.Load += new System.EventHandler(this.frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).EndInit();
            this.bNagGrid.ResumeLayout(false);
            this.bNagGrid.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDateOption1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDUpdate;
        private System.Windows.Forms.Button btnDDelete;
        private System.Windows.Forms.Button btnDCancel;
        private System.Windows.Forms.Button btnDEdit;
        private System.Windows.Forms.Button btnDAddNew;
        private System.Windows.Forms.GroupBox groupBox2;
        public C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid2;
        private System.Windows.Forms.TextBox TxtMoney;
        private System.Windows.Forms.Button btnPrinter;


    }
}

