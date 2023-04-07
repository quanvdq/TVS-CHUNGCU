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
    public partial class frmListProduct : Form
    {
        Product objProduct = new Product();
        private int Index = -1;

        public frmListProduct()
        {
            InitializeComponent();
        }

        private void btnProductConfig_Click(object sender, EventArgs e)
        {
            frmProductConfig objfrmProductConfig = new frmProductConfig();
            objfrmProductConfig.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmListProduct_Load(object sender, EventArgs e)
        {
            this.cbbBuilding.SelectedIndex = 0;

            this.cbbZone.DataSource = this.objProduct.getRegionData("Khu vực");
            this.cbbZone.DisplayMember = "NameRegion";
            this.cbbZone.ValueMember = "IDRegion";

            this.getDataRelease();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getDataRelease();
        }

        private void txtRoom_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btnSearch.PerformClick();
            }
        }

        private void getDataRelease()
        {
            try
            {
                this.dgvProduct1.DataSource = null;
                this.dgvProduct1.AutoGenerateColumns = false;
                this.dgvProduct1.DataSource = this.objProduct.getDataRelease(int.Parse(this.cbbZone.SelectedValue.ToString()),this.txtSearch.Text);
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void cbbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.getDataRelease();
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductState objfrmProductState = new frmProductState();
                objfrmProductState.ProductReleaseId = int.Parse(this.dgvProduct1.Rows[this.Index].Cells["dgvProduct1Id"].Value.ToString());
                objfrmProductState.lblnfomation.Text = this.dgvProduct1.Rows[this.Index].Cells["dgvProduct1NameProduct"].Value.ToString();
                objfrmProductState.lblProductCode.Text = this.dgvProduct1.Rows[this.Index].Cells["dgvProduct1PossitionName"].Value.ToString();
                objfrmProductState.ShowDialog();
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void dgvProduct1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Index = e.RowIndex;
        }

        private void ctmProduct_State_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductState objfrmProductState = new frmProductState();
                objfrmProductState.ProductReleaseId = int.Parse(this.dgvProduct1.Rows[this.Index].Cells["dgvProduct1Id"].Value.ToString());
                objfrmProductState.lblnfomation.Text = this.dgvProduct1.Rows[this.Index].Cells["dgvProduct1NameProduct"].Value.ToString();
                objfrmProductState.lblProductCode.Text = this.dgvProduct1.Rows[this.Index].Cells["dgvProduct1PossitionName"].Value.ToString();
                objfrmProductState.ShowDialog();
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void ctmProduct_Config_Click(object sender, EventArgs e)
        {
            frmProductConfig objfrmProductConfig = new frmProductConfig();
            objfrmProductConfig.ShowDialog();
        }
    }
}