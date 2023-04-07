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
    public partial class FeedBack : Form
    {
        FeedBackClass objFeedBackClass = new FeedBackClass();
        private int Index = 0;

        public FeedBack()
        {
            InitializeComponent();
        }

        private void FeedBack_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {
            this.getData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.getData();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.getData();
        }

        private void getData()
        {
            try
            {
                this.dgvFeedBack.DataSource = null;
                this.dgvFeedBack.AutoGenerateColumns = false;
                this.dgvFeedBack.DataSource = this.objFeedBackClass.getData(this.txtSearch.Text);
            }
            catch
            {
            }
            finally
            {

            }
        }

        private void dgvFeedBack_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.Index = e.RowIndex;
        }

        private void dgvFeedBack_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FeedBackEdit objFeedBackEdit = new FeedBackEdit();
                objFeedBackEdit.ID = int.Parse(this.dgvFeedBack.Rows[e.RowIndex].Cells["dgvFeedBackId"].Value.ToString());
                objFeedBackEdit.ShowDialog();
                this.getData();
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