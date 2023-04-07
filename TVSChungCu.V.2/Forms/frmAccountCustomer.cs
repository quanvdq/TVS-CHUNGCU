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
    public partial class frmAccountCustomer : Form
    {
        Partner objPartner = new Partner();

        public frmAccountCustomer()
        {
            InitializeComponent();
        }

        private void frmAccountCustomer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmAccountCustomer_Shown(object sender, EventArgs e)
        {
            this.getData();
        }

        private void getData()
        {
            try
            {
                this.dgvAccount.DataSource = null;
                this.dgvAccount.AutoGenerateColumns = false;
                this.dgvAccount.DataSource = this.objPartner.getAccountData(this.txtSearch.Text);
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
            this.getData();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (this.txtPassword.Text.Trim() != "")
            {
                if (this.txtPassword.Text.Trim() != this.txtPasswordRepeat.Text.Trim())
                {
                    MessageBox.Show("Bạn lặp lại sai mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.txtPassword.Focus();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtPassword.Focus();
                return;
            }

            string message = this.objPartner.changePassword(this.txtUserName.Text.Trim(), this.txtPassword.Text.Trim());
            if (message  == "OK")
            {
                this.txtPassword.Text = "";
                this.txtPasswordRepeat.Text = "";
                MessageBox.Show("Thay đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lỗi: " + message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAccount_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtUserName.Text = "";
                this.txtFullName.Text = "";
                this.txtDayCreate.Text = "";
                this.txtPassword.Text = "";
                this.txtPasswordRepeat.Text = "";
                this.txtRoomName.Text = "";
                this.txtPhone.Text = "";

                this.txtUserName.Text = this.dgvAccount.Rows[e.RowIndex].Cells["dgvAccountUserName"].Value.ToString();
                this.txtFullName.Text = this.dgvAccount.Rows[e.RowIndex].Cells["dgvAccountFullName"].Value.ToString();
                this.txtDayCreate.Text = DateTime.Parse(this.dgvAccount.Rows[e.RowIndex].Cells["dgvAccountCreate"].Value.ToString()).ToString("dd/MM/yyyy");

                DataTable objTable = new DataTable();
                objTable = this.objPartner.getAccountDataByUserName(this.txtUserName.Text);

                if (objTable.Rows.Count > 0)
                {
                    this.txtRoomName.Text = objTable.Rows[0]["NameRoom"].ToString();
                    this.txtPhone.Text = objTable.Rows[0]["ContactPhone"].ToString();
                }
            }
            catch
            {
            }
        }

        private void btnSyns_Click(object sender, EventArgs e)
        {
            this.objPartner.checkRoomData();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.getData();
            }
        }

        private void frmAccountCustomer_Load(object sender, EventArgs e)
        {

        }
    }
}