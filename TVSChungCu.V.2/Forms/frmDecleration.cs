using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;
using System.Data.OleDb;

namespace TVSMain
{
    public partial class frmDecleration : Form
    {
        #region method Declare ...
        public string sTabTable = "";
        public string sTabRoomStatus = "";
        private string sTab = "";
        private string sTabID = "", sTabName = "";
        private DataTable objdata = new DataTable();
        public bool sTabF2 = false, sTabF2Edit = false;
        public string sTabF2ID = "0";
        private clsGridView clsG = new clsGridView();
        private string sSQLQuery = "", sSQLOrder = "", sSQLWhere = "", sSQLColumn = "";
        private bool sLockButton = false;
        private string sIDGroup = "0";
        #endregion

        public frmDecleration()
        {
            InitializeComponent();
            TVSUtil.Reports.Export.ContextMenu(this.c1TrueDBGrid1);
        }

        #region Mothod FromCode
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            this.c1TrueDBGrid1.AllowAddNew = true;
            this.c1TrueDBGrid1.AllowUpdate = true;
            this.c1TrueDBGrid1.MoveLast();
            this.c1TrueDBGrid1.Row = this.c1TrueDBGrid1.Row + 1;
            this.c1TrueDBGrid1.Col = 1; 
            this.c1TrueDBGrid1.Select();

            try
            {
                switch (sTab)
                {
                    case "TblPaymentVoucherType":
                        {
                            this.c1TrueDBGrid1.Columns["IDGroupPaymentVoucherType"].Value = sIDGroup;
                            
                        break; }
                    case "TblRoom":
                        {
                            if (c1TrueDBGrid1.Row != 0)
                            {
                                this.c1TrueDBGrid1.Columns["IDRegion"].Value = c1TrueDBGrid1.Columns["IDRegion"].CellValue(c1TrueDBGrid1.Row - 1).ToString();

                                this.c1TrueDBGrid1.Columns["IDRoomType"].Value = c1TrueDBGrid1.Columns["IDRoomType"].CellValue(c1TrueDBGrid1.Row - 1).ToString();
                            }                            
                            break;
                        }                    
                }
            }
            catch { }


