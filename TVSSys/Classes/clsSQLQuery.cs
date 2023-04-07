using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVSSys
{
    public static class clsSQLQuery
    {
        public static void EXEQUERY_UPDATEDATA()
        {
            EXEQUERY_ALTERTABLE("TblRoom", "IDRegion", "int");
            EXEQUERY_ALTERTABLE("TblService", "IDPartner", "int");
            EXEQUERY_CREATETABLE();
            EXEQUERY_INPUTDATA();
        }

        #region Cập nhật lại EXEQUERY_ALTER TABLE
        private static void EXEQUERY_ALTERTABLE(string sTable, string sColumn,string sType)
        {
            string sQuery = "";
            sQuery = "   IF NOT EXISTS (SELECT [column_name] FROM information_schema.columns WHERE [table_name] = '" + sTable + "' and column_name = '" + sColumn + "') " +
                    "   BEGIN   " +
                    "       ALTER TABLE " + sTable + " ADD " + sColumn + " " + sType + "  " +
                    "   END     ";
            TVSSys.GlobalModule.objCon.EXEUpdate(sQuery);
        }

        private static void EXEQUERY_ALTERCOLUMN(string sTable, string sColumn, string sType)
        {
            string sQuery = "";
            sQuery = "   IF NOT EXISTS (SELECT [column_name] FROM information_schema.columns WHERE [table_name] = '" + sTable + "' and column_name = '" + sColumn + "' and Data_type='" + sType + "') " +
                    "   BEGIN   " +
                    "       ALTER TABLE " + sTable + " ALTER COLUMN " + sColumn + " " + sType + "  " +
                    "   END     ";
            TVSSys.GlobalModule.objCon.EXEUpdate(sQuery);
        }

        private static void EXEQUERY_ALTERPRIMARY (string sTable, string sColumn)
        {
            string sQuery = "";
            sQuery = "   IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE  CONSTRAINT_TYPE = 'PRIMARY KEY' AND TABLE_NAME = '" + sTable + "' AND TABLE_SCHEMA ='dbo'" +
                    "   BEGIN   " +
                    "       ALTER TABLE " + sTable + " ADD PRIMARY KEY (" + sColumn + ")  " +
                    "   END     ";
            TVSSys.GlobalModule.objCon.EXEUpdate(sQuery);
        }
        #endregion

        #region Cập nhật lại EXEQUERY_CREATETABLE
        private static void EXEQUERY_CREATETABLE()
        {
            EXEQUERY_CREATETABLE_TblRegion();
            EXEQUERY_CREATETABLE_TabConfig();
            EXEQUERY_CREATETABLE_TblUsedStatus();
        }

        private static void EXEQUERY_CREATETABLE_TblRegion()
        {
            string sQuery = "";
            sQuery = "TVSSymbol      IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TblRegion]') AND type in (N'U'))" +
                    "TVSSymbol      BEGIN" +
                    "TVSSymbol      CREATE TABLE [dbo].[TblRegion](" +
                    "TVSSymbol      	[IDRegion] [int] IDENTITY(1,1) NOT NULL," +
                    "TVSSymbol      	[NameRegion] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                    "TVSSymbol       CONSTRAINT [PK_TblRegion] PRIMARY KEY CLUSTERED " +
                    "TVSSymbol      (" +
                    "TVSSymbol      	[IDRegion] ASC" +
                    "TVSSymbol      )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)" +
                    "TVSSymbol      )" +

                    "TVSSymbol      SET IDENTITY_INSERT [dbo].[TblRegion] ON" +
                    "TVSSymbol          INSERT [dbo].[TblRegion] ([IDRegion],[NameRegion]) VALUES (1,N'Mặc định')" +
                    "TVSSymbol      SET IDENTITY_INSERT [dbo].[TblRegion] OFF" +

                    "TVSSymbol      END";
            TVSSys.GlobalModule.objCon.EXEUpdate(sQuery.Replace("TVSSymbol", "\n"));
        }


        private static void EXEQUERY_CREATETABLE_TabConfig()
        {
            string sQuery = "";
            sQuery = "TVSSymbol      IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TabConfig]') AND type in (N'U'))" +
                    "TVSSymbol      BEGIN" +
                    "TVSSymbol      CREATE TABLE [dbo].[TabConfig](" +
                    "TVSSymbol      	[ConfigID] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL," +
                    "TVSSymbol      	[ConfigName] [nvarchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                    "TVSSymbol      	[ConfigValue] [nvarchar](200) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                    "TVSSymbol       CONSTRAINT [PK_TabConfig] PRIMARY KEY CLUSTERED " +
                    "TVSSymbol      (" +
                    "TVSSymbol      	[ConfigID] ASC" +
                    "TVSSymbol      )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)" +
                    "TVSSymbol      )" +

                    "TVSSymbol          INSERT [dbo].[TabConfig] ([ConfigID],[ConfigName],[ConfigValue]) VALUES (0,N'Thông báo: Tiêu đề trên',N'     Ban Quản trị chúng tôi xin thông báo phí tiền phòng, phí dịch vụ, phí trông xe, phí tiền nước, phí tiền điện của Ông (Bà) trong tháng ')" +
                    "TVSSymbol          INSERT [dbo].[TabConfig] ([ConfigID],[ConfigName],[ConfigValue]) VALUES (1,N'Thông báo: Tiêu đề dưới',N'     Vậy ban Quản trị chúng tôi xin thông báo tới quý khách hàng nạp số tiền trên cho ban Quản trị chung cư chậm nhất ngày 10 tháng ')" +
                    "TVSSymbol      END";
            TVSSys.GlobalModule.objCon.EXEUpdate(sQuery.Replace("TVSSymbol", "\n"));
        }

        private static void EXEQUERY_CREATETABLE_TblUsedStatus()
        {
            string sQuery = "";
            sQuery = "TVSSymbol      IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[TblUsedStatus]') AND type in (N'U'))" +
                    "TVSSymbol      BEGIN" +
                    "TVSSymbol      CREATE TABLE [dbo].[TblUsedStatus](" +
                    "TVSSymbol      	[IDUsedStatus] [int] IDENTITY(1,1) NOT NULL," +
                    "TVSSymbol      	[NameUsedStatus] [nvarchar](100) COLLATE SQL_Latin1_General_CP1_CI_AS NULL," +
                    "TVSSymbol       CONSTRAINT [PK_TblUsedStatus] PRIMARY KEY CLUSTERED " +
                    "TVSSymbol      (" +
                    "TVSSymbol      	[IDUsedStatus] ASC" +
                    "TVSSymbol      )WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)" +
                    "TVSSymbol      )" +

                    "TVSSymbol      SET IDENTITY_INSERT [dbo].[TblUsedStatus] ON" +
                    "TVSSymbol          INSERT [dbo].[TblUsedStatus] ([IDUsedStatus],[NameUsedStatus]) VALUES (1,N'Phòng trống')" +
                    "TVSSymbol          INSERT [dbo].[TblUsedStatus] ([IDUsedStatus],[NameUsedStatus]) VALUES (2,N'Đang thuê')" +
                    "TVSSymbol          INSERT [dbo].[TblUsedStatus] ([IDUsedStatus],[NameUsedStatus]) VALUES (3,N'Gần đến hạn')" +
                    "TVSSymbol          INSERT [dbo].[TblUsedStatus] ([IDUsedStatus],[NameUsedStatus]) VALUES (4,N'Đã quá hạn')" +
                    "TVSSymbol      SET IDENTITY_INSERT [dbo].[TblUsedStatus] OFF" + 
                    "TVSSymbol      END";
            TVSSys.GlobalModule.objCon.EXEUpdate(sQuery.Replace("TVSSymbol", "\n"));
        }
        #endregion



        #region Cập nhật lại EXEQUERY_INPUTDATA
        public static void EXEQUERY_INPUTDATA()
        {
            string sQuery = "";
            #region TabPer
            sQuery = " IF NOT EXISTS (SELECT * FROM TabPerGroup WHERE Id = 9)" +
                    System.Environment.NewLine + " BEGIN" +
                    System.Environment.NewLine + "   INSERT INTO TabPerGroup (Id,Name)" +
                    System.Environment.NewLine + "       Values (9,N'Khu vực quản lý')" +
                    System.Environment.NewLine + " END";
            TVSSys.GlobalModule.objCon.EXEUpdate(sQuery);



            DataTable objData = TVSSys.GlobalModule.objCon.EXESelect("SELECT * FROM TblRegion");
            int sPerID = 0;
            for (int i = 0; i < objData.Rows.Count; i++)
            {
                sPerID = int.Parse(objData.Rows[i]["IDRegion"].ToString());
                sPerID = 900 + sPerID;

                sQuery = " IF NOT EXISTS (SELECT * FROM TabPer WHERE PerID = " + sPerID.ToString() + ")" +
                        System.Environment.NewLine + " BEGIN" +
                        System.Environment.NewLine + "   INSERT INTO TabPer (PerID,PerName,PerDes,PStatus,IDgroup)" +
                        System.Environment.NewLine + "       Values (" + sPerID.ToString() + ",N'" + objData.Rows[i]["NameRegion"].ToString() + "',N'" + objData.Rows[i]["NameRegion"].ToString() + "',1,9)" +
                        System.Environment.NewLine + " END" +
                        System.Environment.NewLine + " ELSE" +
                        System.Environment.NewLine + " BEGIN" +
                        System.Environment.NewLine + "   UPDATE TabPer SET PerName=N'" + objData.Rows[i]["NameRegion"].ToString() + "',PerDes=N'" + objData.Rows[i]["NameRegion"].ToString() + "'" +
                        System.Environment.NewLine + "       WHERE PerID=" + sPerID.ToString() + " " +
                        System.Environment.NewLine + " END";
                TVSSys.GlobalModule.objCon.EXEUpdate(sQuery);
            }
            #endregion
        }
        #endregion
    }
}
