namespace TVSReports
{
    /// <summary>
    /// Summary description for Repdialytoday.
    /// </summary>
    partial class rptServiceList
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptServiceList));
            this.lblTitle = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.textBox9 = new DataDynamics.ActiveReports.TextBox();
            this.textBox11 = new DataDynamics.ActiveReports.TextBox();
            this.textBox8 = new DataDynamics.ActiveReports.TextBox();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.textBox4 = new DataDynamics.ActiveReports.TextBox();
            this.textBox7 = new DataDynamics.ActiveReports.TextBox();
            this.textBox12 = new DataDynamics.ActiveReports.TextBox();
            this.textBox13 = new DataDynamics.ActiveReports.TextBox();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.lblRepDay = new DataDynamics.ActiveReports.Label();
            this.subrptHeader = new DataDynamics.ActiveReports.SubReport();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.subrptFooter = new DataDynamics.ActiveReports.SubReport();
            this.textBox5 = new DataDynamics.ActiveReports.TextBox();
            this.textBox6 = new DataDynamics.ActiveReports.TextBox();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.textBox15 = new DataDynamics.ActiveReports.TextBox();
            this.textBox10 = new DataDynamics.ActiveReports.TextBox();
            this.textBox14 = new DataDynamics.ActiveReports.TextBox();
            this.pageHeader1 = new DataDynamics.ActiveReports.PageHeader();
            this.label12 = new DataDynamics.ActiveReports.Label();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.label13 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.label9 = new DataDynamics.ActiveReports.Label();
            this.label8 = new DataDynamics.ActiveReports.Label();
            this.pageFooter1 = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRepDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
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
            this.lblTitle.Height = 0.469F;
            this.lblTitle.HyperLink = null;
            this.lblTitle.Left = 0F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 13.25pt; font-" +
                "family: Arial; vertical-align: bottom; ";
            this.lblTitle.Text = "DANH SÁCH CHI PHÍ CHUNG, TIỀN DỊCH VỤ";
            this.lblTitle.Top = 0.25F;
            this.lblTitle.Width = 7.53125F;
            // 
            // detail
            // 
            this.detail.CanShrink = true;
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox9,
            this.textBox11,
            this.textBox8,
            this.textBox1,
            this.textBox4,
            this.textBox7,
            this.textBox12,
            this.textBox13});
            this.detail.Height = 0.25F;
            this.detail.KeepTogether = true;
            this.detail.Name = "detail";
            this.detail.BeforePrint += new System.EventHandler(this.detail_BeforePrint);
            // 
            // textBox9
            // 
            this.textBox9.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox9.Border.RightColor = System.Drawing.Color.Black;
            this.textBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox9.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox9.Height = 0.25F;
            this.textBox9.Left = 0F;
            this.textBox9.Name = "textBox9";
            this.textBox9.OutputFormat = resources.GetString("textBox9.OutputFormat");
            this.textBox9.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; background-color: White" +
                "; font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox9.SummaryFunc = DataDynamics.ActiveReports.SummaryFunc.Count;
            this.textBox9.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox9.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox9.Text = null;
            this.textBox9.Top = 0F;
            this.textBox9.Width = 0.375F;
            // 
            // textBox11
            // 
            this.textBox11.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox11.Border.RightColor = System.Drawing.Color.Black;
            this.textBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox11.Border.TopColor = System.Drawing.Color.Black;
            this.textBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox11.DataField = "IDRoom";
            this.textBox11.Height = 0.25F;
            this.textBox11.Left = 0.375F;
            this.textBox11.Name = "textBox11";
            this.textBox11.OutputFormat = resources.GetString("textBox11.OutputFormat");
            this.textBox11.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; background-color: White; " +
                "font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox11.Text = null;
            this.textBox11.Top = 0F;
            this.textBox11.Width = 2.4375F;
            // 
            // textBox8
            // 
            this.textBox8.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox8.Border.RightColor = System.Drawing.Color.Black;
            this.textBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox8.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox8.DataField = "MoneyPublic";
            this.textBox8.Height = 0.25F;
            this.textBox8.Left = 2.8125F;
            this.textBox8.Name = "textBox8";
            this.textBox8.OutputFormat = resources.GetString("textBox8.OutputFormat");
            this.textBox8.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox8.Text = null;
            this.textBox8.Top = 0F;
            this.textBox8.Width = 0.75F;
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox1.Border.RightColor = System.Drawing.Color.Black;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.TopColor = System.Drawing.Color.Black;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.DataField = "MoneyParking";
            this.textBox1.Height = 0.25F;
            this.textBox1.Left = 3.5625F;
            this.textBox1.Name = "textBox1";
            this.textBox1.OutputFormat = resources.GetString("textBox1.OutputFormat");
            this.textBox1.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox1.Text = null;
            this.textBox1.Top = 0F;
            this.textBox1.Width = 0.75F;
            // 
            // textBox4
            // 
            this.textBox4.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox4.Border.RightColor = System.Drawing.Color.Black;
            this.textBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.DataField = "MoneyWater";
            this.textBox4.Height = 0.25F;
            this.textBox4.Left = 4.3125F;
            this.textBox4.Name = "textBox4";
            this.textBox4.OutputFormat = resources.GetString("textBox4.OutputFormat");
            this.textBox4.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox4.Text = null;
            this.textBox4.Top = 0F;
            this.textBox4.Width = 0.75F;
            // 
            // textBox7
            // 
            this.textBox7.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox7.Border.RightColor = System.Drawing.Color.Black;
            this.textBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox7.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox7.DataField = "MoneyElectric";
            this.textBox7.Height = 0.25F;
            this.textBox7.Left = 5.0625F;
            this.textBox7.Name = "textBox7";
            this.textBox7.OutputFormat = resources.GetString("textBox7.OutputFormat");
            this.textBox7.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox7.Text = null;
            this.textBox7.Top = 0F;
            this.textBox7.Width = 0.75F;
            // 
            // textBox12
            // 
            this.textBox12.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox12.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox12.Border.RightColor = System.Drawing.Color.Black;
            this.textBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox12.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox12.DataField = "MoneyOther";
            this.textBox12.Height = 0.25F;
            this.textBox12.Left = 5.8125F;
            this.textBox12.Name = "textBox12";
            this.textBox12.OutputFormat = resources.GetString("textBox12.OutputFormat");
            this.textBox12.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox12.Text = null;
            this.textBox12.Top = 0F;
            this.textBox12.Width = 0.75F;
            // 
            // textBox13
            // 
            this.textBox13.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox13.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox13.Border.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox13.Border.TopColor = System.Drawing.Color.Black;
            this.textBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox13.DataField = "MoneyService";
            this.textBox13.Height = 0.25F;
            this.textBox13.Left = 6.5625F;
            this.textBox13.Name = "textBox13";
            this.textBox13.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox13.Text = null;
            this.textBox13.Top = 0F;
            this.textBox13.Width = 0.96875F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblTitle,
            this.lblRepDay,
            this.subrptHeader});
            this.reportHeader1.Height = 0.885F;
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
            this.lblRepDay.Top = 0.71875F;
            this.lblRepDay.Width = 7.53125F;
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
            this.subrptHeader.Width = 7.53125F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subrptFooter,
            this.textBox5,
            this.textBox6,
            this.textBox3,
            this.textBox2,
            this.textBox15,
            this.textBox10,
            this.textBox14});
            this.reportFooter1.Height = 0.5833333F;
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
            this.subrptFooter.Top = 0.3125F;
            this.subrptFooter.Width = 7.53125F;
            // 
            // textBox5
            // 
            this.textBox5.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Border.RightColor = System.Drawing.Color.Black;
            this.textBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox5.Height = 0.25F;
            this.textBox5.Left = 0F;
            this.textBox5.Name = "textBox5";
            this.textBox5.OutputFormat = resources.GetString("textBox5.OutputFormat");
            this.textBox5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; background-color: White; " +
                "font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox5.Text = "TỔNG TIỀN";
            this.textBox5.Top = 0F;
            this.textBox5.Width = 2.8125F;
            // 
            // textBox6
            // 
            this.textBox6.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.Border.RightColor = System.Drawing.Color.Black;
            this.textBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox6.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox6.DataField = "MoneyPublic";
            this.textBox6.Height = 0.25F;
            this.textBox6.Left = 2.8125F;
            this.textBox6.Name = "textBox6";
            this.textBox6.OutputFormat = resources.GetString("textBox6.OutputFormat");
            this.textBox6.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: White; f" +
                "ont-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox6.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox6.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox6.Text = null;
            this.textBox6.Top = 0F;
            this.textBox6.Width = 0.75F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.Border.RightColor = System.Drawing.Color.Black;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox3.DataField = "MoneyParking";
            this.textBox3.Height = 0.25F;
            this.textBox3.Left = 3.5625F;
            this.textBox3.Name = "textBox3";
            this.textBox3.OutputFormat = resources.GetString("textBox3.OutputFormat");
            this.textBox3.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: White; f" +
                "ont-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox3.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox3.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox3.Text = null;
            this.textBox3.Top = 0F;
            this.textBox3.Width = 0.75F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.Border.RightColor = System.Drawing.Color.Black;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox2.DataField = "MoneyWater";
            this.textBox2.Height = 0.25F;
            this.textBox2.Left = 4.3125F;
            this.textBox2.Name = "textBox2";
            this.textBox2.OutputFormat = resources.GetString("textBox2.OutputFormat");
            this.textBox2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: White; f" +
                "ont-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox2.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox2.Text = null;
            this.textBox2.Top = 0F;
            this.textBox2.Width = 0.75F;
            // 
            // textBox15
            // 
            this.textBox15.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.Border.RightColor = System.Drawing.Color.Black;
            this.textBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox15.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox15.DataField = "MoneyElectric";
            this.textBox15.Height = 0.25F;
            this.textBox15.Left = 5.0625F;
            this.textBox15.Name = "textBox15";
            this.textBox15.OutputFormat = resources.GetString("textBox15.OutputFormat");
            this.textBox15.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: White; f" +
                "ont-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox15.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox15.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox15.Text = null;
            this.textBox15.Top = 0F;
            this.textBox15.Width = 0.75F;
            // 
            // textBox10
            // 
            this.textBox10.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox10.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox10.Border.RightColor = System.Drawing.Color.Black;
            this.textBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox10.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox10.DataField = "MoneyOther";
            this.textBox10.Height = 0.25F;
            this.textBox10.Left = 5.8125F;
            this.textBox10.Name = "textBox10";
            this.textBox10.OutputFormat = resources.GetString("textBox10.OutputFormat");
            this.textBox10.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; background-color: White; f" +
                "ont-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox10.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox10.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox10.Text = null;
            this.textBox10.Top = 0F;
            this.textBox10.Width = 0.75F;
            // 
            // textBox14
            // 
            this.textBox14.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox14.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox14.Border.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox14.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.textBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.textBox14.DataField = "MoneyService";
            this.textBox14.Height = 0.25F;
            this.textBox14.Left = 6.5625F;
            this.textBox14.Name = "textBox14";
            this.textBox14.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; background-color: White;" +
                " font-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.textBox14.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All;
            this.textBox14.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal;
            this.textBox14.Text = null;
            this.textBox14.Top = 0F;
            this.textBox14.Width = 0.96875F;
            // 
            // pageHeader1
            // 
            this.pageHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.label12,
            this.label1,
            this.label6,
            this.label5,
            this.label13,
            this.label2,
            this.label9,
            this.label8});
            this.pageHeader1.Height = 0.2916667F;
            this.pageHeader1.Name = "pageHeader1";
            // 
            // label12
            // 
            this.label12.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label12.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label12.Border.RightColor = System.Drawing.Color.Black;
            this.label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label12.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label12.Height = 0.3125F;
            this.label12.HyperLink = null;
            this.label12.Left = 0F;
            this.label12.Name = "label12";
            this.label12.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label12.Text = "STT";
            this.label12.Top = 0F;
            this.label12.Width = 0.375F;
            // 
            // label1
            // 
            this.label1.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Border.RightColor = System.Drawing.Color.Black;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label1.Height = 0.3125F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.375F;
            this.label1.Name = "label1";
            this.label1.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label1.Text = "Phòng - Chủ hộ";
            this.label1.Top = 0F;
            this.label1.Width = 2.4375F;
            // 
            // label6
            // 
            this.label6.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label6.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label6.Border.RightColor = System.Drawing.Color.Black;
            this.label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label6.Height = 0.3125F;
            this.label6.HyperLink = null;
            this.label6.Left = 2.8125F;
            this.label6.Name = "label6";
            this.label6.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label6.Text = "Tiền phòng";
            this.label6.Top = 0F;
            this.label6.Width = 0.75F;
            // 
            // label5
            // 
            this.label5.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Border.RightColor = System.Drawing.Color.Black;
            this.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label5.Height = 0.3125F;
            this.label5.HyperLink = null;
            this.label5.Left = 3.5625F;
            this.label5.Name = "label5";
            this.label5.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label5.Text = "Tiền gửi xe";
            this.label5.Top = 0F;
            this.label5.Width = 0.75F;
            // 
            // label13
            // 
            this.label13.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label13.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label13.Border.RightColor = System.Drawing.Color.Black;
            this.label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label13.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label13.Height = 0.3125F;
            this.label13.HyperLink = null;
            this.label13.Left = 4.3125F;
            this.label13.Name = "label13";
            this.label13.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label13.Text = "Tiền nước";
            this.label13.Top = 0F;
            this.label13.Width = 0.75F;
            // 
            // label2
            // 
            this.label2.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Border.RightColor = System.Drawing.Color.Black;
            this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label2.Height = 0.3125F;
            this.label2.HyperLink = null;
            this.label2.Left = 5.0625F;
            this.label2.Name = "label2";
            this.label2.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label2.Text = "Tiền điện";
            this.label2.Top = 0F;
            this.label2.Width = 0.75F;
            // 
            // label9
            // 
            this.label9.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label9.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label9.Border.RightColor = System.Drawing.Color.Black;
            this.label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label9.Height = 0.3125F;
            this.label9.HyperLink = null;
            this.label9.Left = 5.8125F;
            this.label9.Name = "label9";
            this.label9.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label9.Text = "Dịch vụ";
            this.label9.Top = 0F;
            this.label9.Width = 0.75F;
            // 
            // label8
            // 
            this.label8.Border.BottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label8.Border.LeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label8.Border.RightColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label8.Border.TopColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid;
            this.label8.Height = 0.3125F;
            this.label8.HyperLink = null;
            this.label8.Left = 6.5625F;
            this.label8.Name = "label8";
            this.label8.Style = "text-align: center; font-weight: bold; font-size: 9pt; vertical-align: middle; ";
            this.label8.Text = "Tổng tiền";
            this.label8.Top = 0F;
            this.label8.Width = 0.96875F;
            // 
            // pageFooter1
            // 
            this.pageFooter1.Height = 0F;
            this.pageFooter1.Name = "pageFooter1";
            this.pageFooter1.Visible = false;
            // 
            // rptServiceList
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
            this.PrintWidth = 7.572927F;
            this.Sections.Add(this.reportHeader1);
            this.Sections.Add(this.pageHeader1);
            this.Sections.Add(this.detail);
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
            ((System.ComponentModel.ISupportInitialize)(this.textBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRepDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label lblTitle;
        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.PageHeader pageHeader1;
        private DataDynamics.ActiveReports.PageFooter pageFooter1;
        private DataDynamics.ActiveReports.Label lblRepDay;
        private DataDynamics.ActiveReports.TextBox textBox4;
        private DataDynamics.ActiveReports.TextBox textBox12;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Label label9;
        private DataDynamics.ActiveReports.Label label8;
        private DataDynamics.ActiveReports.TextBox textBox8;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.Label label6;
        private DataDynamics.ActiveReports.Label label12;
        private DataDynamics.ActiveReports.TextBox textBox9;
        private DataDynamics.ActiveReports.TextBox textBox11;
        private DataDynamics.ActiveReports.TextBox textBox13;
        private DataDynamics.ActiveReports.Label label13;
        private DataDynamics.ActiveReports.SubReport subrptHeader;
        private DataDynamics.ActiveReports.SubReport subrptFooter;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.TextBox textBox5;
        private DataDynamics.ActiveReports.TextBox textBox6;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.TextBox textBox10;
        private DataDynamics.ActiveReports.TextBox textBox14;
        private DataDynamics.ActiveReports.TextBox textBox7;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.TextBox textBox15;
        private DataDynamics.ActiveReports.Label label2;
    }
}
