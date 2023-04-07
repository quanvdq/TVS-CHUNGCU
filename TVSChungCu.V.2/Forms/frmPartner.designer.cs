namespace TVSMain
{
    partial class frmPartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPartner));
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bNagGrid = new System.Windows.Forms.BindingNavigator(this.components);
            this.lblMess = new System.Windows.Forms.Label();
            this.ToolStripTop = new System.Windows.Forms.ToolStrip();
            this.ButFocus = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ComListView = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TxtNameSearch = new System.Windows.Forms.ToolStripTextBox();
            this.ButAdd = new System.Windows.Forms.ToolStripButton();
            this.ButEdit = new System.Windows.Forms.ToolStripButton();
            this.ButDelete = new System.Windows.Forms.ToolStripButton();
            this.ButSave = new System.Windows.Forms.ToolStripButton();
            this.ButCancel = new System.Windows.Forms.ToolStripButton();
            this.ButClose = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).BeginInit();
            this.bNagGrid.SuspendLayout();
            this.ToolStripTop.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.bNagGrid.Location = new System.Drawing.Point(6, 533);
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
            // lblMess
            // 
            this.lblMess.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMess.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMess.ForeColor = System.Drawing.Color.Red;
            this.lblMess.Location = new System.Drawing.Point(196, 534);
            this.lblMess.Name = "lblMess";
            this.lblMess.Size = new System.Drawing.Size(682, 22);
            this.lblMess.TabIndex = 19;
            this.lblMess.Text = "Nhấn phím F2 để chọn giá trị";
            this.lblMess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ToolStripTop
            // 
            this.ToolStripTop.AutoSize = false;
            this.ToolStripTop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ToolStripTop.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ToolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButAdd,
            this.ButEdit,
            this.ButDelete,
            this.ButSave,
            this.ButCancel,
            this.ButClose});
            this.ToolStripTop.Location = new System.Drawing.Point(0, 0);
            this.ToolStripTop.Name = "ToolStripTop";
            this.ToolStripTop.Size = new System.Drawing.Size(884, 35);
            this.ToolStripTop.TabIndex = 20;
            this.ToolStripTop.Text = "toolStrip1";
            // 
            // ButFocus
            // 
            this.ButFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButFocus.Location = new System.Drawing.Point(137, 177);
            this.ButFocus.Name = "ButFocus";
            this.ButFocus.Size = new System.Drawing.Size(75, 23);
            this.ButFocus.TabIndex = 21;
            this.ButFocus.Text = "button1";
            this.ButFocus.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip1.Font = new System.Drawing.Font("Arial", 9.75F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.ComListView,
            this.toolStripLabel2,
            this.TxtNameSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 35);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 35);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.AutoSize = false;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(105, 32);
            this.toolStripLabel1.Text = "Dạng hiển thị :";
            this.toolStripLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ComListView
            // 
            this.ComListView.AutoSize = false;
            this.ComListView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComListView.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ComListView.Items.AddRange(new object[] {
            "Dạng danh sách",
            "Dạnh Ảnh"});
            this.ComListView.Name = "ComListView";
            this.ComListView.Size = new System.Drawing.Size(180, 35);
            this.ComListView.SelectedIndexChanged += new System.EventHandler(this.ComListView_SelectedIndexChanged);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(130, 32);
            this.toolStripLabel2.Text = "Tìm kiếm theo tên :";
            // 
            // TxtNameSearch
            // 
            this.TxtNameSearch.Font = new System.Drawing.Font("Arial", 9.75F);
            this.TxtNameSearch.Name = "TxtNameSearch";
            this.TxtNameSearch.Size = new System.Drawing.Size(350, 35);
            this.TxtNameSearch.TextChanged += new System.EventHandler(this.TxtNameSearch_TextChanged);
            // 
            // ButAdd
            // 
            this.ButAdd.Font = new System.Drawing.Font("Arial", 9F);
            this.ButAdd.Image = global::TVSChungCu.Properties.Resources.Add2014;
            this.ButAdd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(92, 32);
            this.ButAdd.Text = "Thêm mới";
            this.ButAdd.Click += new System.EventHandler(this.btnAddNew_Click);
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
            this.ButClose.Size = new System.Drawing.Size(39, 32);
            this.ButClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(6, 74);
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
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(872, 455);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid1.WrapCellPointer = true;
            this.c1TrueDBGrid1.Error += new C1.Win.C1TrueDBGrid.ErrorEventHandler(this.c1TrueDBGrid1_Error);
            this.c1TrueDBGrid1.ButtonClick += new C1.Win.C1TrueDBGrid.ColEventHandler(this.c1TrueDBGrid1_ButtonClick);
            this.c1TrueDBGrid1.FetchCellStyle += new C1.Win.C1TrueDBGrid.FetchCellStyleEventHandler(this.c1TrueDBGrid1_FetchCellStyle);
            this.c1TrueDBGrid1.DoubleClick += new System.EventHandler(this.c1TrueDBGrid1_DoubleClick);
            this.c1TrueDBGrid1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.c1TrueDBGrid1_KeyDown);
            this.c1TrueDBGrid1.FilterChange += new System.EventHandler(this.c1TrueDBGrid1_FilterChange);
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // frmPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ToolStripTop);
            this.Controls.Add(this.bNagGrid);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Controls.Add(this.ButFocus);
            this.Controls.Add(this.lblMess);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmPartner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ DANH MỤC";
            this.Load += new System.EventHandler(this.frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).EndInit();
            this.bNagGrid.ResumeLayout(false);
            this.bNagGrid.PerformLayout();
            this.ToolStripTop.ResumeLayout(false);
            this.ToolStripTop.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Label lblMess;
        private System.Windows.Forms.ToolStrip ToolStripTop;
        private System.Windows.Forms.ToolStripButton ButClose;
        private System.Windows.Forms.ToolStripButton ButAdd;
        private System.Windows.Forms.ToolStripButton ButEdit;
        private System.Windows.Forms.ToolStripButton ButDelete;
        private System.Windows.Forms.ToolStripButton ButSave;
        private System.Windows.Forms.ToolStripButton ButCancel;
        private System.Windows.Forms.Button ButFocus;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox ComListView;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TxtNameSearch;


    }
}

