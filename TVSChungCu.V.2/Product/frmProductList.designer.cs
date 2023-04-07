namespace TVSMain
{
    partial class frmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
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
            this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.dtpDateOption1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOption0 = new System.Windows.Forms.DateTimePicker();
            this.ToolStripCalc = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel4 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ButPrint = new System.Windows.Forms.ToolStripButton();
            this.ButClose = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).BeginInit();
            this.bNagGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
            this.ToolStripCalc.SuspendLayout();
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(58, 23);
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
            // 
            // bNagGrid
            // 
            this.bNagGrid.AddNewItem = null;
            this.bNagGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.bNagGrid.Location = new System.Drawing.Point(6, 469);
            this.bNagGrid.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bNagGrid.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bNagGrid.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bNagGrid.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bNagGrid.Name = "bNagGrid";
            this.bNagGrid.PositionItem = this.bindingNavigatorPositionItem;
            this.bNagGrid.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bNagGrid.Size = new System.Drawing.Size(202, 25);
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
            this.c1TrueDBGrid1.FilterBar = true;
            this.c1TrueDBGrid1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1TrueDBGrid1.GroupByCaption = "Drag a column header here to group by that column";
            this.c1TrueDBGrid1.Images.Add(((System.Drawing.Image)(resources.GetObject("c1TrueDBGrid1.Images"))));
            this.c1TrueDBGrid1.Location = new System.Drawing.Point(6, 39);
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
            this.c1TrueDBGrid1.Size = new System.Drawing.Size(961, 426);
            this.c1TrueDBGrid1.TabIndex = 0;
            this.c1TrueDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue;
            this.c1TrueDBGrid1.WrapCellPointer = true;
            this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
            // 
            // dtpDateOption1
            // 
            this.dtpDateOption1.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOption1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOption1.Location = new System.Drawing.Point(325, 9);
            this.dtpDateOption1.Name = "dtpDateOption1";
            this.dtpDateOption1.Size = new System.Drawing.Size(103, 21);
            this.dtpDateOption1.TabIndex = 38;
            this.dtpDateOption1.ValueChanged += new System.EventHandler(this.dtpDateOption0_ValueChanged);
            // 
            // dtpDateOption0
            // 
            this.dtpDateOption0.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOption0.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOption0.Location = new System.Drawing.Point(109, 8);
            this.dtpDateOption0.Name = "dtpDateOption0";
            this.dtpDateOption0.Size = new System.Drawing.Size(103, 21);
            this.dtpDateOption0.TabIndex = 36;
            this.dtpDateOption0.ValueChanged += new System.EventHandler(this.dtpDateOption0_ValueChanged);
            // 
            // ToolStripCalc
            // 
            this.ToolStripCalc.AutoSize = false;
            this.ToolStripCalc.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripCalc.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ToolStripCalc.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripCalc.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel3,
            this.toolStripLabel4,
            this.toolStripLabel2,
            this.toolStripSeparator1,
            this.ButPrint,
            this.ButClose});
            this.ToolStripCalc.Location = new System.Drawing.Point(0, 0);
            this.ToolStripCalc.Name = "ToolStripCalc";
            this.ToolStripCalc.Size = new System.Drawing.Size(974, 35);
            this.ToolStripCalc.TabIndex = 33;
            this.ToolStripCalc.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(100, 32);
            this.toolStripLabel1.Text = "         Từ ngày :";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.AutoSize = false;
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(150, 32);
            // 
            // toolStripLabel4
            // 
            this.toolStripLabel4.Name = "toolStripLabel4";
            this.toolStripLabel4.Size = new System.Drawing.Size(69, 32);
            this.toolStripLabel4.Text = "đến ngày :";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.AutoSize = false;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(150, 32);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // ButPrint
            // 
            this.ButPrint.Font = new System.Drawing.Font("Arial", 9F);
            this.ButPrint.Image = global::TVSChungCu.Properties.Resources.Print2014;
            this.ButPrint.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButPrint.Name = "ButPrint";
            this.ButPrint.Size = new System.Drawing.Size(106, 32);
            this.ButPrint.Text = "In danh sách";
            this.ButPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 499);
            this.ControlBox = false;
            this.Controls.Add(this.bNagGrid);
            this.Controls.Add(this.dtpDateOption1);
            this.Controls.Add(this.dtpDateOption0);
            this.Controls.Add(this.ToolStripCalc);
            this.Controls.Add(this.c1TrueDBGrid1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProductList";
            this.Text = "TỔNG HỢP VẬT TƯ";
            this.Load += new System.EventHandler(this.frm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.bNagGrid)).EndInit();
            this.bNagGrid.ResumeLayout(false);
            this.bNagGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
            this.ToolStripCalc.ResumeLayout(false);
            this.ToolStripCalc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
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
        private System.Windows.Forms.DateTimePicker dtpDateOption0;
        private System.Windows.Forms.DateTimePicker dtpDateOption1;
        private System.Windows.Forms.ToolStrip ToolStripCalc;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ButPrint;
        private System.Windows.Forms.ToolStripButton ButClose; 


    }
}

