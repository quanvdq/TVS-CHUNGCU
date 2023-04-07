namespace TVSMain
{
    partial class frmRoomMap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoomMap));
            this.ButFocus = new System.Windows.Forms.Button();
            this.ButClose = new System.Windows.Forms.ToolStripButton();
            this.ToolStripTop = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.ComRegion = new System.Windows.Forms.ToolStripComboBox();
            this.ButConfig = new System.Windows.Forms.ToolStripButton();
            this.PanMain = new System.Windows.Forms.Panel();
            this.ToolStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButFocus
            // 
            this.ButFocus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButFocus.Location = new System.Drawing.Point(757, 12);
            this.ButFocus.Name = "ButFocus";
            this.ButFocus.Size = new System.Drawing.Size(75, 23);
            this.ButFocus.TabIndex = 21;
            this.ButFocus.Text = "button1";
            this.ButFocus.UseVisualStyleBackColor = true;
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
            // ToolStripTop
            // 
            this.ToolStripTop.AutoSize = false;
            this.ToolStripTop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripTop.Font = new System.Drawing.Font("Arial", 9.75F);
            this.ToolStripTop.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ButClose,
            this.toolStripLabel2,
            this.ComRegion,
            this.ButConfig});
            this.ToolStripTop.Location = new System.Drawing.Point(0, 0);
            this.ToolStripTop.Name = "ToolStripTop";
            this.ToolStripTop.Size = new System.Drawing.Size(984, 35);
            this.ToolStripTop.TabIndex = 20;
            this.ToolStripTop.Text = "toolStrip1";
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
            this.ComRegion.Size = new System.Drawing.Size(120, 35);
            this.ComRegion.SelectedIndexChanged += new System.EventHandler(this.ComRegion_SelectedIndexChanged);
            // 
            // ButConfig
            // 
            this.ButConfig.Font = new System.Drawing.Font("Arial", 9F);
            this.ButConfig.Image = global::TVSChungCu.Properties.Resources.Config;
            this.ButConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ButConfig.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ButConfig.Name = "ButConfig";
            this.ButConfig.Size = new System.Drawing.Size(115, 32);
            this.ButConfig.Text = "Cấu hình phòng";
            this.ButConfig.Click += new System.EventHandler(this.ButConfig_Click);
            // 
            // PanMain
            // 
            this.PanMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanMain.AutoScroll = true;
            this.PanMain.BackColor = System.Drawing.Color.Transparent;
            this.PanMain.Location = new System.Drawing.Point(0, 38);
            this.PanMain.Name = "PanMain";
            this.PanMain.Size = new System.Drawing.Size(984, 418);
            this.PanMain.TabIndex = 74;
            // 
            // frmRoomMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 457);
            this.ControlBox = false;
            this.Controls.Add(this.PanMain);
            this.Controls.Add(this.ToolStripTop);
            this.Controls.Add(this.ButFocus);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRoomMap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SƠ ĐỒ PHÒNG - CĂN HỘ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_Load);
            this.Shown += new System.EventHandler(this.frmRoomMap_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_KeyDown);
            this.ToolStripTop.ResumeLayout(false);
            this.ToolStripTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButFocus;
        private System.Windows.Forms.ToolStripButton ButClose;
        private System.Windows.Forms.ToolStrip ToolStripTop;
        private System.Windows.Forms.Panel PanMain;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox ComRegion;
        private System.Windows.Forms.ToolStripButton ButConfig;


    }
}