            this.c1TrueDBGrid1.Columns[sTabName].Value = "Cập nhật dữ liệu";
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
                string sID = c1TrueDBGrid1.Columns[0].CellValue(c1TrueDBGrid1.Row).ToString();
                MessageBox.Show("Dữ liệu của bạn được cập nhật thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.LoadList();

                int i = 0;
                for (i = 0; i < c1TrueDBGrid1.RowCount; i++)
                {
                    if (sID == c1TrueDBGrid1.Columns[0].CellValue(i).ToString()) break;
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

        private void Set_DBGrid(string sTab)
        {
            try
            {
                clsGridView objGv = new clsGridView();
                switch (sTab)
                {

                    case "TblRoomType":
                        {
                            clsG.DeclerationRoomType(this.c1TrueDBGrid1);   
                            break;
                        }
                    case "TblRoom":
                        {
                            clsG.DeclerationRoom(this.c1TrueDBGrid1);
                            TVSUtil.GridView.Interface.ContextMenu(this.c1TrueDBGrid1, sTab);
                            
                            break;
                        }
                    case "TblPriceParking":
                        {
                            clsG.DeclerationPriceParking(this.c1TrueDBGrid1);
                            break;
                        }
                    case "TblPriceWater":
                        {
                            clsG.DeclerationPriceWater(this.c1TrueDBGrid1);
                            break;
                        }
                    case "TblPriceElectric":
                        {
                            clsG.DeclerationPriceElectric(this.c1TrueDBGrid1);
                            break;
                        }

                    case "TblPayWater":
                        {
                            clsG.DeclerationPayWater(this.c1TrueDBGrid1);
                            break;
                        }
                    case "TblPayElectric":
                        {
                            clsG.DeclerationPayElectric(this.c1TrueDBGrid1);
                            break;
                        }

                    case "TblPaymentVoucherType":
                        {
                            clsG.DeclerationPaymentVoucher(this.c1TrueDBGrid1);
                            break;
                        }

                    case "TblProduct":
                        {
                            clsG.DeclerationProduct(this.c1TrueDBGrid1);
                            break;
                        }

                    case "TblUnit":
                        {
                            clsG.DeclerationUnit(this.c1TrueDBGrid1);
                            break;
                        }
                    case "TblRegion":
                        {
                            clsG.DeclerationRegion(this.c1TrueDBGrid1);
                            break;
                        }

                    case "TblSMSPhoneNo":
                        {
                            c1TrueDBGrid1.Splits[0].DisplayColumns[0].Visible = false;
                            c1TrueDBGrid1.Splits[0].DisplayColumns[0].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                            c1TrueDBGrid1.Columns["NameSMSPhoneNo"].Caption = "Đầu số nhắn tin";
                            break;
                        }

                    case "TblFamilyRelations":
                        {
                            c1TrueDBGrid1.Splits[0].DisplayColumns[0].Visible = false;
                            c1TrueDBGrid1.Splits[0].DisplayColumns[0].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                            c1TrueDBGrid1.Columns["NameFamilyRelations"].Caption = "Quan hệ gia đình";
                            break;
                        }
                }
                this.Text = "THÔNG TIN " + c1TrueDBGrid1.Columns[sTabName].Caption.ToUpper();
            }
            catch
            {
            }
        }

        private void Set_sTabTable(string sTabTable)
        {
            try
            {
                switch (sTabTable)
                {
                    case "LOẠI PHÒNG": { sTab = "TblRoomType"; break; }
                    case "TRẠNG THÁI": { sTab = "TblRoomType"; break; }
                    case "PHÒNG - CĂN HỘ": { sTab = "TblRoom"; this.ComRegion.Visible = true; this.ButImport.Visible = false; break; }
                    case "ĐƠN GIÁ TRÔNG XE": { sTab = "TblPriceParking"; break; }
                    case "ĐƠN GIÁ NƯỚC SINH HOẠT": { sTab = "TblPriceWater"; break; }
                    case "ĐƠN GIÁ ĐIỆN SINH HOẠT": { sTab = "TblPriceElectric"; break; }

                    case "SỬ DỤNG NƯỚC": { sTab = "TblPayWater"; break; }
                    case "SỬ DỤNG ĐIỆN": { sTab = "TblPayElectric"; break; }

                    case "KHOẢN THU":
                    case "HÌNH THỨC THU": { sTab = "TblPaymentVoucherType"; sIDGroup = "1"; sSQLWhere = " WHERE IDGroupPaymentVoucherType=" + sIDGroup; break; }
                    case "KHOẢN CHI":
                    case "HÌNH THỨC CHI": { sTab = "TblPaymentVoucherType"; sIDGroup = "2"; sSQLWhere = " WHERE IDGroupPaymentVoucherType=" + sIDGroup; break; }

                    case "VẬT TƯ": { sTab = "TblProduct"; break; }
                    case "ĐVT": 
                    case "ĐƠN VỊ TÍNH": { sTab = "TblUnit"; break; }
                    case "KHU VỰC": { sTab = "TblRegion"; break; }

                    case "ĐẦU SỐ": { sTab = "TblSMSPhoneNo"; break; }
                    case "QUAN HỆ": { sTab = "TblFamilyRelations"; break; }
                }

                sTabID = "ID" + sTab.Substring(3);
                sTabName = "Name" + sTab.Substring(3);
                sSQLOrder = " Order by " + "Name" + sTab.Substring(3);

                switch (sTab)
                {
                    case "TblPriceWater": { sSQLOrder = " Order by IDPayWater," + "Name" + sTab.Substring(3); break; }
                    case "TblPriceElectric": { sSQLOrder = " Order by IDPayElectric," + "Name" + sTab.Substring(3); break;}
                    case "TblRoom": { sSQLOrder = " Order by IDRoomType," + "Name" + sTab.Substring(3); sSQLColumn = Room.sSQLRoomStatus; break; }

                    //case "TblPayWater":
                    //case "TblPayElectric": { sLockButton = true; break; }
                }
            }
            catch { }
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

                if (sTab == "TblPriceParking")
                {
                    this.ButAdd.Enabled = false;
                    this.ButDelete.Enabled = false;
                }
                if (this.sLockButton)
                {
                    this.c1TrueDBGrid1.AllowUpdate = false;
                    this.ButAdd.Enabled = false;
                    this.ButEdit.Enabled = false;
                    this.ButDelete.Enabled = false;
                    this.ButSave.Enabled = false;
                    this.ButCancel.Enabled = false;
                }
            }
            catch
            {
            }
        }

        private void frm_Load(object sender, EventArgs e)
        {
            if (!sTabF2) lblMess.Visible = false;   
            Set_sTabTable(sTabTable);
            Service.SetRegion(this.ComRegion);
            this.LoadList();

            if (sTab == "TblRoom")
            {            
                TVSSys.ItemCombobox objRegion = (TVSSys.ItemCombobox)ComRegion.SelectedItem;
                if (objRegion.Value != "0")
                    this.c1TrueDBGrid1.Columns["IDRegion"].FilterText = objRegion.Name;
                else
                    this.c1TrueDBGrid1.Columns["IDRegion"].FilterText = ""; 

                if (this.sTabRoomStatus != "") 
                    c1TrueDBGrid1.Columns["Status"].FilterText = this.sTabRoomStatus;
            }
        }

        #region LoadList

        BindingSource bindsrc = new BindingSource();
        private void LoadList()
        {
            try
            {
                sSQLQuery = "Select * " + sSQLColumn + " from " + sTab + sSQLWhere + sSQLOrder;
                objdata = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;
                Set_DBGrid(sTab);
                this.Set_ModeButton("Load");
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
                if (c1TrueDBGrid1.RowCount>0)
                    sTabF2ID = c1TrueDBGrid1.Columns[0].CellValue(c1TrueDBGrid1.Row).ToString();
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
                                    sTabF2ID = c1TrueDBGrid1.Columns[0].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.Close();
                            }
                            break;
                        }
                    case Keys.F2:
                        {
                            if ((sTabF2) && (!ButSave.Enabled))
                            {
                                sTabF2ID = c1TrueDBGrid1.Columns[0].CellValue(c1TrueDBGrid1.Row).ToString();
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

        private bool sAllowFilter=false; 
        private void c1TrueDBGrid1_FilterChange(object sender, EventArgs e)
        {
            try
            {
                string sWhere = "";
                this.sAllowFilter=false; 
                
                
                foreach (C1.Win.C1TrueDBGrid.C1DataColumn dc in this.c1TrueDBGrid1.Columns)
                {
                    if (dc.FilterText.Length > 0)
                    {
                        if (dc.DropDown!=null)
                            {
                                sAllowFilter = true;
                                break; 
                            }
                        
                        if (sWhere != "") sWhere += " AND ";
                        if (dc.DataType.ToString() != "System.String")
                            sWhere += dc.DataField + "=" + dc.FilterText;
                        else sWhere += dc.DataField + " LIKE '%" + dc.FilterText + "%'";
                    }
                }

                this.c1TrueDBGrid1.AllowFilter=sAllowFilter;

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
                        sTabF2ID = c1TrueDBGrid1.Columns[0].CellValue(c1TrueDBGrid1.Row).ToString();
                    this.Close();
                }
            }
            catch { }
        }

        #endregion

        #region c1TrueDBGrid1
        private void c1TrueDBGrid1_BeforeColUpdate(object sender, BeforeColUpdateEventArgs e)
        {
            if ((e.Column.DataColumn.DataField == sTabName) &&  (sTab!="TblRoom"))
            {
                if (TVSSys.GlobalModule.objCon.Get_EXESelectInt("SELECT " + sTabID + " FROM " + sTab + " WHERE UPPER(" + sTabName + ")=N'" + this.c1TrueDBGrid1.Columns[sTabName].Value.ToString().ToUpper() + "' ") != 0)
                {
                    MessageBox.Show("Lỗi." + this.c1TrueDBGrid1.Columns[sTabName].Caption + " này đã tồn tại !", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.c1TrueDBGrid1.Columns[sTabName].Value = "Cập nhật dữ liệu";
                    e.Cancel = true;
                }
            }
        }
        
        private void c1TrueDBGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if ((c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].DataType.Name == "DateTime") && (ButSave.Enabled) && (e.KeyCode == Keys.Delete))
                {
                    c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].Value = System.DBNull.Value;
                }

                if ((c1TrueDBGrid1.Splits[0].DisplayColumns[c1TrueDBGrid1.Col].Button == true) && (ButSave.Enabled) && (e.KeyCode == Keys.F2) && (sTab == "TblRoom") && (c1TrueDBGrid1.Columns[c1TrueDBGrid1.Col].DataField == "IDPartner"))
                {
                    int sCol = c1TrueDBGrid1.Col;
                    frmPartner objfrm = new frmPartner();
                    objfrm.sTabF2 = true;
                    objfrm.ShowDialog();
                    if (objfrm.sTabF2Edit)
                    {
                        clsG.CreateControlTrueDBDropdownPartner(c1TrueDBGrid1);
                    }
                    if (objfrm.sTabF2ID != "") this.c1TrueDBGrid1.Columns[sCol].Value = objfrm.sTabF2ID;
                    c1TrueDBGrid1.Col = c1TrueDBGrid1.Col - 1;
                    c1TrueDBGrid1.Col = c1TrueDBGrid1.Col + 1;


                    return;
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

        #endregion

        private void ComRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            TVSSys.ItemCombobox objRegion = (TVSSys.ItemCombobox)ComRegion.SelectedItem;
            if (objRegion.Value != "0")
                this.c1TrueDBGrid1.Columns["IDRegion"].FilterText = objRegion.Name;
            else
                this.c1TrueDBGrid1.Columns["IDRegion"].FilterText = "";
        }

        private void ButImport_Click(object sender, EventArgs e)
        {
            try
            {
                string strConnExcel;
                string fileName = "";
                DataTable objdataTable = new DataTable();
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "Excel files 2003 (*.xls)|*.xls"; //*.bmp,*.jpg,*.gif,*.tiff,*.png
                dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    fileName = dlg.FileName;
                }
                if (fileName == "") return;

                this.Cursor = Cursors.WaitCursor;

                DataSet dsExcel = new DataSet();
                int k = 0;

                strConnExcel = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=Excel 8.0;", fileName);
                OleDbDataAdapter myCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", strConnExcel);
                myCommand.Fill(dsExcel);
                objdataTable = dsExcel.Tables[0];
                if (objdataTable == null || objdataTable.Rows.Count == 0) return;

                string sNameError = "";
                int sIDPartner = 0;
                int sIDRegion = 0;
                int sIDRoomType = 0;
                int sIDPayWater = 0;
                int sIDPayElectric = 0;

                string sqlQuery = "";
                SqlConnection sqlCon = new SqlConnection();
                SqlCommand Cmd = new SqlCommand();

                for (int i = 0; i < objdataTable.Rows.Count; i++)
                {
                    if (objdataTable.Rows[i][3].ToString().Trim() != "")
                    {
                        if (TVSSys.GlobalModule.objCon.Get_EXESelect("select NameRoom from TblRoom where UPPER(CodeRoom)=N'" + objdataTable.Rows[i][2].ToString().Trim() + objdataTable.Rows[i][3].ToString().Trim() + "'") != "")
                        {
                            sNameError += objdataTable.Rows[i][3].ToString().Trim().Trim() + " ;\r\n  ";
                            continue;
                        }

                        sIDPartner = CheckValue(objdataTable.Rows[i][1].ToString().Trim());

                        sIDRegion = CheckValue(objdataTable.Rows[i][2].ToString().Trim(), "Region");
                        sIDRoomType = CheckValue(objdataTable.Rows[i][4].ToString().Trim(), "RoomType");
                        sIDPayWater = CheckValue(objdataTable.Rows[i][5].ToString().Trim(), "PayWater");
                        sIDPayElectric = CheckValue(objdataTable.Rows[i][6].ToString().Trim(), "PayElectric");

                        sqlCon = new SqlConnection(TVSSys.Connection.strConnection);
                        sqlCon.Open();
                        Cmd = sqlCon.CreateCommand();
                        sqlQuery = "INSERT INTO TblRoom ([CodeRoom],[NameRoom],[IDPartner],[IDRegion],[IDRoomType],[IDPayWater],[IDPayElectric],[DateBegin],[Action])" +
                                    "           VALUES(@CodeRoom,@NameRoom,@IDPartner,@IDRegion,@IDRoomType,@IDPayWater,@IDPayElectric,getdate(),1)  ";
                        Cmd.CommandText = sqlQuery;
                        Cmd.Parameters.Add("@CodeRoom", SqlDbType.NVarChar, 50).Value = objdataTable.Rows[i][2].ToString().Trim() + objdataTable.Rows[i][3].ToString().Trim();
                        Cmd.Parameters.Add("@NameRoom", SqlDbType.NVarChar, 250).Value = objdataTable.Rows[i][3].ToString().Trim();
                        Cmd.Parameters.Add("@IDPartner", SqlDbType.Int).Value = sIDPartner;
                        Cmd.Parameters.Add("@IDRegion", SqlDbType.Int).Value = sIDRegion;
                        Cmd.Parameters.Add("@IDRoomType", SqlDbType.Int).Value = sIDRoomType;
                        Cmd.Parameters.Add("@IDPayWater", SqlDbType.Int).Value = sIDPayWater;
                        Cmd.Parameters.Add("@IDPayElectric", SqlDbType.Int).Value = sIDPayElectric;
                        Cmd.ExecuteNonQuery();
                        sqlCon.Close();
                        sqlCon.Dispose();

                        k++;
                    }
                }
                MessageBox.Show("Cập nhật " + k.ToString() + " phòng thành công !");
                if (sNameError != "")
                    MessageBox.Show("Lỗi: Các phòng không cập nhật được. \r\n" + sNameError, "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Service.SetRegion(this.ComRegion);
                this.LoadList();

                TVSSys.ItemCombobox objRegion = (TVSSys.ItemCombobox)ComRegion.SelectedItem;
                if (objRegion.Value != "0")
                    this.c1TrueDBGrid1.Columns["IDRegion"].FilterText = objRegion.Name;
                else
                    this.c1TrueDBGrid1.Columns["IDRegion"].FilterText = "";

                if (this.sTabRoomStatus != "")
                    c1TrueDBGrid1.Columns["Status"].FilterText = this.sTabRoomStatus;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật dữ liệu !" + ex.ToString(), "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private int CheckValue(string tName, string tTableName)
        {
            int tmp = 0;
            if (tName == "")
                tName = "Mặc định";
            try
            {
                try
                {
                    tmp = TVSSys.GlobalModule.objCon.Get_EXESelectInt("select ID" + tTableName + " from Tbl" + tTableName + " where UPPER(Name" + tTableName + ")=N'" + tName.Trim().ToUpper() + "'");
                }
                catch { }
                if (tmp == 0)
                {
                    TVSSys.GlobalModule.objCon.EXEUpdate("Insert into  Tbl" + tTableName + "(Name" + tTableName + ") VALUES (N'" + tName.Trim() + "')");
                    tmp = TVSSys.GlobalModule.objCon.Get_EXESelectInt("select MAX(ID" + tTableName + ") from Tbl" + tTableName + " where UPPER(Name" + tTableName + ")=N'" + tName.Trim().ToUpper() + "'");
                }
            }
            catch { }
            return tmp;
        }
        private int CheckValue(string tName)
        {
            int tmp = 0;
            if (tName == "")
                tName = "Mặc định";
            try
            {
                if (tName != "")
                {
                    TVSSys.GlobalModule.objCon.EXEUpdate("Insert into  TblPartner (ContactPerson) VALUES (N'" + tName + "')");
                    tmp = TVSSys.GlobalModule.objCon.Get_EXESelectInt("select MAX(IDPartner) from TblPartner where UPPER(ContactPerson)=N'" + tName.ToUpper() + "'");
                }
            }
            catch { }
            return tmp;
        }
    }
}