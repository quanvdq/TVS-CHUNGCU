using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using System.Xml;   

namespace TVSSys
{
    public class clsConfigXML
    {       
        #region method Declare ...
        private XmlDocument xmlDoc = new XmlDocument();
        private string sFileName = "TVSConfig.xml";
        #endregion

        #region method UpdateKey
        public void UpdateKey(string strKey, string newValue)
        {
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + sFileName);
            if (!KeyExists(strKey)) CreateKey(strKey);
            XmlNode appSettingsNode =
               xmlDoc.SelectSingleNode("configuration/appSettings");
            // Attempt to locate the requested setting.
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["key"].Value == strKey)
                    childNode.Attributes["value"].Value = newValue;
            }
            xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + sFileName);
        }
        #endregion

        #region method KeyExists
        private bool KeyExists(string strKey)
        {
            xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + sFileName);
            XmlNode appSettingsNode =
              xmlDoc.SelectSingleNode("configuration/appSettings");
            // Attempt to locate the requested setting.
            foreach (XmlNode childNode in appSettingsNode)
            {
                if (childNode.Attributes["key"].Value == strKey)
                    return true;
            }
            return false;
        }
        #endregion        

        #region method GetKey
        public string GetKey(string strKey)
        {
            try
                {
                string sValue = "";

                if (!KeyExists(strKey)) CreateKey(strKey);


                xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + sFileName);
                XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
                // Attempt to locate the requested setting.
                foreach (XmlNode childNode in appSettingsNode)
                {
                    if (childNode.Attributes["key"].Value == strKey)
                    {
                        sValue = childNode.Attributes["value"].Value;
                        break; 
                    }
                }
                return sValue;
            }
            catch
            {
                return "";
            }
        }
        #endregion


        #region method CreateKey
        private void CreateKey(string strKey)
        {
            try
            {
                XmlNode newChild;
                xmlDoc.Load(AppDomain.CurrentDomain.BaseDirectory + sFileName);
                XmlNode appSettingsNode = xmlDoc.SelectSingleNode("configuration/appSettings");
                if (appSettingsNode.FirstChild != null)
                {
                    newChild = appSettingsNode.FirstChild.Clone();
                }
                else
                {
                    newChild = xmlDoc.CreateElement("add");
                    XmlAttribute att1 = xmlDoc.CreateAttribute("key");
                    XmlAttribute att2 = xmlDoc.CreateAttribute("value");
                    newChild.Attributes.Append(att1);
                    newChild.Attributes.Append(att2);
                    appSettingsNode.AppendChild(newChild);
                }
                newChild.Attributes["key"].Value = strKey;
                newChild.Attributes["value"].Value = SetDefaultKey(strKey);
                appSettingsNode.AppendChild(newChild);
                xmlDoc.Save(AppDomain.CurrentDomain.BaseDirectory + sFileName);
            }
            catch { }
        }
        #endregion



        #region method SetDefaultKey
        private string SetDefaultKey(string strKey)
        {
            try
            {
                string sValue = "";
                switch (strKey)
                {
                    case "ReportNotify": { sValue = "0"; break; }
                    case "ReportPayment": { sValue = "0"; break; }

                    case "Autobackup": { sValue = "False"; break; }
                    case "BackupCount": { sValue = "30"; break; }

                    case "WarningRoom": { sValue = "True"; break; }
                    case "WarningRoomStatus": { sValue = "Gần đến hạn"; break; }

                    case "SMSPortName": { sValue = ""; break; }
                    case "SMSBaudRate": { sValue = "115200"; break; }
                    case "SMSParity": { sValue = "N"; break; }
                    case "SMSDataBits": { sValue = "8"; break; }
                    case "SMSStopBits": { sValue = "1"; break; }
                    case "SMSReadTimeOut": { sValue = "600"; break; }
                    case "SMSWriteTimeOut": { sValue = "600"; break; }
                }
                return sValue;
            }
            catch { return ""; }
        }
        #endregion
    }

}
