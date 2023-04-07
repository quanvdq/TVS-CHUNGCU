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
    public class Version
    {

        #region Method GetVersion
        public static string GetVersion(string sSoftWare)
        {
            string sResult = "14:30'  09/06/2014";
            try
            {
                string sPath = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\";
                DateTime sDateWrite = System.IO.File.GetLastWriteTime(sPath + sSoftWare + ".exe");
                sResult = sDateWrite.ToString("HH:mm") + "'  " + sDateWrite.ToString("dd/MM/yyyy");
            }
            catch { }
            sResult = "Phiên bản cập nhật : " + sResult; 
            return sResult;
        }
        #endregion   

    }
}
 