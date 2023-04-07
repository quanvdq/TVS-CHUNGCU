namespace TVSReports
{
    /// <summary>
    /// Summary description for Repdialytoday.
    /// </summary>
    partial class rptPaymentVoucherListTotal
    {
        private DataDynamics.ActiveReports.Detail detail;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

        #region ActiveReport Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptPaymentVoucherListTotal));
            this.lblTitle = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.textBox12 = new DataDynamics.ActiveReports.TextBox();
            this.textBox15 = new DataDynamics.ActiveReports.TextBox();
            this.textBox13 = new DataDynamics.ActiveReports.TextBox();
            this.textBox11 = new DataDynamics.ActiveReports.TextBox();
            this.textBox9 = new DataDynamics.ActiveReports.TextBox();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.lblRepDay = new DataDynamics.ActiveReports.Label();
            this.subrptHeader = new DataDynamics.ActiveReports.SubReport();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.subrptFooter = new DataDynamics.ActiveReports.SubReport();
            this.line1 = new DataDynamics.ActiveReports.Line();
            this.pageHeader1 = new DataDynamics.ActiveReports.PageHeader();
            this.pageFooter1 = new DataDynamics.ActiveReports.PageFooter();
            this.groupHeader1 = new DataDynamics.ActiveReports.GroupHeader();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.label10 = new DataDynamics.ActiveReports.Label();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.groupFooter1 = new DataDynamics.ActiveReports.GroupFooter();
            this.groupHeader2 = new DataDynamics.ActiveReports.GroupHeader();
            this.textBox6 = new DataDynamics.ActiveReports.TextBox();
            this.groupFooter2 = new DataDynamics.ActiveReports.GroupFooter();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.TxtIndex = new DataDynamics.ActiveReports.TextBox();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.textBox4 = new DataDynamics.ActiveReports.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRepDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // lblTitle
            // 
            this.lblTitle.Border.BottomColor = System.Drawing.Color.Black;
            this.lblTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTitle.Border.LeftColor = System.Drawing.Color.Black;
            this.lblTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTitle.Border.RightColor = System.Drawing.Color.Black;
            this.lblTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTitle.Border.TopColor = System.Drawing.Color.Black;
            this.lblTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblTitle.Height = 0.59375F;
            this.lblTitle.HyperLink = null;
            this.lblTitle.Left = 0F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 13.25pt; font-" +
                "family: Arial; vertical-align: bottom; ";
            this.lblTitle.Text = "BÁO CÁO THU TIỀN MẶT";
            this.lblTitle.Top = 0.25F;
            this.lblTitle.Width = 7.5F;
            // 
            // detail
            // 
            this.detail.CanShrink = true;
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox12,
            this.textBox15,
            this.textBox13,
            this.textBox11,
            this.textBox9});
            this.detail.Height = 0F;
            this.detail.KeepTogether = true;
            this.detail.Name = "detail";
            this.detail.Visible = false;
            this.detail.BeforePrint += new System.EventHandler(this.detail_BeforePrint);
            // 
            // textBox12
            // 
            this.textBox12.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox12.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox12.Border.RightColor = System.Drawing.Color.Black;
            this.textBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox12.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox12.DataField = "Money";
            this.textBox12.Height = 0.25F;
            this.textBox12.Left = 6.375F;
            this.textBox12.Name = "textBox12";
            this.textBox12.OutputFormat = resources.GetString("textBox12.OutputFormat");
            this.textBox12.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox12.Text = null;
            this.textBox12.Top = 0F;
            this.textBox12.Width = 1.125F;
            // 
            // textBox15
            // 
            this.textBox15.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.RightColor = System.Drawing.Color.Black;
            this.textBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.TopColor = System.Drawing.Color.Black;
            this.textBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox15.DataField = "NamePartner";
            this.textBox15.Height = 0.25F;
            this.textBox15.Left = 2.188F;
            this.textBox15.Name = "textBox15";
            this.textBox15.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; background-color: White; " +
                "font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox15.Text = null;
            this.textBox15.Top = 0F;
            this.textBox15.Width = 1.875F;
            // 
            // textBox13
            // 
            this.textBox13.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox13.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox13.Border.RightColor = System.Drawing.Color.Black;
            this.textBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox13.Border.TopColor = System.Drawing.Color.Black;
            this.textBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox13.DataField = "CodePaymentVoucher";
            this.textBox13.Height = 0.25F;
            this.textBox13.Left = 1.125F;
            this.textBox13.Name = "textBox13";
            this.textBox13.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; background-color: White" +
                "; font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox13.Text = null;
            this.textBox13.Top = 0F;
            this.textBox13.Width = 1.063F;
            // 
            // textBox11
            // 
            this.textBox11.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.RightColor = System.Drawing.Color.Black;
            this.textBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.TopColor = System.Drawing.Color.Black;
            this.textBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox11.DataField = "DatePaymentVoucher";
            this.textBox11.Height = 0.25F;
            this.textBox11.Left = 0.375F;
            this.textBox11.Name = "textBox11";
            this.textBox11.OutputFormat = resources.GetString("textBox11.OutputFormat");
            this.textBox11.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; background-color: White" +
                "; font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox11.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.DCount;
            this.textBox11.Text = null;
            this.textBox11.Top = 0F;
            this.textBox11.Width = 0.75F;
            // 
            // textBox9
            // 
            this.textBox9.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.RightColor = System.Drawing.Color.Black;
            this.textBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox9.Height = 0.25F;
            this.textBox9.Left = 0F;
            this.textBox9.Name = "textBox9";
            this.textBox9.OutputFormat = resources.GetString("textBox9.OutputFormat");
            this.textBox9.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; background-color: White" +
                "; font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox9.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.Count;
            this.textBox9.SummaryGroup = "groupHeader2";
            this.textBox9.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group;
            this.textBox9.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox9.Text = null;
            this.textBox9.Top = 0F;
            this.textBox9.Width = 0.375F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblTitle,
            this.lblRepDay,
            this.subrptHeader});
            this.reportHeader1.Height = 1.010417F;
            this.reportHeader1.Name = "reportHeader1";
            // 
            // lblRepDay
            // 
            this.lblRepDay.Border.BottomColor = System.Drawing.Color.Black;
            this.lblRepDay.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblRepDay.Border.LeftColor = System.Drawing.Color.Black;
            this.lblRepDay.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblRepDay.Border.RightColor = System.Drawing.Color.Black;
            this.lblRepDay.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblRepDay.Border.TopColor = System.Drawing.Color.Black;
            this.lblRepDay.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblRepDay.Height = 0.15625F;
            this.lblRepDay.HyperLink = null;
            this.lblRepDay.Left = 0F;
            this.lblRepDay.Name = "lblRepDay";
            this.lblRepDay.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-style: normal; font-" +
                "size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.lblRepDay.Text = "";
            this.lblRepDay.Top = 0.84375F;
            this.lblRepDay.Width = 7.5F;
            // 
            // subrptHeader
            // 
            this.subrptHeader.Border.BottomColor = System.Drawing.Color.Black;
            this.subrptHeader.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptHeader.Border.LeftColor = System.Drawing.Color.Black;
            this.subrptHeader.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptHeader.Border.RightColor = System.Drawing.Color.Black;
            this.subrptHeader.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptHeader.Border.TopColor = System.Drawing.Color.Black;
            this.subrptHeader.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptHeader.CloseBorder = false;
            this.subrptHeader.Height = 0.25F;
            this.subrptHeader.Left = 0F;
            this.subrptHeader.Name = "subrptHeader";
            this.subrptHeader.Report = null;
            this.subrptHeader.ReportName = "";
            this.subrptHeader.Top = 0F;
            this.subrptHeader.Width = 7.5F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subrptFooter,
            this.line1});
            this.reportFooter1.Height = 0.3125F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // subrptFooter
            // 
            this.subrptFooter.Border.BottomColor = System.Drawing.Color.Black;
            this.subrptFooter.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptFooter.Border.LeftColor = System.Drawing.Color.Black;
            this.subrptFooter.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptFooter.Border.RightColor = System.Drawing.Color.Black;
            this.subrptFooter.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptFooter.Border.TopColor = System.Drawing.Color.Black;
            this.subrptFooter.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subrptFooter.CloseBorder = false;
            this.subrptFooter.Height = 0.25F;
            this.subrptFooter.Left = 0F;
            this.subrptFooter.Name = "subrptFooter";
            this.subrptFooter.Report = null;
            this.subrptFooter.ReportName = "";
            this.subrptFooter.Top = 0.03125F;
            this.subrptFooter.Width = 7.5F;
            // 
            // line1
            // 
            this.line1.Border.BottomColor = System.Drawing.Color.Black;
            this.line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.LeftColor = System.Drawing.Color.Black;
            this.line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.RightColor = System.Drawing.Color.Black;
            this.line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Border.TopColor = System.Drawing.Color.Black;
            this.line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.line1.Height = 0F;
            this.line1.Left = 0F;
            this.line1.LineWeight = 1F;
            this.line1.Name = "line1";
            this.line1.Top = 0F;
            this.line1.Width = 7.5F;
            this.line1.X1 = 0F;
            this.line1.X2 = 7.5F;
            this.line1.Y1 = 0F;
            this.line1.Y2 = 0F;
            // 
            // pageHeader1
            // 
            this.pageHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label1,
            this.textBox4});
            this.pageHeader1.Height = 0.28125F;
            this.pageHeader1.Name = "pageHeader1";
            // 
            // pageFooter1
            // 
            this.pageFooter1.Height = 0F;
            this.pageFooter1.Name = "pageFooter1";
            this.pageFooter1.Visible = false;
            // 
            // groupHeader1
            // 
            this.groupHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label7,
            this.label10,
            this.textBox2});
            this.groupHeader1.DataField = "Group";
            this.groupHeader1.Height = 0.2916667F;
            this.groupHeader1.Name = "groupHeader1";
            this.groupHeader1.BeforePrint += new System.EventHandler(this.groupHeader1_BeforePrint);
            // 
            // label7
            // 
            this.label7.Border.BottomColor = System.Drawing.Color.Black;
            this.label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label7.Border.LeftColor = System.Drawing.Color.Black;
            this.label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label7.Border.RightColor = System.Drawing.Color.Black;
            this.label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.TopColor = System.Drawing.Color.Black;
            this.label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Height = 0.3125F;
            this.label7.HyperLink = null;
            this.label7.Left = 0F;
            this.label7.Name = "label7";
            this.label7.Style = "text-align: center; font-weight: bold; background-color: #E0E0E0; font-size: 9pt;" +
                " vertical-align: middle; ";
            this.label7.Text = "";
            this.label7.Top = 0F;
            this.label7.Width = 0.375F;
            // 
            // label10
            // 
            this.label10.Border.BottomColor = System.Drawing.Color.Black;
            this.label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label10.Border.LeftColor = System.Drawing.Color.Black;
            this.label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.Border.RightColor = System.Drawing.Color.Black;
            this.label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label10.Border.TopColor = System.Drawing.Color.Black;
            this.label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label10.DataField = "Group";
            this.label10.Height = 0.3125F;
            this.label10.HyperLink = null;
            this.label10.Left = 0.375F;
            this.label10.Name = "label10";
            this.label10.Style = "text-align: left; font-weight: bold; background-color: #E0E0E0; font-size: 9.75pt" +
                "; vertical-align: middle; ";
            this.label10.Text = "";
            this.label10.Top = 0F;
            this.label10.Width = 5.65625F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.RightColor = System.Drawing.Color.Black;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.TopColor = System.Drawing.Color.Black;
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.DataField = "Money";
            this.textBox2.Height = 0.3125F;
            this.textBox2.Left = 6.03125F;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: #E0E0E0;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox2.SummaryGroup = "groupHeader1";
            this.textBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox2.Text = null;
            this.textBox2.Top = 0F;
            this.textBox2.Width = 1.46875F;
            // 
            // groupFooter1
            // 
            this.groupFooter1.Height = 0F;
            this.groupFooter1.Name = "groupFooter1";
            this.groupFooter1.Visible = false;
            // 
            // groupHeader2
            // 
            this.groupHeader2.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.TxtIndex,
            this.textBox1,
            this.textBox6});
            this.groupHeader2.DataField = "IDPaymentVoucherType";
            this.groupHeader2.Height = 0.28125F;
            this.groupHeader2.Name = "groupHeader2";
            this.groupHeader2.BeforePrint += new System.EventHandler(this.groupHeader2_BeforePrint);
            // 
            // textBox6
            // 
            this.textBox6.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dash;
            this.textBox6.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.Border.RightColor = System.Drawing.Color.Black;
            this.textBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.Border.TopColor = System.Drawing.Color.Black;
            this.textBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox6.DataField = "Money";
            this.textBox6.Height = 0.28125F;
            this.textBox6.Left = 6.03125F;
            this.textBox6.Name = "textBox6";
            this.textBox6.OutputFormat = resources.GetString("textBox6.OutputFormat");
            this.textBox6.Style = "ddo-char-set: 1; text-align: right; font-weight: normal; font-size: 9pt; font-fam" +
                "ily: Arial; vertical-align: middle; ";
            this.textBox6.SummaryGroup = "groupHeader2";
            this.textBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal;
            this.textBox6.Text = null;
            this.textBox6.Top = 0F;
            this.textBox6.Width = 1.46875F;
            // 
            // groupFooter2
            // 
            this.groupFooter2.Height = 0F;
            this.groupFooter2.Name = "groupFooter2";
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dash;
            this.textBox1.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.RightColor = System.Drawing.Color.Black;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.TopColor = System.Drawing.Color.Black;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.DataField = "IDPaymentVoucherType";
            this.textBox1.Height = 0.28125F;
            this.textBox1.Left = 0.65625F;
            this.textBox1.Name = "textBox1";
            this.textBox1.OutputFormat = resources.GetString("textBox1.OutputFormat");
            this.textBox1.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-size: 9pt; font-fami" +
                "ly: Arial; vertical-align: middle; ";
            this.textBox1.Text = null;
            this.textBox1.Top = 0F;
            this.textBox1.Width = 5.375F;
            // 
            // TxtIndex
            // 
            this.TxtIndex.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TxtIndex.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dash;
            this.TxtIndex.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TxtIndex.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.TxtIndex.Border.RightColor = System.Drawing.Color.Black;
            this.TxtIndex.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.TxtIndex.Border.TopColor = System.Drawing.Color.Black;
            this.TxtIndex.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.TxtIndex.Height = 0.28125F;
            this.TxtIndex.Left = 0F;
            this.TxtIndex.Name = "TxtIndex";
            this.TxtIndex.OutputFormat = resources.GetString("TxtIndex.OutputFormat");
            this.TxtIndex.Style = "ddo-char-set: 1; text-align: center; font-weight: normal; font-size: 9pt; font-fa" +
                "mily: Arial; vertical-align: middle; ";
            this.TxtIndex.Text = null;
            this.TxtIndex.Top = 0F;
            this.TxtIndex.Width = 0.65625F;
            // 
            // label1
            // 
            this.label1.Border.BottomColor = System.Drawing.Color.Black;
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.LeftColor = System.Drawing.Color.Black;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.RightColor = System.Drawing.Color.Black;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.TopColor = System.Drawing.Color.Black;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Height = 0.3125F;
            this.label1.HyperLink = null;
            this.label1.Left = 0F;
            this.label1.Name = "label1";
            this.label1.Style = "text-align: center; font-weight: bold; background-color: #80FF80; font-size: 9.75" +
                "pt; vertical-align: middle; ";
            this.label1.Text = "KHOẢN THU / CHI";
            this.label1.Top = 0F;
            this.label1.Width = 6.03125F;
            // 
            // textBox4
            // 
            this.textBox4.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.textBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.RightColor = System.Drawing.Color.Black;
            this.textBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.TopColor = System.Drawing.Color.Black;
            this.textBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Height = 0.3125F;
            this.textBox4.Left = 6.03125F;
            this.textBox4.Name = "textBox4";
            this.textBox4.OutputFormat = resources.GetString("textBox4.OutputFormat");
            this.textBox4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: #80FF80" +
                "; font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox4.Text = "SỐ TIỀN";
            this.textBox4.Top = 0F;
            this.textBox4.Width = 1.46875F;
            // 
            // rptPaymentVoucherListTotal
            // 
            this.MasterReport = false;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0.2F;
            this.PageSettings.Margins.Left = 0.35F;
            this.PageSettings.Margins.Right = 0.3F;
            this.PageSettings.Margins.Top = 0.35F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait;
            this.PageSettings.PaperHeight = 11.69291F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.PageSettings.PaperWidth = 8.267716F;
            this.PrintWidth = 7.520844F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader1);
            this.Sections.Add(this.groupHeader1);
            this.Sections.Add(this.groupHeader2);
            this.Sections.Add(this.detail);
            this.Sections.Add(this.groupFooter2);
            this.Sections.Add(this.groupFooter1);
            this.Sections.Add(this.pageFooter1);
            this.Sections.Add(this.reportFooter1);
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" +
                        "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204; ", "Heading1", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" +
                        "lic; ddo-char-set: 204; ", "Heading2", "Normal"));
            this.StyleSheet.Add(new DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ddo-char-set: 204; ", "Heading3", "Normal"));
            this.ReportStart += new System.EventHandler(this.rptPaymentVoucherList_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRepDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label lblTitle;
        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.PageHeader pageHeader1;
        private DataDynamics.ActiveReports.PageFooter pageFooter1;
        private DataDynamics.ActiveReports.Label lblRepDay;
        private DataDynamics.ActiveReports.TextBox textBox12;
        private DataDynamics.ActiveReports.GroupHeader groupHeader1;
        private DataDynamics.ActiveReports.Label label7;
        private DataDynamics.ActiveReports.Label label10;
        private DataDynamics.ActiveReports.GroupFooter groupFooter1;
        private DataDynamics.ActiveReports.TextBox textBox9;
        private DataDynamics.ActiveReports.TextBox textBox11;
        private DataDynamics.ActiveReports.TextBox textBox13;
        private DataDynamics.ActiveReports.TextBox textBox15;
        private DataDynamics.ActiveReports.SubReport subrptHeader;
        private DataDynamics.ActiveReports.SubReport subrptFooter;
        private DataDynamics.ActiveReports.GroupHeader groupHeader2;
        private DataDynamics.ActiveReports.GroupFooter groupFooter2;
        private DataDynamics.ActiveReports.TextBox textBox6;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.Line line1;
        private DataDynamics.ActiveReports.TextBox TxtIndex;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.TextBox textBox4;
    }
}
