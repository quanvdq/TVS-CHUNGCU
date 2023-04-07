namespace TVSReports
{
    /// <summary>
    /// Summary description for Repdialytoday.
    /// </summary>
    partial class rptPaymentVoucher
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptPaymentVoucher));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.lblTitle = new DataDynamics.ActiveReports.Label();
            this.textBox7 = new DataDynamics.ActiveReports.TextBox();
            this.lblID = new DataDynamics.ActiveReports.Label();
            this.lblRepDay = new DataDynamics.ActiveReports.Label();
            this.subrptHeader = new DataDynamics.ActiveReports.SubReport();
            this.LblTax = new DataDynamics.ActiveReports.Label();
            this.lblBangchu = new DataDynamics.ActiveReports.Label();
            this.lblProName = new DataDynamics.ActiveReports.Label();
            this.label1 = new DataDynamics.ActiveReports.Label();
            this.label2 = new DataDynamics.ActiveReports.Label();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.textBox2 = new DataDynamics.ActiveReports.TextBox();
            this.textBox4 = new DataDynamics.ActiveReports.TextBox();
            this.label5 = new DataDynamics.ActiveReports.Label();
            this.textBox3 = new DataDynamics.ActiveReports.TextBox();
            this.label4 = new DataDynamics.ActiveReports.Label();
            this.label3 = new DataDynamics.ActiveReports.Label();
            this.lblPaidAmount = new DataDynamics.ActiveReports.Label();
            this.label8 = new DataDynamics.ActiveReports.Label();
            this.subrptFooter = new DataDynamics.ActiveReports.SubReport();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.pageHeader1 = new DataDynamics.ActiveReports.PageHeader();
            this.pageFooter1 = new DataDynamics.ActiveReports.PageFooter();
            this.lblPrintDate = new DataDynamics.ActiveReports.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRepDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBangchu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPaidAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrintDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Height = 0F;
            this.detail.Name = "detail";
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblTitle,
            this.textBox7,
            this.lblID,
            this.lblRepDay,
            this.subrptHeader,
            this.LblTax,
            this.lblBangchu,
            this.lblProName,
            this.label1,
            this.label2,
            this.textBox1,
            this.textBox2,
            this.textBox4,
            this.label5,
            this.textBox3,
            this.label4,
            this.label3,
            this.lblPaidAmount,
            this.label8,
            this.subrptFooter});
            this.reportHeader1.Height = 4.875F;
            this.reportHeader1.Name = "reportHeader1";
            this.reportHeader1.BeforePrint += new System.EventHandler(this.reportHeader1_BeforePrint);
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
            this.lblTitle.Height = 0.625F;
            this.lblTitle.HyperLink = null;
            this.lblTitle.Left = 0F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 15.75pt; font-" +
                "family: Arial; vertical-align: bottom; ";
            this.lblTitle.Text = "PHIẾU CHI TIỀN MẶT";
            this.lblTitle.Top = 0.25F;
            this.lblTitle.Width = 7.15625F;
            // 
            // textBox7
            // 
            this.textBox7.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox7.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox7.Border.RightColor = System.Drawing.Color.Black;
            this.textBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox7.Border.TopColor = System.Drawing.Color.Black;
            this.textBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox7.DataField = "NamePartner";
            this.textBox7.Height = 0.1875F;
            this.textBox7.Left = 1.0625F;
            this.textBox7.Name = "textBox7";
            this.textBox7.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; background-color: White; fo" +
                "nt-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.textBox7.Text = null;
            this.textBox7.Top = 1.28125F;
            this.textBox7.Width = 3.15625F;
            // 
            // lblID
            // 
            this.lblID.Border.BottomColor = System.Drawing.Color.Black;
            this.lblID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblID.Border.LeftColor = System.Drawing.Color.Black;
            this.lblID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblID.Border.RightColor = System.Drawing.Color.Black;
            this.lblID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblID.Border.TopColor = System.Drawing.Color.Black;
            this.lblID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblID.DataField = "CodePaymentVoucher";
            this.lblID.Height = 0.25F;
            this.lblID.HyperLink = null;
            this.lblID.Left = 0F;
            this.lblID.Name = "lblID";
            this.lblID.Style = "ddo-char-set: 163; text-align: center; font-weight: bold; font-style: normal; fon" +
                "t-size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.lblID.Text = "-:-";
            this.lblID.Top = 0.875F;
            this.lblID.Width = 7.15625F;
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
            this.lblRepDay.DataField = "DatePaymentVoucher";
            this.lblRepDay.Height = 0.25F;
            this.lblRepDay.HyperLink = null;
            this.lblRepDay.Left = 4.90625F;
            this.lblRepDay.Name = "lblRepDay";
            this.lblRepDay.Style = "ddo-char-set: 0; text-align: center; font-style: italic; font-size: 9pt; font-fam" +
                "ily: Arial; vertical-align: middle; ";
            this.lblRepDay.Text = "";
            this.lblRepDay.Top = 0.875F;
            this.lblRepDay.Width = 2.25F;
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
            this.subrptHeader.Width = 7.15625F;
            // 
            // LblTax
            // 
            this.LblTax.Border.BottomColor = System.Drawing.Color.Black;
            this.LblTax.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblTax.Border.LeftColor = System.Drawing.Color.Black;
            this.LblTax.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblTax.Border.RightColor = System.Drawing.Color.Black;
            this.LblTax.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblTax.Border.TopColor = System.Drawing.Color.Black;
            this.LblTax.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblTax.Height = 0.1875F;
            this.LblTax.HyperLink = null;
            this.LblTax.Left = 0F;
            this.LblTax.Name = "LblTax";
            this.LblTax.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-style: normal; font-" +
                "size: 9pt; font-family: Arial; vertical-align: middle; ";
            this.LblTax.Text = "";
            this.LblTax.Top = 0.25F;
            this.LblTax.Width = 2.71875F;
            // 
            // lblBangchu
            // 
            this.lblBangchu.Border.BottomColor = System.Drawing.Color.Black;
            this.lblBangchu.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBangchu.Border.LeftColor = System.Drawing.Color.Black;
            this.lblBangchu.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBangchu.Border.RightColor = System.Drawing.Color.Black;
            this.lblBangchu.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBangchu.Border.TopColor = System.Drawing.Color.Black;
            this.lblBangchu.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblBangchu.Height = 0.375F;
            this.lblBangchu.HyperLink = null;
            this.lblBangchu.Left = 1.0625F;
            this.lblBangchu.Name = "lblBangchu";
            this.lblBangchu.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: italic; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: top; ";
            this.lblBangchu.Text = "Nhà cung cấp:";
            this.lblBangchu.Top = 2.4375F;
            this.lblBangchu.Width = 6.09375F;
            // 
            // lblProName
            // 
            this.lblProName.Border.BottomColor = System.Drawing.Color.Black;
            this.lblProName.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblProName.Border.LeftColor = System.Drawing.Color.Black;
            this.lblProName.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblProName.Border.RightColor = System.Drawing.Color.Black;
            this.lblProName.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblProName.Border.TopColor = System.Drawing.Color.Black;
            this.lblProName.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblProName.Height = 0.1875F;
            this.lblProName.HyperLink = null;
            this.lblProName.Left = 0.125F;
            this.lblProName.Name = "lblProName";
            this.lblProName.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.lblProName.Text = "Đối tác:";
            this.lblProName.Top = 1.28125F;
            this.lblProName.Width = 0.9375F;
            // 
            // label1
            // 
            this.label1.Border.BottomColor = System.Drawing.Color.Black;
            this.label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.LeftColor = System.Drawing.Color.Black;
            this.label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.RightColor = System.Drawing.Color.Black;
            this.label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Border.TopColor = System.Drawing.Color.Black;
            this.label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label1.Height = 0.1875F;
            this.label1.HyperLink = null;
            this.label1.Left = 0.125F;
            this.label1.Name = "label1";
            this.label1.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label1.Text = "Địa chỉ:";
            this.label1.Top = 1.6875F;
            this.label1.Width = 0.9375F;
            // 
            // label2
            // 
            this.label2.Border.BottomColor = System.Drawing.Color.Black;
            this.label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.LeftColor = System.Drawing.Color.Black;
            this.label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.RightColor = System.Drawing.Color.Black;
            this.label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Border.TopColor = System.Drawing.Color.Black;
            this.label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label2.Height = 0.1875F;
            this.label2.HyperLink = null;
            this.label2.Left = 0.125F;
            this.label2.Name = "label2";
            this.label2.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label2.Text = "Lý do:";
            this.label2.Top = 1.9375F;
            this.label2.Width = 0.9375F;
            // 
            // textBox1
            // 
            this.textBox1.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.RightColor = System.Drawing.Color.Black;
            this.textBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.Border.TopColor = System.Drawing.Color.Black;
            this.textBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox1.DataField = "AddressPartner";
            this.textBox1.Height = 0.1875F;
            this.textBox1.Left = 1.0625F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "ddo-char-set: 0; text-align: left; background-color: White; font-size: 9.75pt; fo" +
                "nt-family: Arial; vertical-align: middle; ";
            this.textBox1.Text = null;
            this.textBox1.Top = 1.6875F;
            this.textBox1.Width = 4F;
            // 
            // textBox2
            // 
            this.textBox2.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.RightColor = System.Drawing.Color.Black;
            this.textBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.Border.TopColor = System.Drawing.Color.Black;
            this.textBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox2.DataField = "Note";
            this.textBox2.Height = 0.1875F;
            this.textBox2.Left = 1.0625F;
            this.textBox2.Name = "textBox2";
            this.textBox2.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; background-color: White; " +
                "font-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.textBox2.Text = null;
            this.textBox2.Top = 1.9375F;
            this.textBox2.Width = 6.09375F;
            // 
            // textBox4
            // 
            this.textBox4.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.Border.RightColor = System.Drawing.Color.Black;
            this.textBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.Border.TopColor = System.Drawing.Color.Black;
            this.textBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox4.DataField = "NamePaymentVoucherType";
            this.textBox4.Height = 0.40625F;
            this.textBox4.Left = 5.25F;
            this.textBox4.Name = "textBox4";
            this.textBox4.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; background-color: White; " +
                "font-size: 9.75pt; font-family: Arial; vertical-align: top; ";
            this.textBox4.Text = null;
            this.textBox4.Top = 1.28125F;
            this.textBox4.Width = 1.90625F;
            // 
            // label5
            // 
            this.label5.Border.BottomColor = System.Drawing.Color.Black;
            this.label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.LeftColor = System.Drawing.Color.Black;
            this.label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.RightColor = System.Drawing.Color.Black;
            this.label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Border.TopColor = System.Drawing.Color.Black;
            this.label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label5.Height = 0.1875F;
            this.label5.HyperLink = null;
            this.label5.Left = 5.0625F;
            this.label5.Name = "label5";
            this.label5.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label5.Text = "Điện thoại:";
            this.label5.Top = 1.6875F;
            this.label5.Width = 0.75F;
            // 
            // textBox3
            // 
            this.textBox3.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.RightColor = System.Drawing.Color.Black;
            this.textBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.Border.TopColor = System.Drawing.Color.Black;
            this.textBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox3.DataField = "PhonePartner";
            this.textBox3.Height = 0.1875F;
            this.textBox3.Left = 5.8125F;
            this.textBox3.Name = "textBox3";
            this.textBox3.Style = "ddo-char-set: 0; text-align: left; background-color: White; font-size: 9.75pt; fo" +
                "nt-family: Arial; vertical-align: middle; ";
            this.textBox3.Text = null;
            this.textBox3.Top = 1.6875F;
            this.textBox3.Width = 1.34375F;
            // 
            // label4
            // 
            this.label4.Border.BottomColor = System.Drawing.Color.Black;
            this.label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.LeftColor = System.Drawing.Color.Black;
            this.label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.RightColor = System.Drawing.Color.Black;
            this.label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Border.TopColor = System.Drawing.Color.Black;
            this.label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label4.Height = 0.1875F;
            this.label4.HyperLink = null;
            this.label4.Left = 4.25F;
            this.label4.Name = "label4";
            this.label4.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label4.Text = "Khoản thu chi :";
            this.label4.Top = 1.28125F;
            this.label4.Width = 1F;
            // 
            // label3
            // 
            this.label3.Border.BottomColor = System.Drawing.Color.Black;
            this.label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.LeftColor = System.Drawing.Color.Black;
            this.label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.RightColor = System.Drawing.Color.Black;
            this.label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Border.TopColor = System.Drawing.Color.Black;
            this.label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label3.Height = 0.1875F;
            this.label3.HyperLink = null;
            this.label3.Left = 0.125F;
            this.label3.Name = "label3";
            this.label3.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label3.Text = "Số tiền:";
            this.label3.Top = 2.1875F;
            this.label3.Width = 0.875F;
            // 
            // lblPaidAmount
            // 
            this.lblPaidAmount.Border.BottomColor = System.Drawing.Color.Black;
            this.lblPaidAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPaidAmount.Border.LeftColor = System.Drawing.Color.Black;
            this.lblPaidAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPaidAmount.Border.RightColor = System.Drawing.Color.Black;
            this.lblPaidAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPaidAmount.Border.TopColor = System.Drawing.Color.Black;
            this.lblPaidAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPaidAmount.Height = 0.1875F;
            this.lblPaidAmount.HyperLink = null;
            this.lblPaidAmount.Left = 1.0625F;
            this.lblPaidAmount.Name = "lblPaidAmount";
            this.lblPaidAmount.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.lblPaidAmount.Text = "";
            this.lblPaidAmount.Top = 2.1875F;
            this.lblPaidAmount.Width = 1.75F;
            // 
            // label8
            // 
            this.label8.Border.BottomColor = System.Drawing.Color.Black;
            this.label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.LeftColor = System.Drawing.Color.Black;
            this.label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.RightColor = System.Drawing.Color.Black;
            this.label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Border.TopColor = System.Drawing.Color.Black;
            this.label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label8.Height = 0.1875F;
            this.label8.HyperLink = null;
            this.label8.Left = 0.125F;
            this.label8.Name = "label8";
            this.label8.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label8.Text = "Bằng chữ:";
            this.label8.Top = 2.4375F;
            this.label8.Width = 0.875F;
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
            this.subrptFooter.Top = 2.90625F;
            this.subrptFooter.Width = 7.15625F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Height = 0F;
            this.reportFooter1.Name = "reportFooter1";
            // 
            // pageHeader1
            // 
            this.pageHeader1.Height = 0F;
            this.pageHeader1.Name = "pageHeader1";
            // 
            // pageFooter1
            // 
            this.pageFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblPrintDate});
            this.pageFooter1.Height = 0.15625F;
            this.pageFooter1.Name = "pageFooter1";
            // 
            // lblPrintDate
            // 
            this.lblPrintDate.Border.BottomColor = System.Drawing.Color.Black;
            this.lblPrintDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintDate.Border.LeftColor = System.Drawing.Color.Black;
            this.lblPrintDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintDate.Border.RightColor = System.Drawing.Color.Black;
            this.lblPrintDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintDate.Border.TopColor = System.Drawing.Color.Black;
            this.lblPrintDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.lblPrintDate.Height = 0.15625F;
            this.lblPrintDate.HyperLink = null;
            this.lblPrintDate.Left = 0F;
            this.lblPrintDate.Name = "lblPrintDate";
            this.lblPrintDate.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: italic; font-" +
                "size: 8pt; font-family: Arial; vertical-align: middle; ";
            this.lblPrintDate.Text = " In ngày:";
            this.lblPrintDate.Top = 0F;
            this.lblPrintDate.Width = 7.6875F;
            // 
            // rptPaymentVoucher
            // 
            this.MasterReport = false;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0F;
            this.PageSettings.Margins.Left = 0F;
            this.PageSettings.Margins.Right = 0F;
            this.PageSettings.Margins.Top = 0F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape;
            this.PageSettings.PaperHeight = 8.267716F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5;
            this.PageSettings.PaperWidth = 5.826772F;
            this.PrintWidth = 7.1875F;
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
            this.ReportStart += new System.EventHandler(this.rptPaymentVoucher_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblRepDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblTax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblBangchu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPaidAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblPrintDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.PageHeader pageHeader1;
        private DataDynamics.ActiveReports.PageFooter pageFooter1;
        private DataDynamics.ActiveReports.Label lblPrintDate;
        private DataDynamics.ActiveReports.Label lblTitle;
        private DataDynamics.ActiveReports.TextBox textBox7;
        private DataDynamics.ActiveReports.Label lblID;
        private DataDynamics.ActiveReports.Label lblRepDay;
        private DataDynamics.ActiveReports.SubReport subrptHeader;
        private DataDynamics.ActiveReports.Label LblTax;
        private DataDynamics.ActiveReports.Label lblBangchu;
        private DataDynamics.ActiveReports.Label lblProName;
        private DataDynamics.ActiveReports.Label label1;
        private DataDynamics.ActiveReports.Label label2;
        private DataDynamics.ActiveReports.TextBox textBox1;
        private DataDynamics.ActiveReports.TextBox textBox2;
        private DataDynamics.ActiveReports.TextBox textBox4;
        private DataDynamics.ActiveReports.Label label5;
        private DataDynamics.ActiveReports.TextBox textBox3;
        private DataDynamics.ActiveReports.Label label4;
        private DataDynamics.ActiveReports.Label label3;
        private DataDynamics.ActiveReports.Label lblPaidAmount;
        private DataDynamics.ActiveReports.Label label8;
        private DataDynamics.ActiveReports.SubReport subrptFooter;
    }
}
