using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TVSReports;

namespace TVSChungCu.Reports
{
    public partial class frmCustomerDebit : Form
    {
        clsReports objclsReports = new clsReports();
        public frmCustomerDebit()
        {
            InitializeComponent();
        }

        private void frmCustomerDebit_Load(object sender, EventArgs e)
        {
            this.getData();
        }

        private void frmCustomerDebit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getData();
        }

        private void getData()
        {
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.DataSource = this.objclsReports.getCustomerDebit(this.dtpFromDay.Value, this.dtpTo.Value, this.txtSearchKey.Text.Trim());
        }

        private void txtSearchKey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.getData();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmCustomerDebit_View objfrmCustomerDebit_View = new frmCustomerDebit_View();
            objfrmCustomerDebit_View.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
