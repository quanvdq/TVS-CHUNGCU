using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVSChungCu.Forms
{
    public partial class frmSendNotification : Form
    {
        public frmSendNotification()
        {
            InitializeComponent();
        }

        private void frmSendNotification_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void frmSendNotification_Load(object sender, EventArgs e)
        {

        }
    }
}