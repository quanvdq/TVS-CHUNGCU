using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;

using System.IO.Ports;

namespace TVSMain
{
    public partial class frmSMS : Form
    {
        #region method Declare ...
        SerialPort port = new SerialPort();
        TVSSMS.clsSMS objclsSMS = new TVSSMS.clsSMS();
        string sPortName = "";
        int sBaudRate = 9600, sDataBits = 1, sReadTimeOut = 300, sWriteTimeOut = 300;
        string sSMSContent = "";


        private DataTable objdata = new DataTable();
        private clsGridView clsG = new clsGridView();
        private string sSQLQuery = "";
        #endregion

        public frmSMS()
        {
            InitializeComponent();
            TVSUtil.Reports.Export.ContextMenu(this.c1TrueDBGrid1);
        }

        #region Mothod FromCode

        private void c1TrueDBGrid1_Error(object sender, C1.Win.C1TrueDBGrid.ErrorEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Lỗi kiểu dữ liệu", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frm_Load(object sender, EventArgs e)
        {
            this.LoadList();

            GetConfigModem(); 

            this.TxtContent1.Text = TVSSys.GlobalModule.objXML.GetKey("SMSContent1");
            this.TxtContent2.Text = TVSSys.GlobalModule.objXML.GetKey("SMSContent2");
        }

        #region LoadList
        BindingSource bindsrc = new BindingSource();
        private void LoadList()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                sSQLQuery = "Select '' as Image,cast(0 as bit) as Status,* " +
                            ", " + Partner.sQueryBalance + "  as Balance " + 
                            " from TblPartner " + TVSSys.GlobalModule.sOrderbyPartner;

                objdata = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);
                BindingSource bindsrc = new BindingSource();
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;
                this.c1TrueDBGrid1.AllowUpdate = true;
                for (int i = 0; i < c1TrueDBGrid1.Columns.Count; i++)
                {
                    c1TrueDBGrid1.Splits[0].DisplayColumns[i].Locked = true;
                }
                c1TrueDBGrid1.Columns["Status"].Caption = "Chọn";
                c1TrueDBGrid1.Splits[0].DisplayColumns["Status"].Width = 60;
                c1TrueDBGrid1.Splits[0].DisplayColumns["Status"].Locked = false;
                c1TrueDBGrid1.Splits[0].DisplayColumns["Image"].Visible = false;

                c1TrueDBGrid1.Columns["Balance"].Caption = "Công nợ";
                c1TrueDBGrid1.Columns["Balance"].NumberFormat = "#,##0";

