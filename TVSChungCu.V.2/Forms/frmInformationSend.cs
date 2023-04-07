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
    public partial class frmInformationSend : Form
    {
        public int ID = 0, State = 0;
        Information objInformation = new Information();

        public frmInformationSend()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.ID > 0)
            {
                if (this.objInformation.sendInformation(this.ID) > 0)
                {
                    this.getData();
                    MessageBox.Show("Gửi thông báo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lỗi: Gửi thông báo thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void frmInformationSend_Load(object sender, EventArgs e)
        {
            if (this.State == 1)
            {
                this.btnSend.Enabled = true;
            }
            else
            {
                this.btnSend.Enabled = false;
            }
            this.getData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmInformationSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void getData()
        {
            try
            {
                this.dgvAccount.DataSource = null;
                this.dgvAccount.AutoGenerateColumns = false;
                this.dgvAccount.DataSource = this.objInformation.getPartnerData(this.ID);
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