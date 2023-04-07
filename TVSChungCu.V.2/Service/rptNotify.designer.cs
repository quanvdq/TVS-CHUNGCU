namespace TVSReports
{
    /// <summary>
    /// Summary description for Repdialytoday.
    /// </summary>
    partial class rptNotify
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptNotify));
            this.lblTitle = new DataDynamics.ActiveReports.Label();
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.lblProName = new DataDynamics.ActiveReports.Label();
            this.textBox7 = new DataDynamics.ActiveReports.TextBox();
            this.label7 = new DataDynamics.ActiveReports.Label();
            this.label9 = new DataDynamics.ActiveReports.Label();
            this.textBox5 = new DataDynamics.ActiveReports.TextBox();
            this.subParking = new DataDynamics.ActiveReports.SubReport();
            this.subWater = new DataDynamics.ActiveReports.SubReport();
            this.LableTime = new DataDynamics.ActiveReports.Label();
            this.LblMoneyParking = new DataDynamics.ActiveReports.Label();
            this.LblMoneyPublic = new DataDynamics.ActiveReports.Label();
            this.LblMoneyWater = new DataDynamics.ActiveReports.Label();
            this.LblMoneyService = new DataDynamics.ActiveReports.Label();
            this.LblMoneyServiceString = new DataDynamics.ActiveReports.Label();
            this.LableTimePay = new DataDynamics.ActiveReports.Label();
            this.LblMoneyOther = new DataDynamics.ActiveReports.Label();
            this.LblMoneyElectric = new DataDynamics.ActiveReports.Label();
            this.subElectric = new DataDynamics.ActiveReports.SubReport();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.subrptHeader = new DataDynamics.ActiveReports.SubReport();
            this.label6 = new DataDynamics.ActiveReports.Label();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.subrptFooter = new DataDynamics.ActiveReports.SubReport();
            this.pageHeader1 = new DataDynamics.ActiveReports.PageHeader();
            this.pageFooter1 = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LableTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyWater)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyServiceString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LableTimePay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyOther)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyElectric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).BeginInit();
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
            this.lblTitle.Height = 0.34375F;
            this.lblTitle.HyperLink = null;
            this.lblTitle.Left = 0F;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 15.75pt; font-" +
                "family: Arial; vertical-align: bottom; ";
            this.lblTitle.Text = "THÔNG BÁO";
            this.lblTitle.Top = 0.25F;
            this.lblTitle.Width = 5.3125F;
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblProName,
            this.textBox7,
            this.label7,
            this.label9,
            this.textBox5,
            this.subParking,
            this.subWater,
            this.LableTime,
            this.LblMoneyParking,
            this.LblMoneyPublic,
            this.LblMoneyWater,
            this.LblMoneyService,
            this.LblMoneyServiceString,
            this.LableTimePay,
            this.LblMoneyOther,
            this.LblMoneyElectric,
            this.subElectric});
            this.detail.Height = 3.875F;
            this.detail.Name = "detail";
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
            this.lblProName.Left = 0.1875F;
            this.lblProName.Name = "lblProName";
            this.lblProName.Style = "ddo-char-set: 0; text-decoration: underline; text-align: left; font-weight: norma" +
                "l; font-style: normal; font-size: 9.75pt; font-family: Arial; vertical-align: mi" +
                "ddle; ";
            this.lblProName.Text = "Kính gửi: ";
            this.lblProName.Top = 0.03125F;
            this.lblProName.Width = 0.875F;
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
            this.textBox7.DataField = "ContactPerson";
            this.textBox7.Height = 0.1875F;
            this.textBox7.Left = 1.8125F;
            this.textBox7.Name = "textBox7";
            this.textBox7.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; background-color: White; fo" +
                "nt-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.textBox7.Text = null;
            this.textBox7.Top = 0.03125F;
            this.textBox7.Width = 3.5F;
            // 
            // label7
            // 
            this.label7.Border.BottomColor = System.Drawing.Color.Black;
            this.label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.LeftColor = System.Drawing.Color.Black;
            this.label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.RightColor = System.Drawing.Color.Black;
            this.label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Border.TopColor = System.Drawing.Color.Black;
            this.label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label7.Height = 0.1875F;
            this.label7.HyperLink = null;
            this.label7.Left = 1.0625F;
            this.label7.Name = "label7";
            this.label7.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label7.Text = "Ông (Bà) :";
            this.label7.Top = 0.03125F;
            this.label7.Width = 0.71875F;
            // 
            // label9
            // 
            this.label9.Border.BottomColor = System.Drawing.Color.Black;
            this.label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Border.LeftColor = System.Drawing.Color.Black;
            this.label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Border.RightColor = System.Drawing.Color.Black;
            this.label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Border.TopColor = System.Drawing.Color.Black;
            this.label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label9.Height = 0.1875F;
            this.label9.HyperLink = null;
            this.label9.Left = 1.0625F;
            this.label9.Name = "label9";
            this.label9.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.label9.Text = "Phòng :";
            this.label9.Top = 0.21875F;
            this.label9.Width = 0.71875F;
            // 
            // textBox5
            // 
            this.textBox5.Border.BottomColor = System.Drawing.Color.Black;
            this.textBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.Border.LeftColor = System.Drawing.Color.Black;
            this.textBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.Border.RightColor = System.Drawing.Color.Black;
            this.textBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.Border.TopColor = System.Drawing.Color.Black;
            this.textBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.textBox5.DataField = "Room";
            this.textBox5.Height = 0.1875F;
            this.textBox5.Left = 1.8125F;
            this.textBox5.Name = "textBox5";
            this.textBox5.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; background-color: White; fo" +
                "nt-size: 9.75pt; font-family: Arial; vertical-align: middle; ";
            this.textBox5.Text = null;
            this.textBox5.Top = 0.21875F;
            this.textBox5.Width = 3.5F;
            // 
            // subParking
            // 
            this.subParking.Border.BottomColor = System.Drawing.Color.Black;
            this.subParking.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subParking.Border.LeftColor = System.Drawing.Color.Black;
            this.subParking.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subParking.Border.RightColor = System.Drawing.Color.Black;
            this.subParking.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subParking.Border.TopColor = System.Drawing.Color.Black;
            this.subParking.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subParking.CloseBorder = false;
            this.subParking.Height = 0.25F;
            this.subParking.Left = 0F;
            this.subParking.Name = "subParking";
            this.subParking.Report = null;
            this.subParking.ReportName = "";
            this.subParking.Top = 1.625F;
            this.subParking.Width = 5.3125F;
            // 
            // subWater
            // 
            this.subWater.Border.BottomColor = System.Drawing.Color.Black;
            this.subWater.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subWater.Border.LeftColor = System.Drawing.Color.Black;
            this.subWater.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subWater.Border.RightColor = System.Drawing.Color.Black;
            this.subWater.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subWater.Border.TopColor = System.Drawing.Color.Black;
            this.subWater.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subWater.CloseBorder = false;
            this.subWater.Height = 0.25F;
            this.subWater.Left = 0F;
            this.subWater.Name = "subWater";
            this.subWater.Report = null;
            this.subWater.ReportName = "";
            this.subWater.Top = 2.125F;
            this.subWater.Width = 5.3125F;
            // 
            // LableTime
            // 
            this.LableTime.Border.BottomColor = System.Drawing.Color.Black;
            this.LableTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTime.Border.LeftColor = System.Drawing.Color.Black;
            this.LableTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTime.Border.RightColor = System.Drawing.Color.Black;
            this.LableTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTime.Border.TopColor = System.Drawing.Color.Black;
            this.LableTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTime.Height = 0.5625F;
            this.LableTime.HyperLink = null;
            this.LableTime.Left = 0F;
            this.LableTime.Name = "LableTime";
            this.LableTime.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: italic; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: middle; ";
            this.LableTime.Text = "       Ban Quản trị chúng tôi xin thông báo phí tiền phòng, phí dịch vụ, phí trôn" +
                "g xe, phí tiền nước, phí tiền điện của Ông (Bà) trong tháng 10 năm 2014 như sau:" +
                "";
            this.LableTime.Top = 0.40625F;
            this.LableTime.Width = 5.3125F;
            // 
            // LblMoneyParking
            // 
            this.LblMoneyParking.Border.BottomColor = System.Drawing.Color.Black;
            this.LblMoneyParking.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyParking.Border.LeftColor = System.Drawing.Color.Black;
            this.LblMoneyParking.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyParking.Border.RightColor = System.Drawing.Color.Black;
            this.LblMoneyParking.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyParking.Border.TopColor = System.Drawing.Color.Black;
            this.LblMoneyParking.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyParking.Height = 0.21875F;
            this.LblMoneyParking.HyperLink = null;
            this.LblMoneyParking.Left = 0F;
            this.LblMoneyParking.Name = "LblMoneyParking";
            this.LblMoneyParking.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.LblMoneyParking.Text = "3: Phí trông giữ xe :";
            this.LblMoneyParking.Top = 1.40625F;
            this.LblMoneyParking.Width = 5.3125F;
            // 
            // LblMoneyPublic
            // 
            this.LblMoneyPublic.Border.BottomColor = System.Drawing.Color.Black;
            this.LblMoneyPublic.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyPublic.Border.LeftColor = System.Drawing.Color.Black;
            this.LblMoneyPublic.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyPublic.Border.RightColor = System.Drawing.Color.Black;
            this.LblMoneyPublic.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyPublic.Border.TopColor = System.Drawing.Color.Black;
            this.LblMoneyPublic.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyPublic.Height = 0.21875F;
            this.LblMoneyPublic.HyperLink = null;
            this.LblMoneyPublic.Left = 0F;
            this.LblMoneyPublic.Name = "LblMoneyPublic";
            this.LblMoneyPublic.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.LblMoneyPublic.Text = "1: Phí tiền phòng :";
            this.LblMoneyPublic.Top = 0.96875F;
            this.LblMoneyPublic.Width = 5.3125F;
            // 
            // LblMoneyWater
            // 
            this.LblMoneyWater.Border.BottomColor = System.Drawing.Color.Black;
            this.LblMoneyWater.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyWater.Border.LeftColor = System.Drawing.Color.Black;
            this.LblMoneyWater.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyWater.Border.RightColor = System.Drawing.Color.Black;
            this.LblMoneyWater.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyWater.Border.TopColor = System.Drawing.Color.Black;
            this.LblMoneyWater.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyWater.Height = 0.21875F;
            this.LblMoneyWater.HyperLink = null;
            this.LblMoneyWater.Left = 0F;
            this.LblMoneyWater.Name = "LblMoneyWater";
            this.LblMoneyWater.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.LblMoneyWater.Text = "4: Phí tiền nước :";
            this.LblMoneyWater.Top = 1.90625F;
            this.LblMoneyWater.Width = 5.3125F;
            // 
            // LblMoneyService
            // 
            this.LblMoneyService.Border.BottomColor = System.Drawing.Color.Black;
            this.LblMoneyService.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyService.Border.LeftColor = System.Drawing.Color.Black;
            this.LblMoneyService.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyService.Border.RightColor = System.Drawing.Color.Black;
            this.LblMoneyService.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyService.Border.TopColor = System.Drawing.Color.Black;
            this.LblMoneyService.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyService.Height = 0.21875F;
            this.LblMoneyService.HyperLink = null;
            this.LblMoneyService.Left = 0F;
            this.LblMoneyService.Name = "LblMoneyService";
            this.LblMoneyService.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-style: normal; font-si" +
                "ze: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.LblMoneyService.Text = "Tổng số tiền phải nộp ";
            this.LblMoneyService.Top = 2.875F;
            this.LblMoneyService.Width = 5.3125F;
            // 
            // LblMoneyServiceString
            // 
            this.LblMoneyServiceString.Border.BottomColor = System.Drawing.Color.Black;
            this.LblMoneyServiceString.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyServiceString.Border.LeftColor = System.Drawing.Color.Black;
            this.LblMoneyServiceString.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyServiceString.Border.RightColor = System.Drawing.Color.Black;
            this.LblMoneyServiceString.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyServiceString.Border.TopColor = System.Drawing.Color.Black;
            this.LblMoneyServiceString.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyServiceString.Height = 0.375F;
            this.LblMoneyServiceString.HyperLink = null;
            this.LblMoneyServiceString.Left = 0F;
            this.LblMoneyServiceString.Name = "LblMoneyServiceString";
            this.LblMoneyServiceString.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: top; ";
            this.LblMoneyServiceString.Text = "Bằng chữ: ";
            this.LblMoneyServiceString.Top = 3.09375F;
            this.LblMoneyServiceString.Width = 5.3125F;
            // 
            // LableTimePay
            // 
            this.LableTimePay.Border.BottomColor = System.Drawing.Color.Black;
            this.LableTimePay.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTimePay.Border.LeftColor = System.Drawing.Color.Black;
            this.LableTimePay.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTimePay.Border.RightColor = System.Drawing.Color.Black;
            this.LableTimePay.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTimePay.Border.TopColor = System.Drawing.Color.Black;
            this.LableTimePay.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LableTimePay.Height = 0.4375F;
            this.LableTimePay.HyperLink = null;
            this.LableTimePay.Left = 0F;
            this.LableTimePay.Name = "LableTimePay";
            this.LableTimePay.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-style: italic; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.LableTimePay.Text = "     Vậy ban Quản trị chúng tôi xin thông báo tới quý khách hàng nạp số tiền trên" +
                " cho ban Quản trị chung cư Tân Phúc, chậm nhất ngày 07 tháng 11 năm 2014";
            this.LableTimePay.Top = 3.46875F;
            this.LableTimePay.Width = 5.3125F;
            // 
            // LblMoneyOther
            // 
            this.LblMoneyOther.Border.BottomColor = System.Drawing.Color.Black;
            this.LblMoneyOther.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyOther.Border.LeftColor = System.Drawing.Color.Black;
            this.LblMoneyOther.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyOther.Border.RightColor = System.Drawing.Color.Black;
            this.LblMoneyOther.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyOther.Border.TopColor = System.Drawing.Color.Black;
            this.LblMoneyOther.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyOther.Height = 0.21875F;
            this.LblMoneyOther.HyperLink = null;
            this.LblMoneyOther.Left = 0F;
            this.LblMoneyOther.Name = "LblMoneyOther";
            this.LblMoneyOther.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.LblMoneyOther.Text = "2: Phí dịch vụ :";
            this.LblMoneyOther.Top = 1.1875F;
            this.LblMoneyOther.Width = 5.3125F;
            // 
            // LblMoneyElectric
            // 
            this.LblMoneyElectric.Border.BottomColor = System.Drawing.Color.Black;
            this.LblMoneyElectric.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyElectric.Border.LeftColor = System.Drawing.Color.Black;
            this.LblMoneyElectric.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyElectric.Border.RightColor = System.Drawing.Color.Black;
            this.LblMoneyElectric.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyElectric.Border.TopColor = System.Drawing.Color.Black;
            this.LblMoneyElectric.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.LblMoneyElectric.Height = 0.21875F;
            this.LblMoneyElectric.HyperLink = null;
            this.LblMoneyElectric.Left = 0F;
            this.LblMoneyElectric.Name = "LblMoneyElectric";
            this.LblMoneyElectric.Style = "ddo-char-set: 1; text-align: left; font-weight: normal; font-style: normal; font-" +
                "size: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.LblMoneyElectric.Text = "5: Phí tiền điện :";
            this.LblMoneyElectric.Top = 2.40625F;
            this.LblMoneyElectric.Width = 5.3125F;
            // 
            // subElectric
            // 
            this.subElectric.Border.BottomColor = System.Drawing.Color.Black;
            this.subElectric.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subElectric.Border.LeftColor = System.Drawing.Color.Black;
            this.subElectric.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subElectric.Border.RightColor = System.Drawing.Color.Black;
            this.subElectric.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subElectric.Border.TopColor = System.Drawing.Color.Black;
            this.subElectric.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subElectric.CloseBorder = false;
            this.subElectric.Height = 0.25F;
            this.subElectric.Left = 0F;
            this.subElectric.Name = "subElectric";
            this.subElectric.Report = null;
            this.subElectric.ReportName = "";
            this.subElectric.Top = 2.625F;
            this.subElectric.Width = 5.3125F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.lblTitle,
            this.subrptHeader,
            this.label6});
            this.reportHeader1.Height = 0.8229167F;
            this.reportHeader1.Name = "reportHeader1";
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
            this.subrptHeader.Width = 5.3125F;
            // 
            // label6
            // 
            this.label6.Border.BottomColor = System.Drawing.Color.Black;
            this.label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.LeftColor = System.Drawing.Color.Black;
            this.label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.RightColor = System.Drawing.Color.Black;
            this.label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Border.TopColor = System.Drawing.Color.Black;
            this.label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.label6.Height = 0.21875F;
            this.label6.HyperLink = null;
            this.label6.Left = 0F;
            this.label6.Name = "label6";
            this.label6.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-style: italic; fon" +
                "t-size: 11.25pt; font-family: Arial; vertical-align: bottom; ";
            this.label6.Text = "( V/v thu các loại phí )";
            this.label6.Top = 0.59375F;
            this.label6.Width = 5.3125F;
            // 
            // reportFooter1
            // 
            this.reportFooter1.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.subrptFooter});
            this.reportFooter1.Height = 0.2708333F;
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
            this.subrptFooter.Top = 0F;
            this.subrptFooter.Width = 5.3125F;
            // 
            // pageHeader1
            // 
            this.pageHeader1.Height = 0F;
            this.pageHeader1.Name = "pageHeader1";
            // 
            // pageFooter1
            // 
            this.pageFooter1.Height = 0F;
            this.pageFooter1.Name = "pageFooter1";
            // 
            // rptNotify
            // 
            this.MasterReport = false;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0.3F;
            this.PageSettings.Margins.Left = 0.25F;
            this.PageSettings.Margins.Right = 0.2F;
            this.PageSettings.Margins.Top = 0.3F;
            this.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait;
            this.PageSettings.PaperHeight = 8.267716F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A5;
            this.PageSettings.PaperWidth = 5.826772F;
            this.PrintWidth = 5.34375F;
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
            this.ReportStart += new System.EventHandler(this.rpt_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.lblTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lblProName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LableTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyWater)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyServiceString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LableTimePay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyOther)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblMoneyElectric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.label6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.Label lblTitle;
        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.PageHeader pageHeader1;
        private DataDynamics.ActiveReports.PageFooter pageFooter1;
        private DataDynamics.ActiveReports.Label lblProName;
        private DataDynamics.ActiveReports.TextBox textBox7;
        private DataDynamics.ActiveReports.SubReport subrptHeader;
        private DataDynamics.ActiveReports.SubReport subrptFooter;
        private DataDynamics.ActiveReports.Label label6;
        private DataDynamics.ActiveReports.Label label7;
        private DataDynamics.ActiveReports.Label label9;
        private DataDynamics.ActiveReports.TextBox textBox5;
        private DataDynamics.ActiveReports.SubReport subParking;
        private DataDynamics.ActiveReports.SubReport subWater;
        private DataDynamics.ActiveReports.Label LableTime;
        private DataDynamics.ActiveReports.Label LblMoneyParking;
        private DataDynamics.ActiveReports.Label LblMoneyPublic;
        private DataDynamics.ActiveReports.Label LblMoneyWater;
        private DataDynamics.ActiveReports.Label LblMoneyService;
        private DataDynamics.ActiveReports.Label LblMoneyServiceString;
        private DataDynamics.ActiveReports.Label LableTimePay;
        private DataDynamics.ActiveReports.Label LblMoneyOther;
        private DataDynamics.ActiveReports.Label LblMoneyElectric;
        private DataDynamics.ActiveReports.SubReport subElectric;
    }
}
