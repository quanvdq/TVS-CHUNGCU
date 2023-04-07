using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using C1.Win.C1TrueDBGrid;

namespace TVSSys
{
    public partial class FrmConfig : Form
    {
        #region method Declare ...
        private TVSSys.clsConfigXML objCfig = new TVSSys.clsConfigXML();
        private TVSSys.Connection objCon = new TVSSys.Connection();
        private DataTable objData;
        #endregion

        #region Method FrmConfig
        public FrmConfig()
        {
            InitializeComponent();          
        }
        #endregion

        #region Method GetConfig
        private void GetConfig()
        {
            try
            {
                bool schkAutoBackUp = false;
                try
                {
                    schkAutoBackUp = bool.Parse(objCfig.GetKey("Autobackup"));
                }
                catch { }
                this.chkAutobackup.Checked = schkAutoBackUp;
                int sBackupCount = 0;
                try
                {
                    sBackupCount = int.Parse(objCfig.GetKey("BackupCount"));
                }
                catch { }
                this.txtCount.Text = sBackupCount.ToString();


                try
                {
                    this.chkWarningRoom.Checked = bool.Parse(objCfig.GetKey("WarningRoom"));
                }
                catch { }
                try
                {
                    this.TxtWarningRoomStatus.Text = objCfig.GetKey("WarningRoomStatus");
                }
                catch { }



                try
                {
                    cbbReportNotify.SelectedIndex = int.Parse(objCfig.GetKey("ReportNotify"));
                }
                catch { cbbReportNotify.SelectedIndex = 0; }
                try
                {
                    cbbReportPayment.SelectedIndex = int.Parse(objCfig.GetKey("ReportPayment"));
                }
                catch { cbbReportPayment.SelectedIndex = 0; }
            }
            catch { }          
        }
        #endregion

        #region Method ConfigMainInfo
        private void GetConfigMainInfo()
        {
            try
            {
                objData = objCon.EXESelect("Select ConfigID,ConfigName,ConfigValue from TabConfig Order by ConfigID");
                c1TrueDBGrid1.DataSource = objData;
                c1TrueDBGrid1.Splits[0].DisplayColumns["ConfigID"].Visible = false;  
                c1TrueDBGrid1.Columns["ConfigName"].Caption = "Thông tin";
                c1TrueDBGrid1.Splits[0].DisplayColumns["ConfigName"].Width = 170;
                c1TrueDBGrid1.Splits[0].DisplayColumns["ConfigName"].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                c1TrueDBGrid1.Splits[0].DisplayColumns["ConfigName"].Locked = true;
  
                c1TrueDBGrid1.Columns["ConfigValue"].Caption = "Nội dung";
                c1TrueDBGrid1.Splits[0].DisplayColumns["ConfigValue"].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
            }
            catch { }
        }

        private void SetConfigMainInfo()
        {
            SqlConnection Con = new SqlConnection(objCon.strConnectionString);
            Con.Open();
            try
            {
                if (objData.GetChanges() == null) return;
                SqlCommand cmd = new SqlCommand("Select ConfigID,ConfigName,ConfigValue from TabConfig Order by ConfigID", Con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Update(objData.GetChanges());
                objData.AcceptChanges();

                TVSSys.GlobalModule objGlb = new TVSSys.GlobalModule(); 
                MessageBox.Show("Thông số mới đã được ghi nhận trên hệ thống!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật dữ liệu!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Con.Close(); }
        }
        #endregion

        #region Method FrmCongif_Load
        private void FrmCongif_Load(object sender, EventArgs e)
        {
            GetConfig();
            GetConfigMainInfo();
        }
        #endregion

        #region method FrmCongif_KeyDown
        private void FrmCongif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        } 
        #endregion

        #region method txtEnter
        private void txtEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tmp = (System.Windows.Forms.TextBox)sender;
            tmp.BackColor = GlobalModule.objColorEnter;
        }
        #endregion

        #region method txtLeave
        private void txtLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tmp = (System.Windows.Forms.TextBox)sender;
            tmp.BackColor = GlobalModule.objColorLeave;
        }
        #endregion


        #region method Cauhinhchung
        private void SetPrivate()
        {
            try
            {
                objCfig.UpdateKey("ReportNotify", cbbReportNotify.SelectedIndex.ToString());
                objCfig.UpdateKey("ReportPayment", cbbReportPayment.SelectedIndex.ToString());

                objCfig.UpdateKey("Autobackup", chkAutobackup.Checked.ToString());
                objCfig.UpdateKey("BackupCount", txtCount.Text);
                
                objCfig.UpdateKey("WarningRoom", chkWarningRoom.Checked.ToString());
                objCfig.UpdateKey("WarningRoomStatus", TxtWarningRoomStatus.Text);

                MessageBox.Show("Thông số mới đã được ghi nhận trên hệ thống!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật dữ liệu!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnAllExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region method btnAllUpdate
        private void btnAllUpdate_Click(object sender, EventArgs e)
        {
            switch (tabCodeID.SelectedIndex)
            {
                case 0:
                    {
                        SetPrivate();
                        break;
                    }
                case 1:
                    {
                        SetConfigMainInfo();
                        break;
                    }
            }
        }
        #endregion

    }
}