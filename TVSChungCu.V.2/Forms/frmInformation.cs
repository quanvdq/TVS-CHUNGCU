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
    public partial class frmInformation : Form
    {
        Information objInformation = new Information();
        private int Index = 0;

        public frmInformation()
        {
            InitializeComponent();
        }

        private void frmToolInformation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmToolInformation_Load(object sender, EventArgs e)
        {
            this.getData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmInformationEdit objfrmInformationEdit = new frmInformationEdit();
            objfrmInformationEdit.ShowDialog();
            this.getData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getData()
        {
            try
            {
                this.dgvInformation.DataSource = null;
                this.dgvInformation.AutoGenerateColumns = false;
                this.dgvInformation.DataSource = this.objInformation.getData(this.txtSearch.Text);
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void dgvInformation_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmInformationEdit objfrmInformationEdit = new frmInformationEdit();
                objfrmInformationEdit.ID = int.Parse(this.dgvInformation.Rows[e.RowIndex].Cells["dgvInformationId"].Value.ToString());
                objfrmInformationEdit.ShowDialog();
                this.getData();
            }
            catch
            {
            }
            finally
            {
            }
        }

        private void btnSendInformation_Click(object sender, EventArgs e)
        {
            try
            {
                frmInformationSend objfrmInformationSend = new frmInformationSend();
                objfrmInformationSend.ID = int.Parse(this.dgvInformation.Rows[this.Index].Cells["dgvInformationId"].Value.ToString());
                objfrmInformationSend.State = int.Parse(this.dgvInformation.Rows[this.Index].Cells["dgvInformationState"].Value.ToString());
                objfrmInformationSend.lblTitle.Text = this.dgvInformation.Rows[this.Index].Cells["dgvInformationTitle"].Value.ToString();
                objfrmInformationSend.ShowDialog();

                this.getData();
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void dgvInformation_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Index = e.RowIndex;
            if (this.dgvInformation.Rows[e.RowIndex].Cells["dgvInformationState"].Value.ToString() != "0")
            {
                this.btnSendInformation.Enabled = true;
            }
            else
            {
                this.btnSendInformation.Enabled = false;
            }
        }
    }
}