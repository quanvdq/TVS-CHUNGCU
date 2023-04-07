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
    public partial class rptPaymentVoucherA5 : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use  
        public static DataTable srptTable;
        rptPaymentVoucher rptsubPayment = null;
        #endregion

        #region method rptPaymentVoucherA5
        public rptPaymentVoucherA5()
        {
            InitializeComponent();
            this.DataSource = srptTable; 
        } 
        #endregion

        private void rpt_ReportStart(object sender, EventArgs e)
        {

        }

        private void rptPaymentVoucherA4_ReportEnd(object sender, EventArgs e)
        {
            rptsubPayment.Document.Dispose();
            rptsubPayment.Dispose();
            rptsubPayment = null;
        }

        private void detail_Format(object sender, EventArgs e)
        {
            rptPaymentVoucher.srptID = this.textBox1.Text;
            rptsubPayment = new rptPaymentVoucher();
            this.subReport.Report = rptsubPayment;
        }
    }


}
