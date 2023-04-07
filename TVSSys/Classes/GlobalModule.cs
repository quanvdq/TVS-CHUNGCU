using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace TVSSys
{
    public class GlobalModule
    {       
        #region method Declare ...
        public static  System.Drawing.Color objColorEnter = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(235)))), ((int)(((byte)(25)))));
        public static  System.Drawing.Color objColorLeave = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
        public static string sOrderbyPartner = " order by SUBSTRING(ContactPerson, LEN(ContactPerson) - CHARINDEX(' ', REVERSE(ContactPerson)) + 1, LEN(ContactPerson)) ";
        public static string sOrderbyFamily = " order by SUBSTRING(NameFamily, LEN(NameFamily) - CHARINDEX(' ', REVERSE(NameFamily)) + 1, LEN(NameFamily)) ";

        public static TVSSys.Connection objCon = new Connection();
        public static string objConString = TVSSys.Connection.strConnection;
        public static TVSSys.clsConfigXML objXML = new clsConfigXML();

        public static string objPermission="";
        public static string objUserName = "", objUserFullName = "";
        public static string objComName = "", objComManager = "", objComAddress = "", objComPhone = "", objComEmail = "", objComWebsite = "", objComTax = "";

        public static string objConfigID0 = "", objConfigID1 = "";
        #endregion

        #region method GlobalModule
        public GlobalModule()
        {
            try
            {
                DataTable objdt = objCon.EXESelect("SELECT * FROM TabCompany WHERE ComID='COM01'");
                if (objdt.Rows.Count > 0)
                {
                    objComName = objdt.Rows[0]["ComName"].ToString();
                    objComManager = objdt.Rows[0]["ComManager"].ToString();
                    objComAddress = objdt.Rows[0]["ComAddress"].ToString();
                    objComPhone = objdt.Rows[0]["ComPhone"].ToString();
                    objComEmail = objdt.Rows[0]["ComEmail"].ToString();
                    objComWebsite = objdt.Rows[0]["ComWebsite"].ToString();

                    objComTax = objdt.Rows[0]["ComTax"].ToString();
                }

                objdt = objCon.EXESelect("SELECT * FROM TabConfig Order by ConfigID");
                if (objdt.Rows.Count > 0)
                {
                    objConfigID0 = objdt.Rows[0]["ConfigValue"].ToString();
                    objConfigID1 = objdt.Rows[1]["ConfigValue"].ToString();
                }
            }
            catch { }
        } 
        #endregion
    }
}
