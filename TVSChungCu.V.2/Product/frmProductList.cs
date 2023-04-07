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
    public partial class  frmProductList : Form
    {
        #region method Declare ...
        private DataTable objdata=new DataTable();
        private clsGridView objGv = new clsGridView();
        #endregion

        public frmProductList()
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
                objdata = TVSSys.GlobalModule.objCon.EXESelect("GetProductList", sParam);
                BindingSource bindsrc = new BindingSource();
                bindsrc.DataSource = objdata;
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = bindsrc;
                objGv.Set_GridViewProductList(c1TrueDBGrid1);
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
                TVSReports.rptProductList.srptTable = Get_DataView(c1TrueDBGrid1);
                if (dtpDateOption0.Value.ToString("dd/MM/yyyy") != dtpDateOption1.Value.ToString("dd/MM/yyyy")) TVSReports.rptProductList.srptTitleDescription = "Từ ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + " đến ngày " + dtpDateOption1.Value.ToString("dd/MM/yyyy") + ".";
                else TVSReports.rptProductList.srptTitleDescription = "Ngày: " + dtpDateOption0.Value.ToString("dd/MM/yyyy") + ".";
                TVSReports.rptProductList.srptTitle = "BÁO CÁO TỔNG HỢP VẬT TƯ";
                TVSReports.frmReportViewer objReport = new TVSReports.frmReportViewer();
                objReport.WindowState = FormWindowState.Maximized;
                objReport.srptType = "ProductList";
                objReport.ShowDialog();
            }
            catch { }
        }

        #region GetDataTableFromGridView
        private DataTable Get_DataView(C1TrueDBGrid sDBGrid)
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
                        dr[i] = " " + sDBGrid.Columns[i].CellText(sRow);
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