using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TVSSys
{
    public partial class frmWaitting : Form
    {
        public string sTitleMess = "";
        public frmWaitting()
        {
            InitializeComponent();
        }

        private void frmWaitting_Load(object sender, EventArgs e)
        {
            if (sTitleMess!="") this.label1.Text = sTitleMess;   
            this.progressBar1.Value = 0;
            this.timer1.Enabled = true;   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value += 5;
            if (this.progressBar1.Value == this.progressBar1.Maximum ) this.progressBar1.Value = 0;
        }
    }
}