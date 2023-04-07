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
    
    public partial class rptServiceListM1 : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use
        private clsReports objPub = new clsReports();
        public static string srptID = "";
        public static string srptTitle = "";
        public static string srptTitleDate = "";
        public static string srptTitleDescription = "";
        public static DataTable srptTable;
        #endregion

        #region method rptServiceListM1
        public rptServiceListM1()
        {
            InitializeComponent();

            if (rptServiceList.srptTitle != "") this.lblTitle.Text = rptServiceList.srptTitle;
            if (rptServiceList.srptTitleDescription != "") this.lblRepDay.Text = rptServiceList.srptTitleDescription;

            srptTable = rptServiceList.srptTable.Copy();

            srptTable.Columns.Add("Balance",typeof(double));
            double sMoneyService = 0, sMoneyPayService = 0;
            for (int i = 0; i < srptTable.Rows.Count; i++ )
            {
                try
                {
                    sMoneyService = double.Parse(srptTable.Rows[i]["MoneyService"].ToString());
                }
                catch { sMoneyService = 0; }
                try
                {
                    sMoneyPayService = double.Parse(srptTable.Rows[i]["MoneyPayService"].ToString());
                }
                catch { sMoneyPayService = 0; }

                srptTable.Rows[i]["Balance"] = sMoneyService - sMoneyPayService;
            }
            this.DataSource = srptTable;
        } 
        #endregion

        private void detail_BeforePrint(object sender, EventArgs e)
        {
            if (srptTable.Rows.Count < 2000) objPub.MakeSameHeight(this.detail);
        }

        private void rptPaymentVoucherList_ReportStart(object sender, EventArgs e)
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
