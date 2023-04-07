using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;
using System.Net;
using System.Net.Mail;


namespace TVSMain
{
    public partial class frmEmail : Form
    {
        #region method Declare ...
        private DataTable objdata = new DataTable();
        private clsGridView clsG = new clsGridView();
        private string sSQLQuery = "";
        #endregion

        public frmEmail()
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

            this.TxtEmailAddressFrom.Text = TVSSys.GlobalModule.objXML.GetKey("EmailAddressFrom");
            this.TxtEmailPassword.Text = TVSSys.GlobalModule.objXML.GetKey("EmailPassword");

            this.TxtTitle.Text = TVSSys.GlobalModule.objXML.GetKey("EmailTitle");
            this.TxtContent1.Text = TVSSys.GlobalModule.objXML.GetKey("EmailContent1");
            this.TxtContent2.Text = TVSSys.GlobalModule.objXML.GetKey("EmailContent2");
        }

        #region LoadList
        BindingSource bindsrc = new BindingSource();
        private void LoadList()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                sSQLQuery = "Select '' as Image,cast(0 as bit) as Status,* " +
                            ", "+ Partner.sQueryBalance  +"  as Balance " +
                            " from TblPartner  " + TVSSys.GlobalModule.sOrderbyPartner;

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

        public string Send_Email(string sAddressFrom, string sPassword, string sNameFrom, string sSmtpClient, string sAddressTo,string sContent)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient(sSmtpClient);
                mail.From = new MailAddress(sAddressFrom);
                mail.To.Add(sAddressTo);
                mail.Subject = this.TxtTitle.Text;
                mail.Body += sContent;

                SmtpServer.Port = 587;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.Credentials = new System.Net.NetworkCredential(sAddressFrom, sPassword);
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.EnableSsl = true;
                SmtpServer.Timeout = 30000;
                SmtpServer.Send(mail);



                //MailMessage mail = new MailMessage();
                //SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                //mail.From = new MailAddress("tvsykienphanhoi@gmail.com");
                //mail.To.Add("trinhthanh1102@gmail.com");
                //SmtpServer.Port = 587;
                //SmtpServer.Credentials = new System.Net.NetworkCredential("tvsykienphanhoi", "trungvietsoftware");
                //SmtpServer.EnableSsl = true;
                //SmtpServer.Send(mail);

                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
        

        private void BtnUpdateEmailInfo_Click(object sender, EventArgs e)
        {
            TVSSys.GlobalModule.objXML.UpdateKey("EmailAddressFrom", this.TxtEmailAddressFrom.Text.Trim());
            TVSSys.GlobalModule.objXML.UpdateKey("EmailPassword", this.TxtEmailPassword.Text.Trim());
            MessageBox.Show("Thông tin đã được cập nhật.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButSend_Click(object sender, EventArgs e)
        {
            if (this.TxtEmailAddressFrom.Text.Trim() == "")
            {
                MessageBox.Show("Lỗi, Bạn chưa nhập thông tin người gửi.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.TxtEmailAddressFrom.Focus(); 
                return; 
            }
            string sAddressFrom = this.TxtEmailAddressFrom.Text.Trim();
            string sPassword = this.TxtEmailPassword.Text.Trim();
            string sSmtpClient = "", sNameFrom="";
            try
            {
                sSmtpClient = "smtp." + sAddressFrom.Substring(sAddressFrom.IndexOf("@")+1);
                sNameFrom = sAddressFrom.Substring(0, sAddressFrom.IndexOf("@")); 
            }
            catch { }
            string sContent = "";
            string sBalance = "";
            string sAddressTo = "";
            string sError = "";
            string sErrorIndex = "";
            int sCountTotal = 0,sCount=0;            
            try
            {
                this.Cursor = Cursors.WaitCursor;
                for (int i = 0; i < this.c1TrueDBGrid1.RowCount; i++)
                {
                    if (c1TrueDBGrid1.Columns["Status"].CellValue(i).ToString() == "True")
                    {
                        if (c1TrueDBGrid1.Columns["Email"].CellValue(i).ToString().Trim() != "")
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
                            sContent = this.TxtContent1.Text + " " + sBalance + this.TxtContent2.Text;

                            
                            sCountTotal++;
                            sAddressTo = c1TrueDBGrid1.Columns["Email"].CellValue(i).ToString().Trim();
                            
                            sErrorIndex=Send_Email(sAddressFrom, sPassword, sNameFrom, sSmtpClient, sAddressTo, sContent);
                            if (sErrorIndex == "")
                                sCount++;
                            else
                                sError = System.Environment.NewLine + sErrorIndex;  
                        }

                    }
                }
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;   
            }
            MessageBox.Show("Gửi Email thành công " + sCount.ToString() + "/" + sCountTotal.ToString() + " tin.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            if (sCount!=sCountTotal)
                MessageBox.Show("Lỗi: " + sError, "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }

        private void BtnUpdateContent_Click(object sender, EventArgs e)
        {
            TVSSys.GlobalModule.objXML.UpdateKey("EmailTitle", this.TxtTitle.Text.Trim());
            TVSSys.GlobalModule.objXML.UpdateKey("EmailContent1", this.TxtContent1.Text.Trim());
            TVSSys.GlobalModule.objXML.UpdateKey("EmailContent2", this.TxtContent2.Text.Trim());
            MessageBox.Show("Thông tin đã được cập nhật.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TxtContent1_TextChanged(object sender, EventArgs e)
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
