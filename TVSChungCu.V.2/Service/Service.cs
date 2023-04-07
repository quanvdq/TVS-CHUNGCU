using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using C1.Win.C1TrueDBGrid;
using Microsoft.VisualBasic;
using System.Drawing;

namespace TVSMain
{
    public class Service
    {
        public static void SetRegion(ToolStripComboBox sCom)
        {
            try
            {
                DataTable sData = TVSSys.GlobalModule.objCon.EXESelect("SELECT * FROM TblRegion ORDER BY NameRegion");
                string sIDRegion = "";
                int sPerID = 0;
                int sCount = 0;
                for (int i = 0; i < sData.Rows.Count; i++)
                {
                    sPerID =900 + int.Parse(sData.Rows[i][0].ToString());

                    if (TVSSys.GlobalModule.objPermission.Contains(sPerID.ToString()))
                    {
                        sIDRegion += "," + sData.Rows[i][0].ToString();
                        sCount++;
                    }
                }

                if (sIDRegion != "") sIDRegion = " WHERE IDRegion IN(" +  sIDRegion.Substring(1) + ")";

                if (sCount == sData.Rows.Count)
                    sCom.Items.Add(new TVSSys.ItemCombobox("-- Tất cả --", "0"));

                sData = TVSSys.GlobalModule.objCon.EXESelect("SELECT * FROM TblRegion " + sIDRegion + " ORDER BY NameRegion");
                if (sData.Rows.Count > 0)
                {
                    for (int i = 0; i < sData.Rows.Count; i++)
                    {
                        sCom.Items.Add(new TVSSys.ItemCombobox(sData.Rows[i][1].ToString(), sData.Rows[i][0].ToString()));
                    }
                }
                sCom.SelectedIndex = 0;
            }
            catch { return; }
        }

        #region method Time
        public static void SetTime(ToolStripComboBox sCom)
        {
            try
            {
                DateTime dtFrom = new DateTime(2017, 12, 1); // Thời điểm đầu tiên: 1/2018
                DateTime dtWork;
                long j = DateAndTime.DateDiff(DateInterval.Month, dtFrom, DateTime.Now, Microsoft.VisualBasic.FirstDayOfWeek.System, FirstWeekOfYear.System);
                for (long i = j; i > 0; i--)
                {
                    dtWork = DateAndTime.DateAdd(DateInterval.Month, i, dtFrom);
                    sCom.Items.Add(new TVSSys.ItemCombobox("Tháng " + dtWork.Month.ToString("00") + " năm " + dtWork.Year.ToString("0000"), dtWork.Year.ToString("0000") + dtWork.Month.ToString("00")));
                }
                sCom.SelectedIndex = 0;
            }
            catch { return; }
        }
        public static string SetTimePrevious(string sTime)
        {
            try
            {
                DateTime dtFrom = new DateTime(int.Parse(sTime.Substring(0, 4)), int.Parse(sTime.Substring(4)), 28);
                DateTime dtWork = DateAndTime.DateAdd(DateInterval.Month, -1, dtFrom);
                return dtWork.Year.ToString("0000") + dtWork.Month.ToString("00");
            }
            catch { return "201712"; }
        }

        public static DateTime SetTimeNext(string sTime)
        {
            try
            {
                DateTime dtFrom = new DateTime(int.Parse(sTime.Substring(0, 4)), int.Parse(sTime.Substring(4)), 28);
                return  DateAndTime.DateAdd(DateInterval.Month, 1, dtFrom);
            }
            catch { return DateAndTime.DateAdd(DateInterval.Month, 1, DateTime.Now); }
        }        
        #endregion

