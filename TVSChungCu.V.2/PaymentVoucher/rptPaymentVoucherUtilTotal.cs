using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data.SqlClient;
using System.Data;
using Microsoft.VisualBasic.CompilerServices;  

namespace TVSReports
{
    
    public partial class rptPaymentVoucherUtilTotal : DataDynamics.ActiveReports.ActiveReport3
    {        
        
        #region Declare variable to use
        private TVSSys.Connection objFun = new TVSSys.Connection();
        private clsReports objPub = new clsReports();
        private TVSSys.clsPublic objcP = new TVSSys.clsPublic();
        public static string fullName = "", userName = "";
        public static string srptID = "";
        public static string srptTitle = "";
        public static string srptTitleDate = "";
        public static string srptTitleDescription = "";
        public static string srptMoneyFisrt = "", srptMoneyLast = "";
        public static double  srptMoney = 0;
        public static DataTable srptTable;
        #endregion

        #region method rptPaymentVoucherUtilTotal
        public rptPaymentVoucherUtilTotal()
        {
            InitializeComponent();

            if (srptTitle != "") this.lblTitle.Text = srptTitle;
            if (srptTitleDescription != "") this.lblRepDay.Text = srptTitleDescription;
            this.LblMoneyFisrt.Text = srptMoneyFisrt;
            this.LblMoneyLast.Text = srptMoneyLast;
            this.DataSource = srptTable;
        } 
        #endregion

        private void detail_BeforePrint(object sender, EventArgs e)
        {
            if (srptTable.Rows.Count < 2000) objPub.MakeSameHeight(this.detail);
        }

        private void rptPaymentVoucherUtil_ReportStart(object sender, EventArgs e)
        {
            TVSUtil.Reports.Paramater.sName = this.lblTitle.Text;
            TVSUtil.Reports.Paramater.sWidth = this.PrintWidth - this.PageSettings.Margins.Left - this.PageSettings.Margins.Right;
            this.subrptHeader.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptHeader.Report = new TVSUtil.Reports.SubHeader();

            this.subrptFooter.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptFooter.Report = new TVSUtil.Reports.SubFooter();
        }

    }


}
