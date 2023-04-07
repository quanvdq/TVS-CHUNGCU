using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using TVSChungCu.Forms;
using TVSChungCu;
using System.Data.SqlClient;
using TVSChungCu.Reports;

namespace TVSMain
{
    public partial class frmTVSMain : Form
    {
        #region method Decleration
        private static frmTVSMain objFrmMain = new frmTVSMain();
        private static bool sAddForm = false;
        public static string UserName, FulllName;
        #endregion

        #region method frmTVSMain
        public frmTVSMain()
        {
            InitializeComponent();
            objFrmMain = this;
        }
        #endregion

        #region method CloseAllform
        private static void CloseAllform()
        {
            try
            {
                sAddForm = false;
                for (int i = 0; i < objFrmMain.PanMain.Controls.Count; i++)
                {
                    objFrmMain.PanMain.Controls.RemoveAt(i); 
                }
                sAddForm = true; 
            }
            catch { }
        }
        #endregion

        #region method System

        #region method tvsLogin_Click
        private void tvsLogin_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hệ thống sẽ thoát khỏi phiên làm việc hiện tại\r\n\r\nBạn có thực sự muốn đổi phiên làm việc không?", "TVS - Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TVSSys.frmLogin objLogin = new TVSSys.frmLogin();
                objLogin.ShowDialog();
            }
        }
        #endregion

        #region method tvsChangePass_Click
        private void tvsChangePass_Click(object sender, EventArgs e)
        {
            TVSSys.FrmChangePW objOD = new TVSSys.FrmChangePW();
            objOD.StrUsername = TVSSys.GlobalModule.objUserName;
            objOD.ShowDialog();
        }
        #endregion

        #region method tvsAccount_Click
        private void tvsAccount_Click(object sender, EventArgs e)
        {
            TVSSys.frmPerGroup sFrmShow = new TVSSys.frmPerGroup();
            CloseAllform();
            this.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sender.ToString().ToUpper();       
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            this.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method tvsOnwer_Click
        private void tvsOnwer_Click(object sender, EventArgs e)
        {
            TVSSys.FrmRootCompany objRC = new TVSSys.FrmRootCompany();
            objRC.ShowDialog();
        }
        #endregion

        #region method tvsExit_Click
        private void tvsExit_Click(object sender, EventArgs e)
        {
            this.Close();  
        }
        #endregion

        #region method tvsConfig_Click
        private void tvsConfig_Click(object sender, EventArgs e)
        {
            TVSSys.FrmConfig objfrm = new TVSSys.FrmConfig();
            objfrm.ShowDialog();
        }
        #endregion

        #region method tvsConnectData_Click
        private void tvsConnectData_Click(object sender, EventArgs e)
        {
            CloseAllform();
            TVSSys.FrmConnectData objRC = new TVSSys.FrmConnectData();
            objRC.ShowDialog();
        }
        #endregion

        #endregion

        #region method Help

        private void MnuHotlineSupport_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("ymsgr:sendim?tvs_jsc");
            }
            catch { }
        }

        
        private void MnuTeamViewer_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("TVQS3.exe");
            }
            catch { }
        }

        private void MnuIntroduction_Click(object sender, EventArgs e)
        {
            TVSSys.frmIntro objAbout = new TVSSys.frmIntro();
            objAbout.ShowDialog();
        }

        private void MnuHelpFile_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("Huongdan.doc");
            }
            catch { }
        }

        private void tsMnuRegister_Click(object sender, EventArgs e)
        {
            try
            {
                TVSSys.FrmRegister objRes = new TVSSys.FrmRegister();
                objRes.ShowDialog();
            }
            catch
            {
            }
        }
        #endregion

        #region method from
        private void frmTVS_Load(object sender, EventArgs e)
        {
            //SqlConnection SqlCon = new SqlConnection("Server = '103.56.158.106\\SQLEXPRESS'; uid = 'sa'; password = 'khoanv'; database = 'TVS_CHUNGCU'");
            //SqlCon.Open();

            SetPermission();
            FrmMetro sFrmShow = new FrmMetro();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ";
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();

            sslCompany.Text = TVSSys.GlobalModule.objComName.ToUpper();
            clsPublic objP = new clsPublic();
            lblName.Text = TVSSys.GlobalModule.objUserFullName  + "   [" + objP.GetServerDateTime().ToString("dd/MM/yyyy HH:mm:ss") + "]";

            #region Warning

            try
            {
                TVSSys.clsConfigXML objXml = new TVSSys.clsConfigXML();
                if (objXml.GetKey("Autobackup") == "True")
                {
                    TVSSys.frmProgressBarBK frmbar = new TVSSys.frmProgressBarBK();
                    frmbar.ShowDialog();
                }
            }
            catch { }

            try
            {
                if (TVSSys.GlobalModule.objXML.GetKey("WarningRoom") == "True")
                {
                    string sFormName = "PHÒNG - CĂN HỘ";

                    frmDecleration sFrm = new frmDecleration();
                    sFrm.sTabTable = sFormName;
                    sFrm.sTabRoomStatus = TVSSys.GlobalModule.objXML.GetKey("WarningRoomStatus");
                    sFrm.ShowDialog();
                }
            }
            catch { }
            #endregion
        }

        private void frmTVS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi chương trình này không?\r\n\r\nBấm YES để thoát, bấm NO để tiếp tục sủ dụng chương trình", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                CloseAllform();
            else e.Cancel=true; 
        }

        #region Method SetPermission
        private void SetPermission()
        {
            TVSSys.GlobalModule.objPermission =TVSSys.GlobalModule.objCon.GetSysPerUser(TVSSys.GlobalModule.objUserName);
            // Menu He thong
            if (TVSSys.GlobalModule.objPermission.Contains("101")) this.MnuLogin.Enabled = true;
            else this.MnuLogin.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("102")) this.MnuChangePass.Enabled = true;
            else this.MnuChangePass.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("103")) this.MnuAccount.Enabled = true;
            else this.MnuAccount.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("104")) this.MnuOnwer.Enabled = true;
            else this.MnuOnwer.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("105")) this.MnuConfig.Enabled = true;
            else this.MnuConfigDataBase.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("106")) this.MnuConfigDataBase.Enabled = true;
            else this.MnuConfigDataBase.Enabled = false;

            // Menu Khai báo
            if (TVSSys.GlobalModule.objPermission.Contains("201")) this.MnuDecleration0.Enabled = true;
            else this.MnuDecleration0.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("202")) this.MnuDecleration1.Enabled = true;
            else this.MnuDecleration1.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("203")) this.MnuDecleration2.Enabled = true;
            else this.MnuDecleration2.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("204")) this.MnuDecleration3.Enabled = true;
            else this.MnuDecleration3.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("205")) this.MnuDecleration4.Enabled = true;
            else this.MnuDecleration4.Enabled = false;

            // Menu He thong
            if (TVSSys.GlobalModule.objPermission.Contains("301")) this.MnuServiceParking.Enabled = true;
            else this.MnuServiceParking.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("302")) this.MnuServiceWater.Enabled = true;
            else this.MnuServiceWater.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("303")) this.MnuServiceElectric.Enabled = true;
            else this.MnuServiceElectric.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("304")) this.MnuServiceUsed.Enabled = true;
            else this.MnuServiceUsed.Enabled = false;

            // báo cáo
            if (TVSSys.GlobalModule.objPermission.Contains("401")) this.MnuProduct2.Enabled = true;
            else this.MnuProduct2.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("402")) this.MnuProduct3.Enabled = true;
            else this.MnuProduct3.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("403")) this.MnuProduct1.Enabled = true;
            else this.MnuProduct1.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("404")) this.MnuProduct0.Enabled = true;
            else this.MnuProduct0.Enabled = false;
            
            // Quan ly chung
            if (TVSSys.GlobalModule.objPermission.Contains("501")) this.MnuPaymentVoucher0.Enabled = true;
            else this.MnuPaymentVoucher0.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("502")) this.MnuPaymentVoucher1.Enabled = true;
            else this.MnuPaymentVoucher1.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("503")) this.MnuPaymentVoucher2.Enabled = true;
            else this.MnuPaymentVoucher2.Enabled = false;
        }
        #endregion

        #endregion

        #region method MnuDecleration_Click
        private void MnuDecleration_Click(object sender, EventArgs e)
        {
            ButtomDecleration_Click(sender,e);
        }
        #endregion

        #region method MnuDecPartner_Click
        private void MnuDecPartner_Click(object sender, EventArgs e)
        {
            ButtomDecPartner_Click(sender, e);
        }
        #endregion

        #region method MnuService_Click
        private void MnuService_Click(object sender, EventArgs e)
        {
            ButtomService_Click(sender,e);
        }
        #endregion

        #region method MnuPaymentVoucher_Click
        private void MnuPaymentVoucher_Click(object sender, EventArgs e)
        {
            ButtomPaymentVoucher_Click(sender,e);
        }
        #endregion

        #region method MnuPaymentVoucher2_Click
        private void MnuPaymentVoucher2_Click(object sender, EventArgs e)
        {
            ButtomPaymentVoucher2_Click(sender, e);
        }
        #endregion

        #region method MnuProduct_Click
        private void MnuProduct_Click(object sender, EventArgs e)
        {
            ButtomProduct_Click(sender, e);
        }
        #endregion

        #region method PanMain_ControlRemoved
        private void PanMain_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (!sAddForm) return; 
            if (this.PanMain.Controls.Count == 0)
            {
                FrmMetro sFrmShow = new FrmMetro();
                this.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ";
                sFrmShow.TopLevel = false;
                sFrmShow.Dock = DockStyle.Fill;
                this.PanMain.Controls.Add(sFrmShow);
                sFrmShow.Show();
            }
        }
        #endregion

        #region method Buttom
        public static void ButtomDecleration_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":")>0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim(); 

            frmDecleration sFrmShow = new frmDecleration();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.sTabTable = sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }

        public static void ButtomDecPartner_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmPartner sFrmShow = new frmPartner();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }

        public static void ButtomService_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmServiceUsed sFrmShow = new frmServiceUsed();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.sTabTable = sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }

        public static void ButtomPaymentVoucher_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmPaymentVoucher sFrmShow = new frmPaymentVoucher();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.sTabTable = sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }

        public static void ButtomPaymentVoucher2_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmPaymentVoucherList sFrmShow = new frmPaymentVoucherList();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }

        public static void ButtomProduct_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmProduct sFrmShow = new frmProduct();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.sTabTable = sFormName;  
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method MnuProduct4_Click
        private void MnuProduct4_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmProductList sFrmShow = new frmProductList();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method MnuTool0_Click
        private void MnuTool0_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmEmail sFrmShow = new frmEmail();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method MnuTool1_Click
        private void MnuTool1_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmSMS sFrmShow = new frmSMS();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method MnuRoomMap_Click
        private void MnuRoomMap_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmRoomMap sFrmShow = new frmRoomMap();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method MnuReportPartnerBalance_Click
        private void MnuReportPartnerBalance_Click(object sender, EventArgs e)
        {
            CloseAllform();
            frmCustomerDebit sFrmShow = new frmCustomerDebit();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - CÔNG NỢ KHÁCH HÀNG";
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method mnuListProduct_Click
        private void mnuListProduct_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmListProduct sFrmShow = new frmListProduct();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method mnuListProductState_Click
        private void mnuListProductState_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmListProductState sFrmShow = new frmListProductState();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method mnuToolInformation_Click
        private void mnuToolInformation_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmInformation sFrmShow = new frmInformation();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method mnuToolFeedBack_Click
        private void mnuToolFeedBack_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            FeedBack objFeedBack = new FeedBack();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            objFeedBack.FormBorderStyle = FormBorderStyle.None;
            objFeedBack.TopLevel = false;
            objFeedBack.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(objFeedBack);
            objFeedBack.Show();
        }
        #endregion

        #region method mnuAccountCustomer_Click
        private void mnuAccountCustomer_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmAccountCustomer sFrmShow = new frmAccountCustomer();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion

        #region method mnuReportPayOnline_Click
        private void mnuReportPayOnline_Click(object sender, EventArgs e)
        {
            CloseAllform();
            string sFormName = sender.ToString().ToUpper();
            if (sFormName.IndexOf(":") > 0)
                sFormName = sFormName.Substring(sFormName.IndexOf(":") + 1).Trim();

            frmPaymentOnline sFrmShow = new frmPaymentOnline();
            CloseAllform();
            objFrmMain.Text = "PHẦN MỀM QUẢN LÝ CHUNG CƯ - " + sFormName;
            sFrmShow.FormBorderStyle = FormBorderStyle.None;
            sFrmShow.TopLevel = false;
            sFrmShow.Dock = DockStyle.Fill;
            objFrmMain.PanMain.Controls.Add(sFrmShow);
            sFrmShow.Show();
        }
        #endregion
    }
}
