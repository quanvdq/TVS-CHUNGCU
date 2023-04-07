using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DataDynamics.ActiveReports;
using DataDynamics.ActiveReports.Document;
using System.Data.SqlClient;
using System.Data;

namespace TVSReports
{
    public partial class rptNotifyA5 : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use  
        public static DataTable srptTable;
        rptNotify rptsubNotify = null;
        #endregion

        #region method rptNotifyA5
        public rptNotifyA5()
        {
            InitializeComponent();
            this.DataSource = srptTable; 
        } 
        #endregion

        private void rpt_ReportStart(object sender, EventArgs e)
        {

        }

        private void rptNotifyA4_ReportEnd(object sender, EventArgs e)
        {
            rptsubNotify.Document.Dispose();
            rptsubNotify.Dispose();
            rptsubNotify = null;
        }

        private void detail_Format(object sender, EventArgs e)
        {
            rptNotify.srptID = this.textBox1.Text;
            rptsubNotify = new rptNotify();
            this.subReport.Report = rptsubNotify;
        }
    }


}
