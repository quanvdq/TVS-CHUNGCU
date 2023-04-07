using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVSSys
{
    public partial class frmIntro : Form
    {
        #region method frmIntro
        public frmIntro()
        {
            InitializeComponent();
        } 
        #endregion

        #region method btnClose_Click
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
        #endregion

        #region  method frmIntro_KeyDown
        private void frmIntro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        } 
        #endregion

        private void frmIntro_Load(object sender, EventArgs e)
        {
            try
            {
                this.LblVersion.Text = TVSSys.Version.GetVersion("TVSChungCu");
            }
            catch
            { }
        }
    }
}