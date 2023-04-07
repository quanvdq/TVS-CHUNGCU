using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;

namespace TVSReports
{
    public partial class frmReport : Form
    {
        #region method Declare ...
        public string sTabTable = "";
        private DataTable objdata = new DataTable();
        private DataTable objdatareport = new DataTable();
        private TVSMain.clsGridView objGv = new TVSMain.clsGridView();
        private TVSMain.clsPublic objPb = new TVSMain.clsPublic();     
        private bool sLoading = true; 
        #endregion

        public frmReport()
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
            this.Cursor = Cursors.WaitCursor;

            this.dtpBegin.Value = new DateTime(this.dtpEnd.Value.Year, this.dtpEnd.Value.Month, 1);    
            TVSMain.Service.SetRegion(this.ComRegion);

            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO CÔNG NỢ KHÁCH HÀNG ĐỐI TÁC", "0"));
            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO CÔNG NỢ ĐÃ NỘP ĐỦ TRONG KỲ", "1"));
            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO CÔNG NỢ CÒN NỢ TRONG KỲ", "2"));
            ComReportTitle.Items.Add(new TVSSys.ItemCombobox("BÁO CÁO CÔNG NỢ CÒN NỢ CUỐI KỲ", "3"));
            ComReportTitle.SelectedIndex = 0;

            this.sLoading = false; 
        }

        #region LoadList

