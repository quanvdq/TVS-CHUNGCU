using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVSMain
{
    public partial class frmRoomConfig : Form
    {

        #region method Declare ...
        public bool sTabEdit = false;
        #endregion
        public frmRoomConfig()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void frm_Load(object sender, EventArgs e)
        {
            this.ButColor0.BackColor = Room.sMapRoomColor[0];
            this.ButColor1.BackColor = Room.sMapRoomColor[1];
            this.ButColor2.BackColor = Room.sMapRoomColor[2];
            this.ButColor3.BackColor = Room.sMapRoomColor[3];
            this.ButColor4.BackColor = Room.sMapRoomColor[4];

            this.TxtRoomLeft.Text = Room.sMapRoomLeft.ToString();
            this.TxtRoomTop.Text = Room.sMapRoomTop.ToString();
            this.TxtRoomColumn.Text = Room.sMapColumn.ToString();
            this.TxtRoomExpirationDate.Text = Room.sMapExpirationDate.ToString();
        }

        private void ButColor_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button tmp = (System.Windows.Forms.Button)sender;
            //string sIDRoom = tmp.Name.Substring(4);

            ColorDialog objColor = new ColorDialog();
            objColor.Color = tmp.BackColor; 
            objColor.ShowDialog();
            tmp.BackColor = objColor.Color; 
        }


        #region method Txt
        private void TxtLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tmp = (System.Windows.Forms.TextBox)sender;
            tmp.BackColor = TVSSys.GlobalModule.objColorLeave;
        }


        private void TxtEnter(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox tmp = (System.Windows.Forms.TextBox)sender;
            tmp.BackColor = TVSSys.GlobalModule.objColorEnter;
        }
        #endregion

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TVSSys.GlobalModule.objXML.UpdateKey("RoomColor0", this.ButColor0.BackColor.ToArgb().ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("RoomColor1", this.ButColor1.BackColor.ToArgb().ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("RoomColor2", this.ButColor2.BackColor.ToArgb().ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("RoomColor3", this.ButColor3.BackColor.ToArgb().ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("RoomColor4", this.ButColor4.BackColor.ToArgb().ToString());

                TVSSys.GlobalModule.objXML.UpdateKey("RoomLeft", int.Parse(this.TxtRoomLeft.Text).ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("RoomTop", int.Parse(this.TxtRoomTop.Text).ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("RoomColumn", int.Parse(this.TxtRoomColumn.Text).ToString());
                TVSSys.GlobalModule.objXML.UpdateKey("RoomExpirationDate", int.Parse(this.TxtRoomExpirationDate.Text).ToString());

                MessageBox.Show("Cập nhật thông số thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch 
            {
                MessageBox.Show("Lỗi, Cập nhật thông số không thành công!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);        
                return; 
            }
            Room objRoom = new Room();
            this.sTabEdit = true;  
        }

        private void frm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        {
                            this.Close();
                            break;
                        }

                    case Keys.F6:
                        {
                            this.BtnUpdate.Focus();
                            this.BtnUpdate.PerformClick();
                            break;
                        }
                }
            }
            catch { }
        }
    }
}