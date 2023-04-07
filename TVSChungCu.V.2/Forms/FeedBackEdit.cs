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
    public partial class FeedBackEdit : Form
    {
        public int ID = 0;
        FeedBackClass objFeedBackClass = new FeedBackClass();

        public FeedBackEdit()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.txtFeedBackContent.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập nội dung trả lời!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txtFeedBackContent.Focus();
                return;
            }

            if (MessageBox.Show("Bạn có chắc chắn muốn trả lời nội dung này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.objFeedBackClass.setData(this.ID, this.txtFeedBackContent.Text) > 0)
                {
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FeedBack_Load(object sender, EventArgs e)
        {
            if (ID > 0)
            {
                DataTable objTable = this.objFeedBackClass.getDataById(this.ID.ToString());
                if (objTable.Rows.Count > 0)
                {
                    this.txtSubject.Text = objTable.Rows[0]["Subject"].ToString();
                    this.txtSubjectContent.Text = objTable.Rows[0]["SubjectContent"].ToString();
                    this.txtFeedBackContent.Text = objTable.Rows[0]["FeedBackContent"].ToString();
                    this.txtFeedBackContent.Focus();
                }
            }

            this.txtFeedBackContent.Focus();
        }

        private void FeedBackEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}