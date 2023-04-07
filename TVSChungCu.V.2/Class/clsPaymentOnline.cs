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

namespace TVSChungCu.Class
{
    class clsPaymentOnline
    {
        public DataTable getData(DateTime objDate1, DateTime objDate2, string SearchKey)
        {
            string SQL = "", SQL_SEARCH = "";

            if (SearchKey.Trim() != "")
            {
                SQL_SEARCH = " AND ((B.NameRoom LIKE N'%'+@SearchKey+'%') OR (D.ContactPerson LIKE N'%'+@SearchKey+'%') OR (A.Note LIKE N'%'+@SearchKey+'%') )";
            }

            SQL = "SELECT DISTINCT 0 AS MyIndex, ";
            SQL += "A.MoneyPublic, A.MoneyParking, A.NoteParking, A.MoneyWater, A.MoneyElectric, A.MoneyOther, A.MoneyDebt, A.MoneyService, ";
            SQL += "A.MoneyPayService, A.MoneyDebtBalancer, A.Note, A.PaymentByMomoTime, ";
            SQL += "B.NameRoom, ";
            SQL += "D.ContactPerson ";
            SQL += "FROM TblService A, TblRoom B, TblRoomPartner C, TblPartner D ";
            SQL += "WHERE A.IDRoom = B.IDRoom AND B.IDRoom = C.IDRoom AND C.IDPartner = D.IDPartner ";
            SQL += "AND A.PaymentByMomoTime IS NOT NULL AND C.DateEnd IS NOT NULL AND (DATEPART(YEAR, C.DateEnd) >= DATEPART(YEAR, getdate())) ";
            SQL += "AND A.PaymentByMomoTime BETWEEN @objDate1 AND @objDate2 ";
            SQL += SQL_SEARCH;
            SQL += "ORDER BY PaymentByMomoTime DESC";

            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = SQL;
                Cmd.Parameters.Add("SearchKey", SqlDbType.NVarChar).Value = SearchKey;
                Cmd.Parameters.Add("objDate1", SqlDbType.DateTime).Value = new DateTime(objDate1.Year, objDate1.Month, objDate1.Day, 0,0,0);
                Cmd.Parameters.Add("objDate2", SqlDbType.DateTime).Value = new DateTime(objDate2.Year, objDate2.Month, objDate2.Day, 23, 59, 59); ;
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = Cmd;
                da.Fill(ds);
                objTable = ds.Tables[0];
                for (int i = 0; i < objTable.Rows.Count; i++)
                {
                    objTable.Rows[i]["MyIndex"] = (i + 1).ToString();
                }
            }
            catch (Exception Ex)
            {
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return objTable;
        }
    }
}
