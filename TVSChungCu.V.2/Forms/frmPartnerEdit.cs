using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TVSMain;

namespace TVSChungCu.Forms
{
    public partial class frmPartnerEdit : Form
    {
        public bool AccountAp = false;
        public string sIDPartner = "0";
        private Partner objPartner = new Partner();
        public int itemUpdate = 0;

        public frmPartnerEdit()
        {
            InitializeComponent();
        }

        private void frmPartner_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmPartner_Load(object sender, EventArgs e)
        {
            if (sIDPartner == "")
            {
                sIDPartner = "0";
            }

            DataTable objTable = this.objPartner.getDataById(sIDPartner);
            if (objTable.Rows.Count > 0)
            {
                this.txtCodePartner.Text = objTable.Rows[0]["CodePartner"].ToString();
                this.txtContactPerson.Text = objTable.Rows[0]["ContactPerson"].ToString();
                this.txtContactPhone.Text = objTable.Rows[0]["ContactPhone"].ToString();
                this.txtEmail.Text = objTable.Rows[0]["Email"].ToString();
                this.txtAddress.Text = objTable.Rows[0]["Address"].ToString();
                this.txtNote.Text = objTable.Rows[0]["Note"].ToString();

                if (objTable.Rows[0]["IsAccountApp"].ToString() != "")
                {
                    this.AccountAp = true;
                    this.ckbAccountApp.Checked = true;
                    this.ckbAccountApp.Enabled = false;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtContactPerson.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập họ, tên khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtContactPerson.Focus();
                return;
            }

            if (this.txtContactPhone.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại của khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtContactPhone.Focus();
                return;
            }

            this.itemUpdate = this.objPartner.setData(this.sIDPartner, this.txtContactPerson.Text, this.txtContactPhone.Text, this.txtEmail.Text, this.txtAddress.Text, this.txtNote.Text);
            if (this.itemUpdate > 0)
            {
                MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.btnSave.Enabled = false;
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

        private void ckbAccountApp_CheckedChanged(object sender, EventArgs e)
        {
            if (this.AccountAp)
            {
                return;
            }
            if (this.ckbAccountApp.Checked)
            {
                string msg = this.objPartner.setAccountData(this.txtCodePartner.Text,this.txtContactPerson.Text);
                if (msg == "OK")
                {
                    MessageBox.Show("Tạo tài khoản sử dụng App thành công!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.ckbAccountApp.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Lỗi: Tạo tài khoản sử dụng App thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}