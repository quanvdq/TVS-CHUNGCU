using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVSMain
{
    public partial class FrmMetro : Form
    {
        public FrmMetro()
        {
            InitializeComponent();
        }

        private void FrmMetro_Load(object sender, EventArgs e)
        {
            this.LblCompanyManager.Text = TVSSys.GlobalModule.objComManager.ToUpper();
            this.LblCompanyName.Text = TVSSys.GlobalModule.objComName.ToUpper();
            try
            {
                this.PicCompany.BackgroundImage = Image.FromFile("TVSbg.jpg");
            }
            catch
            {
                this.PicCompany.BackgroundImage = global::TVSChungCu.Properties.Resources.TVSbg;
            }

            SetPermission();
        }

        #region Method SetPermission
        private void SetPermission()
        {
            
            // Menu Khai báo
            if (TVSSys.GlobalModule.objPermission.Contains("202")) this.ButDecleration1.Enabled = true;
            else this.ButDecleration1.Enabled = false;

            // Menu He thong
            if (TVSSys.GlobalModule.objPermission.Contains("301")) this.ButServiceParking.Enabled = true;
            else this.ButServiceParking.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("302")) this.ButServiceWater.Enabled = true;
            else this.ButServiceWater.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("303")) this.ButServiceElectric.Enabled = true;
            else this.ButServiceElectric.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("304")) this.ButServiceUsed.Enabled = true;
            else this.ButServiceUsed.Enabled = false;

            // báo cáo
            if (TVSSys.GlobalModule.objPermission.Contains("401")) this.ButProduct2.Enabled = true;
            else this.ButProduct2.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("402")) this.ButProduct3.Enabled = true;
            else this.ButProduct3.Enabled = false;

            // Quan ly chung
            if (TVSSys.GlobalModule.objPermission.Contains("501")) this.ButPaymentVoucher0.Enabled = true;
            else this.ButPaymentVoucher0.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("502")) this.ButPaymentVoucher1.Enabled = true;
            else this.ButPaymentVoucher1.Enabled = false;
            if (TVSSys.GlobalModule.objPermission.Contains("503")) this.ButPaymentVoucher2.Enabled = true;
            else this.ButPaymentVoucher2.Enabled = false;
        }
        #endregion

        private void ButDecleration1_Click(object sender, EventArgs e)
        {
            frmTVSMain.ButtomDecleration_Click(sender,e);
        }

        private void ButService_Click(object sender, EventArgs e)
        {
            frmTVSMain.ButtomService_Click(sender, e);
        }

        private void ButPaymentVoucher_Click(object sender, EventArgs e)
        {
            frmTVSMain.ButtomPaymentVoucher_Click(sender, e);
        }

        private void ButPaymentVoucher2_Click(object sender, EventArgs e)
        {
            frmTVSMain.ButtomPaymentVoucher2_Click(sender, e);
        }

        private void ButProduct_Click(object sender, EventArgs e)
        {
            frmTVSMain.ButtomProduct_Click(sender, e);
        }
    }
}