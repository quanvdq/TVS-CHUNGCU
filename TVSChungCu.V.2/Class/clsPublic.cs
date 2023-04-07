using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using C1.Win.C1TrueDBGrid;
using Microsoft.VisualBasic;
using System.Drawing;

namespace TVSMain
{
    public class clsPublic
    {       
        #region method Declare ...
        #endregion

        #region method clsPublic
        public clsPublic()
        {
           
        } 
        #endregion

        #region method GetServerDateTime
        public DateTime GetServerDateTime()
        {
            try
            {
                TVSSys.Connection objCon = new TVSSys.Connection();
                DataTable dt = objCon.EXESelect("Select getdate()");
                return DateTime.Parse(dt.Rows[0][0].ToString());
            }
            catch { return DateTime.Now; }
        }
        #endregion

        #region method TotalItem
        public int Get_TotalItem()
        {
            int sResult = 0;
            TVSSys.Connection  objCon = new TVSSys.Connection();
            //sResult += objCon.Get_EXESelectInt("SELECT count(distinct Time) FROM dbo.TblService")*40;
            sResult += objCon.Get_EXESelectInt("SELECT count(*) FROM dbo.TblRoom");
            sResult += objCon.Get_EXESelectInt("SELECT count(*) FROM dbo.TblService");
            return sResult;
        }
        #endregion

        #region method Images

        public Image GetImageFromByteArray(string sByteImage)
        {
            try
            {
                if (sByteImage.Trim() == "") return null;
                byte[] picData = Convert.FromBase64String(sByteImage);
                int bmData = (picData[0] == 0x15 && picData[1] == 0x1c) ? 78 : 0;
                Image img = null;
                try
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(picData, bmData, picData.Length - bmData);
                    img = Image.FromStream(ms);
                }
                catch { }
                return img;
            }
            catch { return null; }
        }

        public string UpLoad_StringImage(string strFile)
        {
            byte[] bImageFile;
            string strImageFile = "";
            bImageFile = File.ReadAllBytes(strFile);
            strImageFile = Convert.ToBase64String(bImageFile);
            return strImageFile;
        }

        public string ImageResize(System.Drawing.Image thisImage)
        {
            try
            {
                string sFileImage = AppDomain.CurrentDomain.BaseDirectory + "PartnerImage.jpg";
                //System.Drawing.Image thisImage = Image.FromFile(sPath);
                Bitmap outImage = new Bitmap(180, 240);
                Graphics outGraphics = Graphics.FromImage(outImage);
                SolidBrush sb = new SolidBrush(System.Drawing.Color.White);
                outGraphics.FillRectangle(sb, 0, 0, outImage.Width, outImage.Height);
                outGraphics.DrawImage(thisImage, 0, 0, outImage.Width, outImage.Height);
                sb.Dispose();
                outGraphics.Dispose();
                thisImage.Dispose();

                outImage.Save(sFileImage, System.Drawing.Imaging.ImageFormat.Jpeg);
                outImage.Dispose();
                return sFileImage;
            }
            catch { return ""; }
        }
        #endregion

        #region method Check_CDKey
        public bool Check_CDKey(string sKey)
        {
            try
            {
                string sListKey = "" +
                                ",PNQIGANQHAGAHQFNGIHG" +   //ALOFUN
                                "";
                return sListKey.Contains(sKey);
               // return true; 
            }
            catch { return false; }
        }
        #endregion
    }
}
 