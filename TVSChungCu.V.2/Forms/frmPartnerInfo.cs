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
    public partial class frmPartnerInfo : Form
    {
        #region method Declare ...
        private DataTable objdata = new DataTable();
        private clsGridView clsG = new clsGridView();
        private string sSQLQuery = "";
        public string sIDRoom = "";        
        #endregion

        public frmPartnerInfo()
        {
            InitializeComponent();
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
        }

        #region LoadList

        BindingSource bindsrc = new BindingSource();
        private void LoadList()
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                sSQLQuery = "Select top 1 '' as Image, TblPartner.*,TblRoom.* " +
                            ", " + Partner.sQueryBalance + "  as Balance " + 
                            " from TblPartner LEFT JOIN TblRoom ON TblRoom.IDPartner=TblPartner.IDPartner WHERE IDRoom=" + sIDRoom;

                objdata = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);
                //BindingSource bindsrc = new BindingSource();
                //bindsrc.DataSource = objdata;
                //bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid1.DataSource = objdata;
                clsG.DeclerationPartner(c1TrueDBGrid1);
                clsG.DeclerationRoom(c1TrueDBGrid1);

                c1TrueDBGrid1.Splits[0].DisplayColumns["IDRoom"].Visible = false;
                c1TrueDBGrid1.Splits[0].DisplayColumns["IDPartner1"].Visible = false;
                c1TrueDBGrid1.Splits[0].DisplayColumns["Action"].Visible = false;

                c1TrueDBGrid1.Columns["Balance"].Caption = "Công nợ";
                c1TrueDBGrid1.Columns["Balance"].NumberFormat = "#,##0";

                #region
                BindingSource bindsrc = new BindingSource();
                bindsrc.DataSource = Set_DataColToRow(c1TrueDBGrid1);
                bNagGrid.BindingSource = bindsrc;
                c1TrueDBGrid2.DataSource = bindsrc;
                c1TrueDBGrid2.Splits[0].DisplayColumns["Name"].Width = 150;
                c1TrueDBGrid2.Columns["Name"].Caption = "Thông tin";
                c1TrueDBGrid2.Columns["Value"].Caption = "Chi tiết";
                c1TrueDBGrid2.Splits[0].DisplayColumns["Name"].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                c1TrueDBGrid2.Splits[0].DisplayColumns["Value"].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                #endregion
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private DataTable Set_DataColToRow(C1TrueDBGrid sDBgrid)
        {
            try
            {
                DataTable objdt = new DataTable();
                DataColumn colAdd;
                colAdd = new DataColumn("Name");
                colAdd.DataType = System.Type.GetType("System.String");
                objdt.Columns.Add(colAdd);
                colAdd = new DataColumn("Value");
                colAdd.DataType = System.Type.GetType("System.String");
                objdt.Columns.Add(colAdd);
                DataRow dr;
                for (int i = 1; i < sDBgrid.Columns.Count; ++i)
                {
                    if (sDBgrid.Splits[0].DisplayColumns[i].Visible)
                    {
                        dr = objdt.NewRow();
                        dr[0] = " " + sDBgrid.Columns[i].Caption;
                        dr[1] = " " + sDBgrid.Columns[i].CellText(0).ToString();
                        objdt.Rows.Add(dr);
                    }
                }
                return objdt;
            }
            catch
            {
                return null;
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
                }
            }
            catch { }

        }

        private void c1TrueDBGrid1_FilterChange(object sender, EventArgs e)
        {
        }

        #endregion


    }
}