        #region Calculator
        public static bool Calculator(string sService,string sTime)
        {
            bool sResult = false;            
            try
            {
                switch (sService)
                {
                    case "Parking": { sResult = CalculatorParking(sTime); break; }
                    case "Water":  
                    case "Electric": { sResult = CalculatorWater(sService, sTime); break; }
                }
                string sSQLQuery = "UPDATE TblService SET MoneyService = ISNULL(MoneyPublic,0) + ISNULL(MoneyParking,0) + ISNULL(MoneyWater,0) + ISNULL(MoneyElectric,0) + ISNULL(MoneyOther,0) + ISNULL(MoneyDebt,0), ";
                sSQLQuery += "MoneyDebtBalancer = (ISNULL(MoneyPublic,0) + ISNULL(MoneyParking,0) + ISNULL(MoneyWater,0) + ISNULL(MoneyElectric,0) + ISNULL(MoneyOther,0) + ISNULL(MoneyDebt,0)) - (ISNULL(MoneyPayPublic,0)+ISNULL(MoneyPayParking,0)+ISNULL(MoneyPayWater,0)+ISNULL(MoneyPayElectric,0)+ISNULL(MoneyPayOther,0)+ISNULL(MoneyPayDebt,0)) ";
                sSQLQuery += "WHERE Time='" + sTime + "' AND ISNULL(PaymentByMomo,0) = 0";
                if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                return sResult;
            }
            catch { return false; }
        }

        private static bool CalculatorParking(string sTime)
        {
            try
            {
                string sSQLQuery = "0", sColumn = ""; ;
                DataTable sTemp = TVSSys.GlobalModule.objCon.EXESelect("SELECT * FROM TblPriceParking Where isnull(Action,0)=1");
                if (sTemp.Rows.Count > 0)
                {
                    for (int i = 0; i < sTemp.Rows.Count; i++)
                    {
                        sColumn = "IDPriceParking" + sTemp.Rows[i]["IDPriceParking"].ToString();
                        sSQLQuery += " + (isnull(" + sColumn + ",0) * isnull((SELECT isnull(Price,0) FROM TblPriceParking WHERE IDPriceParking=" + sTemp.Rows[i]["IDPriceParking"].ToString() + "),0))";
                    }
                }
                sSQLQuery = "   UPDATE TblService SET MoneyParking=" + sSQLQuery +
                            "   WHERE Time='" + sTime + "'";
                return TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery); 
            }
            catch { return false; }
        }

        private static bool CalculatorWater(string sService,string sTime)
        {
            bool sResult = true; 
            try
            {
                string sSQLQuery = " UPDATE TblService SET Number" + sService + " = (ISNULL(NumberEnd" + sService + ",0) - ISNULL(NumberBegin" + sService + ",0)), Money" + sService + " = 0" +
                                    " WHERE Time = '" + sTime + "' AND (ISNULL(NumberEnd" + sService + ",0) - ISNULL(NumberBegin" + sService + ",0)) >= 0";
                if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;

                sSQLQuery = "   DELETE FROM TblService" + sService + "Detail" +
                            "   WHERE Time = '" + sTime + "'";

                if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;

                DataTable sDataRoom = TVSSys.GlobalModule.objCon.EXESelect("SELECT * FROM TblService WHERE Time='" + sTime + "'");
                if (sDataRoom.Rows.Count > 0)
                {
                    for (int i = 0; i < sDataRoom.Rows.Count; i++)
                    {
                        CalculatorMoney(sService, sTime, sDataRoom.Rows[i]["Number" + sService].ToString(), sDataRoom.Rows[i]["IDRoom"].ToString());                        
                    }
                }
                sSQLQuery = "   UPDATE TblService SET Money" + sService + "=(SELECT SUM(Money) FROM TblService" + sService + "Detail WHERE TblService" + sService + "Detail.Time=TblService.Time AND TblService" + sService + "Detail.IDRoom=TblService.IDRoom)" +
                            "   WHERE Time='" + sTime + "'";
                if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                return sResult;
            }
            catch { return false; }
        }

