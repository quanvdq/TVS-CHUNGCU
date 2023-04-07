using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace TVSChungCu.Class
{
    class Product
    {
        public DataTable getData(string SearchKey)
        {
            string SQL_SEARCH = "";
            if (SearchKey.Trim() != "")
            {
                SQL_SEARCH = " AND NameProduct LIKE N'%" + @SearchKey + "%'";
            }
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TblProduct WHERE 1 = 1 " + SQL_SEARCH + " ORDER BY NameProduct";
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

        public DataTable getDataRelease(int IDRegion, string SearchKey)
        {
            string SQL_Region = "", SQL_QUERY = "";
            if (IDRegion > 0)
            {
                SQL_Region = " AND IDRegion = @IDRegion ";
            }
            if (SearchKey.Trim() != "")
            {
                SQL_QUERY = " AND (NameProduct LIKE N'%'+@SearchKey+'%' OR PossitionName LIKE N'%'+@SearchKey+'%') ";
            }
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TblProductRelease WHERE 1 = 1 " + SQL_Region + SQL_QUERY + " ORDER BY NameRegion";
                Cmd.Parameters.Add("IDRegion", SqlDbType.Int).Value = IDRegion;
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

        public DataTable getDataReleaseState(DateTime objDate1, DateTime objDate2, int IDRegion, string SearchKey)
        {            
            string SQL_Region = "", SQL_QUERY = "";
            if (IDRegion > 0)
            {
                SQL_Region = " AND IDRegion = @IDRegion ";
            }
            if (SearchKey.Trim() != "")
            {
                SQL_QUERY = " AND (NameProduct LIKE N'%'+@SearchKey+'%' OR PossitionName LIKE N'%'+@SearchKey+'%') ";
            }
            
            DataTable objTable = new DataTable();



            DataColumn objC1 = new DataColumn("PossitionName", typeof(string));
            DataColumn objC2 = new DataColumn("NameProduct", typeof(string));
            DataColumn objC3 = new DataColumn("TypeName", typeof(string));
            DataColumn objC4 = new DataColumn("Note", typeof(string));
            DataColumn objC5 = new DataColumn("DayCreate", typeof(string));

            objTable.Columns.Add(objC1);
            objTable.Columns.Add(objC2);
            objTable.Columns.Add(objC3);
            objTable.Columns.Add(objC4);
            objTable.Columns.Add(objC5);

            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            SqlConnection SqlCon1 = new SqlConnection(TVSSys.Connection.strConnection);

            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TblProductRelease WHERE 1 = 1 " + SQL_Region + SQL_QUERY + " ORDER BY NameRegion";
                Cmd.Parameters.Add("IDRegion", SqlDbType.Int).Value = IDRegion;
                Cmd.Parameters.Add("SearchKey", SqlDbType.NVarChar).Value = SearchKey;
                SqlDataReader Rd = Cmd.ExecuteReader();
                while (Rd.Read())
                {
                    objTable.Rows.Add(Rd["PossitionName"],Rd["NameProduct"].ToString(),"","","");

                    #region Chi tiết
                    SqlCon1.Open();
                    SqlCommand Cmd1 = SqlCon1.CreateCommand();
                    Cmd1.CommandText = "SELECT * FROM TblProductState WHERE ProductReleaseId = @ProductReleaseId AND DayCreate BETWEEN @objDate1 AND @objDate2 ORDER BY DayCreate DESC";
                    Cmd1.Parameters.Add("ProductReleaseId", SqlDbType.Int).Value = Rd["Id"].ToString();
                    Cmd1.Parameters.Add("objDate1", SqlDbType.DateTime).Value = new DateTime(objDate1.Year, objDate1.Month, objDate1.Day, 0, 0, 0);
                    Cmd1.Parameters.Add("objDate2", SqlDbType.DateTime).Value = new DateTime(objDate2.Year, objDate2.Month, objDate2.Day, 23, 59, 59);
                    SqlDataReader Rd1 = Cmd1.ExecuteReader();
                    while (Rd1.Read())
                    {
                        objTable.Rows.Add("","", Rd1["TypeName"].ToString(), Rd1["Note"].ToString(), DateTime.Parse(Rd1["DayCreate"].ToString()).ToString("dd/MM/yyyy"));
                    }
                    Rd1.Close();
                    SqlCon1.Close();
                    #endregion

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
            return objTable;
        }

        public DataTable getRegionData(string Description)
        {
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT IDRegion, NameRegion FROM TblRegion ORDER BY NameRegion";
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da.SelectCommand = Cmd;
                da.Fill(ds);
                objTable = ds.Tables[0];
                if (Description.Trim() != "")
                {
                    DataRow objRow = objTable.NewRow();
                    objRow[0] = 0;
                    objRow[1] = "Khu vực";
                    objTable.Rows.InsertAt(objRow, 0);
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
            return objTable;
        }

        public int setReleaseData(int ProductId, string NameProduct, int IDRegion, string NameRegion, string PossitionName)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "INSERT INTO TblProductRelease(ProductId,NameProduct,IDRegion,NameRegion,PossitionName) VALUES(@ProductId,@NameProduct,@IDRegion,@NameRegion,@PossitionName)";
                Cmd.Parameters.Add("ProductId", SqlDbType.Int).Value = ProductId;
                Cmd.Parameters.Add("NameProduct", SqlDbType.NVarChar).Value = NameProduct;
                Cmd.Parameters.Add("IDRegion", SqlDbType.Int).Value = IDRegion;
                Cmd.Parameters.Add("NameRegion", SqlDbType.NVarChar).Value = NameRegion;
                Cmd.Parameters.Add("PossitionName", SqlDbType.NVarChar).Value = PossitionName;
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

        public int delReleaseData(int Id)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "DELETE TblProductRelease WHERE Id = @Id";
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = Id;
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

        public int editReleaseData(int Id, string PossitionName)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "UPDATE TblProductRelease SET PossitionName = @PossitionName WHERE Id = @Id";
                Cmd.Parameters.Add("Id", SqlDbType.Int).Value = Id;
                Cmd.Parameters.Add("PossitionName", SqlDbType.NVarChar).Value = PossitionName;
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

        public int setProductStateData(int ProductReleaseId, int TypeId, string TypeName, string Note, DateTime DayCreate)
        {
            int tmpValue = 0;
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "INSERT INTO TblProductState(ProductReleaseId,TypeId,TypeName,Note,DayCreate) VALUES(@ProductReleaseId,@TypeId,@TypeName,@Note,@DayCreate)";
                Cmd.Parameters.Add("ProductReleaseId", SqlDbType.Int).Value = ProductReleaseId;
                Cmd.Parameters.Add("TypeId", SqlDbType.Int).Value = TypeId;
                Cmd.Parameters.Add("TypeName", SqlDbType.NVarChar).Value = TypeName;
                Cmd.Parameters.Add("Note", SqlDbType.NVarChar).Value = Note;
                Cmd.Parameters.Add("DayCreate", SqlDbType.DateTime).Value = DayCreate; 
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

        public DataTable getProductStateData(DateTime objDate1, DateTime objDate2, int ProductReleaseId)
        {
            DataTable objTable = new DataTable();
            SqlConnection SqlCon = new SqlConnection(TVSSys.Connection.strConnection);
            try
            {
                SqlCon.Open();
                SqlCommand Cmd = SqlCon.CreateCommand();
                Cmd.CommandText = "SELECT * FROM TblProductState WHERE DayCreate BETWEEN @objDate1 AND @objDate2 AND ProductReleaseId = @ProductReleaseId ORDER BY DayCreate DESC";
                Cmd.Parameters.Add("ProductReleaseId", SqlDbType.Int).Value = ProductReleaseId;
                Cmd.Parameters.Add("objDate1", SqlDbType.DateTime).Value = new DateTime(objDate1.Year, objDate1.Month, objDate1.Day,0,0,0);
                Cmd.Parameters.Add("objDate2", SqlDbType.DateTime).Value = new DateTime(objDate2.Year, objDate2.Month, objDate2.Day, 23, 59, 59);
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
    }
}
