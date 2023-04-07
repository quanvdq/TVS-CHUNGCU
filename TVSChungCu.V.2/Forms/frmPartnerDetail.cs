using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;

namespace TVSMain
{
    public partial class frmPartnerDetail : Form
    {

        #region method Declare ...
        public bool sFormPartner = true;
        public string sIDPartner = "";
        public bool sTabEdit = false; 
        clsPublic objPub = new clsPublic();

        private string sTab = "TblPartner";
        private string sTabID = "IDPartner", sTabName = "ContactPerson";

        #endregion

        public frmPartnerDetail()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                
                string sContent = "";
                try
                {
                    sContent = objPub.UpLoad_StringImage(objPub.ImageResize(picCadre.Image));
                }
                catch { }
                if (TVSSys.GlobalModule.objCon.EXEUpdate("Update " + sTab + " Set Images='" + sContent + "' Where " + sTabID + "=" + sIDPartner))
                {
                    this.sTabEdit = true; 
                    MessageBox.Show("Cập nhật thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Lỗi, Cập nhật khôngthành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch { }
            finally
            {
                this.Cursor = Cursors.Default;  
            }
        }

        
        private void frm_Load(object sender, EventArgs e)
        {
            if (sIDPartner == "")
            {
                MessageBox.Show("Lỗi, Chưa chọn khách hàng để cập nhật.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            if (!sFormPartner)
            {
                sTab = "TblFamily";
                sTabID = "IDFamily";
                sTabName = "NameFamily";
            }

            string sSQL = "Select " + sTabName + " as ContactPerson,convert(nvarchar(10),Birthday,103) as Birthday" +
                        ",NameSex,Address,Native,IdentityCardNo,DateIssued,PlaceIssued,Images" +
                        " from " + sTab + " LEFT JOIN TblSex ON " + sTab + ".IDSex=TblSex.IDSex" +
                        " where " + sTabID + "=" + sIDPartner;
            string sImage = "";
            DataTable dt = TVSSys.GlobalModule.objCon.EXESelect(sSQL);
            if (dt.Rows.Count > 0)
            {
                Lbl1.Text = dt.Rows[0]["ContactPerson"].ToString();
                Lbl3.Text = dt.Rows[0]["Birthday"].ToString();
                Lbl4.Text = dt.Rows[0]["NameSex"].ToString();
                Lbl5.Text = dt.Rows[0]["Address"].ToString();
                Lbl7.Text = dt.Rows[0]["Native"].ToString();
                Lbl6.Text = dt.Rows[0]["IdentityCardNo"].ToString();
                Lbl8.Text = dt.Rows[0]["DateIssued"].ToString();
                Lbl2.Text = dt.Rows[0]["PlaceIssued"].ToString();
                sImage = dt.Rows[0]["Images"].ToString();
                if (sImage != "")
                {
                    this.picCadre.Image = objPub.GetImageFromByteArray(sImage);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName="";
                openFileDialog1.ShowReadOnly=true;  
                openFileDialog1.Title="Cập nhật ảnh Nhân viên";
                openFileDialog1.Filter = "JPG|*.Jpg|BMP|*.Bmp|PNG|*.Png"; 
                openFileDialog1.ShowDialog();
                picCadre.ImageLocation= openFileDialog1.FileName; 
  
            }
            catch { }
        }

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close(); 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn xóa ảnh của khách hàng này ?...", "TVS - Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            this.picCadre.Image = null; 

        }
    }
}