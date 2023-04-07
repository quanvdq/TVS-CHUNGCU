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
    public partial class rptWater : DataDynamics.ActiveReports.ActiveReport3
    {        
        #region Declare variable to use  
        public static string srptID = "";
        #endregion

        #region method rptWater
        public rptWater()
        {
            InitializeComponent();
            string sSQL =   "   Select Number,Price,Money" +
                            "   FROM TblServiceWaterDetail" +
                            "   WHERE Time=(SELECT Time FROM TblService WHERE  IDService= " + srptID + ")" +
                            "   AND IDRoom=(SELECT IDRoom FROM TblService WHERE  IDService= " + srptID + ")";
            this.DataSource = TVSSys.GlobalModule.objCon.EXESelect(sSQL);
        } 
        #endregion
    }


}