                clsG.DeclerationPartner(c1TrueDBGrid1);
                TVSUtil.GridView.Interface.ContextMenu(this.c1TrueDBGrid1,  "TblPartnerEmail");
                  
                
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        } 
        #endregion

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
        }

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        {
                            this.Close();
                            break;
                        }
                    
                    case Keys.F6:
                        {
                            //this.ToolStripTop.Focus();
                            //this.ButSave.PerformClick();
                            break;
                        }
                }
            }
            catch { }

        }

        private void c1TrueDBGrid1_FilterChange(object sender, EventArgs e)
        {
            try
            {
                string sWhere = "";
                foreach (C1.Win.C1TrueDBGrid.C1DataColumn dc in this.c1TrueDBGrid1.Columns)
                {
                    if (dc.FilterText.Length > 0)
                    {
                        if (sWhere != "") sWhere += " AND ";
                        if (dc.DataType.ToString() != "System.String") sWhere += dc.DataField + "=" + dc.FilterText;
                        else sWhere += dc.DataField + " LIKE '%" + dc.FilterText + "%'";
                    }
                }
                this.objdata.DefaultView.RowFilter = sWhere;
            }
            catch { return; }
        }

        private void BtnUpdateInfo_Click(object sender, EventArgs e)
        {
            SetConfigModem();            
        }

        private void ButSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (c1TrueDBGrid1.RowCount == 0) return;

                this.Cursor = Cursors.WaitCursor;
                
                bool sSendSuccess = false;
                string sHeaderPhoneNo = "";
                string sPhoneNo = "";
                string sBalance = "";

                DataTable dt = TVSSys.GlobalModule.objCon.EXESelect("Select NameSMSPhoneNo from TblSMSPhoneNo");
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        sHeaderPhoneNo += dt.Rows[i][0].ToString().Trim() + ",";
                    }
                    if (sHeaderPhoneNo != "") sHeaderPhoneNo = sHeaderPhoneNo.Remove(sHeaderPhoneNo.Length - 1);
                }

                if (c1TrueDBGrid1.RowCount > 0)
                {
                    for (int i = 0; i < c1TrueDBGrid1.RowCount; i++)
                    {
                        sBalance = "";
                        if (this.chkBalance.Checked)
                        {
                            try
                            {
                                sBalance = double.Parse(c1TrueDBGrid1.Columns["Balance"].CellValue(i).ToString()).ToString("#,##0") + ". ";
                            }
                            catch { }
                        }
                        sSMSContent = this.TxtContent1.Text + " " + sBalance + this.TxtContent2.Text;

                        sPhoneNo = c1TrueDBGrid1.Columns["ContactPhone"].CellText(i).ToString().Trim();
                        sPhoneNo = sPhoneNo.Replace("  ", "").Replace(" ", "").Replace(".", "").Replace(";", "/").Replace("*", "/");

                        sSendSuccess = SendMsgSMS(sHeaderPhoneNo, sPhoneNo, sSMSContent, c1TrueDBGrid1.Columns["IDPartner"].CellText(i).ToString());
                    }
                }
                if (sSendSuccess)
                    this.LblMess.Text="Tin nhắn đã được gửi.";
                else
                    this.LblMess.Text="Lỗi, tin nhắn chưa được gửi.";
            }
            catch (Exception ex)
            {
                //ErrorLog(ex.Message);
            }
            finally 
            {
                this.Cursor = Cursors.Default;
            }
        }

        #region SendMsgSMS
        private bool SendMsgSMS(string sPhoneNoSend, string sContent, string sIDPartner)
        {
            bool sSendSuccess = false;
            string sSQL = "";
            try
            {
                if (objclsSMS.sendMsg(this.port, sPhoneNoSend, sContent))
                {
                    //sSQL = "  Insert into TabSMSSend (PhoneNo,IDPartner,Contents) values (" + sPhoneNoSend + "," + sIDPartner + ",N'" + sContent + "')";
                    //objCon.EXEUpdate(sSQL);
                    sSendSuccess = true;
                }
                else
                {
                    objclsSMS.ClosePort(this.port);
                    Set_OpenPort();
                    objclsSMS.sendMsg(this.port, sPhoneNoSend, sContent);
                }
                return sSendSuccess;
            }
            catch { return false; }
        }

        private bool SendMsgSMS(string sHeaderPhoneNo, string sPhoneNo, string sContent, string sIDPartner)
        {
            bool sSendSuccess = false;
            if (sPhoneNo == "") return true;
            string sPhoneNoSend = sPhoneNo;
            int i = sPhoneNoSend.IndexOf("/");
            if (i > 0)
            {
                sPhoneNoSend = sPhoneNo.Substring(0, i);
            }
            if (sPhoneNoSend.Length > 8)
            {
                if (sHeaderPhoneNo.Contains(sPhoneNoSend.Substring(0, 3)))
                {
                    sPhoneNoSend = "+84" + sPhoneNoSend.Substring(1);
                    sSendSuccess = SendMsgSMS(sPhoneNoSend, sContent, sIDPartner);
                }
            }

            if (i > 0)
            {
                if (sPhoneNo.Substring(i + 1).Length > 8)
                    sSendSuccess = SendMsgSMS(sHeaderPhoneNo, sPhoneNo.Substring(i + 1), sContent, sIDPartner);
            }
            return sSendSuccess;
        }

        private void Set_OpenPort()
        {
            try
            {
                this.port = objclsSMS.OpenPort(sPortName, sBaudRate, sDataBits, sReadTimeOut, sWriteTimeOut);

                if (this.port != null)
                {
                    this.LblMess.Text = "Thiết bị đã được kết nối tại PORT " + sPortName;
                }
                else
                {
                    this.LblMess.Text = "Thiết bị chưa được thiết lập";
                }
            }
            catch (Exception ex)
            {
                //ErrorLog(ex.Message);
            }

        }
        #endregion

        private void BtnUpdateContent_Click(object sender, EventArgs e)
        {
            TVSSys.GlobalModule.objXML.UpdateKey("SMSContent1", this.TxtContent1.Text.Trim());
            TVSSys.GlobalModule.objXML.UpdateKey("SMSContent2", this.TxtContent2.Text.Trim());
            MessageBox.Show("Thông tin đã được cập nhật.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Method ConfigModem
        private void GetConfigModem()
        {
            try
            {
                #region Display all available COM Ports
                string[] ports = SerialPort.GetPortNames();

                // Add all port names to the combo box:
                foreach (string port in ports)
                {
                    cbbPortName.Items.Add(new TVSSys.ItemCombobox(port, port));
                }
                #endregion

                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("1200", "1200"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("2400", "2400"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("4800", "4800"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("9600", "9600"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("19200", "19200"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("38400", "38400"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("57600", "57600"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("115200", "115200"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("230400", "230400"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("460800", "460800"));
                cbbBaudRate.Items.Add(new TVSSys.ItemCombobox("921600", "921600"));

                cbbParity.Items.Add(new TVSSys.ItemCombobox("E", "E"));
                cbbParity.Items.Add(new TVSSys.ItemCombobox("O", "O"));
                cbbParity.Items.Add(new TVSSys.ItemCombobox("N", "N"));

                cbbDataBits.Items.Add(new TVSSys.ItemCombobox("8", "8"));
                cbbDataBits.Items.Add(new TVSSys.ItemCombobox("7", "7"));
                cbbDataBits.Items.Add(new TVSSys.ItemCombobox("6", "6"));
                cbbDataBits.Items.Add(new TVSSys.ItemCombobox("5", "5"));

                cbbStopBits.Items.Add(new TVSSys.ItemCombobox("1", "1"));
                cbbStopBits.Items.Add(new TVSSys.ItemCombobox("1.5", "1.5"));
                cbbStopBits.Items.Add(new TVSSys.ItemCombobox("2", "2"));

                TVSSys.clsPublic objP = new TVSSys.clsPublic();

                objP.SelectValueCombobox(cbbPortName, TVSSys.GlobalModule.objXML.GetKey("SMSPortName"));
                objP.SelectValueCombobox(cbbBaudRate, TVSSys.GlobalModule.objXML.GetKey("SMSBaudRate"));
                objP.SelectValueCombobox(cbbParity, TVSSys.GlobalModule.objXML.GetKey("SMSParity"));
                objP.SelectValueCombobox(cbbDataBits, TVSSys.GlobalModule.objXML.GetKey("SMSDataBits"));
                objP.SelectValueCombobox(cbbStopBits, TVSSys.GlobalModule.objXML.GetKey("SMSStopBits"));
                this.TxtReadTimeOut.Text = TVSSys.GlobalModule.objXML.GetKey("SMSReadTimeOut");
                this.TxtWriteTimeOut.Text = TVSSys.GlobalModule.objXML.GetKey("SMSWriteTimeOut");


                this.TxtContent1.Text = TVSSys.GlobalModule.objXML.GetKey("SMSContent1");
                this.TxtContent2.Text = TVSSys.GlobalModule.objXML.GetKey("SMSContent2");

                this.port = objclsSMS.OpenPort(sPortName, sBaudRate, sDataBits, sReadTimeOut, sWriteTimeOut);

                if (this.port != null)
                {
                    this.LblMess.Text = "Thiết bị đã được kết nối tại PORT " + sPortName;
                }
                else
                {
                    this.LblMess.Text = "Thiết bị chưa được thiết lập";
                }
            }
            catch
            {
            }
        }

        private void SetConfigModem()
        {
            try
            {
                TVSSys.ItemCombobox objItem = (TVSSys.ItemCombobox)cbbPortName.SelectedItem;
                TVSSys.GlobalModule.objXML.UpdateKey("SMSPortName", objItem.Value);
                objItem = (TVSSys.ItemCombobox)cbbBaudRate.SelectedItem;
                TVSSys.GlobalModule.objXML.UpdateKey("SMSBaudRate", objItem.Value);
                objItem = (TVSSys.ItemCombobox)cbbParity.SelectedItem;
                TVSSys.GlobalModule.objXML.UpdateKey("SMSParity", objItem.Value);
                objItem = (TVSSys.ItemCombobox)cbbDataBits.SelectedItem;
                TVSSys.GlobalModule.objXML.UpdateKey("SMSDataBits", objItem.Value);
                objItem = (TVSSys.ItemCombobox)cbbStopBits.SelectedItem;
                TVSSys.GlobalModule.objXML.UpdateKey("SMSStopBits", objItem.Value);
                int sMax = int.Parse(this.TxtReadTimeOut.Text.Trim());
                int sStart = int.Parse(this.TxtWriteTimeOut.Text.Trim());
                TVSSys.GlobalModule.objXML.UpdateKey("SMSReadTimeOut", sMax.ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("SMSWriteTimeOut", sStart.ToString());

                //TVSSys.GlobalModule.objXML.UpdateKey("SMSContent0", this.TxtMessage0.Text);
                //TVSSys.GlobalModule.objXML.UpdateKey("SMSContent1", this.TxtMessage1.Text);
                //TVSSys.GlobalModule.objXML.UpdateKey("SMSContent2", this.TxtMessage2.Text);
                MessageBox.Show("Cập nhật thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật dữ liệu!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void TxtContent2_TextChanged(object sender, EventArgs e)
        {
            string sBalance = "";
            if (this.chkBalance.Checked)
            {
                try
                {
                    if (this.c1TrueDBGrid1.RowCount > 0)
                    {
                        sBalance = double.Parse(c1TrueDBGrid1.Columns["Balance"].CellValue(0).ToString()).ToString("#,##0") + ". ";
                    }
                }
                catch { }
            }
            this.TxtContent0.Text = this.TxtContent1.Text + " " + sBalance + this.TxtContent2.Text;
        }

        private void BtnPhoneNo_Click(object sender, EventArgs e)
        {
            frmDecleration frm = new frmDecleration();
            frm.sTabTable = "ĐẦU SỐ";
            frm.ShowDialog(); 
        }

        private void frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            objclsSMS.ClosePort(this.port);
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < c1TrueDBGrid1.Columns.Count; i++)
                {
                    objdata.Rows[i][1] = chkAll.Checked.ToString();
                }
            }
            catch { }
        }

        #endregion
    }
}