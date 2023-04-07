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
    
    public partial class rptProductList : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use
        private clsReports objPub = new clsReports();
        public static string srptTitle = "";
        public static string srptTitleDate = "";
        public static string srptTitleDescription = "";
        public static DataTable srptTable;
        #endregion

        #region method rptProductList
        public rptProductList()
        {
            InitializeComponent();

            if (srptTitle != "") this.lblTitle.Text = srptTitle;
            if (srptTitleDescription != "") this.lblRepDay.Text = srptTitleDescription;
            
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
