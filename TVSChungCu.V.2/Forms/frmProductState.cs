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
    public partial class frmProductState : Form
    {
        public int ProductReleaseId = 0;
        Product objProduct = new Product();

        public frmProductState()
        {
            InitializeComponent();
        }

        private void frmProductState_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmProductState_Load(object sender, EventArgs e)
        {
            this.cbbType.SelectedIndex = 0;

            this.getProductStateData();
        }

        private void btnState_Click(object sender, EventArgs e)
        {
            if (this.txtNote.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung về tình trạng tài sản!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNote.Focus();
                return;
            }

            if (this.objProduct.setProductStateData(this.ProductReleaseId, this.cbbType.SelectedIndex, this.cbbType.Text, this.txtNote.Text, this.dtpDayCreate.Value) > 0)
            {
                this.getProductStateData();
                this.txtNote.Text = "";

                this.dtpDayCreate.Enabled = false;
                this.cbbType.Enabled = false;
                this.txtNote.Enabled = false;
                this.btnState.Enabled = false;
                this.btnAdd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Lỗi: Cập nhật thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getProductStateData()
        {
            try
            {
                this.dgvProduct.DataSource = null;
                this.dgvProduct.AutoGenerateColumns = false;
                this.dgvProduct.DataSource = this.objProduct.getProductStateData(this.dtpDate1.Value, this.dtpDate2.Value, this.ProductReleaseId);
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.dtpDayCreate.Enabled = true;
            this.cbbType.Enabled = true;
            this.txtNote.Enabled = true;
            this.btnState.Enabled = true;
            this.btnAdd.Enabled = false;
        }
    }
}