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
    public partial class rptParking : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use  
        public static string srptID = "";
        #endregion

        #region method rptParking
        public rptParking()
        {
            InitializeComponent();
            string sSQL = "   Select NamePriceParking,Price" +
                            "   ,dbo.GetServiceParking(IDPriceParking," + srptID + ")  as Number " +
                            "   ,(dbo.GetServiceParking(IDPriceParking," + srptID + ")* isnull(Price,0))  as Money " + 
                            "   FROM TblPriceParking WHERE isnull(Action,0)=1";
            this.DataSource = TVSSys.GlobalModule.objCon.EXESelect(sSQL);
        } 
        #endregion
    }


}
