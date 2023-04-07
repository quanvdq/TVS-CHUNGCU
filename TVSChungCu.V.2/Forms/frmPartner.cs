using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;
using TVSChungCu.Forms;

namespace TVSMain
{
    public partial class frmPartner : Form
    {
        #region method Declare ...
        private string sTab = "TblPartner";
        private string sTabID = "IDPartner", sTabName = "ContactPerson";
        private DataTable objdata = new DataTable();
        public bool sTabF2 = false, sTabF2Edit = false;
        public string sTabF2ID = "0";
        private clsGridView clsG = new clsGridView();
        private string sSQLQuery = "";
        private clsPublic clsP = new clsPublic();
        private string sSQLOrder = "";

        public bool sFormPartner = true;
        public string sIDPartner = "";
        #endregion

        #region method frmPartner
        public frmPartner()
        {
            InitializeComponent();
            TVSUtil.Reports.Export.ContextMenu(this.c1TrueDBGrid1);
        }
        #endregion

        #region Mothod FromCode
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid1.AllowAddNew = true;
            this.c1TrueDBGrid1.AllowUpdate = true;
            this.c1TrueDBGrid1.MoveLast();
            this.c1TrueDBGrid1.Row = this.c1TrueDBGrid1.Row + 1;
            this.c1TrueDBGrid1.Col = 1; 
            this.c1TrueDBGrid1.Select();
            this.c1TrueDBGrid1.Columns[sTabName].Value = "Cập nhật dữ liệu";

            if (!sFormPartner)
                this.c1TrueDBGrid1.Columns["IDPartner"].Value = sIDPartner;

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

            if (TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery,objdata))
            {
                string sID = c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row).ToString();
                MessageBox.Show("Dữ liệu của bạn được cập nhật thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.LoadList();

                int i = 0;
                for (i = 0; i < c1TrueDBGrid1.RowCount; i++)
                {
                    if (sID == c1TrueDBGrid1.Columns[sTabID].CellValue(i).ToString()) break;
                }
                c1TrueDBGrid1.Row = i;
                c1TrueDBGrid1.Select();
                sTabF2Edit = true;
            }
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
                            this.ButEdit.Enabled = true;
                            this.ButDelete.Enabled = true;
                            this.ButSave.Enabled = false;
                            this.ButCancel.Enabled = false;

