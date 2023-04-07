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
    public partial class frmInformationEdit : Form
    {
        public int ID = 0;
        Information objInformation = new Information();

        public frmInformationEdit()
        {
            InitializeComponent();
        }

        private void frmInformationEdit_Load(object sender, EventArgs e)
        {
            this.cbbState.SelectedIndex = 0;

            if (ID > 0)
            {
                DataTable objTable = this.objInformation.getDataById(this.ID.ToString());
                if (objTable.Rows.Count > 0)
                {
                    this.txtTitle.Text = objTable.Rows[0]["Title"].ToString();
                    this.txtNewsContent.Text = objTable.Rows[0]["NewsContent"].ToString();
                    this.dtpDayCreate.Text = objTable.Rows[0]["DayCreate"].ToString();
                    this.cbbState.SelectedIndex = int.Parse(objTable.Rows[0]["State"].ToString());

                    if (this.cbbState.SelectedIndex == 2)
                    {
                        this.btnEdit.Enabled = false;
                    }
                    else
                    {
                        this.btnEdit.Enabled = true;
                    }
                }
            }
        }

        private void frmInformationEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập tiêu đề thông báo!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtTitle.Focus();
                return;
            }

            if (this.txtNewsContent.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung thông báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtNewsContent.Focus();
                return;
            }

            if (this.cbbState.SelectedIndex == 2)
            {
                MessageBox.Show("Bạn chọn sai trạng thái của thông báo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cbbState.Focus();
                return;
            }

            if (this.objInformation.setData(this.ID, this.txtTitle.Text, this.txtNewsContent.Text, "", this.cbbState.SelectedIndex) > 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDel.Enabled = false;
                this.btnSave.Enabled = false;

                this.txtTitle.ReadOnly = true;
                this.txtNewsContent.ReadOnly = true;
                this.dtpDayCreate.Enabled = false;
                this.cbbState.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.ID = 0;

            this.txtTitle.Text = "";
            this.txtNewsContent.Text = "";
            this.dtpDayCreate.Value = DateTime.Now;
            this.cbbState.SelectedIndex = 0;

            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
            this.btnSave.Enabled = true;

            this.txtTitle.ReadOnly = false;
            this.txtNewsContent.ReadOnly = false;
            this.dtpDayCreate.Enabled = true;
            this.cbbState.Enabled = true;

            this.txtTitle.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDel.Enabled = false;
            this.btnSave.Enabled = true;

            this.txtTitle.ReadOnly = false;
            this.txtNewsContent.ReadOnly = false;
            this.dtpDayCreate.Enabled = true;
            this.cbbState.Enabled = true;

            this.txtTitle.Focus();
        }
    }
}