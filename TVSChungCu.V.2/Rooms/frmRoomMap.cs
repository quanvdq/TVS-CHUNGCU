using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using C1.Win.C1TrueDBGrid;
using System.Net;
using System.Net.Mail;


namespace TVSMain
{
    public partial class frmRoomMap : Form
    {
        #region method Declare ...
        private DataTable objdata = new DataTable();
        private string sSQLQuery = "";
        private bool sLoading = true; 

        
        #endregion

        public frmRoomMap()
        {
            InitializeComponent();
        }

        #region Mothod FromCode


        private void frm_Load(object sender, EventArgs e)
        {
            Service.SetRegion(this.ComRegion);
            sLoading = false;

            LoadRoom_Map();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch { }
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
                            //this.ToolStripTop.Focus();
                            //this.ButSave.PerformClick();
                            break;
                        }
                }
            }
            catch { }

        }

        public int LoadRoomMap(System.Windows.Forms.Panel sPanel, string sIDRegion, string sNameRegion, int sTop, int sLeft)
        {
            sSQLQuery = "SELECT IDRoom,NameRoom" + Room.sSQLRoomStatus +                 
                        " FROM TblRoom WHERE IDRegion=" + sIDRegion + " AND  isnull(Action,0)=1";
            objdata = TVSSys.GlobalModule.objCon.EXESelect(sSQLQuery);
            if (objdata.Rows.Count == 0) return sTop;

            int sLeftCurr = sLeft + Room.sMapRoomWidth + Room.sMapRoomStep;
            int sTopCurr = sTop;
            int sRoomCurr = 0;

            Button objRoom = new Button();

            int sMapRow = objdata.Rows.Count / Room.sMapColumn;
            if (Room.sMapColumn * sMapRow < objdata.Rows.Count) sMapRow++;

            for (int i = 0; i < sMapRow; i++)
            {
                sLeftCurr = sLeft + Room.sMapRoomWidth + Room.sMapRoomStep;

                for (int j = 0; j < Room.sMapColumn; j++)
                {
                    if (sRoomCurr < objdata.Rows.Count)
                    {
                        objRoom = new Button();
                        objRoom.FlatStyle = FlatStyle.Flat;
                        objRoom.FlatAppearance.BorderSize  = 0;
                        objRoom.Cursor = Cursors.Hand;  
                        objRoom.Top = sTopCurr;
                        objRoom.Left = sLeftCurr;
                        objRoom.Height = Room.sMapRoomHeight;
                        objRoom.Width = Room.sMapRoomWidth;
                        objRoom.Name = "Room" + objdata.Rows[sRoomCurr]["IDRoom"].ToString();
                        objRoom.Text = objdata.Rows[sRoomCurr]["NameRoom"].ToString();
                        objRoom.BackColor = Room.sMapRoomColor[int.Parse(objdata.Rows[sRoomCurr]["Status"].ToString())];
                        objRoom.Click += new System.EventHandler(Room_Click);
                        
                        sPanel.Controls.Add(objRoom);
                        sRoomCurr++;
                        sLeftCurr += Room.sMapRoomWidth + Room.sMapRoomStep;
                    }
                }
                sTopCurr += Room.sMapRoomWidth + Room.sMapRoomStep;
            }

            objRoom = new Button();
            objRoom.FlatStyle = FlatStyle.Flat;
            objRoom.FlatAppearance.BorderSize = 0;
            objRoom.Top = sTop;
            objRoom.Left = sLeft;
            objRoom.Height = sTopCurr - sTop - Room.sMapRoomStep;
            objRoom.Width = Room.sMapRoomWidth;
            objRoom.Name = "Region" + sIDRegion;
            objRoom.Text = sNameRegion;
            objRoom.BackColor = Room.sMapRoomColor[0];
            sPanel.Controls.Add(objRoom);

            return sTopCurr;
        }

        private void LoadRoom_Map()
        {
            if (this.sLoading) return;
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string sSQLWhere = "";
                TVSSys.ItemCombobox objRegion = (TVSSys.ItemCombobox)ComRegion.SelectedItem;
                if (objRegion.Value != "0")
                    sSQLWhere = " WHERE IDRegion=" + objRegion.Value;

                this.PanMain.Controls.Clear();
                int sMapTop = Room.sMapRoomTop;

                DataTable objDt = TVSSys.GlobalModule.objCon.EXESelect("SELECT IDRegion,NameRegion FROM TblRegion" + sSQLWhere);
                if (objDt.Rows.Count == 0) return;


                for (int i = 0; i < objDt.Rows.Count; i++)
                {
                    sMapTop = this.LoadRoomMap(this.PanMain, objDt.Rows[i]["IDRegion"].ToString(), objDt.Rows[i]["NameRegion"].ToString(), sMapTop, Room.sMapRoomLeft);
                    sMapTop += Room.sMapRoomStep;
                }
            }
            catch
            {

            }
            finally
            {
                this.Cursor = Cursors.Default;   
            }
        }

        private void Room_Click(object sender, EventArgs e)
        {
            try
            {
                System.Windows.Forms.Button tmp = (System.Windows.Forms.Button)sender;
                string sIDRoom = tmp.Name.Substring(4);
                if (sIDRoom != "")
                {
                    frmPartnerInfo frm = new frmPartnerInfo();
                    frm.sIDRoom = sIDRoom;
                    frm.Text = tmp.Text.ToUpper();   
                    frm.ShowDialog(); 
                }
            }
            catch { }
        }
        #endregion

        private void frmRoomMap_Shown(object sender, EventArgs e)
        {
            Room.sMapRoomWidth = Room.sMapRoomHeight = (this.Width - Room.sMapRoomStep * (Room.sMapColumn + 1) - Room.sMapRoomLeft - Room.sMapRoomLeft) / (Room.sMapColumn + 1);

            LoadRoom_Map();
        }

        private void ComRegion_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRoom_Map();
        }

        private void ButConfig_Click(object sender, EventArgs e)
        {
            frmRoomConfig objfrm = new frmRoomConfig();
            objfrm.ShowDialog();
            if (objfrm.sTabEdit)
            {
                Room.sMapRoomWidth = Room.sMapRoomHeight = (this.Width - Room.sMapRoomStep * (Room.sMapColumn + 1) - Room.sMapRoomLeft - Room.sMapRoomLeft) / (Room.sMapColumn + 1);
                LoadRoom_Map();
            }
        }
    }
}