using System;
using System.Net;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TVSMain
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        // </summary>
        [STAThread]
        static void Main()
        {
            TVSSys.dataBase objdb = new TVSSys.dataBase();       
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string instanceName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            Process[] processes = Process.GetProcessesByName(instanceName);
            if (processes.Length > 1)
            {
                MessageBox.Show("Chương trình đang được sử dụng", "Thông báo - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //if (!objdb.CheckConnect())
            //{
            //    TVSSys.FrmConnectData frmCon = new TVSSys.FrmConnectData();
            //    frmCon.ShowDialog();
            //}
            //if (!objdb.CheckDatabase())
            //{
            //    TVSSys.FrmConnectData frmCon = new TVSSys.FrmConnectData();
            //    frmCon.ShowDialog();
            //}
            //if (objdb.CheckDatabase())

            if (1==1)
            {

                #region InsertInfo
                TVS_LICENSE.TVSEDU objRes = new TVS_LICENSE.TVSEDU();

                string CDKey = "", strRegister = "", strRegister0 = "", strRegister1 = "", strRegister2 = "", strRegister3 = "";

                strRegister0 = objRes.InsertInfo("Win32_Processor").Trim();
                if (strRegister0 != "") CDKey += ",'" + objRes.GetCDKey(strRegister0).ToUpper() + "'";

                strRegister1 = objRes.Insert("Win32_Processor").Trim();
                if (strRegister1 != "") CDKey += ",'" + objRes.GetCDKey(strRegister1).ToUpper() + "'";

                strRegister2 = objRes.InsertInfoUSB("Win32_Processor").Trim();
                if (strRegister2 != "") CDKey += ",'" + objRes.GetCDKey(strRegister2).ToUpper() + "'";

                strRegister3 = objRes.InsertInfoIDE("Win32_Processor").Trim();
                if (strRegister3 != "") CDKey += ",'" + objRes.GetCDKey(strRegister3).ToUpper() + "'";

                //MessageBox.Show(strRegister0 + "(InsertInfo)" + strRegister1 + "(Insert)" + strRegister2 + "(InsertInfoUSB)" + strRegister3 + "(InsertInfoIDE)");

                if (strRegister0.Length > 5)
                    strRegister = strRegister0;
                else if (strRegister1.Length > 5)
                    strRegister = strRegister1;
                else if (strRegister2.Length > 5)
                    strRegister = strRegister2;
                else if (strRegister3.Length > 5)
                    strRegister = strRegister3;
                else
                {
                    strRegister = "50026B7380377D49";
                    CDKey += ",'" + objRes.GetCDKey(strRegister).ToUpper() + "'";
                }

                if (CDKey != "") CDKey = CDKey.Substring(1);
                #endregion

                string sInsertInfoTemp = "50026B7380377D49";
                string strRegisterTemp = objRes.GetCDKey(sInsertInfoTemp);

                bool sTabRegister = false;
                clsPublic clsPub = new clsPublic();
                int totalItem = clsPub.Get_TotalItem();
                TVSSys.Regis objR = new TVSSys.Regis();
                string strSerial = objR.GetSerial().ToUpper().Trim();
                if (strSerial == "") strSerial = "TVSGROUP";

                if (totalItem < 100) sTabRegister = true;
                if (CDKey.Contains(strSerial)) sTabRegister = true;

                string sDate = DateTime.Now.ToString("yyyyMMdd");
                if (double.Parse(sDate) < 20221113) sTabRegister = true;

                if (sTabRegister)
                {
                    TVSSys.frmLogin objLogin = new TVSSys.frmLogin();
                    objLogin.ShowDialog();
                    if (objLogin.OK)
                    {
                        TVSSys.frmUpdateData frmUD = new TVSSys.frmUpdateData();
                        frmUD.ShowDialog();  
                        
                        TVSSys.GlobalModule objGlb = new TVSSys.GlobalModule();
                        Room objRoom = new Room();  

                        frmTVSMain objfrm = new frmTVSMain();
                        objfrm.ShowDialog();
                    }
                }
                else
                {
                    try
                    {
                        TVSSys.FrmRegister objResDx = new TVSSys.FrmRegister();
                        objResDx.ShowDialog();
                    }
                    catch
                    {
                    }
                }  
            } 
        }
    }
}