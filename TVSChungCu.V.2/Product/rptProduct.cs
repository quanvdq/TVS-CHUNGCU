using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data.SqlClient;
using System.Data;

namespace TVSReports
{
    public partial class rptProduct : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use  
        public static DataTable srptTable;
        public static DataTable srptTableBill;
        public static int srptBillIndex=0;
        public static string srptTitle = "";
        #endregion

        #region method rptProduct
        public rptProduct()
        {
            InitializeComponent();
            try
            {
                this.LblTitle.Text = srptTitle;
                try
                {
                    this.LblName.Text = srptTableBill.Rows[srptBillIndex]["NamePartner"].ToString();
                    this.LblAddress.Text = srptTableBill.Rows[srptBillIndex]["AddressPartner"].ToString();
                    this.LblPhone.Text = srptTableBill.Rows[srptBillIndex]["PhonePartner"].ToString();
                    DateTime sDateBill = DateTime.Parse(srptTableBill.Rows[srptBillIndex]["DateBill"].ToString()); ;
                    this.LblTime.Text = "Số : " + srptTableBill.Rows[srptBillIndex]["CodeBill"].ToString() + ".   " +
                                    "Ngày " + sDateBill.ToString("dd") + " tháng " + sDateBill.ToString("MM") + " năm " + sDateBill.ToString("yyyy") + ".";
                }
                catch { }
                this.DataSource = srptTable;                
            }
            catch { }
        } 
        #endregion

        private void rpt_ReportStart(object sender, EventArgs e)
        {
            TVSUtil.Reports.Paramater.sName = this.LblTitle.Text;
            TVSUtil.Reports.Paramater.sWidth = this.PrintWidth - this.PageSettings.Margins.Left - this.PageSettings.Margins.Right;
            this.subrptHeader.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptHeader.Report = new TVSUtil.Reports.SubHeader();

            this.subrptFooter.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptFooter.Report = new TVSUtil.Reports.SubFooter();

        }
    }


}