                            break;
                        }
                    case "Update":
                        {
                            this.ButEdit.Enabled = false;
                            this.ButDelete.Enabled = false;
                            this.ButSave.Enabled = true;
                            this.ButCancel.Enabled = true;
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
            if (!sTabF2) lblMess.Visible = false;
            this.ComListView.SelectedIndex = 0;
            if (!sFormPartner)
            {
                sTab = "TblFamily";
                sTabID = "IDFamily";
                sTabName = "NameFamily";
                if (sIDPartner != "")
                    sSQLOrder = " WHERE IDPartner=" + sIDPartner + " ";
                        
                sSQLOrder += TVSSys.GlobalModule.sOrderbyFamily;
            }
            else
                sSQLOrder = TVSSys.GlobalModule.sOrderbyPartner;
            this.LoadList();


            if (!sFormPartner)
                this.Text = "THÔNG TIN THÂN NHÂN KHÁCH HÀNG, ĐỐI TÁC: " + TVSSys.GlobalModule.objCon.Get_EXESelect("SELECT ContactPerson + '-' + ContactPhone FROM TblPartner WHERE IDPartner=" + sIDPartner);
            else
                this.Text = "THÔNG TIN KHÁCH HÀNG, ĐỐI TÁC";
        }

        #region LoadList

        BindingSource bindsrc = new BindingSource();
        private void LoadList()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                sSQLQuery = "Select '' as Image,* from " + sTab + sSQLOrder;

                objdata = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);
                BindingSource bindsrc = new BindingSource();
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;

                C1.Win.C1TrueDBGrid.C1DisplayColumn dc;
                dc = c1TrueDBGrid1.Splits[0].DisplayColumns["Image"];
                c1TrueDBGrid1.Splits[0].DisplayColumns.RemoveAt(c1TrueDBGrid1.Splits[0].DisplayColumns.IndexOf(dc));
                c1TrueDBGrid1.Splits[0].DisplayColumns.Insert(0, dc);
                dc.Visible = true;
                dc.FetchStyle = true;

                try
                {
                    if (ComListView.SelectedIndex != 0)
                    {
                        c1TrueDBGrid1.RowHeight = 120;
                        c1TrueDBGrid1.Splits[0].DisplayColumns["Image"].Visible = true;
                    }
                    else
                    {
                        c1TrueDBGrid1.RowHeight = 22;
                        c1TrueDBGrid1.Splits[0].DisplayColumns["Image"].Visible = false;
                    }
                }
                catch { }

                if (!sFormPartner)
                    clsG.DeclerationFamily(c1TrueDBGrid1);
                else
                    clsG.DeclerationPartner(c1TrueDBGrid1);

                TVSUtil.GridView.Interface.ContextMenu(this.c1TrueDBGrid1, sTab);  
                this.Set_ModeButton("Load");
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        } 
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin này ?...", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            if (TVSSys.GlobalModule.objCon.EXEUpdate("Delete from " + sTab + "  Where " + sTabID + "=" + c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row)))
            {
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
                if (c1TrueDBGrid1.RowCount > 0)
                    sTabF2ID = c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row).ToString();
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
                            if (ButSave.Enabled)
                            {
                                //this.ToolStripTop.Focus();
                                this.ButCancel.PerformClick();
                            }
                            else
                            {
                                if (c1TrueDBGrid1.RowCount > 0)
                                    sTabF2ID = c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.Close();
                            }
                            break;
                        }
                    case Keys.F2:
                        {
                            if ((sTabF2) && (!ButSave.Enabled))
                            {
                                sTabF2ID = c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.Close();
                            }
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
        
        private void c1TrueDBGrid1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if ((sTabF2) && !ButSave.Enabled) 
                {
                    if (c1TrueDBGrid1.RowCount > 0)
                        sTabF2ID = c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row).ToString();
                    this.Close();
                }
                else if (!ButSave.Enabled)
                {
                    if (c1TrueDBGrid1.RowCount == 0) return;

                    frmPartnerEdit objFrm = new frmPartnerEdit();
                    objFrm.sIDPartner = c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row).ToString();
                    objFrm.ShowDialog();

                    if (objFrm.itemUpdate > 0)
                    {
                        this.LoadList();
                    }
                }
            }
            catch { }
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
                    frmDecleration objfrm = new frmDecleration();
                    objfrm.sTabF2 = true;                    
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

        private void c1TrueDBGrid1_ButtonClick(object sender, ColEventArgs e)
        {
            try
            {
                if ((!ButSave.Enabled) && (c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].DataField.ToString() == "Image"))
                {
                    frmPartnerDetail objFrm = new frmPartnerDetail();
                    objFrm.sIDPartner = c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row).ToString();
                    objFrm.sFormPartner = this.sFormPartner;  
                    objFrm.ShowDialog();
                    if (objFrm.sTabEdit)
                        this.LoadList(); 
                }
            }
            catch { }
        }

        private void c1TrueDBGrid1_FetchCellStyle(object sender, FetchCellStyleEventArgs e)
        {
            try
            {
                if (ButSave.Enabled) return;
                DataRow row = objdata.Rows[c1TrueDBGrid1.RowBookmark(e.Row)];
                e.CellStyle.ForegroundImage = clsP.GetImageFromByteArray(row["Images"].ToString());
                e.CellStyle.ForeGroundPicturePosition = C1.Win.C1TrueDBGrid.ForeGroundPicturePositionEnum.PictureOnly;
            }
            catch { }
        }

        

        private void ComListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ComListView.SelectedIndex != 0)
                {
                    c1TrueDBGrid1.RowHeight = 120;
                    c1TrueDBGrid1.Splits[0].DisplayColumns["Image"].Visible = true;
                }
                else
                {
                    c1TrueDBGrid1.RowHeight = 22;
                    c1TrueDBGrid1.Splits[0].DisplayColumns["Image"].Visible = false;
                }
            }
            catch { }
        }

        private void TxtNameSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.objdata.DefaultView.RowFilter = c1TrueDBGrid1.Columns[sTabName].DataField + " LIKE '%" + TxtNameSearch.Text + "%'";
            }
            catch { return; }
        }

        #endregion
    }
}