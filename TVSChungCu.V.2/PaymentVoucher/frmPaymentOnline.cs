using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;
using System.IO;
using TVSChungCu.Class;
 
namespace TVSMain
{
    public partial class  frmPaymentOnline : Form
    {
        private clsPaymentOnline objClsPaymentOnline = new clsPaymentOnline();

        public frmPaymentOnline()
        {
            InitializeComponent();
        }

        private void frmPaymentOnline_Load(object sender, EventArgs e)
        {
            this.dtpFrom.Value = new DateTime(DateTime.Now.Year,DateTime.Now.Month,1,0,0,0);
            this.getData();
        }

        private void frmPaymentOnline_KeyDown(object sender, KeyEventArgs e)
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
                this.dgvBill.DataSource = null;
                this.dgvBill.AutoGenerateColumns = false;
                this.dgvBill.DataSource = this.objClsPaymentOnline.getData(this.dtpFrom.Value, this.dtpTo.Value, this.txtSearch.Text);

                double TongTien = 0, DaThanhToan = 0, TienNo = 0;
                for (int i = 0; i < this.dgvBill.RowCount; i++)
                {
                    TongTien += double.Parse(this.dgvBill.Rows[i].Cells["dgvBillMoneyService"].Value.ToString());
                    DaThanhToan += double.Parse(this.dgvBill.Rows[i].Cells["dgvBillMoneyPayService"].Value.ToString());
                    TienNo += double.Parse(this.dgvBill.Rows[i].Cells["dgvBillMoneyDebtBalancer"].Value.ToString());


                    this.txtTongTien.Text = string.Format("{0:0,0}", TongTien);
                    if (this.txtTongTien.Text == "00")
                    {
                        this.txtTongTien.Text = "0";
                    } 
                    this.txtDaThanhToan.Text = string.Format("{0:0,0}", DaThanhToan);
                    if (this.txtDaThanhToan.Text == "00")
                    {
                        this.txtDaThanhToan.Text = "0";
                    }
                    this.txtTienNo.Text = string.Format("{0:0,0}", TienNo);
                    if (this.txtTienNo.Text == "00")
                    {
                        this.txtTienNo.Text = "0";
                    }
                }

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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.getData();
            }
        }
    }
}