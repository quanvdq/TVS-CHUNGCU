using System;
using System.Collections;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TVSSys
{
    public class Regis
    {
        #region method Declare ...
        private TVSSys.Connection objFunc = new TVSSys.Connection(); 
        private string strConnection = "";
        #endregion

        #region method Regis
        public Regis()
        {
            this.strConnection = this.objFunc.strConnectionString;
        } 
        #endregion
      

        #region method GetSerial
        public string GetSerial()
        {
            clsConfigXML objXML = new clsConfigXML();
            return  objXML.GetKey("License");
        }       
        #endregion

        #region Method CryptographyMD5
        public string CryptographyMD5(string source)
        {
            string result = "";
            try
            {
                System.Security.Cryptography.MD5CryptoServiceProvider objMD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
                byte[] buffer = System.Text.Encoding.UTF8.GetBytes(source);
                byte[] bytHash = objMD5.ComputeHash(buffer);
                foreach (byte a in bytHash)
                {
                    result += int.Parse(a.ToString(), System.Globalization.NumberStyles.HexNumber).ToString();
                }
            }
            catch
            {
            }
            return result;
        }
        #endregion
    }
}
