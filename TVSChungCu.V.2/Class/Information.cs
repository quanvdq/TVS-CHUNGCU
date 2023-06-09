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
    class Information
    {
        public int setData(int Id, string Title, string NewsContent, string UserName, int State)
        {
            string SQL = "";
            SQL = "IF NOT EXISTS (SELECT * FROM TblInformation WHERE Id = @ID) ";
            SQL += "BEGIN INSERT INTO TblInformation(Title,NewsContent,UserName,State) VALUES(@Title,@NewsContent,@UserName,@State) END ";
            SQL += "ELSE ";
            SQL += "BEGIN UPDATE TblInformation SET Title = @Title, NewsContent = @NewsContent, UserName = @UserName, State = @State WHERE Id = @ID END";
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = SQL;
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = Id;
                Cmd.Parameters.Add("Title", SqlDbType.NVarChar).Value = Title;
                Cmd.Parameters.Add("NewsContent", SqlDbType.NVarChar).Value = NewsContent;
                Cmd.Parameters.Add("UserName", SqlDbType.NVarChar).Value = UserName;
                Cmd.Parameters.Add("State", SqlDbType.Int).Value = State;
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

        public DataTable getData(string SearchKey)
        {
            string SQL_SEARCH = "";
            if (SearchKey.Trim() != "")
            {
                SQL_SEARCH = " AND Title LIKE N'%'+@SearchKey+'%'";
            }
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT *, REPLACE(REPLACE(REPLACE(State,0,N'Đang soạn thảo'),1,N'Đã hoàn thành'),2,N'Đã công bố') AS StateName FROM TblInformation WHERE 1 = 1 " + SQL_SEARCH + " ORDER BY DayCreate DESC";
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

        public DataTable getDataById(string Id)
        {
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TblInformation WHERE Id = @Id";
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = Id;
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

        public DataTable getPartnerData(int InformationId)
        {
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT A.*, B.FullName FROM tblInformationPartner A, TabUser B WHERE A.CodePartner = B.UserName AND A.InformationId = @InformationId ORDER BY B.FullName";
                Cmd.Parameters.Add("InformationId", SqlDbType.Int).Value = InformationId;
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

        public int sendInformation(int Id)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT UserName, FullName FROM TabUser A, TblPartner B WHERE A.UserName = B.CodePartner AND A.Status = 1 ORDER BY B.ContactPerson";
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    tmpValue += this.sendInformation(Id, Rd["UserName"].ToString());
                }
                Rd.Close();
                if (tmpValue > 0)
                {
                    this.LockInformation(Id);
                }
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

        public int sendInformation(int InformationId, string CodePartner)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                string SQL = "";
                SQL = "IF NOT EXISTS (SELECT * FROM tblInformationPartner WHERE InformationId = @InformationId AND CodePartner = @CodePartner) ";
                SQL += "BEGIN INSERT INTO tblInformationPartner(InformationId,CodePartner,SendUserName) VALUES(@InformationId,@CodePartner,@SendUserName) END ";
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = SQL;
                Cmd.Parameters.Add("InformationId", SqlDbType.Int).Value = InformationId;
                Cmd.Parameters.Add("CodePartner", SqlDbType.NVarChar).Value = CodePartner;
                Cmd.Parameters.Add("SendUserName", SqlDbType.NVarChar).Value = TVSSys.frmLogin._UserName;
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

        public int LockInformation(int InformationId)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                string SQL = "";
                SQL = "UPDATE tblInformation SET State = 2, DayRelease = getdate() WHERE Id = @Id";
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = SQL;
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = InformationId;
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
    }
}
