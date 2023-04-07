using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSChungCu.Class
{
    class FeedBackClass
    {
        public DataTable getData(string SearchKey)
        {
            string SQL_SEARCH = "";
            if (SearchKey.Trim() != "")
            {
                SQL_SEARCH = " AND tblFeedBack.Subject LIKE N'%'+@SearchKey+'%'";
            }
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT tblFeedBack.*, TabUser.FullName FROM tblFeedBack, TabUser WHERE tblFeedBack.UserName = TabUser.UserName " + SQL_SEARCH + " ORDER BY tblFeedBack.DayCreate DESC";
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
                Cmd.CommandText = "SELECT * FROM tblFeedBack WHERE Id = @Id";
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

        public int setData(int Id, string FeedBackContent)
        {
            string SQL = "";
            SQL = "UPDATE tblFeedBack SET FeedBackUserName = @FeedBackUserName, FeedBackContent = @FeedBackContent, FeedBackDay = getdate() WHERE Id = @ID";
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = SQL;
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = Id;
                Cmd.Parameters.Add("FeedBackUserName", SqlDbType.NVarChar).Value = TVSSys.frmLogin._UserName;
                Cmd.Parameters.Add("FeedBackContent", SqlDbType.NVarChar).Value = FeedBackContent;
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
