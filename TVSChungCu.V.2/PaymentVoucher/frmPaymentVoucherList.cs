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
    public partial class  frmPaymentVoucherList : Form
    {
        #region method Declare ...
        private DataTable objdata=new DataTable();
        private clsGridView objGv = new clsGridView();
        #endregion

        public frmPaymentVoucherList()
        {
            InitializeComponent();
            TVSUtil.Reports.Export.ContextMenu(this.c1TrueDBGrid1);
        }

        #region  CodeForm

        private void frm_Load(object sender, EventArgs e)
        {
            this.LoadList();
        }

        #region LoadList
        private void LoadList()
        {
            try
            {
                SqlParameter[] sParam = new SqlParameter[] {
                new SqlParameter("@Date0", dtpDateOption0.Value.ToString("yyyyMMdd")),
                new SqlParameter("@Date1", dtpDateOption1.Value.ToString("yyyyMMdd"))};
                objdata = TVSSys.GlobalModule.objCon.EXESelect("GetPaymentVoucherList", sParam);
                BindingSource bindsrc = new BindingSource();
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;
                objGv.Set_GridViewPaymentVoucherList(c1TrueDBGrid1);
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
            this.Close();
        }

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    {
                        this.Close();
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
                string sReportName = "PaymentVoucherUtil";
                

                double sMoneyFirst = TVSSys.GlobalModule.objCon.Get_EXESelectDouble("SELECT SUM(CASE WHEN (IDPaymentVoucherTypeGroup=1) THEN isnull(Money,0) ELSE isnull(Money,0)*(-1) END) FROM TblPaymentVoucher WHERE convert(nvarchar,DatePaymentVoucher,112) <'" + dtpDateOption0.Value.ToString("yyyyMMdd") + "'");
                double sMoneyLast = TVSSys.GlobalModule.objCon.Get_EXESelectDouble("SELECT SUM(CASE WHEN (IDPaymentVoucherTypeGroup=1) THEN isnull(Money,0) ELSE isnull(Money,0)*(-1) END) FROM TblPaymentVoucher WHERE convert(nvarchar,DatePaymentVoucher,112) <='" + dtpDateOption1.Value.ToString("yyyyMMdd") + "'");
                TVSReports.rptPaymentVoucherUtil.srptMoneyFisrt = "Số dư đầu kỳ: " + sMoneyFirst.ToString("#,##0") + " VNĐ.";
                TVSReports.rptPaymentVoucherUtil.srptMoneyLast = "Số dư cuối kỳ: " + sMoneyLast.ToString("#,##0") + " VNĐ.";
                if (!chkPrinterDetail.Checked)
                {
                    sReportName += "Total";
                    TVSReports.rptPaymentVoucherUtilTotal.srptMoneyFisrt = "Số dư đầu kỳ: " + sMoneyFirst.ToString("#,##0") + " VNĐ.";
                    TVSReports.rptPaymentVoucherUtilTotal.srptMoneyLast = "Số dư cuối kỳ: " + sMoneyLast.ToString("#,##0") + " VNĐ.";
                }


                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = sReportName;
                if (dtpDateOption0.Value.ToString("dd/MM/yyyy") != dtpDateOption1.Value.ToString("dd/MM/yyyy")) objReport.srptTitleDescription = "Từ ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + " đến ngày " + dtpDateOption1.Value.ToString("dd/MM/yyyy") + ".";
                else objReport.srptTitleDescription = "Ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + ".";

                SqlParameter[] sParam = new SqlParameter[] {
                new SqlParameter("@Date0", dtpDateOption0.Value.ToString("yyyyMMdd")),
                new SqlParameter("@Date1", dtpDateOption1.Value.ToString("yyyyMMdd"))};
                //objReport.srptTable = TVSSys.GlobalModule.objCon.EXESelect("GetPaymentVoucherUtil", sParam);
                DataTable objData = TVSSys.GlobalModule.objCon.EXESelect("Get" + sReportName, sParam);
                double sMoney = sMoneyFirst;
                if (objData.Rows.Count > 0)
                {
                    for (int i = 0; i < objData.Rows.Count; i++)
                    { 
                        try
                        {
                            sMoney += double.Parse(objData.Rows[i]["IMoney"].ToString()) - double.Parse(objData.Rows[i]["EMoney"].ToString());  
                        }
                        catch {}
                        objData.Rows[i]["Money"] = sMoney; 
                    }
                }
                objReport.srptTable = objData;
                objReport.ShowDialog();
            }
            catch { }
        }

        private void btnPrintList_Click(object sender, EventArgs e)
        {
            try
            {
                if (c1TrueDBGrid1.RowCount == 0) return;

                string sReportName = "PaymentVoucherList";
                if (!chkPrinterDetail.Checked) 
                    sReportName += "Total";
     
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = sReportName;
                objReport.srptTitle = "THỐNG KÊ THU CHI TIỀN MẶT";
                objReport.sDataField0 = "GROUP";
                if (dtpDateOption0.Value.ToString("dd/MM/yyyy") != dtpDateOption1.Value.ToString("dd/MM/yyyy")) objReport.srptTitleDescription = "Từ ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + " đến ngày " + dtpDateOption1.Value.ToString("dd/MM/yyyy") + ".";
                else objReport.srptTitleDescription = "Ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + ".";
                objReport.srptTable = Get_DataViewPV(c1TrueDBGrid1);
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

    }
}