using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;
using C1.Win.C1TrueDBGrid;

namespace TVSMain
{
    public class Room
    {       
        #region method Declare ...
        public static int sMapExpirationDate = 15;
        public static int sMapColumn = 15;
        public static int sMapRoomHeight = 10;
        public static int sMapRoomWidth = 10;
        public static int sMapRoomStep = 5;
        public static int sMapRoomTop = 15, sMapRoomLeft = 15;
        public static int sDateWarning = 0;
        public static System.Drawing.Color[] sMapRoomColor = new System.Drawing.Color[5];

        public static string sSQLRoomStatus= "";
        #endregion

        #region method Room
        public Room()
        {
            try
            {
                sMapRoomColor[0] = System.Drawing.Color.FromArgb(int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomColor0")));
                sMapRoomColor[1] = System.Drawing.Color.FromArgb(int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomColor1")));
                sMapRoomColor[2] = System.Drawing.Color.FromArgb(int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomColor2")));
                sMapRoomColor[3] = System.Drawing.Color.FromArgb(int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomColor3")));
                sMapRoomColor[4] = System.Drawing.Color.FromArgb(int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomColor4")));

                sMapRoomTop = int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomTop"));
                sMapRoomLeft = int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomLeft"));
                sMapColumn = int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomColumn"));
                sMapExpirationDate = int.Parse(TVSSys.GlobalModule.objXML.GetKey("RoomExpirationDate"));


                sSQLRoomStatus =    ", (case when (DateBegin is null AND DateEnd is null) then 1 else " + // chưa thuê
                                    " (case when (DateBegin is not null AND convert(nvarchar,getdate(),112)>convert(nvarchar,DateEnd,112)) then 4 else " + // thue quá hạn             
                                    " (case when (DateBegin is not null AND convert(nvarchar,getdate(),112)>convert(nvarchar,DATEADD(day,-" + Room.sMapExpirationDate.ToString() + ",DateEnd),112)) then 3 else " + // gần đến ngày quá hạn.
                                    " (case when (DateBegin is not null AND convert(nvarchar,getdate(),112)<=convert(nvarchar,DateEnd,112)) then 2 else " + // đang thue
                                    " 0 end) " +
                                    " end) " +
                                    " end) " +
                                    " end) as Status";
            }
            catch { }

        } 
        #endregion

        

    }
}
 