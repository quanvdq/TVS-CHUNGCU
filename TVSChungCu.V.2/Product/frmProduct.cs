using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;

namespace TVSMain
{
    public partial class frmProduct : Form
    {

        #region method Declare ...
        public string sTabTable = "";
        private string sTabTypeBill = "NH";
        private string sTab = "TblBill";
        private string sTabDate = "DateBill";
        private DataTable objdata = new DataTable();
        private DataTable objdata2 = new DataTable();
        private DataTable objdata3 = new DataTable();
        private clsGridView clsG = new clsGridView();
        private bool sTabAdd = false;
        private string sTabIDBill = "";
        private string sSQLdata = "";
        private string sSQLdata2 = "";
        #endregion

        public frmProduct()
        {
            InitializeComponent();
        }

        #region Mothod FromCode
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.textBox1.Text="";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.dtpDateOption1.Value = DateTime.Now;    
            this.textBox1.Focus();

            this.Set_ModeButton("Update");
            this.sTabAdd = true; 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")
            {
                //MessageBox.Show("Lỗi, Bạn chưa nhập số phiếu.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //this.textBox1.Focus(); 
                //return;
                this.textBox1.Text = sTabTypeBill + "/" + DateTime.Now.ToString("yyyyMMdd") + "-" + DateTime.Now.ToString("HHmm");      
            }
            if (this.textBox2.Text.Trim()  == "")
            {
                MessageBox.Show("Lỗi, Bạn chưa nhập Nhà cung cấp.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
                return;
            }
            if (sTabAdd)
            {
                this.c1TrueDBGrid1.AllowAddNew = true;
                this.c1TrueDBGrid1.AllowUpdate = true;
                this.c1TrueDBGrid1.MoveLast();
                this.c1TrueDBGrid1.Row = this.c1TrueDBGrid1.Row + 1;
                this.c1TrueDBGrid1.Col = 1;
                this.c1TrueDBGrid1.Select();
                this.c1TrueDBGrid1.Columns["CodeBill"].Value = this.textBox1.Text.Trim();
                this.c1TrueDBGrid1.Columns["DateBill"].Value = dtpDateOption1.Value;
                this.c1TrueDBGrid1.Columns["NamePartner"].Value = this.textBox2.Text.Trim();
                this.c1TrueDBGrid1.Columns["AddressPartner"].Value = this.textBox3.Text.Trim();
                this.c1TrueDBGrid1.Columns["PhonePartner"].Value = this.textBox4.Text.Trim();
                this.c1TrueDBGrid1.Columns["Note"].Value = this.textBox5.Text.Trim();
                this.c1TrueDBGrid1.Columns["UserCreate"].Value = TVSSys.GlobalModule.objUserName;
                this.c1TrueDBGrid1.Columns["DateCreate"].Value = DateTime.Now;
                this.c1TrueDBGrid1.Columns["TypeBill"].Value = sTabTypeBill;
                this.c1TrueDBGrid1.AllowAddNew = false;
            }
            else
            {
                this.c1TrueDBGrid1.Columns["CodeBill"].Value = this.textBox1.Text.Trim();
                this.c1TrueDBGrid1.Columns["DateBill"].Value = dtpDateOption1.Value;
                this.c1TrueDBGrid1.Columns["NamePartner"].Value = this.textBox2.Text.Trim();
                this.c1TrueDBGrid1.Columns["AddressPartner"].Value = this.textBox3.Text.Trim();
                this.c1TrueDBGrid1.Columns["PhonePartner"].Value = this.textBox4.Text.Trim();
                this.c1TrueDBGrid1.Columns["Note"].Value = this.textBox5.Text.Trim();
            }
            this.c1TrueDBGrid1.Focus();
            this.btnUpdate.Focus();

            if (objdata.GetChanges() == null) return;
            string sID = c1TrueDBGrid1.Columns[0].CellValue(c1TrueDBGrid1.Row).ToString();
            TVSSys.GlobalModule.objCon.EXEUpdate(sSQLdata, objdata);    
            this.LoadList();
            int i = 0;
            for (i = 0; i < c1TrueDBGrid1.RowCount; i++)
            {
                if (sID == c1TrueDBGrid1.Columns[0].CellValue(i).ToString()) break;
            }
            c1TrueDBGrid1.Row = i;
            c1TrueDBGrid1.Select(); 
        }

