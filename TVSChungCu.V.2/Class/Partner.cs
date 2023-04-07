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
    public class Partner
    {       
        #region method Declare ...
        public static string sQueryBalance=" (isnull((SELECT SUM(case when IDPaymentVoucherTypeGroup=2 then isnull(Money,0) else isnull(Money,0)*(-1) end)  FROM TblPaymentVoucher  WHERE  TblPaymentVoucher.IDPartner=TblPartner.IDPartner),0)" +
                                            " + isnull((SELECT SUM(isnull(MoneyService,0)-isnull(MoneyPayService,0)) FROM TblService LEFT JOIN TblRoom ON TblService.IDRoom=TblRoom.IDRoom WHERE TblRoom.IDPartner=TblPartner.IDPartner ),0))" ;
        #endregion

        #region method setData
        public int setData(string IDPartner, string ContactPerson, string ContactPhone, string Email, string Address, string Note)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "UPDATE TblPartner SET ContactPerson = @ContactPerson, ContactPhone = @ContactPhone, Email = @Email, Address = @Address, Note = @Note WHERE IDPartner = @IDPartner";
                Cmd.Parameters.Add("IDPartner", SqlDbType.Int).Value = IDPartner;
                Cmd.Parameters.Add("ContactPerson", SqlDbType.NVarChar).Value = ContactPerson;
                Cmd.Parameters.Add("ContactPhone", SqlDbType.NVarChar).Value = ContactPhone;
                Cmd.Parameters.Add("Email", SqlDbType.NVarChar).Value = Email;
                Cmd.Parameters.Add("Address", SqlDbType.NVarChar).Value = Address;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = Note;
                tmpValue = Cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return tmpValue;
        }
        #endregion

        #region method getDataById
        public DataTable getDataById(string IDPartner)
        {
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT *, ISNULL((SELECT UserName FROM TabUser WHERE UserName = TblPartner.CodePartner),N'') AS IsAccountApp FROM TblPartner WHERE IDPartner = @IDPartner";
                Cmd.Parameters.Add("IDPartner", SqlDbType.Int).Value = IDPartner;
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = Cmd;
                da.Fill(ds);
                objTable = ds.Tables[0];
            }
            catch
            {
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return objTable;
        }
        #endregion

        #region method setAccountData
        public string setAccountData(string UserName, string FullName)
        {
            string message = "";
            int tmpValue = 0;
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "INSERT INTO TabUser(UserName,FullName,Pass,Status,[Group],Nhom) VALUES(@UserName,@FullName,@Pass,1,0,2)";
                Cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = UserName;
                Cmd.Parameters.Add("FullName", SqlDbType.NVarChar).Value = FullName;
                Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = this.cryptographyMD5("121212");
                tmpValue = Cmd.ExecuteNonQuery();
                if (tmpValue > 0)
                {
                    message = "OK";
                }
            }
            catch (Exception Ex)
            {
                message = Ex.Message;
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return message;
        }
        #endregion

        #region Method cryptographyMD5
        public string cryptographyMD5(string source)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider objMD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(source);
            byte[] bytHash = objMD5.ComputeHash(buffer);
            string result = "";
            foreach (byte a in bytHash)
            {
                result += int.Parse(a.ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
            }
            return result;
        }
        #endregion

        #region method getAccountData
        public DataTable getAccountData(string SearchKey)
        {
            string SQL_SEARCH = "";
            if (SearchKey.Trim() != "")
            {
                SQL_SEARCH = " AND (UserName LIKE N'%'+@SearchKey+'%' OR FullName LIKE N'%'+@SearchKey+'%')";
            }
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TabUser WHERE UserName <> 'alofun' AND ISNULL(Nhom,0) = 2 " + SQL_SEARCH + " ORDER BY FullName";
                Cmd.Parameters.Add("SearchKey", SqlDbType.NVarChar).Value = SearchKey;
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = Cmd;
                da.Fill(ds);
                objTable = ds.Tables[0];
            }
            catch
            {
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return objTable;
        }
        #endregion

        #region method getAccountDataByUserName
        public DataTable getAccountDataByUserName(string UserName)
        {
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT TOP 1 B.ContactPhone, C.NameRoom FROM TabUser A, TblPartner B, TblRoom C WHERE A.UserName = B.CodePartner AND B.IDPartner = C.IDPartner AND A.UserName = @UserName";
                Cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = UserName;
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = Cmd;
                da.Fill(ds);
                objTable = ds.Tables[0];
            }
            catch
            {
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return objTable;
        }
        #endregion

        #region method changePassword
        public string changePassword(string UserName, string Password)
        {
            string message = "";
            int tmpValue = 0;
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "UPDATE TabUser SET Pass = @Pass WHERE UserName = @UserName";
                Cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = UserName;
                Cmd.Parameters.Add("Pass", SqlDbType.NVarChar).Value = this.cryptographyMD5(Password);
                tmpValue = Cmd.ExecuteNonQuery();
                if (tmpValue > 0)
                {
                    message = "OK";
                }
            }
            catch (Exception Ex)
            {
                message = Ex.Message;
            }
            finally
            {
                SqlCon.Close();
                SqlCon.Dispose();
            }
            return message;
        }
        #endregion

        #region method checkRoomData
        public void checkRoomData()
        {
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT IDRoom, IDPartner, DateBegin, DateEnd FROM dbo.TblRoom WHERE IDPartner NOT IN (SELECT IDPartner FROM TblRoomPartner WHERE IDRoom = TblRoom.IDRoom) AND DateBegin IS NOT NULL AND DateEnd IS NOT NULL";
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    this.addRoomData(int.Parse(Rd["IDRoom"].ToString()), int.Parse(Rd["IDPartner"].ToString()), DateTime.Parse(Rd["DateBegin"].ToString()), DateTime.Parse(Rd["DateEnd"].ToString()));
                }
                Rd.Close();
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

        #region method addRoomData
        public void addRoomData(int IDRoom,int IDPartner,DateTime DateBegin,DateTime DateEnd)
        {
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "INSERT INTO dbo.TblRoomPartner(IDRoom,IDPartner,DateBegin,DateEnd) VALUES(@IDRoom,@IDPartner,@DateBegin,@DateEnd)";
                Cmd.Parameters.Add("IDRoom",SqlDbType.Int).Value = IDRoom;
                Cmd.Parameters.Add("IDPartner", SqlDbType.Int).Value = IDPartner;
                Cmd.Parameters.Add("DateBegin", SqlDbType.DateTime).Value = DateBegin;
                Cmd.Parameters.Add("DateEnd", SqlDbType.DateTime).Value = DateEnd;
                Cmd.ExecuteNonQuery();
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
 