        BindingSource bindsrc = new BindingSource();
        private void LoadList()
        {
            try
            {
                if (sLoading) 
                    return; 

                this.Cursor = Cursors.WaitCursor;

                TVSSys.ItemCombobox objRegion = (TVSSys.ItemCombobox)ComRegion.SelectedItem;
                string sWhere = "";
                if (objRegion.Value != "0")
                    sWhere = " WHERE isnull(TblRoom.IDRegion,0)=" + objRegion.Value;

                string sSQLQuery = "SELECT TblPartner.IDPartner,ContactPerson, TblRoom.NameRoom,ContactPhone,Address" +
                    //",(SELECT SUM(MoneyService) FROM TblService where TblService.IDPartner=TblPartner.IDPartner) as MoneyService " +
                    //",(SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=1)  as 'Thu'  " +
                    //",(SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=2)  as 'Chi' " +

                    ",(ISNULL((SELECT SUM(MoneyService) FROM TblService where TblService.IDPartner=TblPartner.IDPartner AND ((TblService.Time + '01')< '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' )),0)  " + // as MoneyService
                    " - ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=1 AND (convert(nvarchar,DatePaymentVoucher,112)<'" + this.dtpBegin.Value.ToString("yyyyMMdd") + "') ),0)  " + //  as 'Thu'
                    " + ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=2 AND (convert(nvarchar,DatePaymentVoucher,112)<'" + this.dtpBegin.Value.ToString("yyyyMMdd") + "') ),0)  ) as BalanceFirst" + // as 'Chi'

                    ",(ISNULL((SELECT SUM(MoneyService) FROM TblService where TblService.IDPartner=TblPartner.IDPartner AND ((TblService.Time + '01') between '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' AND '" + this.dtpEnd.Value.ToString("yyyyMMdd") + "' )),0)  " + // as MoneyService                    
                    " + ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=2 AND (convert(nvarchar,DatePaymentVoucher,112) between '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' AND '" + this.dtpEnd.Value.ToString("yyyyMMdd") + "') ),0)  ) as BalanceUp" + // as 'Chi'

                    " ,(ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=1 AND (convert(nvarchar,DatePaymentVoucher,112)between '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' AND '" + this.dtpEnd.Value.ToString("yyyyMMdd") + "') ),0)  ) as BalanceDown" + // as 'Chi'

                    ",(ISNULL((SELECT SUM(MoneyService) FROM TblService where TblService.IDPartner=TblPartner.IDPartner AND ((TblService.Time + '01')< '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' )),0)  " + // as MoneyService
                    " - ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=1 AND (convert(nvarchar,DatePaymentVoucher,112)<'" + this.dtpBegin.Value.ToString("yyyyMMdd") + "') ),0)  " + //  as 'Thu'
                    " + ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=2 AND (convert(nvarchar,DatePaymentVoucher,112)<'" + this.dtpBegin.Value.ToString("yyyyMMdd") + "') ),0)  " + // as 'Chi'

                    " + ISNULL((SELECT SUM(MoneyService) FROM TblService where TblService.IDPartner=TblPartner.IDPartner AND ((TblService.Time + '01') between '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' AND '" + this.dtpEnd.Value.ToString("yyyyMMdd") + "' )),0)  " + // as MoneyService                    
                    " + ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=2 AND (convert(nvarchar,DatePaymentVoucher,112) between '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' AND '" + this.dtpEnd.Value.ToString("yyyyMMdd") + "') ),0)  " +

                    " - ISNULL((SELECT SUM(Money) FROM TblPaymentVoucher LEFT JOIN TblService ON TblService.IDService=TblPaymentVoucher.IDService where (TblPaymentVoucher.IDPartner=TblPartner.IDPartner OR TblService.IDPartner=TblPartner.IDPartner) AND IDPaymentVoucherTypeGroup=1 AND (convert(nvarchar,DatePaymentVoucher,112)between '" + this.dtpBegin.Value.ToString("yyyyMMdd") + "' AND '" + this.dtpEnd.Value.ToString("yyyyMMdd") + "') ),0)  ) as BalanceLast" + // as 'Chi'

                    " FROM TblPartner" +
                    " LEFT JOIN TblRoom ON TblRoom.IDPartner=TblPartner.IDPartner" +
                    " LEFT JOIN TblRegion ON TblRegion.IDRegion=TblRoom.IDRegion" +
                    sWhere + 
                    "  ORDER BY SUBSTRING(ContactPerson, LEN(ContactPerson) - CHARINDEX(' ', REVERSE(ContactPerson)) + 1, LEN(ContactPerson)) ";
                DataTable sData = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);

                objdata = sData.Copy();
                switch (this.ComReportTitle.SelectedIndex)
                {
                    case 1:
                        {
                            objdata.Clear();
                            for (int i = 0; i < sData.Rows.Count; i++)
                            {
                                if ((sData.Rows[i]["BalanceUp"].ToString()!="0")&&(double.Parse(sData.Rows[i]["BalanceUp"].ToString()) ==double.Parse(sData.Rows[i]["BalanceDown"].ToString())))
                                    objdata.ImportRow(sData.Rows[i]); 
                            }
                            break; 
                        }
                    case 2:
                        {
                            objdata.Clear();
                            for (int i = 0; i < sData.Rows.Count; i++)
                            {
                                if ((sData.Rows[i]["BalanceUp"].ToString() != "0") && (double.Parse(sData.Rows[i]["BalanceUp"].ToString()) > double.Parse(sData.Rows[i]["BalanceDown"].ToString())))
                                    objdata.ImportRow(sData.Rows[i]);
                            }
                            break;
                        }
                    case 3:
                        {
                            objdata.Clear();
                            for (int i = 0; i < sData.Rows.Count; i++)
                            {
                                if (double.Parse(sData.Rows[i]["BalanceUp"].ToString()) >0)
                                    objdata.ImportRow(sData.Rows[i]);
                            }
                            break;
                        }
                }

                bindsrc = new BindingSource();
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;

                objGv.Set_GridViewPartnerBalance(c1TrueDBGrid1);
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
                            this.Close(); break; 
                        }
                }
            }
            catch { }

        }

        private void frm_Shown(object sender, EventArgs e)
        {             
            this.LoadList();
            this.Cursor = Cursors.Default;   
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

                this.objdatareport = this.objdata.DefaultView.ToTable(); 
            }
            catch { return; }
        } 
        
        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void Cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadList();
        }

        private void BtnPrintList_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;                
                string sRptTitleDescription = "Ngày " + this.dtpBegin.Value.ToString("dd/MM/yyyy");
                if (this.dtpBegin.Value.ToString("dd/MM/yyyy") != this.dtpEnd.Value.ToString("dd/MM/yyyy"))
                    sRptTitleDescription = "Từ ngày " + this.dtpBegin.Value.ToString("dd/MM/yyyy") + " đến ngày " + this.dtpEnd.Value.ToString("dd/MM/yyyy");
                
                TVSReports.rptPartnerBalance.srptTitle = this.ComReportTitle.Text.ToUpper();
                TVSReports.rptPartnerBalance.srptTitleDescription = sRptTitleDescription;
                TVSReports.rptPartnerBalance.srptTable = objdata; 
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = "PartnerBalance";
                objReport.ShowDialog();
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void BtnPrintDetail_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                double sValue = 0;
                

                DataDynamics.ActiveReports.ActiveReport3 sRepExport = new DataDynamics.ActiveReports.ActiveReport3();
                string sRptTitle = "";
                string sRptTitleDescription = "Ngày " + this.dtpBegin.Value.ToString("dd/MM/yyyy");
                if (this.dtpBegin.Value.ToString("dd/MM/yyyy") != this.dtpEnd.Value.ToString("dd/MM/yyyy"))
                    sRptTitleDescription = "Từ ngày " + this.dtpBegin.Value.ToString("dd/MM/yyyy") + " đến ngày " + this.dtpEnd.Value.ToString("dd/MM/yyyy");



                
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }
        
        private void BtnExportExcel_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExportMobile_Click(object sender, EventArgs e)
        {
            
        }
        #endregion
    }
}