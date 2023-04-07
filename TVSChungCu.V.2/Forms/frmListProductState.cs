using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TVSChungCu.Class;

namespace TVSChungCu.Forms
{
    public partial class frmListProductState : Form
    {
        Product objProduct = new Product();

        public frmListProductState()
        {
            InitializeComponent();
        }

        private void frmListProductState_Load(object sender, EventArgs e)
        {
            this.dtpDate1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month,1,0,0,0);
            this.cbbZone.DataSource = this.objProduct.getRegionData("");
            this.cbbZone.DisplayMember = "NameRegion";
            this.cbbZone.ValueMember = "IDRegion";

            this.getDataReleaseState();
        }

        private void frmListProductState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void cbbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.getDataReleaseState();
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void getDataReleaseState()
        {
            try
            {
                this.dgvProduct1.DataSource = null;
                this.dgvProduct1.AutoGenerateColumns = false;
                this.dgvProduct1.DataSource = this.objProduct.getDataReleaseState(this.dtpDate1.Value, this.dtpDate2.Value, int.Parse(this.cbbZone.SelectedValue.ToString()), this.txtSearch.Text);
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getDataReleaseState();
        }

        private void dgvProduct1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            try
            {
                if (this.dgvProduct1.Rows[e.RowIndex].Cells["dgvProduct1NameProduct"].Value.ToString().Trim() != "")
                {
                    this.dgvProduct1.Rows[e.RowIndex].DefaultCellStyle.Font = new Font("Arial",11,FontStyle.Bold);
                }
            }
            catch
            {
            }
        }
    }
}