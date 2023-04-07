namespace TVSReports
{
    /// <summary>
    /// Summary description for Repdialytoday.
    /// </summary>
    partial class rptPaymentVoucherA5
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
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(rptPaymentVoucherA5));
            this.detail = new DataDynamics.ActiveReports.Detail();
            this.textBox1 = new DataDynamics.ActiveReports.TextBox();
            this.subReport = new DataDynamics.ActiveReports.SubReport();
            this.reportHeader1 = new DataDynamics.ActiveReports.ReportHeader();
            this.reportFooter1 = new DataDynamics.ActiveReports.ReportFooter();
            this.pageHeader1 = new DataDynamics.ActiveReports.PageHeader();
            this.pageFooter1 = new DataDynamics.ActiveReports.PageFooter();
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // detail
            // 
            this.detail.ColumnSpacing = 0F;
            this.detail.Controls.AddRange(new DataDynamics.ActiveReports.ARControl[] {
            this.textBox1,
            this.subReport});
            this.detail.Height = 0.8333333F;
            this.detail.KeepTogether = true;
            this.detail.Name = "detail";
            this.detail.Format += new System.EventHandler(this.detail_Format);
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
            this.textBox1.DataField = "IDService";
            this.textBox1.Height = 0.25F;
            this.textBox1.Left = 0F;
            this.textBox1.Name = "textBox1";
            this.textBox1.Style = "text-align: center; ";
            this.textBox1.Text = null;
            this.textBox1.Top = 0.5625F;
            this.textBox1.Visible = false;
            this.textBox1.Width = 7.22F;
            // 
            // subReport
            // 
            this.subReport.Border.BottomColor = System.Drawing.Color.Black;
            this.subReport.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subReport.Border.LeftColor = System.Drawing.Color.Black;
            this.subReport.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subReport.Border.RightColor = System.Drawing.Color.Black;
            this.subReport.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subReport.Border.TopColor = System.Drawing.Color.Black;
            this.subReport.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None;
            this.subReport.CloseBorder = false;
            this.subReport.Height = 0.25F;
            this.subReport.Left = 0F;
            this.subReport.Name = "subReport";
            this.subReport.Report = null;
            this.subReport.ReportName = "";
            this.subReport.Top = 0.5625F;
            this.subReport.Width = 7.22F;
            // 
            // reportHeader1
            // 
            this.reportHeader1.Height = 0F;
            this.reportHeader1.Name = "reportHeader1";
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
            this.pageFooter1.Height = 0F;
            this.pageFooter1.Name = "pageFooter1";
            // 
            // rptPaymentVoucherA5
            // 
            this.MasterReport = false;
            this.PageSettings.DefaultPaperSize = false;
            this.PageSettings.Margins.Bottom = 0F;
            this.PageSettings.Margins.Left = 0.35F;
            this.PageSettings.Margins.Right = 0.2F;
            this.PageSettings.Margins.Top = 0F;
            this.PageSettings.PaperHeight = 5.51F;
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.PageSettings.PaperName = "Custom paper";
            this.PageSettings.PaperWidth = 8.27F;
            this.PrintWidth = 7.260833F;
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
            this.ReportEnd += new System.EventHandler(this.rptPaymentVoucherA4_ReportEnd);
            this.ReportStart += new System.EventHandler(this.rpt_ReportStart);
            ((System.ComponentModel.ISupportInitialize)(this.textBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private DataDynamics.ActiveReports.ReportHeader reportHeader1;
        private DataDynamics.ActiveReports.ReportFooter reportFooter1;
        private DataDynamics.ActiveReports.PageHeader pageHeader1;
        private DataDynamics.ActiveReports.PageFooter pageFooter1;
        private DataDynamics.ActiveReports.SubReport subReport;
        private DataDynamics.ActiveReports.TextBox textBox1;
    }
}
