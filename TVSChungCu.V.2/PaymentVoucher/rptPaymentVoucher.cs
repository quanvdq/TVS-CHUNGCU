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
    public partial class rptPaymentVoucher : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use
        private TVSSys.clsPublic objcP = new TVSSys.clsPublic();
        public static bool srptService= true;
        public static string srptID = "";
        public static string srptTitle = "";
        private static double  srptMoney = 0;
        #endregion

        #region method rptPaymentVoucher
        public rptPaymentVoucher()
        {
            InitializeComponent();
            this.lblID.Text =srptID;
            if ((srptTitle != "") && (srptTitle == "PHIẾU THU TIỀN MẶT"))
                this.lblTitle.Text = srptTitle;


            this.LblTax.Text = TVSSys.GlobalModule.objComTax;  
            lblPrintDate.Text = "In ngày: " + DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
            string sSQL = "";
            DataTable dt = new DataTable();
            if (srptService)
            {
                sSQL = "Select CodePaymentVoucher " +
                        ",( N'Ngày ' + cast(day(DatePaymentVoucher) as nvarchar) + N' tháng ' + cast(month(DatePaymentVoucher) as nvarchar) + N' năm ' + cast(year(DatePaymentVoucher) as nvarchar) ) as DatePaymentVoucher" +
                        " ,NamePartner,AddressPartner, PhonePartner" +
                        ", NamePaymentVoucherType,isnull(Money,0) as Money, FullName,Note " +
                        " from TblPaymentVoucher left join TblPaymentVoucherType On  TblPaymentVoucher.IDPaymentVoucherType=TblPaymentVoucherType.IDPaymentVoucherType " +
                        " left join TabUser On TabUser.UserName=TblPaymentVoucher.UserName " +
                        " Where IDPaymentVoucher=" + srptID;
                dt = TVSSys.GlobalModule.objCon.EXESelect(sSQL);
            }
            else
            {
                sSQL = "Select CodePaymentVoucher " +
                        ",( N'Ngày ' + cast(day(DatePaymentVoucher) as nvarchar) + N' tháng ' + cast(month(DatePaymentVoucher) as nvarchar) + N' năm ' + cast(year(DatePaymentVoucher) as nvarchar) ) as DatePaymentVoucher" +
                        " ,NamePartner,AddressPartner, PhonePartner" +
                        ", NamePaymentVoucherType,isnull(Money,0) as Money, FullName,Note " +
                        " from TblPaymentVoucher left join TblPaymentVoucherType On  TblPaymentVoucher.IDPaymentVoucherType=TblPaymentVoucherType.IDPaymentVoucherType " +
                        " left join TabUser On TabUser.UserName=TblPaymentVoucher.UserName " +
                        " Where IDService=" + srptID;
                DataTable dtTemp = TVSSys.GlobalModule.objCon.EXESelect(sSQL);
                dt = dtTemp.Copy();
                dt.Clear();
                string sCodePaymentVoucher = "";
                string sNamePaymentVoucherType = "";
                srptMoney = 0;
                for (int j = 0; j < dtTemp.Rows.Count; j++)
                {
                    sCodePaymentVoucher +="; " + dtTemp.Rows[j]["CodePaymentVoucher"].ToString();
                    sNamePaymentVoucherType += "; " + dtTemp.Rows[j]["NamePaymentVoucherType"].ToString();
                    srptMoney += double.Parse(dtTemp.Rows[j]["Money"].ToString());  
                }
                if (sCodePaymentVoucher != "") sCodePaymentVoucher = sCodePaymentVoucher.Substring(2);
                if (sNamePaymentVoucherType != "") sNamePaymentVoucherType = sNamePaymentVoucherType.Substring(2);

                dt.Rows.Add(sCodePaymentVoucher, dtTemp.Rows[0]["DatePaymentVoucher"].ToString()
                                                , dtTemp.Rows[0]["NamePartner"].ToString()
                                                , dtTemp.Rows[0]["AddressPartner"].ToString()
                                                , dtTemp.Rows[0]["PhonePartner"].ToString()
                                                , sNamePaymentVoucherType
                                                , srptMoney
                                                , dtTemp.Rows[0]["FullName"].ToString()
                                                , dtTemp.Rows[0]["Note"].ToString());
            }

            if (dt.Rows.Count > 0) srptMoney = double.Parse(dt.Rows[0]["Money"].ToString());  
            this.DataSource = dt; 
            lblPaidAmount.Text = string.Format("{0:###,0}", srptMoney) + " đồng";
            lblBangchu.Text = objcP.changeNumberToWord1(Convert.ToInt64(srptMoney));
            //this.lblID.Text = "SỐ PHIẾU: " + this.lblID.Text;
        } 
        #endregion

        private void rptPaymentVoucher_ReportStart(object sender, EventArgs e)
        {
            TVSUtil.Reports.Paramater.sName = this.lblTitle.Text;
            TVSUtil.Reports.Paramater.sWidth = this.PrintWidth - this.PageSettings.Margins.Left - this.PageSettings.Margins.Right;
            this.subrptHeader.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptHeader.Report = new TVSUtil.Reports.SubHeader();

            this.subrptFooter.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptFooter.Report = new TVSUtil.Reports.SubFooter();
        }

        private void reportHeader1_BeforePrint(object sender, EventArgs e)
        {
            this.lblID.Text = "SỐ PHIẾU: " + this.lblID.Text;
        }

    }


}
