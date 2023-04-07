using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace TVSReports
{
    public partial class frmReportViewer : Form
    {
        #region method Declare ...
        public string srptType = "";
        public string srptTitle = "";
        public string srptTitleDescription = "";
        public DataTable srptTable;
        public string sCaderCode = "";
        public string sDataField0 = "", sDataField1 = "", sDataField2 = "";
        public string sCaption0 = "", sCaption1 = "", sCaption2 = "";
        private DataDynamics.ActiveReports.ActiveReport3 report = null;
        private DataDynamics.ActiveReports.ActiveReport3 subreport = null;
        public DateTime srptDateTime0, srptDateTime1;
        #endregion

        #region method frmReportViewer
        public frmReportViewer()
        {
            InitializeComponent();
        } 
        #endregion

        #region method frmReportViewer_Load
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            this.viewer1.Toolbar.Tools[20].Visible = false;
            this.viewer1.Toolbar.Tools[21].Visible = false;
            this.viewer1.Toolbar.Tools[22].Visible = false;
            this.viewer1.Toolbar.Tools[23].Visible = false;
            this.LoadReport();
        }

        private void LoadReport()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                switch (srptType)
                {
                    #region PaymentVoucher
                    case "PaymentVoucherList":
                        {
                            rptPaymentVoucherList.srptTitle = this.srptTitle;
                            rptPaymentVoucherList.srptTable = this.srptTable;
                            rptPaymentVoucherList.srptID = this.sDataField0;
                            rptPaymentVoucherList.srptTitleDescription = this.srptTitleDescription;
                            report = new rptPaymentVoucherList();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "PaymentVoucherListTotal":
                        {
                            rptPaymentVoucherListTotal.srptTitle = this.srptTitle;
                            rptPaymentVoucherListTotal.srptTable = this.srptTable;
                            rptPaymentVoucherListTotal.srptID = this.sDataField0;
                            rptPaymentVoucherListTotal.srptTitleDescription = this.srptTitleDescription;
                            report = new rptPaymentVoucherListTotal();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "PaymentVoucherUtil":
                        {
                            rptPaymentVoucherUtil.srptTitle = this.srptTitle;
                            rptPaymentVoucherUtil.srptTable = this.srptTable;
                            rptPaymentVoucherUtil.srptTitleDescription = this.srptTitleDescription;
                            report = new rptPaymentVoucherUtil();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "PaymentVoucherUtilTotal":
                        {
                            rptPaymentVoucherUtilTotal.srptTitle = this.srptTitle;
                            rptPaymentVoucherUtilTotal.srptTable = this.srptTable;
                            rptPaymentVoucherUtilTotal.srptTitleDescription = this.srptTitleDescription;
                            report = new rptPaymentVoucherUtilTotal();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "PaymentVoucherA5":
                        {
                            rptPaymentVoucherA5.srptTable = this.srptTable;
                            report = new rptPaymentVoucherA5();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "PaymentVoucherA4":
                        {
                            rptPaymentVoucherA4.srptTable = this.srptTable;
                            report = new rptPaymentVoucherA4();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }

                    case "PartnerBalance":
                        {
                            report = new rptPartnerBalance();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    #endregion

                    #region Service
                    case "NotifyA5":
                        {
                            rptNotifyA5.srptTable = this.srptTable;
                            report = new rptNotifyA5();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;


                            //if (this.srptTable.Rows.Count==0)
                            //{
                            //    MessageBox.Show("Lỗi, Bạn chưa chọn dữ liệu cần In!", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                            //    return ;
                            //}
                            //rptNotify.srptID = this.srptTable.Rows[0]["IDService"].ToString();
                            //report = new rptNotify();
                            //viewer1.Document = report.Document;
                            //report.Run();

                            //if (this.srptTable.Rows.Count>1)
                            //{
                            //    for (int i = 1; i < this.srptTable.Rows.Count; i++ )
                            //    {
                            //        rptNotify.srptID = this.srptTable.Rows[i]["IDService"].ToString();
                            //        subreport = new rptNotify();
                            //        subreport.Run();
                            //        report.Document.Pages.Insert(i, subreport.Document.Pages[0]);
                            //    }

                            //}
                            //break; 
                        }
                    case "NotifyA4":
                        {
                            rptNotifyA4.srptTable = this.srptTable;
                            report = new rptNotifyA4();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "ServiceList":
                        {
                            report = new rptServiceList();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "ServiceListM1":
                        {
                            report = new rptServiceListM1();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    #endregion


                    #region Product
                    case "Product":
                        {
                            report = new rptProduct();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    case "ProductList":
                        {
                            report = new rptProductList();
                            viewer1.Document = report.Document;
                            report.Run();
                            break;
                        }
                    #endregion
                }
            }
            catch { }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        } 
        #endregion

        #region KeyDown
        private void frmReportViewer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
        #endregion

        #region Export
        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string sPathFile = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\TVSExcel.xls";
                try
                {
                    System.IO.FileInfo fr = new System.IO.FileInfo(sPathFile);
                    fr.Delete();
                }
                catch { }
                DataDynamics.ActiveReports.Export.Xls.XlsExport x = new DataDynamics.ActiveReports.Export.Xls.XlsExport();
                x.FileFormat = DataDynamics.ActiveReports.Export.Xls.FileFormat.Xls97Plus;
                x.MinRowHeight = 0;
                x.RemoveVerticalSpace = false;
                x.UseCellMerging = true;                
                x.Export(viewer1.Document, sPathFile);
                MessageBox.Show("Kết xuất dữ liệu thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(sPathFile);
            }
            catch
            {
                MessageBox.Show("Lỗi, Kết xuất dữ liệu không thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            try
            {
                string sPathFile = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\TVSExport.Pdf";
                //try
                //{
                //    System.IO.FileInfo fr = new System.IO.FileInfo(sPathFile);
                //    fr.Delete();
                //}
                //catch { }
                //DataDynamics.ActiveReports.Export.Pdf.PdfExport p = new DataDynamics.ActiveReports.Export.Pdf.PdfExport();
                //p.NeverEmbedFonts = "Aria";
                //p.Export(viewer1.Document, sPathFile);
                //MessageBox.Show("Kết xuất dữ liệu thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //System.Diagnostics.Process.Start(sPathFile);


                sPathFile = AppDomain.CurrentDomain.BaseDirectory.ToString() + "\\TVSExport.doc";
                try
                {
                    System.IO.FileInfo fr = new System.IO.FileInfo(sPathFile);
                    fr.Delete();
                }
                catch { }
                DataDynamics.ActiveReports.Export.Rtf.RtfExport exp = new DataDynamics.ActiveReports.Export.Rtf.RtfExport();
                exp.EnableShapes = true;  
                exp.Export(viewer1.Document, sPathFile);
                MessageBox.Show("Kết xuất dữ liệu thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(sPathFile);
            }
            catch
            {
                MessageBox.Show("Lỗi, Kết xuất dữ liệu không thành công.", "TVS - Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        #endregion

        #region btnConfig_Click
        private void btnConfig_Click(object sender, EventArgs e)
        {
            TVSUtil.Reports.FrmConfig frmCon = new TVSUtil.Reports.FrmConfig();
            frmCon.ShowDialog();
            if (frmCon.sAction) this.LoadReport();
        }
        #endregion
    }
}