        private static void CalculatorMoney(string sService, string sTime, string sNumber, string sIDRoom)
        {
            try
            {
                string sSQLDetail = "";
                string sSQLQuery = "    SELECT * FROM TblPrice" +  sService +
                                   "    WHERE IDPay" + sService + "=(SELECT isnull(IDPay" + sService + ",0) FROM TblRoom WHERE IDRoom=" + sIDRoom + " )" +
                                   "    ORDER BY isnull(NumberMin,0)";
                DataTable sDtPrice = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);
                double sNumberAll = 0, sNumberMin = 0, sPrice = 0;
                try
                {
                    sNumberAll = double.Parse(sNumber);  
                }
                catch { sNumberAll = 0; }
                if (sDtPrice.Rows.Count == 0) return;
                if (sNumberAll == 0) return;

                for (int i = 0; i < sDtPrice.Rows.Count; i++)
                {
                    try
                    {
                        sNumberMin = double.Parse(sDtPrice.Rows[i]["NumberMin"].ToString());
                    }
                    catch { sNumberMin = 0; }
                    try
                    {
                        sPrice = double.Parse(sDtPrice.Rows[i]["Price"].ToString());
                    }
                    catch { sPrice = 0; }

                    if (sNumberAll < sNumberMin)
                    {
                        sSQLDetail += SQLDetail(sService, sTime, sIDRoom, sDtPrice.Rows[i]["IDPrice" + sService].ToString(), sNumberAll, sPrice);
                        break;
                    }
                    else
                    {
                        sNumberAll = sNumberAll - sNumberMin;
                        sSQLDetail += SQLDetail(sService, sTime, sIDRoom, sDtPrice.Rows[i]["IDPrice" + sService].ToString(), sNumberMin, sPrice);
                    }
                }
                if (sSQLDetail != "") TVSSys.GlobalModule.objCon.EXEUpdate(sSQLDetail);    
            }
            catch { }
        }

        private static string SQLDetail(string sService, string sTime, string sIDRoom, string sIDPrice, double sNumber, double sPrice)
        {
            return " INSERT INTO TblService" + sService + "Detail (Time,IDRoom,IDPrice" + sService + ",Number,Price,Money)" +
                        " VALUES ('" + sTime + "'," + sIDRoom + "," + sIDPrice + "," + sNumber + "," + sPrice + "," + sNumber * sPrice + ")" +
                        System.Environment.NewLine;
        }


        public static bool PaymentVoucher(DataTable  sDataService)
        {
            bool sResult = false;
            try
            {
                int IDPaymentVoucherTypeGroup = 1; // THU 
                int sIDPayTypePublic = 7;
                int sIDPayTypeParking = 4;
                int sIDPayTypeWater = 5;
                int sIDPayTypeElectric = 6;
                int sIDPayTypeOther = 8;
                string sSQLQuery = "";

                double sMoneyPayPublic = 0;
                double sMoneyPayParking = 0;
                double sMoneyPayWater = 0;
                double sMoneyPayElectric = 0;
                double sMoneyPayOther = 0;
                string sIDService = "0", sIDRoom = "0";
                string sNoteTime = "";
                try
                {
                    sNoteTime = sDataService.Rows[0]["Time"].ToString();
                }
                catch { sIDService = ""; }
                if (sNoteTime != "")
                {
                    try
                    {
                        sNoteTime = "Thu tháng " + sNoteTime.Substring(4, 2) + " năm " + sNoteTime.Substring(0, 4); 
                    }
                    catch { }
                }

                for (int i = 0; i < sDataService.Rows.Count; i++)
                {
                    try
                    {
                        sIDService=sDataService.Rows[i]["IDService"].ToString();  
                    }
                    catch {sIDService="0"; }
                    try
                    {
                        sIDRoom = sDataService.Rows[i]["IDRoom"].ToString();
                    }
                    catch { sIDRoom = "0"; }

                    #region sMoneyPayPublicOther
                    try
                    {
                        sMoneyPayOther = double.Parse(sDataService.Rows[i]["MoneyPayOther"].ToString());
                    }
                    catch { sMoneyPayOther = 0; }
                    if (sMoneyPayOther == 0)
                    {
                        sSQLQuery = "   DELETE FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeOther + " AND IDService=" + sIDService;
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    else
                    {
                        sSQLQuery = "   IF NOT EXISTS (SELECT * FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeOther + " AND IDService=" + sIDService + ")" +
                                    "   BEGIN" +
                                    "       INSERT INTO TblPaymentVoucher (UserName,DatePaymentVoucher,IDPaymentVoucherTypeGroup,IDPaymentVoucherType,NamePartner,AddressPartner,PhonePartner,Money,Note,IDService)" +
                                    "       SELECT '" + TVSSys.GlobalModule.objUserName + "',getdate()," + IDPaymentVoucherTypeGroup + "," + sIDPayTypeOther + ", ContactPerson,isnull(CodeRoom,'') + ': ' + isnull(NameRoom,'') + '. ' + isnull(Address,''),ContactPhone," + sMoneyPayOther + ",N'" + sNoteTime + "'," + sIDService + " " +
                                    "       FROM TblRoom LEFT JOIN TblPartner ON TblPartner.IDPartner=TblRoom.IDPartner WHERE IDRoom=" + sIDRoom +
                                    "   END" +
                                    "   ELSE" +
                                    "   BEGIN" +
                                    "       UPDATE TblPaymentVoucher SET Money=" + sMoneyPayOther +
                                    "       WHERE IDPaymentVoucherType=" + sIDPayTypeOther + " AND IDService=" + sIDService +
                                    "   END";
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    #endregion

                    #region sMoneyPayPublic
                    try
                    {
                        sMoneyPayPublic = double.Parse(sDataService.Rows[i]["MoneyPayPublic"].ToString());
                    }
                    catch { sMoneyPayPublic = 0; }
                    if (sMoneyPayPublic == 0)
                    {
                        sSQLQuery = "   DELETE FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypePublic + " AND IDService=" + sIDService;
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    else
                    {
                        sSQLQuery = "   IF NOT EXISTS (SELECT * FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypePublic + " AND IDService=" + sIDService +")" +
                                    "   BEGIN"  +
                                    "       INSERT INTO TblPaymentVoucher (UserName,DatePaymentVoucher,IDPaymentVoucherTypeGroup,IDPaymentVoucherType,NamePartner,AddressPartner,PhonePartner,Money,Note,IDService)" +
                                    "       SELECT '" + TVSSys.GlobalModule.objUserName + "',getdate()," + IDPaymentVoucherTypeGroup + "," + sIDPayTypePublic + ", ContactPerson,isnull(CodeRoom,'') + ': ' + isnull(NameRoom,'') + '. ' + isnull(Address,''),ContactPhone," + sMoneyPayPublic + ",N'" + sNoteTime + "'," + sIDService + " " +
                                    "       FROM TblRoom LEFT JOIN TblPartner ON TblPartner.IDPartner=TblRoom.IDPartner WHERE IDRoom=" + sIDRoom +
                                    "   END" +
                                    "   ELSE"   +
                                    "   BEGIN" +
                                    "       UPDATE TblPaymentVoucher SET Money=" + sMoneyPayPublic +
                                    "       WHERE IDPaymentVoucherType=" + sIDPayTypePublic + " AND IDService=" + sIDService  +
                                    "   END";
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    #endregion

                    #region sMoneyPayParking
                    try
                    {
                        sMoneyPayParking = double.Parse(sDataService.Rows[i]["MoneyPayParking"].ToString());
                    }
                    catch { sMoneyPayParking = 0; }
                    if (sMoneyPayParking == 0)
                    {
                        sSQLQuery = "   DELETE FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeParking + " AND IDService=" + sIDService;
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    else
                    {
                        sSQLQuery = "   IF NOT EXISTS (SELECT * FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeParking + " AND IDService=" + sIDService + ")" +
                                    "   BEGIN" +
                                    "       INSERT INTO TblPaymentVoucher (UserName,DatePaymentVoucher,IDPaymentVoucherTypeGroup,IDPaymentVoucherType,NamePartner,AddressPartner,PhonePartner,Money,Note,IDService)" +
                                    "       SELECT '" + TVSSys.GlobalModule.objUserName + "',getdate()," + IDPaymentVoucherTypeGroup + "," + sIDPayTypeParking + ", ContactPerson,isnull(CodeRoom,'') + ': ' + isnull(NameRoom,'') + '. ' + isnull(Address,''),ContactPhone," + sMoneyPayParking + ",N'" + sNoteTime + "'," + sIDService + " " +
                                    "       FROM TblRoom LEFT JOIN TblPartner ON TblPartner.IDPartner=TblRoom.IDPartner WHERE IDRoom=" + sIDRoom +
                                    "   END" +
                                    "   ELSE" +
                                    "   BEGIN" +
                                    "       UPDATE TblPaymentVoucher SET Money=" + sMoneyPayParking +
                                    "       WHERE IDPaymentVoucherType=" + sIDPayTypeParking + " AND IDService=" + sIDService +
                                    "   END";
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    #endregion

                    #region sMoneyPayWater
                    try
                    {
                        sMoneyPayWater = double.Parse(sDataService.Rows[i]["MoneyPayWater"].ToString());
                    }
                    catch { sMoneyPayWater = 0; }
                    if (sMoneyPayWater == 0)
                    {
                        sSQLQuery = "   DELETE FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeWater + " AND IDService=" + sIDService;
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    else
                    {
                        sSQLQuery = "   IF NOT EXISTS (SELECT * FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeWater + " AND IDService=" + sIDService + ")" +
                                    "   BEGIN" +
                                    "       INSERT INTO TblPaymentVoucher (UserName,DatePaymentVoucher,IDPaymentVoucherTypeGroup,IDPaymentVoucherType,NamePartner,AddressPartner,PhonePartner,Money,Note,IDService)" +
                                    "       SELECT '" + TVSSys.GlobalModule.objUserName + "',getdate()," + IDPaymentVoucherTypeGroup + "," + sIDPayTypeWater + ", ContactPerson,isnull(CodeRoom,'') + ': ' + isnull(NameRoom,'') + '. ' + isnull(Address,''),ContactPhone," + sMoneyPayWater + ",N'" + sNoteTime + "'," + sIDService + " " +
                                    "       FROM TblRoom LEFT JOIN TblPartner ON TblPartner.IDPartner=TblRoom.IDPartner WHERE IDRoom=" + sIDRoom +
                                    "   END" +
                                    "   ELSE" +
                                    "   BEGIN" +
                                    "       UPDATE TblPaymentVoucher SET Money=" + sMoneyPayWater +
                                    "       WHERE IDPaymentVoucherType=" + sIDPayTypeWater + " AND IDService=" + sIDService +
                                    "   END";
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    #endregion

                    #region sMoneyPayElectric
                    try
                    {
                        sMoneyPayElectric = double.Parse(sDataService.Rows[i]["MoneyPayElectric"].ToString());
                    }
                    catch { sMoneyPayElectric = 0; }
                    if (sMoneyPayElectric == 0)
                    {
                        sSQLQuery = "   DELETE FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeElectric + " AND IDService=" + sIDService;
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    else
                    {
                        sSQLQuery = "   IF NOT EXISTS (SELECT * FROM TblPaymentVoucher WHERE IDPaymentVoucherType=" + sIDPayTypeElectric + " AND IDService=" + sIDService + ")" +
                                    "   BEGIN" +
                                    "       INSERT INTO TblPaymentVoucher (UserName,DatePaymentVoucher,IDPaymentVoucherTypeGroup,IDPaymentVoucherType,NamePartner,AddressPartner,PhonePartner,Money,Note,IDService)" +
                                    "       SELECT '" + TVSSys.GlobalModule.objUserName + "',getdate()," + IDPaymentVoucherTypeGroup + "," + sIDPayTypeElectric + ", ContactPerson,isnull(CodeRoom,'') + ': ' + isnull(NameRoom,'') + '. ' + isnull(Address,''),ContactPhone," + sMoneyPayElectric + ",N'" + sNoteTime + "'," + sIDService + " " +
                                    "       FROM TblRoom LEFT JOIN TblPartner ON TblPartner.IDPartner=TblRoom.IDPartner WHERE IDRoom=" + sIDRoom +
                                    "   END" +
                                    "   ELSE" +
                                    "   BEGIN" +
                                    "       UPDATE TblPaymentVoucher SET Money=" + sMoneyPayElectric +
                                    "       WHERE IDPaymentVoucherType=" + sIDPayTypeElectric + " AND IDService=" + sIDService +
                                    "   END";
                        if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                    }
                    #endregion
                }
                return sResult;
            }
            catch { return false; }
        }
        #endregion

        #region Balances
        public static bool Balances(string sService, string sTime)
        {
            bool sResult = false;
            try
            {
                switch (sService)
                {
                    case "Parking": { sResult = BalancesParking(sTime); break; }
                    case "Water":
                    case "Electric": { sResult = BalancesWater(sService,sTime); break; }
                }
                return sResult;
            }
            catch { return false; }
        }

        private static bool BalancesParking(string sTime)
        {
            bool sResult = true;
            try
            {
                string sSQLQuery = "  Update TblService  Set IDPriceParking1= ServicePre.IDPriceParking1" +
                            " ,IDPriceParking2= ServicePre.IDPriceParking2" +
                            " ,IDPriceParking3= ServicePre.IDPriceParking3" +
                            " ,IDPriceParking4= ServicePre.IDPriceParking4" +
                            " ,IDPriceParking5= ServicePre.IDPriceParking5" +
                            " ,IDPriceParking6= ServicePre.IDPriceParking6" +
                            " ,IDPriceParking7= ServicePre.IDPriceParking7" +
                            " ,IDPriceParking8= ServicePre.IDPriceParking8" +
                            " ,IDPriceParking9= ServicePre.IDPriceParking9" +
                            " ,NoteParking= ServicePre.NoteParking" +
                            " from TblService as ServiceCur" +
                            ", (Select IDRoom,IDPriceParking1,IDPriceParking2,IDPriceParking3,IDPriceParking4" +
                            ", IDPriceParking5,IDPriceParking6,IDPriceParking7,IDPriceParking8,IDPriceParking9,NoteParking" +
                            " from TblService Where Time='" + SetTimePrevious(sTime) + "') as ServicePre" +
                            " Where ServiceCur.Time='" + sTime + "' AND ServiceCur.IDRoom=ServicePre.IDRoom   " +
                            "   ";
                if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                if (!CalculatorParking(sTime)) sResult = false;
                return sResult;
            }
            catch { return false; }
        }

        private static bool BalancesWater(string sService,string sTime)
        {
            bool sResult = true;
            try
            {
                string sSQLQuery = "  Update TblService  Set NumberBegin" + sService + "= ServicePre.NumberEnd" + sService +
                            " from TblService as ServiceCur" +
                            ", (Select IDRoom,NumberBegin" + sService + ",NumberEnd" + sService + " from TblService Where Time='" + SetTimePrevious(sTime) + "') as ServicePre" +
                            " Where ServiceCur.Time='" + sTime + "' AND ServiceCur.IDRoom=ServicePre.IDRoom   " +
                            "   ";
                if (!TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery)) sResult = false;
                if (!CalculatorWater(sService,sTime)) sResult = false;
                return sResult;
            }
            catch { return false; }
        }
        #endregion

        #region getPermisstionOfUser
        public void getPermisstionOfUser(string UserName, ref bool EditServiceParking, ref bool EditServiceWater, ref bool EditServiceElectric, ref bool EditServiceUsed)
        {
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TabUser WHERE UserName = @UserName";
                Cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = UserName;
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    if (Rd["EditServiceParking"].ToString() != "")
                    {
                        EditServiceParking = bool.Parse(Rd["EditServiceParking"].ToString());
                    }
                    else
                    {
                        EditServiceParking = false;
                    }

                    if (Rd["EditServiceWater"].ToString() != "")
                    {
                        EditServiceWater = bool.Parse(Rd["EditServiceWater"].ToString());
                    }
                    else
                    {
                        EditServiceWater = false;
                    }

                    if (Rd["EditServiceElectric"].ToString() != "")
                    {
                        EditServiceElectric = bool.Parse(Rd["EditServiceElectric"].ToString());
                    }
                    else
                    {
                        EditServiceElectric = false;
                    }

                    if (Rd["EditServiceUsed"].ToString() != "")
                    {
                        EditServiceUsed = bool.Parse(Rd["EditServiceUsed"].ToString());
                    }
                    else
                    {
                        EditServiceUsed = false;
                    }
                }
                Rd.Close();
                Rd.Dispose();
               
            }
            catch
            {
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
        }
        #endregion
    }
}
 