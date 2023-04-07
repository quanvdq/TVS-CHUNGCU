using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TVSSys
{
    public partial class frmUpdateData : Form
    {
        #region method Declare ...
        #endregion

        public frmUpdateData()
        {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                backgroundWorker1.RunWorkerAsync();
            }
            catch
            {
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                TVSSys.clsSQLQuery.EXEQUERY_UPDATEDATA();
            }
            catch { }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            PbrData.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.PbrData.Value = this.PbrData.Maximum;
            this.Close(); 
        }
    }
}