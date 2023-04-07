using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;
using System.IO;
 
namespace TVSMain
{
    public partial class  frmPaymentVoucher : Form
    {
        #region method Declare ...
        private DataTable objdata=new DataTable();
        private clsGridView objGv = new clsGridView();
        public string sTabTable = "";
        private string sTabID = "1";
        #endregion

        public frmPaymentVoucher()
        {
            InitializeComponent();
            TVSUtil.Reports.Export.ContextMenu(this.c1TrueDBGrid1);
        }

        #region  CodeForm
        private void c1TrueDBGrid1_Error(object sender, C1.Win.C1TrueDBGrid.ErrorEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Lỗi kiểu dữ liệu", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void c1TrueDBGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].DataType.Name == "DateTime") && (ButSave.Enabled) && (e.KeyCode == Keys.Delete))
                {
                    c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].Value = System.DBNull.Value;
                }
                if ((c1TrueDBGrid1.Splits[0].DisplayColumns[c1TrueDBGrid1.Col].Button == true) && (ButSave.Enabled) && (e.KeyCode == Keys.F2))
                {
                    int sCol = c1TrueDBGrid1.Col;
                    if (c1TrueDBGrid1.Columns[sCol].DataField.ToString() == "NamePartner")
                    {
                        frmPartner objfrm = new frmPartner();
                        objfrm.sTabF2 = true;
                        objfrm.ShowDialog();
                        if (objfrm.sTabF2Edit)
                        {
                            objGv.CreateControlTrueDBDropdownPartner(c1TrueDBGrid1);
                        }
                        if (objfrm.sTabF2ID != "")
                        {
                            this.c1TrueDBGrid1.Columns["NamePartner"].Value = TVSSys.GlobalModule.objCon.Get_EXESelect("SELECT ContactPerson FROM TblPartner WHERE IDPartner=" + objfrm.sTabF2ID);
                            this.c1TrueDBGrid1.Columns["AddressPartner"].Value = TVSSys.GlobalModule.objCon.Get_EXESelect("SELECT Address FROM TblPartner WHERE IDPartner=" + objfrm.sTabF2ID);
                            this.c1TrueDBGrid1.Columns["IDPartner"].Value = objfrm.sTabF2ID;
                        }
                    }
                    else
                    {
                        frmDecleration objfrm = new frmDecleration();
                        objfrm.sTabF2 = true;
                        objfrm.sTabTable = c1TrueDBGrid1.Columns[sCol].Caption.ToString().ToUpper();
                        objfrm.ShowDialog();
                        if (objfrm.sTabF2Edit)
                        {
                            objGv.CreateControlTrueDBDropdown(c1TrueDBGrid1, c1TrueDBGrid1.Columns[sCol].DataField.ToString(), sTabID);
                        }
                        if (objfrm.sTabF2ID != "") this.c1TrueDBGrid1.Columns[sCol].Value = objfrm.sTabF2ID;
                    }
                    c1TrueDBGrid1.Col = c1TrueDBGrid1.Col - 1;
                    c1TrueDBGrid1.Col = c1TrueDBGrid1.Col + 1;
                }
            }
            catch { }
        }

        private void frm_Load(object sender, EventArgs e)
        {
            if (sTabTable != "THU TIỀN MẶT") sTabID = "2";
            this.Text = sTabTable;
            this.LoadList();
        }

        #region LoadList
        private void LoadList()
        {
            try
            {
                SqlParameter[] sParam = new SqlParameter[] {
                new SqlParameter("@Date0", dtpDateOption0.Value.ToString("yyyyMMdd")),
                new SqlParameter("@Date1", dtpDateOption1.Value.ToString("yyyyMMdd")),
                new SqlParameter("@IDGroup",sTabID )};
                objdata = TVSSys.GlobalModule.objCon.EXESelect("GetPaymentVoucher", sParam);
                BindingSource bindsrc = new BindingSource();
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;
                objGv.Set_GridViewPaymentVoucher(c1TrueDBGrid1, sTabID);

                this.Set_ModeButton("Load"); 
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid1.AllowAddNew = true;
            this.c1TrueDBGrid1.AllowUpdate = true;
            this.c1TrueDBGrid1.MoveLast();
            this.c1TrueDBGrid1.Row = this.c1TrueDBGrid1.Row + 1;
            this.c1TrueDBGrid1.Col = 1;
            this.c1TrueDBGrid1.Select();
            this.c1TrueDBGrid1.Columns["DatePaymentVoucher"].Value = DateTime.Now;
            this.c1TrueDBGrid1.Columns["IDPaymentVoucherTypeGroup"].Value = sTabID;
            this.c1TrueDBGrid1.Columns["UserName"].Value = TVSSys.GlobalModule.objUserName;
            try
            {
                this.c1TrueDBGrid1.Columns["IDPaymentVoucherType"].Value = TVSSys.GlobalModule.objCon.Get_EXESelectInt("SELECT top 1 IDPaymentVoucherType FROM TblPaymentVoucherType WHERE  IDGroupPaymentVoucherType=" + sTabID);
            }
            catch { }
            this.c1TrueDBGrid1.AllowAddNew = false;
            this.Set_ModeButton("Update");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.ButFocus.Focus();
            if (objdata.GetChanges() == null)
            {
                MessageBox.Show("Dữ liệu của bạn chưa có sự thay đổi!.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (TVSSys.GlobalModule.objCon.EXEUpdate("Select * from TblPaymentVoucher", objdata))
            {
                MessageBox.Show("Dữ liệu của bạn được cập nhật thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadList();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin này ?...", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            if (c1TrueDBGrid1.Columns["IDService"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
            {
                MessageBox.Show("Phiếu này không thể loại bỏ.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TVSSys.GlobalModule.objCon.EXEUpdate("Delete from TblPaymentVoucher  Where IDPaymentVoucher=" + c1TrueDBGrid1.Columns["IDPaymentVoucher"].CellValue(c1TrueDBGrid1.Row)))
            {
                MessageBox.Show("Xóa thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadList();
            }
            else MessageBox.Show("Lỗi, xóa không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (c1TrueDBGrid1.Columns["IDService"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
            {
                MessageBox.Show("Phiếu này không thể cập nhật thông tin.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            
            this.c1TrueDBGrid1.AllowUpdate = true;
            this.Set_ModeButton("Update");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
                            this.ButAdd.Enabled = true;
                            this.ButEdit.Enabled = true;
                            this.ButDelete.Enabled = true;
                            this.ButSave.Enabled = false;
                            this.ButCancel.Enabled = false;

                            this.ToolStripCalc.Enabled = true;
                            break;
                        }
                    case "Update":
                        {
                            this.ButAdd.Enabled = false;
                            this.ButEdit.Enabled = false;
                            this.ButDelete.Enabled = false;
                            this.ButSave.Enabled = true;
                            this.ButCancel.Enabled = true;

                            this.ToolStripCalc.Enabled = false;
                            break;
                        }
                }
            }
            catch
            {
            }
        }

        

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        if (ButSave.Enabled)
                        {
                            this.ToolStripTop.Focus();
                            this.ButCancel.PerformClick();
                        }
                        else
                            this.Close();
                        break;
                    }
                case Keys.F4:
                    {
                        this.ToolStripTop.Focus();
                        this.ButAdd.PerformClick();
                        break;
                    }
                case Keys.F5:
                    {
                        this.ToolStripTop.Focus();
                        this.ButEdit.PerformClick();
                        break;
                    }
                case Keys.F6:
                    {
                        this.ToolStripTop.Focus();
                        this.ButSave.PerformClick();
                        break;
                    }
                case Keys.F8:
                    {
                        this.ToolStripTop.Focus();
                        this.ButDelete.PerformClick();
                        break;
                    }
            }
        }
        
        #endregion

        private void dtpDateOption0_ValueChanged(object sender, EventArgs e)
        {
            LoadList();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                if (c1TrueDBGrid1.RowCount == 0) return;

                DataTable objService = new DataTable();
                objService.Columns.Add("IDService", System.Type.GetType("System.String"));
                objService.Rows.Add(c1TrueDBGrid1.Columns["IDPaymentVoucher"].CellValue(c1TrueDBGrid1.Row).ToString());
                #region sReportType
                string sReportType = "A5";
                int sReportTypeIndex = 0;
                try
                {
                    sReportTypeIndex = int.Parse(TVSSys.GlobalModule.objXML.GetKey("ReportPayment"));
                    if (sReportTypeIndex > 1)
                        sReportType = "A4";

                    if ((sReportTypeIndex == 1) || (sReportTypeIndex == 3))
                    {
                        DataTable sTemp = objService.Copy();
                        sTemp.Clear();
                        for (int i = 0; i < objService.Rows.Count; i++)
                        {
                            sTemp.ImportRow(objService.Rows[i]);
                            sTemp.ImportRow(objService.Rows[i]);
                        }
                        objService = sTemp;
                    }
                }
                catch { }
                #endregion


                TVSReports.rptPaymentVoucher.srptService = true;    
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = "PaymentVoucher" + sReportType;
                if (sTabID == "1")
                    TVSReports.rptPaymentVoucher.srptTitle = "PHIẾU THU TIỀN MẶT";
                else
                    TVSReports.rptPaymentVoucher.srptTitle = "PHIẾU CHI TIỀN MẶT";
                objReport.srptTable = objService;
                objReport.ShowDialog();
            }
            catch { }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            try
            {
                if (c1TrueDBGrid1.RowCount == 0) return;
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = "PaymentVoucherList";
                if (sTabID != "1") objReport.srptTitle = "BÁO CÁO CHI TIỀN MẶT";
                if (dtpDateOption0.Value.ToString("dd/MM/yyyy") != dtpDateOption1.Value.ToString("dd/MM/yyyy")) objReport.srptTitleDescription = "Từ ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + " đến ngày " + dtpDateOption1.Value.ToString("dd/MM/yyyy") + ".";
                else objReport.srptTitleDescription = "Ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + ".";


                DataView sDw = Get_DataViewPV(c1TrueDBGrid1).DefaultView;
                sDw.Sort = "IDPaymentVoucherType,DatePaymentVoucher";
                objReport.srptTable = sDw.ToTable(); 
                //objReport.srptTable = Get_DataViewPV(c1TrueDBGrid1);
                objReport.ShowDialog();
            }
            catch { }
        }

        #region GetDataTableFromGridView
        private DataTable Get_DataViewPV(C1TrueDBGrid sDBGrid)
        {
            try
            {
                DataTable objdt = new DataTable();
                DataColumn colAdd;
                DataRow dr;
                for (int i = 0; i < sDBGrid.Columns.Count; ++i)
                {
                    colAdd = new DataColumn(sDBGrid.Columns[i].DataField.ToString());
                    colAdd.DataType = System.Type.GetType("System.String");
                    objdt.Columns.Add(colAdd);
                }

                for (int sRow = 0; sRow < sDBGrid.RowCount; sRow++)
                {
                    dr = objdt.NewRow();
                    for (int i = 0; i < sDBGrid.Columns.Count; ++i)
                    {
                        if (i == 9) // Ghi chú
                        {
                            dr[i] = " " + sDBGrid.Columns[i-2].CellText(sRow) + " - " + sDBGrid.Columns[i].CellText(sRow);
                        }
                        else dr[i] = " " + sDBGrid.Columns[i].CellText(sRow);
                    }
                    objdt.Rows.Add(dr);
                }
                return objdt;
            }
            catch
            {
                return null;
            }
        }
        #endregion

        int sRowBefore = 0;
        private void c1TrueDBGrid1_RowColChange(object sender, RowColChangeEventArgs e)
        {
            try
            {
                if ((this.ButSave.Enabled) && (c1TrueDBGrid1.Row != sRowBefore))
                {
                    c1TrueDBGrid1.Row = sRowBefore;
                    return;
                }
                sRowBefore = c1TrueDBGrid1.Row;
            }
            catch { }
        }

        private void c1TrueDBGrid1_ButtonClick(object sender, ColEventArgs e)
        {
            try
            {
                if ((ButSave.Enabled) && (c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].DataField.ToString() == "NamePartner"))
                {
                    frmPartner objFrm = new frmPartner();
                    objFrm.sTabF2 = true;  
                    objFrm.ShowDialog();
                    if (objFrm.sTabF2ID != "")
                    {
                        string sSQL = "SELECT ContactPerson,(CodeRoom + ': ' + NameRoom) as ContactAddress,ContactPhone FROM TblPartner LEFT JOIN TblRoom ON TblPartner.IDPartner=TblRoom.IDPartner WHERE TblPartner.IDPartner=" + objFrm.sTabF2ID;
                        DataTable objdt = TVSSys.GlobalModule.objCon.EXESelect(sSQL);
                        if (objdt.Rows.Count > 0)
                        {
                            this.c1TrueDBGrid1.Columns["NamePartner"].Value = objdt.Rows[0]["ContactPerson"].ToString();
                            this.c1TrueDBGrid1.Columns["AddressPartner"].Value = objdt.Rows[0]["ContactAddress"].ToString();
                            this.c1TrueDBGrid1.Columns["PhonePartner"].Value = objdt.Rows[0]["ContactPhone"].ToString();
                            this.c1TrueDBGrid1.Columns["IDPartner"].Value = objFrm.sTabF2ID;
                        }
                    }
                    else
                    {
                        this.c1TrueDBGrid1.Columns["NamePartner"].Value = "";
                        this.c1TrueDBGrid1.Columns["AddressPartner"].Value = "";
                        this.c1TrueDBGrid1.Columns["PhonePartner"].Value = "";
                        this.c1TrueDBGrid1.Columns["IDPartner"].Value = "";
                    }
                }
            }
            catch { }
        }

    }
}