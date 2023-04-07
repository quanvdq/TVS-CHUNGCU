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
using TVSSys;

namespace TVSMain
{
    public partial class frmServiceUsed : Form
    {
        #region method Declare ...
        public string sTabTable = "";
        private string sTab = "TblService";
        private string sTabID = "IDService", sTabName = "IDRoom";
        private string sTabService = "Parking";
        private DataTable objdata = new DataTable();
        private clsGridView clsG = new clsGridView();
        private string sSQLQuery = "";
        private bool sLoading = true;
        private bool EditServiceParking, EditServiceWater, EditServiceElectric, EditServiceUsed;
        private Service objService = new Service();
        #endregion

        #region method frmServiceUsed
        public frmServiceUsed()
        {
            InitializeComponent();

            TVSUtil.Reports.Export.ContextMenu(this.c1TrueDBGrid1);
        }
        #endregion

        #region Mothod FromCode
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!this.setPermission())
            {
                MessageBox.Show("Bạn không có quyền cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TVSSys.ItemCombobox objTime= (TVSSys.ItemCombobox)ComTime.SelectedItem;
            sSQLQuery = "INSERT INTO " + sTab + "(Time,IDRoom,IDPartner,MoneyPublic,MoneyOther)" +
                     " SELECT " + objTime.Value + ",IDRoom,IDPartner,isnull((SELECT isnull(Money,0) FROM TblRoomType WHERE TblRoomType.IDRoomType=TblRoom.IDRoomType),0) " +
                     ",isnull((SELECT isnull(MoneyOther,0) FROM " + sTab + " WHERE TblRoom.IDRoom=" + sTab + ".IDRoom AND " + sTab + ".Time='" + Service.SetTimePrevious(objTime.Value) + "'),0) " +
                     " FROM TblRoom  WHERE isnull(Action,0)=1 " +
                     " AND IDRoom NOT IN (SELECT IDRoom FROM " + sTab + " WHERE Time='" + objTime.Value + "')" +
                     "";
            if (TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery))
            {

                string SQL1 = "UPDATE TblService SET MoneyPublic = (";
                SQL1 += "SELECT Money FROM dbo.TblRoomType WHERE IDRoomType = (SELECT TOP 1 IDRoomType FROM TblRoom WHERE TblRoom.IDRoom = TblService.IDRoom AND Time = '"+ objTime.Value + "'))";
                SQL1 += "WHERE Time = N'"+ objTime.Value + "' AND ISNULL(MoneyPublic,0) = 0";

                TVSSys.GlobalModule.objCon.EXEUpdate(SQL1);

                MessageBox.Show("Dữ liệu của bạn được cập nhật thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadList(); 
            }
            else
                MessageBox.Show("Dữ liệu của bạn cập nhật không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!this.setPermission())
            {
                MessageBox.Show("Bạn không có quyền cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.ButFocus.Focus();
            if (objdata.GetChanges() == null)
            {
                MessageBox.Show("Dữ liệu của bạn chưa có sự thay đổi!.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable sDataService = new DataTable();
            if (sTabService == "Service")
                sDataService = objdata.GetChanges();


            if (TVSSys.GlobalModule.objCon.EXEUpdate(sSQLQuery, objdata))
            {
                string sID = c1TrueDBGrid1.Columns[0].CellValue(c1TrueDBGrid1.Row).ToString();
                TVSSys.ItemCombobox objTime = (TVSSys.ItemCombobox)ComTime.SelectedItem;
                Service.Calculator(sTabService, objTime.Value);
                if (sTabService == "Service") Service.PaymentVoucher(sDataService);
                this.LoadList();
                int i = 0;
                for (i = 0; i < c1TrueDBGrid1.RowCount; i++)
                {
                    if (sID == c1TrueDBGrid1.Columns[0].CellValue(i).ToString()) break;
                }
                c1TrueDBGrid1.Row = i;
                c1TrueDBGrid1.Select();
                MessageBox.Show("Dữ liệu của bạn được cập nhật thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void c1TrueDBGrid1_Error(object sender, C1.Win.C1TrueDBGrid.ErrorEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("Lỗi: Dữ liệu nhập vào chưa đúng định dạng!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                            if (sTabService == "Service")
                            {
                                this.c1TrueDBGrid1.AllowUpdate = true;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["Printer"].Locked = false;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayPublic"].Locked = true;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayParking"].Locked = true;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayWater"].Locked = true;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayElectric"].Locked = true;
                                //c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayOther"].Locked = true;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["PayAll"].Locked = true;

                                this.chkPrinter.Enabled = true;
                            }
                               
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

                            if (sTabService == "Service")
                            {
                                c1TrueDBGrid1.Splits[0].DisplayColumns["Printer"].Locked = true;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayPublic"].Locked = false;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayParking"].Locked = false;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayWater"].Locked = false;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayElectric"].Locked = false;
                                //c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyPayOther"].Locked = false;
                                c1TrueDBGrid1.Splits[0].DisplayColumns["PayAll"].Locked = false;

                                this.chkPrinter.Enabled = false;
                            }
                            break;
                        }
                }
            }
            catch { }
        }

        private void frm_Load(object sender, EventArgs e)
        {
            this.objService.getPermisstionOfUser(frmLogin._UserName, ref EditServiceParking, ref EditServiceWater, ref EditServiceElectric, ref EditServiceUsed);
            Service.SetRegion(this.ComRegion);
            Service.SetTime(this.ComTime);
            switch (sTabTable)
            {
                case "DỊCH VỤ TRÔNG XE":
                    {
                        sTabService = "Parking";
                        this.ButPrint.Visible = false;
                        this.ButPrintPay.Visible = false;
                        this.ButPrintList.Visible = false;
                        this.chkPrinter.Visible = false;
                        this.toolStripSeparator3.Visible = false;
                        this.toolStripSeparator4.Visible = false;
                        this.toolStripSeparator5.Visible = false;
                        this.btnSendNotification.Visible = false;
                        this.ButAdd.Enabled = this.EditServiceParking;
                        this.ButEdit.Enabled = this.EditServiceParking;
                        this.ButDelete.Enabled = this.EditServiceParking;
                        this.ButSave.Enabled = this.EditServiceParking;
                        break;
                    }
                case "NƯỚC SINH HOẠT":
                    {
                        sTabService = "Water";
                        this.ButPrint.Visible = false;
                        this.ButPrintPay.Visible = false;
                        this.ButPrintList.Visible = false;
                        this.chkPrinter.Visible = false;
                        this.toolStripSeparator3.Visible = false;
                        this.toolStripSeparator4.Visible = false;
                        this.toolStripSeparator5.Visible = false;
                        this.btnSendNotification.Visible = false;
                        this.ButAdd.Enabled = this.EditServiceWater;
                        this.ButEdit.Enabled = this.EditServiceWater;
                        this.ButDelete.Enabled = this.EditServiceWater;
                        this.ButSave.Enabled = this.EditServiceWater;
                        break;
                    }
                case "ĐIỆN SINH HOẠT":
                    {
                        sTabService = "Electric";
                        this.ButPrint.Visible = false;
                        this.ButPrintPay.Visible = false;
                        this.ButPrintList.Visible = false;
                        this.chkPrinter.Visible = false;
                        this.toolStripSeparator3.Visible = false;
                        this.toolStripSeparator4.Visible = false;
                        this.toolStripSeparator5.Visible = false;
                        this.btnSendNotification.Visible = false;
                        this.ButAdd.Enabled = this.EditServiceElectric;
                        this.ButEdit.Enabled = this.EditServiceElectric;
                        this.ButDelete.Enabled = this.EditServiceElectric;
                        this.ButSave.Enabled = this.EditServiceElectric;
                        break;
                    }
                case "TỔNG HỢP CHI PHÍ":
                case "TỔNG HỢP CHI PHÍ SỬ DỤNG":
                    {
                        sTabService = "Service";
                        this.ButBalances.Visible = false;
                        this.ButCalculator.Visible = false;
                        this.ComReportTitle.Visible = true;
                        this.ButAdd.Enabled = this.EditServiceUsed;
                        this.ButEdit.Enabled = this.EditServiceUsed;
                        this.ButDelete.Enabled = this.EditServiceUsed;
                        this.ButSave.Enabled = this.EditServiceUsed;
                        break;
                    }
            }

            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO TỔNG HỢP CHI PHÍ", "0"));
            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO CHI PHÍ ĐÃ NỘP ĐỦ TRONG KỲ", "1"));
            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO CHI PHÍ CHƯA NỘP TRONG KỲ", "2"));
            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO CHI PHÍ CÒN NỢ TRONG KỲ", "3"));
            ComReportTitle.SelectedIndex = 0;

            sLoading = false;
            this.LoadList();
        }

        private bool setPermission()
        {
            bool tmpValue = true;
            this.objService.getPermisstionOfUser(frmLogin._UserName, ref EditServiceParking, ref EditServiceWater, ref EditServiceElectric, ref EditServiceUsed);
            switch (sTabTable)
            {
                case "DỊCH VỤ TRÔNG XE":
                    {
                        if (!this.EditServiceParking)
                        {
                            tmpValue = false;
                        }
                        break;
                    }
                case "NƯỚC SINH HOẠT":
                    {
                        if (!this.EditServiceWater)
                        {
                            tmpValue = false;
                        }
                        break;
                    }
                case "ĐIỆN SINH HOẠT":
                    {
                        if (!this.EditServiceElectric)
                        {
                            tmpValue = false;
                        }
                        break;
                    }
                case "TỔNG HỢP CHI PHÍ":
                case "TỔNG HỢP CHI PHÍ SỬ DỤNG":
                    {
                        if (!this.EditServiceUsed)
                        {
                            tmpValue = false;
                        }
                        break;
                    }
            }
            return tmpValue;
        }

        #region method LoadList
        BindingSource bindsrc = new BindingSource();
        private void LoadList()
        {
            try
            {
                if (this.sLoading)
                    return;

                this.Cursor = Cursors.WaitCursor;

                string sSQLWhere = "";
                TVSSys.ItemCombobox objTime = (TVSSys.ItemCombobox)ComTime.SelectedItem;
                TVSSys.ItemCombobox objRegion = (TVSSys.ItemCombobox)ComRegion.SelectedItem;

                if (objRegion.Value != "0")
                    sSQLWhere = " AND IDRoom IN (SELECT IDRoom FROM TblRoom WHERE IDRegion = " + objRegion.Value + ") ";

                switch (ComReportTitle.SelectedIndex)
                {
                    case 1: { sSQLWhere += " AND isnull(MoneyService,0) <> 0 AND isnull(MoneyService,0) = isnull(MoneyPayService,0) "; break; }
                    case 2: { sSQLWhere += " AND isnull(MoneyService,0) <> 0 AND isnull(MoneyPayService,0) = 0 "; break; }
                    case 3: { sSQLWhere += " AND isnull(MoneyService,0) <> 0 AND isnull(MoneyService,0) > isnull(MoneyPayService,0) "; break; }
                }

                string ListColumn = "";
                ListColumn += "[IDService]";
                ListColumn += ",[Time]";
                ListColumn += ",[IDRoom]";
                ListColumn += ",[DateBegin]";
                ListColumn += ",[DateEnd]";
                ListColumn += ",[MoneyPublic]";
                ListColumn += ",[IDPriceParking1]";
                ListColumn += ",[IDPriceParking2]";
                ListColumn += ",[IDPriceParking3]";
                ListColumn += ",[IDPriceParking4]";
                ListColumn += ",[IDPriceParking5]";
                ListColumn += ",[IDPriceParking6]";
                ListColumn += ",[IDPriceParking7]";
                ListColumn += ",[IDPriceParking8]";
                ListColumn += ",[IDPriceParking9]";
                ListColumn += ",[MoneyParking]";
                ListColumn += ",[NoteParking]";
                ListColumn += ",[NumberBeginWater]";
                ListColumn += ",[NumberEndWater]";
                ListColumn += ",[NumberWater]";
                ListColumn += ",[MoneyWater]";
                ListColumn += ",[NumberBeginElectric]";
                ListColumn += ",[NumberEndElectric]";
                ListColumn += ",[NumberElectric]";
                ListColumn += ",[MoneyElectric]";
                ListColumn += ",[MoneyOther]";
                ListColumn += ",([MoneyDebt] + ISNULL(((SELECT TOP 1 MoneyDebtBalancer FROM TblService A WHERE CAST(A.Time AS int) < CAST(TblService.Time AS int) AND A.IDRoom = TblService.IDRoom ORDER BY CAST(A.Time AS int) DESC )),0) ) AS MoneyDebt";
                ListColumn += ",[MoneyService]";
                ListColumn += ",[PayAll]";
                ListColumn += ",[MoneyPayPublic]";
                ListColumn += ",[MoneyPayParking]";
                ListColumn += ",[MoneyPayWater]";
                ListColumn += ",[MoneyPayElectric]";
                ListColumn += ",[MoneyPayOther]";
                ListColumn += ",[MoneyPayDebt]";
                ListColumn += ",[MoneyPayService]";
                ListColumn += ",[MoneyDebtBalancer]";
                ListColumn += ",[Note]";
                ListColumn += ",[IDPartner]";
                ListColumn += ",[Lock]";
                ListColumn += ",[SentNotification]";
                ListColumn += ",[SentNotificationTime]";
                ListColumn += ",[SentNotificationRead]";
                ListColumn += ",[SentNotificationReadTime]";
                ListColumn += ",[PaymentByMomo]";
                ListColumn += ",[PaymentByMomoTime]";

                sSQLQuery = "Select " + ListColumn + ", (SELECT isnull(IDRegion,0) FROM TblRoom WHERE TblRoom.IDRoom=" + sTab + ".IDRoom) as IDRegion" +
                            " from " + sTab +
                            " Where Time='" + objTime.Value + "'" + sSQLWhere +
                            " ORDER BY (SELECT NameRoom FROM TblRoom WHERE TblRoom.IDRoom=" + sTab + ".IDRoom)";
                objdata = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);
                if (sTabService == "Service")
                    objdata.Columns.Add("Printer", System.Type.GetType("System.Boolean"));

                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;
                clsG.ServiceUsed(sTabService, this.c1TrueDBGrid1);
                this.Set_ModeButton("Load");
                double sMoney = 0, sMoneyPublic = 0, sMoneyParking = 0, sMoneyWater = 0;
                for (int i = 0; i < this.c1TrueDBGrid1.RowCount; i++)
                {
                    try
                    {
                        sMoney += double.Parse(c1TrueDBGrid1.Columns["Money" + sTabService].CellValue(i).ToString());
                    }
                    catch { }

                    try
                    {
                        sMoneyPublic += double.Parse(c1TrueDBGrid1.Columns["MoneyPublic"].CellValue(i).ToString());
                    }
                    catch { }

                    try
                    {
                        sMoneyParking += double.Parse(c1TrueDBGrid1.Columns["MoneyParking"].CellValue(i).ToString());
                    }
                    catch { }

                    try
                    {
                        sMoneyWater += double.Parse(c1TrueDBGrid1.Columns["MoneyWater"].CellValue(i).ToString());
                    }
                    catch { }

                    string strPaymentByMomo = c1TrueDBGrid1.Columns["PaymentByMomo"].CellValue(i).ToString();
                    if (strPaymentByMomo.Trim() != "")
                    {
                        if (strPaymentByMomo.Trim().ToUpper() == "TRUE")
                        {
                            this.c1TrueDBGrid1.Splits[0].DisplayColumns["MoneyOther"].Locked = true;
                        }
                    }
                }

                if (sTabService != "Service")
                {
                    this.LblMess.Text = "";
                    return;
                }

                this.LblMess.Text = "Phí chung cư:  " + sMoneyPublic.ToString("#,##0") + ". ";
                this.LblMess.Text += "Tiền gửi xe:  " + sMoneyParking.ToString("#,##0") + ". ";
                this.LblMess.Text += "Tiền nước:  " + sMoneyWater.ToString("#,##0") + ". ";
                this.LblMess.Text += "Tổng thành tiền:  " + sMoney.ToString("#,##0") + ". ";

                if (sTabService == "Service")
                {
                    sMoney = 0;
                    for (int i = 0; i < this.c1TrueDBGrid1.RowCount; i++)
                    {
                        try
                        {
                            sMoney += double.Parse(c1TrueDBGrid1.Columns["MoneyPayService"].CellValue(i).ToString());
                        }
                        catch { }
                    }
                    this.LblMess.Text += "Tổng thanh toán:  " + sMoney.ToString("#,##0") + " VNĐ.";
                }


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
            if (!this.setPermission())
            {
                MessageBox.Show("Bạn không có quyền cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Bạn chắc chắn muốn xóa thông tin này ?...", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            if (TVSSys.GlobalModule.objCon.EXEUpdate("Delete from " + sTab + "  Where " + sTabID + "=" + c1TrueDBGrid1.Columns[sTabID].CellValue(c1TrueDBGrid1.Row)))
            {
                MessageBox.Show("Xóa thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadList();
            }
            else MessageBox.Show("Lỗi, xóa không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!this.setPermission())
            {
                MessageBox.Show("Bạn không có quyền cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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
                        //if (dc.DataType.ToString() != "System.String") sWhere += dc.DataField + "=" + dc..FilterText;
                        //else 
                            
                            sWhere += dc.DataField + " LIKE '%" + dc.FilterText + "%'";
                    }
                }
                this.objdata.DefaultView.RowFilter = sWhere;
            }
            catch { return; }
        } 
        #endregion

        #region method c1TrueDBGrid1
        private void c1TrueDBGrid1_BeforeColUpdate(object sender, BeforeColUpdateEventArgs e)
        {
            if (e.Column.DataColumn.DataField == sTabName)
            {
                if (TVSSys.GlobalModule.objCon.Get_EXESelectInt("SELECT " + sTabID + " FROM " + sTab + " WHERE UPPER(" + sTabName + ")=N'" + this.c1TrueDBGrid1.Columns[sTabName].Value.ToString().ToUpper() + "' ") != 0)
                {
                    MessageBox.Show("Lỗi." + this.c1TrueDBGrid1.Columns[sTabName].Caption + " này đã tồn tại !", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.c1TrueDBGrid1.Columns[sTabName].Value = "Cập nhật dữ liệu";
                    e.Cancel = true;
                }
            }
        }

        double sMoneyPublic = 0, sMoneyParking = 0, sMoneyWater = 0, sMoneyElectric = 0, sMoneyOther = 0, sMoneyDebt = 0;

        double sMoneyPayPublic = 0, sMoneyPayParking = 0, sMoneyPayWater = 0, sMoneyPayElectric = 0, sMoneyPayService = 0, sMoneyPayDebt = 0;

        private void c1TrueDBGrid1_AfterColUpdate(object sender, ColEventArgs e)
        {
            try
            {
                string sDataField = e.Column.DataColumn.DataField.ToString();
                switch (sDataField)
                {
                    case "MoneyDebt":
                        {
                            if (c1TrueDBGrid1.Columns["MoneyPublic"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
                            {
                                try
                                {
                                    sMoneyPublic = double.Parse(c1TrueDBGrid1.Columns["MoneyPublic"].CellValue(c1TrueDBGrid1.Row).ToString());
                                }
                                catch { sMoneyPublic = 0; }
                            }

                            if (c1TrueDBGrid1.Columns["MoneyParking"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
                            {
                                try
                                {
                                    sMoneyParking = double.Parse(c1TrueDBGrid1.Columns["MoneyParking"].CellValue(c1TrueDBGrid1.Row).ToString());
                                }
                                catch { sMoneyParking = 0; }
                            }

                            if (c1TrueDBGrid1.Columns["MoneyWater"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
                            {
                                try
                                {
                                    sMoneyWater = double.Parse(c1TrueDBGrid1.Columns["MoneyWater"].CellValue(c1TrueDBGrid1.Row).ToString());
                                }
                                catch { sMoneyWater = 0; }
                            }

                            if (c1TrueDBGrid1.Columns["MoneyElectric"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
                            {
                                try
                                {
                                    sMoneyElectric = double.Parse(c1TrueDBGrid1.Columns["MoneyElectric"].CellValue(c1TrueDBGrid1.Row).ToString());
                                }
                                catch { sMoneyElectric = 0; }
                            }

                            if (c1TrueDBGrid1.Columns["MoneyOther"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
                            {
                                try
                                {
                                    sMoneyOther = double.Parse(c1TrueDBGrid1.Columns["MoneyOther"].CellValue(c1TrueDBGrid1.Row).ToString());
                                }
                                catch { sMoneyOther = 0; }
                            }

                            if (c1TrueDBGrid1.Columns["MoneyDebt"].CellValue(c1TrueDBGrid1.Row).ToString() != "")
                            {
                                try
                                {
                                    sMoneyDebt = double.Parse(c1TrueDBGrid1.Columns["MoneyDebt"].CellValue(c1TrueDBGrid1.Row).ToString());
                                }
                                catch { sMoneyDebt = 0; }
                            }
                            this.c1TrueDBGrid1.Columns["MoneyService"].Value
                                = sMoneyPublic + sMoneyParking + sMoneyWater + sMoneyElectric + sMoneyOther + sMoneyDebt;
                            break;
                        }
                    case "PayAll":
                        {
                            if (c1TrueDBGrid1.Columns["PayAll"].CellValue(c1TrueDBGrid1.Row).ToString() == "True")
                            {
                                this.c1TrueDBGrid1.Columns["MoneyPayPublic"].Value = c1TrueDBGrid1.Columns["MoneyPublic"].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.c1TrueDBGrid1.Columns["MoneyPayParking"].Value = c1TrueDBGrid1.Columns["MoneyParking"].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.c1TrueDBGrid1.Columns["MoneyPayWater"].Value = c1TrueDBGrid1.Columns["MoneyWater"].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.c1TrueDBGrid1.Columns["MoneyPayElectric"].Value = c1TrueDBGrid1.Columns["MoneyElectric"].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.c1TrueDBGrid1.Columns["MoneyPayService"].Value = c1TrueDBGrid1.Columns["MoneyService"].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.c1TrueDBGrid1.Columns["MoneyPayOther"].Value = c1TrueDBGrid1.Columns["MoneyOther"].CellValue(c1TrueDBGrid1.Row).ToString();
                                this.c1TrueDBGrid1.Columns["MoneyPayDebt"].Value = c1TrueDBGrid1.Columns["MoneyDebt"].CellValue(c1TrueDBGrid1.Row).ToString();    
                            }
                            break; ;
                        }
                    case "MoneyPayPublic":
                    case "MoneyPayParking":
                    case "MoneyPayWater":
                    case "MoneyPayElectric":
                    case "MoneyPayService":
                    case "MoneyPayDebt":
                        {
                            try
                            {
                                if (c1TrueDBGrid1.Columns["MoneyPayPublic"].CellValue(c1TrueDBGrid1.Row).ToString() != c1TrueDBGrid1.Columns["MoneyPublic"].CellValue(c1TrueDBGrid1.Row).ToString())
                                    this.c1TrueDBGrid1.Columns["PayAll"].Value = 0;
                                if (c1TrueDBGrid1.Columns["MoneyPayParking"].CellValue(c1TrueDBGrid1.Row).ToString() != c1TrueDBGrid1.Columns["MoneyParking"].CellValue(c1TrueDBGrid1.Row).ToString())
                                    this.c1TrueDBGrid1.Columns["PayAll"].Value = 0;
                                if (c1TrueDBGrid1.Columns["MoneyPayWater"].CellValue(c1TrueDBGrid1.Row).ToString() != c1TrueDBGrid1.Columns["MoneyWater"].CellValue(c1TrueDBGrid1.Row).ToString())
                                    this.c1TrueDBGrid1.Columns["PayAll"].Value = 0;
                                if (c1TrueDBGrid1.Columns["MoneyPayElectric"].CellValue(c1TrueDBGrid1.Row).ToString() != c1TrueDBGrid1.Columns["MoneyElectric"].CellValue(c1TrueDBGrid1.Row).ToString())
                                    this.c1TrueDBGrid1.Columns["PayAll"].Value = 0;
                                if (c1TrueDBGrid1.Columns["MoneyPayService"].CellValue(c1TrueDBGrid1.Row).ToString() != c1TrueDBGrid1.Columns["MoneyService"].CellValue(c1TrueDBGrid1.Row).ToString())
                                    this.c1TrueDBGrid1.Columns["PayAll"].Value = 0;
                            }
                            catch { }
                            #region Check
                            try
                            {
                                sMoneyPayPublic = double.Parse(c1TrueDBGrid1.Columns["MoneyPayPublic"].CellValue(c1TrueDBGrid1.Row).ToString());
                            }
                            catch { sMoneyPayPublic = 0; }

                            try
                            {
                                sMoneyPayParking = double.Parse(c1TrueDBGrid1.Columns["MoneyPayParking"].CellValue(c1TrueDBGrid1.Row).ToString());
                            }
                            catch { sMoneyPayParking = 0; }

                            try
                            {
                                sMoneyPayWater = double.Parse(c1TrueDBGrid1.Columns["MoneyPayWater"].CellValue(c1TrueDBGrid1.Row).ToString());
                            }
                            catch { sMoneyPayWater = 0; }

                            try
                            {
                                sMoneyPayElectric = double.Parse(c1TrueDBGrid1.Columns["MoneyPayElectric"].CellValue(c1TrueDBGrid1.Row).ToString());
                            }
                            catch { sMoneyPayElectric = 0; }

                            try
                            {
                                sMoneyPayDebt = double.Parse(c1TrueDBGrid1.Columns["MoneyPayDebt"].CellValue(c1TrueDBGrid1.Row).ToString());
                            }
                            catch { sMoneyPayDebt = 0; }

                            sMoneyPayService = sMoneyPayPublic + sMoneyPayParking + sMoneyPayWater + sMoneyPayElectric + sMoneyPayDebt;

                            #endregion
                            this.c1TrueDBGrid1.Columns["MoneyPayService"].Value = sMoneyPayService;
                            break;
                        }
                }
            }
            catch { }
        }
        #endregion

        #region method ComTime_SelectedIndexChanged
        private void ComTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadList();
        }
        #endregion

        #region method ButBalances_Click
        private void ButBalances_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn cập nhật số dư đầu kỳ ?...", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) != DialogResult.Yes) return;
            TVSSys.ItemCombobox objTime = (TVSSys.ItemCombobox)ComTime.SelectedItem;
            if (Service.Balances(sTabService, objTime.Value))
            {
                MessageBox.Show("Cập nhật thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadList();
            }
            else MessageBox.Show("Lỗi, Cập nhật không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region method ButCalculator_Click
        private void ButCalculator_Click(object sender, EventArgs e)
        {
            TVSSys.ItemCombobox objTime = (TVSSys.ItemCombobox)ComTime.SelectedItem;
            if (Service.Calculator(sTabService, objTime.Value))
            {
                MessageBox.Show("Cập nhật thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.LoadList();
            }
            else MessageBox.Show("Lỗi, Cập nhật không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion

        #region method ButPrint_Click
        private void ButPrint_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (c1TrueDBGrid1.RowCount == 0) return;
                DataTable objService = new DataTable();
                objService.Columns.Add("IDService", System.Type.GetType("System.String"));
                for (int i = 0; i < c1TrueDBGrid1.RowCount; i++)
                {
                    if (c1TrueDBGrid1.Columns["Printer"].CellValue(i).ToString() == "True")
                        objService.Rows.Add(c1TrueDBGrid1.Columns["IDService"].CellValue(i).ToString());
                }
                if (objService.Rows.Count == 0)
                {
                    MessageBox.Show("Lỗi, Bạn chưa chọn dữ liệu cần In!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string sReportType = "A5";
                if (TVSSys.GlobalModule.objXML.GetKey("ReportNotify") == "1") sReportType = "A4";

                TVSReports.rptNotify.srptNoteTime = ComTime.Text;
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = "Notify" + sReportType;
                objReport.srptTable = objService;
                objReport.ShowDialog();
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region method chkPrinter_CheckedChanged
        private void chkPrinter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.c1TrueDBGrid1.MoveFirst();
                for (int j = 0; j < this.c1TrueDBGrid1.RowCount; j++)
                {
                    this.c1TrueDBGrid1.Columns["Printer"].Value = chkPrinter.Checked;
                    this.c1TrueDBGrid1.MoveNext();
                }
            }
            catch { }
        }
        #endregion

        #region method ButPrintPay_Click
        private void ButPrintPay_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                if (c1TrueDBGrid1.RowCount == 0) return;
                DataTable objService = new DataTable();
                objService.Columns.Add("IDService", System.Type.GetType("System.String"));
                for (int i = 0; i < c1TrueDBGrid1.RowCount; i++)
                {
                    if (c1TrueDBGrid1.Columns["Printer"].CellValue(i).ToString() == "True")
                        objService.Rows.Add(c1TrueDBGrid1.Columns["IDService"].CellValue(i).ToString());
                }
                if (objService.Rows.Count == 0)
                {
                    MessageBox.Show("Lỗi, Bạn chưa chọn dữ liệu cần In!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
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

                TVSReports.rptPaymentVoucher.srptTitle = "PHIẾU THU TIỀN MẶT";            
                TVSReports.rptPaymentVoucher.srptService = false;
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = "PaymentVoucher" + sReportType;   
                objReport.srptTable = objService;
                objReport.ShowDialog();
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region method ButPrintList_Click
        private void ButPrintList_Click(object sender, EventArgs e)
        {
            try
            {
                
                this.Cursor = Cursors.WaitCursor;
                if (c1TrueDBGrid1.RowCount == 0) return;
                TVSReports.rptServiceList.srptTitle = this.ComReportTitle.Text.ToUpper();
                TVSReports.rptServiceList.srptTitleDescription = this.ComTime.Text;

                TVSSys.ItemCombobox objRegion = (TVSSys.ItemCombobox)ComRegion.SelectedItem;
                if (objRegion.Value != "0")
                    TVSReports.rptServiceList.srptTitleDescription += ". Khu vực: " + objRegion.Name.ToUpper(); 

                TVSReports.rptServiceList.srptTable =clsG.Get_DataView(this.c1TrueDBGrid1);

                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;

                objReport.srptType = "ServiceListM1";
                objReport.ShowDialog();
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        #endregion

        #region method btnSendNotification_Click
        private void btnSendNotification_Click(object sender, EventArgs e)
        {
            frmSendNotification objfrmSendNotification = new frmSendNotification();
            objfrmSendNotification.ShowDialog();
        }
        #endregion

        #region method c1TrueDBGrid1_FetchRowStyle
        private void c1TrueDBGrid1_FetchRowStyle(object sender, FetchRowStyleEventArgs e)
        {
            if (c1TrueDBGrid1[e.Row, "PaymentByMomo"] != null)
            {
                string strPaymentByMomo = c1TrueDBGrid1[e.Row, "PaymentByMomo"].ToString();
                if (strPaymentByMomo.Trim().ToUpper() == "TRUE")
                {
                    e.CellStyle.Locked = true;
                }
            }
        }
        #endregion
    }
}