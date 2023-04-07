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
    public partial class rptNotify4 : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use  
        private TVSSys.clsPublic objcP = new TVSSys.clsPublic();
        public static string srptID = "";
        public static string srptNoteTime = "";
        private static double sMoneyPublic = 0, sMoneyService = 0, sMoneyParking = 0, sMoneyOther = 0, sMoneyWater = 0, sMoneyElectric = 0;
        private DataTable srptTable;
        #endregion

        #region method rptNotify4
        public rptNotify4()
        {
            InitializeComponent();
            try
            {
                string sSQL = "Select Time, (ContactPerson + '. ' + isnull(ContactPhone,'')) as ContactPerson,(CodeRoom + ': ' + NameRoom + '. ' + isnull(Address,'')) as Room" +
                            " ,isnull(MoneyPublic,0) as MoneyPublic " +
                            " ,isnull(MoneyService,0) as MoneyService " +
                            " ,isnull(NumberBeginWater,0) as NumberBeginWater " +
                            " ,isnull(NumberEndWater,0) as NumberEndWater " +
                            " ,isnull(NumberBeginElectric,0) as NumberBeginElectric " +
                            " ,isnull(NumberEndElectric,0) as NumberEndElectric " +
                            " ,NoteParking" +
                            " ,isnull(MoneyParking,0) as MoneyParking " +
                            " ,isnull(MoneyWater,0) as MoneyWater " +
                            " ,isnull(MoneyElectric,0) as MoneyElectric " +
                            " ,isnull(MoneyOther,0) as MoneyOther " +
                            " FROM TblService LEFT JOIN TblRoom ON TblRoom.IDRoom=TblService.IDRoom" +
                            " LEFT JOIN TblPartner ON TblPartner.IDPartner=TblRoom.IDPartner " +                            
                            " WHERE IDService= " + srptID;
                srptTable = TVSSys.GlobalModule.objCon.EXESelect(sSQL);
                if (srptTable.Rows.Count > 0)
                {
                    sMoneyPublic = double.Parse(srptTable.Rows[0]["MoneyPublic"].ToString());
                    sMoneyService = double.Parse(srptTable.Rows[0]["MoneyService"].ToString());
                    sMoneyParking = double.Parse(srptTable.Rows[0]["MoneyParking"].ToString());
                    sMoneyWater = double.Parse(srptTable.Rows[0]["MoneyWater"].ToString());
                    sMoneyElectric = double.Parse(srptTable.Rows[0]["MoneyElectric"].ToString());                    
                    sMoneyOther = double.Parse(srptTable.Rows[0]["MoneyOther"].ToString());
                }
                this.DataSource = srptTable;
                this.LblMoneyPublic.Text = "1: Phí tiền phòng : " + string.Format("{0:###,0}", sMoneyPublic) + " đồng";
                this.LblMoneyOther.Text = "2: Phí dịch vụ : " + string.Format("{0:###,0}", sMoneyOther) + " đồng";
                this.LblMoneyParking.Text = "3: Phí trông xe : " + string.Format("{0:###,0}", sMoneyParking) + " đồng";
                

                this.LblMoneyService.Text = "Tổng số tiền phải nộp:  " + string.Format("{0:###,0}", sMoneyService) + " đồng";
                this.LblMoneyServiceString.Text = "Bằng chữ: (" + objcP.changeNumberToWord1(Convert.ToInt64(sMoneyService)) + ")";

                this.LableTime.Text = TVSSys.GlobalModule.objConfigID0 + srptTable.Rows[0]["Time"].ToString().Substring(4, 2) + "/" + srptTable.Rows[0]["Time"].ToString().Substring(0, 4) + ":";                
                DateTime sDtNext = TVSMain.Service.SetTimeNext(srptTable.Rows[0]["Time"].ToString());
                this.LableTimePay.Text = TVSSys.GlobalModule.objConfigID1 + sDtNext.ToString("MM") + "/" + sDtNext.ToString("yyyy")  + ".";
            }
            catch { }
        } 
        #endregion

        private void rpt_ReportStart(object sender, EventArgs e)
        {
            TVSUtil.Reports.Paramater.sName = this.lblTitle.Text;
            TVSUtil.Reports.Paramater.sWidth = this.PrintWidth - this.PageSettings.Margins.Left - this.PageSettings.Margins.Right;
            this.subrptHeader.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptHeader.Report = new TVSUtil.Reports.SubHeader();

            this.subrptFooter.Width = TVSUtil.Reports.Paramater.sWidth;
            this.subrptFooter.Report = new TVSUtil.Reports.SubFooter();

            rptParking.srptID = srptID;
            this.subParking.Report = new rptParking();
        }
    }


}
