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
    public partial class frmProductConfig : Form
    {
        int IndexAdd = -1, IndexDel = -1;
        Product objProduct = new Product();

        public frmProductConfig()
        {
            InitializeComponent();
        }

        private void frmProductConfig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmProductConfig_Load(object sender, EventArgs e)
        {
            this.cbbZone.DataSource = this.objProduct.getRegionData("");
            this.cbbZone.DisplayMember = "NameRegion";
            this.cbbZone.ValueMember = "IDRegion";

            this.getData();
            this.getDataRelease();
        }

        private void getData()
        {
            this.dgvProduct.AutoGenerateColumns = false;
            this.dgvProduct.DataSource = this.objProduct.getData(this.txtSearch.Text.Trim());
        }

        private void getDataRelease()
        {
            try
            {
                this.dgvProduct1.DataSource = null;
                this.dgvProduct1.AutoGenerateColumns = false;
                this.dgvProduct1.DataSource = this.objProduct.getDataRelease(int.Parse(this.cbbZone.SelectedValue.ToString()),"");
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.getData();
                this.dgvProduct.Focus();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.objProduct.setReleaseData(int.Parse(this.dgvProduct.Rows[this.IndexAdd].Cells["dgvProductIDProduct"].Value.ToString()), this.dgvProduct.Rows[this.IndexAdd].Cells["dgvProductNameProduct"].Value.ToString(), int.Parse(this.cbbZone.SelectedValue.ToString()), this.cbbZone.Text, "") > 0)
                {
                    this.getDataRelease();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.objProduct.delReleaseData(int.Parse(this.dgvProduct1.Rows[this.IndexDel].Cells["dgvProduct1Id"].Value.ToString())) > 0)
                {
                    this.getDataRelease();
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void dgvProduct_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.IndexAdd = e.RowIndex;
        }

        private void dgvProduct1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.IndexDel = e.RowIndex;
        }

        private void cbbZone_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.getDataRelease();
        }

        private void dgvProduct1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.objProduct.editReleaseData(int.Parse(this.dgvProduct1.Rows[e.RowIndex].Cells["dgvProduct1Id"].Value.ToString()), this.dgvProduct1.Rows[e.RowIndex].Cells["dgvProduct1PossitionName"].Value.ToString());
            }
            catch
            {
            }
            finally
            {
            }
        }
    }
}