        private void c1TrueDBGrid1_Error(object sender, C1.Win.C1TrueDBGrid.ErrorEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Lỗi kiểu dữ liệu", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Set_ModeButton(string sMode)
        {
            try
            {
                switch (sMode)
                {
                    case "Load":
                        {
                            this.c1TrueDBGrid1.AllowUpdate = false;
                            this.btnAddNew.Enabled = true;
                            this.btnEdit.Enabled = true;
                            this.btnDelete.Enabled = true;
                            this.btnUpdate.Enabled = false;
                            this.btnCancel.Enabled = false;
                            this.btnPrinter.Enabled = true;
                            this.Set_ModeButton2("Load");
                            this.sTabAdd = false;
                            this.btnDAddNew.Enabled = true;
                            break;
                        }
                    case "Update":
                        {
                            this.btnAddNew.Enabled = false;
                            this.btnEdit.Enabled = false;
                            this.btnDelete.Enabled = false;
                            this.btnUpdate.Enabled = true;
                            this.btnCancel.Enabled = true;
                            this.btnPrinter.Enabled = false;
                            this.Set_ModeButton2("Visible");
                            break;
                        }
                }
            }
            catch
            {
            }
        }

        private void frm_Load(object sender, EventArgs e)
        {
            this.Text = sTabTable;
            if (sTabTable!="NHẬP VẬT TƯ")
                sTabTypeBill = "XH"; 
            this.LoadList(); 
        }

        #region LoadList
        private void LoadList()
        {
            try
            {
                sSQLdata = "Select * from " + sTab + " WHERE TypeBill='" + sTabTypeBill + "' Order by " + sTabDate + " desc ";
                objdata = TVSSys.GlobalModule.objCon.EXESelect(sSQLdata);
                BindingSource bindsrc = new BindingSource();
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;
                clsG.Set_GridViewBill(this.c1TrueDBGrid1);  
                this.Set_ModeButton("Load");
                this.Load_detail(); 
            }
            catch { }
        } 
        #endregion

        #region method Load_detai
        private void Load_detail()
        {
            try
            {
                this.sTabIDBill = c1TrueDBGrid1.Columns["IDBill"].CellValue(c1TrueDBGrid1.Row).ToString();
                objdata3 = TVSSys.GlobalModule.objCon.EXESelect("Select * from " + sTab + " where IDBill=" + this.sTabIDBill);
                if (objdata3.Rows.Count > 0)
                {
                    this.textBox1.Text = objdata3.Rows[0]["CodeBill"].ToString();
                    this.textBox2.Text = objdata3.Rows[0]["NamePartner"].ToString();
                    this.textBox3.Text = objdata3.Rows[0]["AddressPartner"].ToString();
                    this.textBox4.Text = objdata3.Rows[0]["PhonePartner"].ToString();
                    this.textBox5.Text = objdata3.Rows[0]["Note"].ToString();
                    this.dtpDateOption1.Value = DateTime.Parse(objdata3.Rows[0]["DateBill"].ToString());
                }
                sSQLdata2 = "Select * from " + sTab + "Detail where IDBill=" + this.sTabIDBill;
                objdata2 = TVSSys.GlobalModule.objCon.EXESelect(sSQLdata2);
                c1TrueDBGrid2.DataSource = objdata2;
                clsG.Set_GridViewBillDetail(this.c1TrueDBGrid2);
                this.Set_SumMoney();
                this.Set_ModeButton2("Load");
            }
            catch { }
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin này ?...", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (TVSSys.GlobalModule.objCon.EXEUpdate("Delete from " + sTab + "  Where IDBill=" + sTabIDBill))
            {
                TVSSys.GlobalModule.objCon.EXEUpdate("Delete from " + sTab + "Detail Where IDBill=" + sTabIDBill);
                MessageBox.Show("Xóa thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadList();            }
            else MessageBox.Show("Lỗi, xóa không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid1.AllowUpdate = true;
            this.Set_ModeButton("Update");
        }

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
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        if (btnUpdate.Enabled)
                        {
                            this.btnCancel.Focus();
                            this.btnCancel.PerformClick();
                        }
                        else
                        {
                            this.Close();
                        }
                        break;
                    }
                case Keys.F4:
                    {
                        this.btnAddNew.Focus();
                        this.btnAddNew.PerformClick();
                        break;
                    }
                case Keys.F5:
                    {
                        this.btnEdit.Focus();
                        this.btnEdit.PerformClick();
                        break;
                    }
                case Keys.F6:
                    {
                        this.btnUpdate.Focus();
                        this.btnUpdate.PerformClick();
                        break;
                    }
                case Keys.F8:
                    {
                        this.btnDelete.Focus();
                        this.btnDelete.PerformClick();
                        break;
                    }
            }

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
        

        #endregion


        #region c1TrueDBGrid1

        private void c1TrueDBGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].DataType.Name == "DateTime") && (btnUpdate.Enabled) && (e.KeyCode == Keys.Delete))
                {
                    c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].Value = System.DBNull.Value;
                }

                if ((c1TrueDBGrid1.Splits[0].DisplayColumns[c1TrueDBGrid1.Col].Button == true) && (btnUpdate.Enabled) && (e.KeyCode == Keys.F2))
                {
                    frmDecleration objfrm = new frmDecleration();
                    objfrm.sTabF2 = true;
                    int sCol = c1TrueDBGrid1.Col;
                    objfrm.sTabTable = c1TrueDBGrid1.Columns[sCol].Caption.ToString().ToUpper();
                    objfrm.ShowDialog();
                    if (objfrm.sTabF2Edit)
                    {
                        clsG.CreateControlTrueDBDropdown(c1TrueDBGrid1, c1TrueDBGrid1.Columns[sCol].DataField.ToString());
                    }
                    if (objfrm.sTabF2ID != "") this.c1TrueDBGrid1.Columns[sCol].Value = objfrm.sTabF2ID;
                    c1TrueDBGrid1.Col = c1TrueDBGrid1.Col - 1;
                    c1TrueDBGrid1.Col = c1TrueDBGrid1.Col + 1;
                }
            }
            catch { }
        }
        #endregion


        private void c1TrueDBGrid1_RowColChange(object sender, RowColChangeEventArgs e)
        {
            try
            {
                if (btnUpdate.Enabled) return; 
                this.Load_detail();
            }
            catch { }
        }

        #region method txtTextBox
        private void txtEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tmp = (System.Windows.Forms.TextBox)sender;
            tmp.BackColor = TVSSys.GlobalModule.objColorEnter;
        }
        private void txtLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tmp = (System.Windows.Forms.TextBox)sender;
            tmp.BackColor = TVSSys.GlobalModule.objColorLeave;
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter) SendKeys.Send("{TAB}");
        }
        #endregion


        #region LoadDetail()

        private void btnDAddNew_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid2.AllowAddNew = true;
            this.c1TrueDBGrid2.AllowUpdate = true;
            this.c1TrueDBGrid2.MoveLast();
            this.c1TrueDBGrid2.Row = this.c1TrueDBGrid2.Row + 1;
            this.c1TrueDBGrid2.Col = 2;
            this.c1TrueDBGrid2.Select();
            this.c1TrueDBGrid2.Columns["IDBill"].Value = this.sTabIDBill;
            this.c1TrueDBGrid2.AllowAddNew = false;
            this.Set_ModeButton2("Update");
        }

        private void btnDUpdate_Click(object sender, EventArgs e)
        {
            TVSSys.GlobalModule.objCon.EXEUpdate(sSQLdata2, objdata2);    
            Load_detail();
        }

        private void Set_ModeButton2(string sMode)
        {
            try
            {
                switch (sMode)
                {
                    case "Load":
                        {
                            this.c1TrueDBGrid2.AllowUpdate = false;
                            this.btnDEdit.Enabled = true;
                            this.btnDDelete.Enabled = true;
                            this.btnDUpdate.Enabled = false;
                            this.btnDCancel.Enabled = false;
                            break;
                        }
                    case "Update":
                        {
                            this.c1TrueDBGrid2.AllowUpdate = true;
                            this.btnDEdit.Enabled = false;
                            this.btnDDelete.Enabled = false;
                            this.btnDUpdate.Enabled = true;
                            this.btnDCancel.Enabled = true;
                            Set_ModeButton("Visible");
                            break;
                        }
                    case "Visible":
                        {
                            this.btnDAddNew.Enabled = false;
                            this.btnDEdit.Enabled = false;
                            this.btnDDelete.Enabled = false;
                            this.btnDUpdate.Enabled = false;
                            this.btnDCancel.Enabled = false;
                            break;
                        }
                }
            }
            catch
            {
            }
        }

        private void btnDCancel_Click(object sender, EventArgs e)
        {
            Load_detail();
        }

        private void btnDDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin này ?...", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (TVSSys.GlobalModule.objCon.EXEUpdate("Delete from " + sTab + "Detail Where IDBillDetail=" + c1TrueDBGrid2.Columns["IDBillDetail"].CellValue(c1TrueDBGrid2.Row)))
            {
                MessageBox.Show("Xóa thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Load_detail();
                int sRow1 = c1TrueDBGrid1.Row;
                int sCol1 = c1TrueDBGrid1.Col;
                LoadList();
                c1TrueDBGrid1.Col = sCol1;
                c1TrueDBGrid1.Row = sRow1;
                c1TrueDBGrid1.Select();
            }
            else MessageBox.Show("Lỗi, xóa không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDEdit_Click(object sender, EventArgs e)
        {
            this.Set_ModeButton2("Update");
        }


        private void c1TrueDBGrid2_AfterColUpdate(object sender, ColEventArgs e)
        {
            try
            {
                string sDataField = e.Column.DataColumn.DataField.ToString();
                switch (sDataField)
                {
                    case "IDProduct":
                        {
                            this.c1TrueDBGrid2.Columns["Price"].Value = TVSSys.GlobalModule.objCon.Get_EXESelectDouble("SELECT Price FROM TblProduct WHERE IDProduct=" + c1TrueDBGrid2.Columns["IDProduct"].CellValue(c1TrueDBGrid2.Row).ToString());
                            this.c1TrueDBGrid2.Columns["IDUnit"].Value = TVSSys.GlobalModule.objCon.Get_EXESelectInt("SELECT IDUnit FROM TblProduct WHERE IDProduct=" + c1TrueDBGrid2.Columns["IDProduct"].CellValue(c1TrueDBGrid2.Row).ToString());   
                            break;; 
                        }
                    case "Number":
                    case "Price":
                    case "VAT":
                        {
                            double sValue0 = 0, sValue1 = 0, sValue2 = 0;
                            try
                            {
                                sValue0 = double.Parse(c1TrueDBGrid2.Columns["Number"].CellValue(c1TrueDBGrid2.Row).ToString());
                            }
                            catch { }
                            try
                            {
                                sValue1 = double.Parse(c1TrueDBGrid2.Columns["Price"].CellValue(c1TrueDBGrid2.Row).ToString());
                            }
                            catch { }
                            try
                            {
                                sValue2 = double.Parse(c1TrueDBGrid2.Columns["VAT"].CellValue(c1TrueDBGrid2.Row).ToString());
                            }
                            catch { }
                            this.c1TrueDBGrid2.Columns["Money"].Value = sValue0 * sValue1*(1 + sValue2/100);
                            this.Set_SumMoney();
                            break;
                        }
                }
            }
            catch { }
        }

        private void Set_SumMoney()
        {
            double sMoney = 0;
            try
            {
                for (int i = 0; i < c1TrueDBGrid2.RowCount; i++)
                {
                    sMoney += double.Parse(c1TrueDBGrid2.Columns["Money"].CellValue(i).ToString());  
                }
            }
            catch { }
            this.TxtMoney.Text = sMoney.ToString("#,##0");   
        }

        private void c1TrueDBGrid2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((c1TrueDBGrid2.Splits[0].DisplayColumns[c1TrueDBGrid2.Col].Button == true) && (btnDUpdate.Enabled) && (e.KeyCode == Keys.F2))
                {
                    frmDecleration objfrm = new frmDecleration();
                    objfrm.sTabF2 = true;
                    int sCol = c1TrueDBGrid2.Col;
                    objfrm.sTabTable = c1TrueDBGrid2.Columns[sCol].Caption.ToString().ToUpper();
                    objfrm.ShowDialog();
                    if (objfrm.sTabF2Edit)
                    {
                        clsG.CreateControlTrueDBDropdown(c1TrueDBGrid2, c1TrueDBGrid2.Columns[sCol].DataField.ToString());
                    }
                    if (objfrm.sTabF2ID != "") this.c1TrueDBGrid2.Columns[sCol].Value = objfrm.sTabF2ID;
                    c1TrueDBGrid2.Col = c1TrueDBGrid2.Col - 1;
                    c1TrueDBGrid2.Col = c1TrueDBGrid2.Col + 1;
                }
                if (e.KeyCode == Keys.Enter)
                {
                    if ((c1TrueDBGrid2.Row == c1TrueDBGrid2.RowCount - 1) && (c1TrueDBGrid2.Columns[c1TrueDBGrid2.Col].DataField=="Note"))
                    {
                        this.btnDAddNew.Focus();
                        this.btnDAddNew.PerformClick();
                    }
                }
            }
            catch { }
        }

        

        private void btnPrinter_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (c1TrueDBGrid1.RowCount == 0) return;
                TVSReports.rptProduct.srptTitle = "HÓA ĐƠN " + sTabTable;
                TVSReports.rptProduct.srptTable = clsG.Get_DataView(this.c1TrueDBGrid2);
                TVSReports.rptProduct.srptTableBill = objdata3;
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = "Product";
                objReport.ShowDialog();
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        #endregion
    }
}