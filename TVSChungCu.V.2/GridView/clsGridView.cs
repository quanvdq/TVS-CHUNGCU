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
    public class clsGridView
    {       
        #region method Declare ...
        #endregion
        
        #region method clsGridView
        public clsGridView()
        {
           
        } 
        #endregion

        #region method Decleration
        public void DeclerationRoomType(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NameRoomType"].Caption = "Loại phòng";
                sDBGridView.Columns["Money"].Caption = "Chi phí chung";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";

                sDBGridView.Splits[0].DisplayColumns["Money"].Width = 120;
                sDBGridView.Columns["Money"].NumberFormat = "#,##0";
            }
            catch { }
        }

        public void DeclerationRoom(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["CodeRoom"].Caption = "Mã phòng";
                sDBGridView.Columns["NameRoom"].Caption = "Tên phòng";
                sDBGridView.Columns["IDPartner"].Caption = "Chủ hộ";

                sDBGridView.Columns["IDRoomType"].Caption = "Loại phòng";
                sDBGridView.Columns["IDPayWater"].Caption = "Sử dụng nước";
                sDBGridView.Columns["IDPayElectric"].Caption = "Sử dụng điện";
                sDBGridView.Columns["Action"].Caption = "Kích hoạt";
                sDBGridView.Columns["IDRegion"].Caption = "Khu vực";

                sDBGridView.Splits[0].DisplayColumns["CodeRoom"].Width = 80;
                sDBGridView.Splits[0].DisplayColumns["NameRoom"].Width = 180;
                sDBGridView.Splits[0].DisplayColumns["IDPartner"].Width = 200;
                sDBGridView.Splits[0].DisplayColumns["IDPayWater"].Width = 120;
                sDBGridView.Splits[0].DisplayColumns["IDPayElectric"].Width = 120;

                sDBGridView.Columns["DateBegin"].Caption = "Ngày bắt đầu";
                sDBGridView.Columns["DateEnd"].Caption = "Ngày kết thúc";

                sDBGridView.Columns["DateBegin"].NumberFormat = "dd/MM/yyyy";
                sDBGridView.Columns["DateEnd"].NumberFormat = "dd/MM/yyyy";


                CreateControlTrueDBDropdownPartner(sDBGridView);

                CreateControlTrueDBDropdown(sDBGridView, "IDRoomType");
                CreateControlTrueDBDropdown(sDBGridView, "IDPayWater");
                CreateControlTrueDBDropdown(sDBGridView, "IDPayElectric");
                CreateControlTrueDBDropdown(sDBGridView, "IDRegion");

                sDBGridView.Splits[0].DisplayColumns["DateBegin"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["DateEnd"].Style.HorizontalAlignment = AlignHorzEnum.Center;

                sDBGridView.Splits[0].DisplayColumns["Status"].Locked = true;
                sDBGridView.Columns["Status"].Caption = "Trạng thái";
                CreateControlTrueDBDropdown(sDBGridView, "IDUsedStatus", "NameUsedStatus", "TblUsedStatus", "Status");


                //sDBGridView.Columns["Status"].FilterDropdown =true;
            }
            catch { }
        }

        public void DeclerationPriceParking(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NamePriceParking"].Caption = "Loại xe gửi";
                sDBGridView.Columns["Price"].Caption = "Đơn giá";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";
                sDBGridView.Columns["Action"].Caption = "Kích hoạt";

                sDBGridView.Columns["Price"].NumberFormat = "#,##0";

                sDBGridView.Splits[0].DisplayColumns["NamePriceParking"].Width = 200;
            }
            catch { }
        }

        public void DeclerationPriceElectric(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["IDPayElectric"].Caption = "Sử dụng điện";
                sDBGridView.Columns["NamePriceElectric"].Caption = "Mức sử dụng";
                sDBGridView.Columns["Price"].Caption = "Đơn giá";
                sDBGridView.Columns["NumberMin"].Caption = "Số giới hạn";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";
                sDBGridView.Columns["Price"].NumberFormat = "#,##0";
                sDBGridView.Columns["NumberMin"].NumberFormat = "#,##0";

                CreateControlTrueDBDropdown(sDBGridView, "IDPayElectric");

                sDBGridView.Splits[0].DisplayColumns["IDPayElectric"].Width = 120;
                sDBGridView.Splits[0].DisplayColumns["NamePriceElectric"].Width = 200;
            }
            catch { }
        }

        public void DeclerationPriceWater(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["IDPayWater"].Caption = "Sử dụng nước";
                sDBGridView.Columns["NamePriceWater"].Caption = "Mức sử dụng";
                sDBGridView.Columns["Price"].Caption = "Đơn giá";
                sDBGridView.Columns["NumberMin"].Caption = "Số giới hạn";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";
                sDBGridView.Columns["Price"].NumberFormat = "#,##0";
                sDBGridView.Columns["NumberMin"].NumberFormat = "#,##0";

                CreateControlTrueDBDropdown(sDBGridView, "IDPayWater");

                sDBGridView.Splits[0].DisplayColumns["IDPayWater"].Width = 120;
                sDBGridView.Splits[0].DisplayColumns["NamePriceWater"].Width = 200;
            }
            catch { }
        }

        public void DeclerationPayWater(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NamePayWater"].Caption = "Hình thức sử dụng nước";

                sDBGridView.Splits[0].DisplayColumns["NamePayWater"].Width = 200;
            }
            catch { }
        }

        public void DeclerationPayElectric(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NamePayElectric"].Caption = "Hình thức sử dụng điện";
                sDBGridView.Splits[0].DisplayColumns["NamePayElectric"].Width = 200;
            }
            catch { }
        }

        public void DeclerationProduct(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NameProduct"].Caption = "Vật tư";
                sDBGridView.Columns["IDUnit"].Caption = "Đơn vị tính";
                sDBGridView.Columns["Price"].Caption = "Đơn giá";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";

                sDBGridView.Splits[0].DisplayColumns["NameProduct"].Width = 250;
                sDBGridView.Splits[0].DisplayColumns["IDUnit"].Width = 120;
                sDBGridView.Columns["Price"].NumberFormat = "#,##0";
                CreateControlTrueDBDropdown(sDBGridView, "IDUnit");
            }
            catch { }
        }

        public void DeclerationUnit(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NameUnit"].Caption = "Đơn vị tính";
            }
            catch { }
        }

        public void DeclerationRegion(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NameRegion"].Caption = "Khu vực";
                sDBGridView.Splits[0].DisplayColumns["NameRegion"].Width = 150;

                sDBGridView.Columns["Note"].Caption = "Diễn giải";
            }
            catch { }
        }

        public void DeclerationPartner(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns["IDPartner"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["Images"].Visible = false;
                for (int i = 0; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["Image"].Caption = "Ảnh";
                sDBGridView.Splits[0].DisplayColumns["Image"].Button = true;
                sDBGridView.Columns["CodePartner"].Caption = "Mã";
                sDBGridView.Columns["ContactPerson"].Caption = "Chủ hộ";
                sDBGridView.Columns["ContactPhone"].Caption = "Điện thoại";
                sDBGridView.Columns["Email"].Caption = "Email";
                sDBGridView.Columns["Career"].Caption = "Nghề nghiệp";
                sDBGridView.Columns["Birthday"].Caption = "Ngày sinh";
                sDBGridView.Columns["Address"].Caption = "Địa chỉ";
                sDBGridView.Columns["Native"].Caption = "Quê quán";
                sDBGridView.Columns["IDSex"].Caption = "Giới tính";
                sDBGridView.Columns["MaritalStatus"].Caption = "Hôn nhân";
                sDBGridView.Columns["IdentityCardNo"].Caption = "Số CMND";
                sDBGridView.Columns["DateIssued"].Caption = "Ngày cấp";
                sDBGridView.Columns["PlaceIssued"].Caption = "Nơi cấp";
                sDBGridView.Columns["VidaCardNo"].Caption = "Số hộ chiếu";

                sDBGridView.Columns["ContactPersonExt"].Caption = "Người liên hệ";
                sDBGridView.Columns["ContactPhoneExt"].Caption = "Điện thoại";
                sDBGridView.Columns["EmailExt"].Caption = "Email";
                sDBGridView.Columns["CareerExt"].Caption = "Nghề nghiệp";
                sDBGridView.Columns["BirthdayExt"].Caption = "Ngày sinh";

                sDBGridView.Columns["Tax"].Caption = "Mã số thuế";
                sDBGridView.Columns["AccountNo"].Caption = "Tài khoản";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";

                sDBGridView.Splits[0].DisplayColumns["Image"].Width = 90;
                sDBGridView.Splits[0].DisplayColumns["ContactPerson"].Width = 180;
                sDBGridView.Splits[0].DisplayColumns["Birthday"].Width = 80;
                sDBGridView.Splits[0].DisplayColumns["IDSex"].Width = 70;
                sDBGridView.Splits[0].DisplayColumns["DateIssued"].Width = 80;
                sDBGridView.Splits[0].DisplayColumns["ContactPersonExt"].Width = 180;
                sDBGridView.Splits[0].DisplayColumns["BirthdayExt"].Width = 80;

                sDBGridView.Columns["Birthday"].NumberFormat = "dd/MM/yyyy";
                sDBGridView.Columns["DateIssued"].NumberFormat = "dd/MM/yyyy";
                sDBGridView.Columns["BirthdayExt"].NumberFormat = "dd/MM/yyyy";

                CreateControlTrueDBDropdown(sDBGridView, "IDSex");


                sDBGridView.Splits[0].DisplayColumns["Birthday"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["IDSex"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["DateIssued"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["BirthdayExt"].Style.HorizontalAlignment = AlignHorzEnum.Center;

            }
            catch { }
        }

        public void DeclerationFamily(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns["IDFamily"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["IDPartner"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["Images"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["CodeFamily"].Visible = false;
                for (int i = 0; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["Image"].Caption = "Ảnh";
                sDBGridView.Splits[0].DisplayColumns["Image"].Button = true;
                sDBGridView.Columns["CodeFamily"].Caption = "Mã";
                sDBGridView.Columns["NameFamily"].Caption = "Họ và tên";
                sDBGridView.Columns["IDFamilyRelations"].Caption = "Quan hệ";
                sDBGridView.Columns["Phone"].Caption = "Điện thoại";
                sDBGridView.Columns["Email"].Caption = "Email";
                sDBGridView.Columns["Career"].Caption = "Nghề nghiệp";
                sDBGridView.Columns["Birthday"].Caption = "Ngày sinh";
                sDBGridView.Columns["Address"].Caption = "Địa chỉ";
                sDBGridView.Columns["Native"].Caption = "Quê quán";
                sDBGridView.Columns["IDSex"].Caption = "Giới tính";
                sDBGridView.Columns["MaritalStatus"].Caption = "Hôn nhân";
                sDBGridView.Columns["IdentityCardNo"].Caption = "Số CMND";
                sDBGridView.Columns["DateIssued"].Caption = "Ngày cấp";
                sDBGridView.Columns["PlaceIssued"].Caption = "Nơi cấp";
                sDBGridView.Columns["VidaCardNo"].Caption = "Số hộ chiếu";

                sDBGridView.Columns["Note"].Caption = "Ghi chú";

                sDBGridView.Splits[0].DisplayColumns["Image"].Width = 90;
                sDBGridView.Splits[0].DisplayColumns["NameFamily"].Width = 180;
                sDBGridView.Splits[0].DisplayColumns["Birthday"].Width = 80;
                sDBGridView.Splits[0].DisplayColumns["IDSex"].Width = 70;
                sDBGridView.Splits[0].DisplayColumns["DateIssued"].Width = 80;

                sDBGridView.Columns["Birthday"].NumberFormat = "dd/MM/yyyy";
                sDBGridView.Columns["DateIssued"].NumberFormat = "dd/MM/yyyy";

                CreateControlTrueDBDropdown(sDBGridView, "IDSex");
                CreateControlTrueDBDropdown(sDBGridView, "IDFamilyRelations");

                sDBGridView.Splits[0].DisplayColumns["Birthday"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["IDSex"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["DateIssued"].Style.HorizontalAlignment = AlignHorzEnum.Center;
            }
            catch { }
        }
        #endregion

        #region method Service
        public void ServiceUsed(string sService,C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["IDRegion"].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                    sDBGridView.Splits[0].DisplayColumns[i].Visible = false;
                    sDBGridView.Splits[0].DisplayColumns[i].Width = 80;
                }
                sDBGridView.Columns["IDRoom"].Caption = "Phòng, khách hàng";
                sDBGridView.Splits[0].DisplayColumns["IDRoom"].Visible = true;
                sDBGridView.Splits[0].DisplayColumns["IDRoom"].Width = 270;
                sDBGridView.Splits[0].DisplayColumns["IDRoom"].Frozen = true;

                sDBGridView.Columns["MoneyPublic"].Caption = "Phí tiền phòng";
                sDBGridView.Splits[0].DisplayColumns["MoneyPublic"].Locked = true;
                sDBGridView.Columns["MoneyPublic"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["MoneyPublic"].Width = 100;

                sDBGridView.Columns["MoneyParking"].Caption = "Tiền gửi xe";
                sDBGridView.Splits[0].DisplayColumns["MoneyParking"].Locked = true;
                sDBGridView.Columns["MoneyParking"].NumberFormat = "#,##0";

                sDBGridView.Columns["NumberBeginWater"].Caption = "Chỉ số đầu";
                sDBGridView.Columns["NumberEndWater"].Caption = "Chỉ số cuối";
                sDBGridView.Columns["NumberWater"].Caption = "Sử dụng";
                sDBGridView.Columns["MoneyWater"].Caption = "Tiền nước";

                sDBGridView.Columns["NumberBeginWater"].NumberFormat = "#,##0.0";
                sDBGridView.Columns["NumberEndWater"].NumberFormat = "#,##0.0";
                sDBGridView.Columns["NumberWater"].NumberFormat = "#,##0.0";
                sDBGridView.Columns["MoneyWater"].NumberFormat = "#,##0";

                sDBGridView.Columns["NumberBeginElectric"].Caption = "Chỉ số đầu";
                sDBGridView.Columns["NumberEndElectric"].Caption = "Chỉ số cuối";
                sDBGridView.Columns["NumberElectric"].Caption = "Sử dụng";
                sDBGridView.Columns["MoneyElectric"].Caption = "Tiền điện";

                sDBGridView.Columns["NumberBeginElectric"].NumberFormat = "#,##0.0";
                sDBGridView.Columns["NumberEndElectric"].NumberFormat = "#,##0.0";
                sDBGridView.Columns["NumberElectric"].NumberFormat = "#,##0.0";
                sDBGridView.Columns["MoneyElectric"].NumberFormat = "#,##0";

                sDBGridView.Columns["MoneyDebt"].Caption = "Nợ cũ";
                sDBGridView.Splits[0].DisplayColumns["MoneyDebt"].Width = 80;
                sDBGridView.Columns["MoneyDebt"].NumberFormat = "#,##0";

                sDBGridView.Splits[0].DisplayColumns["Note"].Visible = true;
                sDBGridView.Columns["Note"].Caption = "Ghi chú";

                sDBGridView.Columns["SentNotification"].Caption = "TB";
                sDBGridView.Splits[0].DisplayColumns["SentNotification"].Visible = true;
                sDBGridView.Splits[0].DisplayColumns["SentNotification"].Width = 30;
                sDBGridView.Splits[0].DisplayColumns["SentNotification"].Locked = true;

                CreateControlTrueDBDropdownRoom(sDBGridView);
                sDBGridView.Splits[0].DisplayColumns["IDRoom"].Button = false;
                switch (sService)
                {
                    case "Parking": 
                        {
                            string sColumn = "";
                            DataTable sTemp = TVSSys.GlobalModule.objCon.EXESelect("SELECT * FROM TblPriceParking Where isnull(Action,0)=1");
                            if (sTemp.Rows.Count > 0)
                            {
                                for (int i = 0; i < sTemp.Rows.Count; i++)
                                {
                                    sColumn = "IDPriceParking" + sTemp.Rows[i]["IDPriceParking"].ToString();
                                    sDBGridView.Splits[0].DisplayColumns[sColumn].Visible = true;
                                    sDBGridView.Columns[sColumn].Caption = sTemp.Rows[i]["NamePriceParking"].ToString();

                                    sDBGridView.Columns[sColumn].NumberFormat = "#,##0.0";
                                }
                            }

                            sDBGridView.Columns["NoteParking"].Caption = "Biển số xe";
                            sDBGridView.Splits[0].DisplayColumns["NoteParking"].Visible = true;

                            sDBGridView.Splits[0].DisplayColumns["MoneyParking"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyParking"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["MoneyParking"].Style.ForeColor = System.Drawing.Color.Blue;
                            sDBGridView.Splits[0].DisplayColumns["MoneyParking"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;

                            sDBGridView.Splits[0].DisplayColumns["Note"].Visible = false;
                            break; }
                    case "Water":
                        {
                            sDBGridView.Splits[0].DisplayColumns["NumberBeginWater"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["NumberEndWater"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["NumberWater"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyWater"].Visible = true;

                            sDBGridView.Splits[0].DisplayColumns["NumberWater"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["NumberWater"].Style.ForeColor = System.Drawing.Color.Brown;
                            sDBGridView.Splits[0].DisplayColumns["NumberWater"].HeadingStyle.ForeColor = System.Drawing.Color.Brown;
                            sDBGridView.Splits[0].DisplayColumns["NumberWater"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyWater"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyWater"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["MoneyWater"].Style.ForeColor = System.Drawing.Color.Blue;
                            sDBGridView.Splits[0].DisplayColumns["MoneyWater"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;
                            break;
                        }
                    case "Electric":
                        {
                            sDBGridView.Splits[0].DisplayColumns["NumberBeginElectric"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["NumberEndElectric"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["NumberElectric"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyElectric"].Visible = true;

                            sDBGridView.Splits[0].DisplayColumns["NumberElectric"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["NumberElectric"].Style.ForeColor = System.Drawing.Color.Brown;
                            sDBGridView.Splits[0].DisplayColumns["NumberElectric"].HeadingStyle.ForeColor = System.Drawing.Color.Brown;
                            sDBGridView.Splits[0].DisplayColumns["NumberElectric"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyElectric"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyElectric"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["MoneyElectric"].Style.ForeColor = System.Drawing.Color.Blue;
                            sDBGridView.Splits[0].DisplayColumns["MoneyElectric"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;
                            break;
                        }
                    case "Service": 
                        {
                            sDBGridView.Splits[0].DisplayColumns["MoneyPublic"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyParking"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyParking"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyWater"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyWater"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyElectric"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyElectric"].Visible = true;

                            sDBGridView.Splits[0].DisplayColumns["MoneyOther"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyDebt"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyService"].Visible = true;

                            sDBGridView.Splits[0].DisplayColumns["MoneyPayPublic"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayParking"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayWater"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayElectric"].Visible = true;

                            sDBGridView.Splits[0].DisplayColumns["MoneyPayOther"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayService"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayService"].Visible = true;

                            sDBGridView.Columns["MoneyPayDebt"].Caption = "Thu nợ cũ";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayDebt"].Width = 80;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayDebt"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayDebt"].Style.ForeColor = System.Drawing.Color.Red;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayDebt"].HeadingStyle.ForeColor = System.Drawing.Color.Red;

                            sDBGridView.Columns["MoneyDebtBalancer"].Caption = "Tổng nợ";
                            sDBGridView.Splits[0].DisplayColumns["MoneyDebtBalancer"].Width = 90;
                            sDBGridView.Splits[0].DisplayColumns["MoneyDebtBalancer"].Visible = true;

                            sDBGridView.Columns["MoneyPayPublic"].Caption = "Thu phí";
                            sDBGridView.Columns["MoneyPayPublic"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayPublic"].Width = 70;
                            
                            sDBGridView.Columns["MoneyPayParking"].Caption = "Thu tiền gửi xe";
                            sDBGridView.Columns["MoneyPayParking"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayParking"].Width = 110;
                            
                            sDBGridView.Columns["MoneyPayWater"].Caption = "Thu tiền nước";
                            sDBGridView.Columns["MoneyPayWater"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayWater"].Width = 110;

                            sDBGridView.Columns["MoneyPayElectric"].Caption = "Thu tiền điện";
                            sDBGridView.Columns["MoneyPayElectric"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayElectric"].Width = 110;
                            
                            sDBGridView.Columns["MoneyPayOther"].Caption = "Thu khác";
                            sDBGridView.Columns["MoneyPayOther"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayOther"].Style.ForeColor = System.Drawing.Color.Red;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayOther"].HeadingStyle.ForeColor = System.Drawing.Color.Red;

                            sDBGridView.Columns["MoneyOther"].Caption = "Phí khác";
                            sDBGridView.Columns["MoneyOther"].NumberFormat = "#,##0";
                            //sDBGridView.Splits[0].DisplayColumns["MoneyOther"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            //sDBGridView.Splits[0].DisplayColumns["MoneyOther"].Style.ForeColor = System.Drawing.Color.Blue;
                            //sDBGridView.Splits[0].DisplayColumns["MoneyOther"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;

                            sDBGridView.Columns["MoneyService"].Caption = "Tổng thu";
                            sDBGridView.Columns["MoneyService"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyService"].Locked = true;
                            sDBGridView.Splits[0].DisplayColumns["MoneyService"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["MoneyService"].Style.ForeColor = System.Drawing.Color.Blue;
                            sDBGridView.Splits[0].DisplayColumns["MoneyService"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;

                            sDBGridView.Splits[0].DisplayColumns["PayAll"].Visible = true;
                            sDBGridView.Splits[0].DisplayColumns["PayAll"].Locked = true;
                            sDBGridView.Columns["PayAll"].Caption = "Trả hết";
                            sDBGridView.Splits[0].DisplayColumns["PayAll"].Width = 60;

                            sDBGridView.Splits[0].DisplayColumns["MoneyPayPublic"].Style.ForeColor = System.Drawing.Color.OrangeRed;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayPublic"].HeadingStyle.ForeColor = System.Drawing.Color.OrangeRed;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayParking"].Style.ForeColor = System.Drawing.Color.OrangeRed;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayParking"].HeadingStyle.ForeColor = System.Drawing.Color.OrangeRed;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayWater"].Style.ForeColor = System.Drawing.Color.OrangeRed;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayWater"].HeadingStyle.ForeColor = System.Drawing.Color.OrangeRed;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayElectric"].Style.ForeColor = System.Drawing.Color.OrangeRed;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayElectric"].HeadingStyle.ForeColor = System.Drawing.Color.OrangeRed;

                            sDBGridView.Columns["MoneyPayService"].Caption = "Đã thanh toán";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayService"].Width = 100;
                            sDBGridView.Columns["MoneyPayService"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayService"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayService"].Style.ForeColor = System.Drawing.Color.Blue;
                            sDBGridView.Splits[0].DisplayColumns["MoneyPayService"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;

                            sDBGridView.Columns["MoneyDebtBalancer"].Caption = "Còn nợ";
                            sDBGridView.Splits[0].DisplayColumns["MoneyDebtBalancer"].Locked = true;
                            sDBGridView.Columns["MoneyDebtBalancer"].NumberFormat = "#,##0";
                            sDBGridView.Splits[0].DisplayColumns["MoneyDebtBalancer"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                            sDBGridView.Splits[0].DisplayColumns["MoneyDebtBalancer"].Style.ForeColor = System.Drawing.Color.Red;
                            sDBGridView.Splits[0].DisplayColumns["MoneyDebtBalancer"].HeadingStyle.ForeColor = System.Drawing.Color.Red;

                            sDBGridView.Splits[0].DisplayColumns["Printer"].Visible = true;
                            sDBGridView.Columns["Printer"].Caption = "Phiếu";
                            sDBGridView.Splits[0].DisplayColumns["Printer"].Width = 50;

                            sDBGridView.Splits[0].DisplayColumns["PaymentByMomo"].Visible = true;
                            sDBGridView.Columns["PaymentByMomo"].Caption = "MOMO";
                            sDBGridView.Splits[0].DisplayColumns["PaymentByMomo"].Width = 50;

                            sDBGridView.Columns["Send"].Caption = "TB";
                            break; }
                }

                sDBGridView.Splits[0].DisplayColumns["IDRoom"].Frozen = true;
            }
            catch { }
        }
        #endregion

        #region Set_GridViewPaymentVoucher
        public void DeclerationPaymentVoucher(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[1].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NamePaymentVoucherType"].Caption = "Khoản thu chi";
            }
            catch { }
        }

        public void Set_GridViewPaymentVoucher(C1TrueDBGrid sDBGridView,string sGroup)
        {
            try
            {
                string sCaption = " thu";
                if (sGroup == "2") sCaption = " chi";

                sDBGridView.Splits[0].DisplayColumns["NamePartner"].Button = true;
                sDBGridView.Splits[0].DisplayColumns["IDPartner"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["IDPaymentVoucherTypeGroup"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["UserName"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["DateCreate"].Visible = false;
                sDBGridView.Splits[0].DisplayColumns["IDService"].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Splits[0].DisplayColumns["PhonePartner"].Width = 150;
                sDBGridView.Splits[0].DisplayColumns["AddressPartner"].Width = 250;
                sDBGridView.Splits[0].DisplayColumns["NamePartner"].Width = 250;
                sDBGridView.Splits[0].DisplayColumns["DatePaymentVoucher"].Width = 80;

                sDBGridView.Columns["CodePaymentVoucher"].Caption = "Số phiếu";
                sDBGridView.Columns["DatePaymentVoucher"].Caption = "Ngày phiếu";
                sDBGridView.Columns["NamePartner"].Caption = "Tên đối tác";
                sDBGridView.Columns["AddressPartner"].Caption = "Địa chỉ";
                sDBGridView.Columns["PhonePartner"].Caption = "Điện thoại";
                sDBGridView.Columns["IDPaymentVoucherType"].Caption = "Khoản" + sCaption;
                sDBGridView.Splits[0].DisplayColumns["IDPaymentVoucherType"].Width = 120;
                sDBGridView.Columns["Money"].Caption = "Số tiền";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";
                sDBGridView.Splits[0].DisplayColumns["CodePaymentVoucher"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["DatePaymentVoucher"].Style.HorizontalAlignment = AlignHorzEnum.Center;

                sDBGridView.Columns["DatePaymentVoucher"].NumberFormat = "dd/MM/yyyy";
                sDBGridView.Columns["Money"].NumberFormat = "#,##0";
                CreateControlTrueDBDropdown(sDBGridView, "IDPaymentVoucherType",sGroup);

                sDBGridView.Splits[0].DisplayColumns["CodePaymentVoucher"].Locked = true;

                sDBGridView.Splits[0].DisplayColumns["Money"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                sDBGridView.Splits[0].DisplayColumns["Money"].Style.ForeColor = System.Drawing.Color.Blue;
                sDBGridView.Splits[0].DisplayColumns["Money"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;
                CreateControlTrueDBDropdown(sDBGridView, "UserName", "FullName", "TabUser");
            }
            catch { }
        }

        public void Set_GridViewPaymentVoucherList(C1TrueDBGrid sDBGridView)
        {
            try
            {
                
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Splits[0].DisplayColumns["AddressPartner"].Width = 250;
                sDBGridView.Splits[0].DisplayColumns["NamePartner"].Width = 250;
                sDBGridView.Splits[0].DisplayColumns["DatePaymentVoucher"].Width = 80;

                sDBGridView.Columns["CodePaymentVoucher"].Caption = "Số phiếu";
                sDBGridView.Columns["DatePaymentVoucher"].Caption = "Ngày phiếu";
                sDBGridView.Columns["Group"].Caption = "Loại thu chi";
                sDBGridView.Columns["NamePartner"].Caption = "Tên đối tác";
                sDBGridView.Columns["AddressPartner"].Caption = "Địa chỉ";
                sDBGridView.Columns["IDPaymentVoucherType"].Caption = "Khoản thu/chi";
                sDBGridView.Splits[0].DisplayColumns["IDPaymentVoucherType"].Width = 120;
                sDBGridView.Columns["Money"].Caption = "Số tiền";
                sDBGridView.Columns["UserName"].Caption = "Người cập nhật";
                sDBGridView.Splits[0].DisplayColumns["CodePaymentVoucher"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["DatePaymentVoucher"].Style.HorizontalAlignment = AlignHorzEnum.Center;

                sDBGridView.Columns["DatePaymentVoucher"].NumberFormat = "dd/MM/yyyy";
                sDBGridView.Columns["Money"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["Money"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                sDBGridView.Splits[0].DisplayColumns["Money"].Style.ForeColor = System.Drawing.Color.Blue;
                sDBGridView.Splits[0].DisplayColumns["Money"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;
                sDBGridView.Splits[0].DisplayColumns["Group"].Visible = false;
                CreateControlTrueDBDropdown(sDBGridView, "UserName", "FullName", "TabUser");
            }
            catch { }
        }


        public void Set_GridViewPartnerBalance(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns["IDPartner"].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Splits[0].DisplayColumns["ContactPerson"].Width = 200;
                sDBGridView.Splits[0].DisplayColumns["Address"].Width = 250;
                sDBGridView.Splits[0].DisplayColumns["BalanceFirst"].Width = 120;
                sDBGridView.Splits[0].DisplayColumns["BalanceLast"].Width = 120;

                sDBGridView.Columns["ContactPerson"].Caption = "Tên đối tác";
                sDBGridView.Columns["NameRoom"].Caption = "Phòng";
                sDBGridView.Columns["ContactPhone"].Caption = "Điện thoại";                
                sDBGridView.Columns["Address"].Caption = "Địa chỉ";
                sDBGridView.Columns["BalanceFirst"].Caption = "Công nợ đầu kỳ";
                sDBGridView.Columns["BalanceUp"].Caption = "Công nợ tăng";
                sDBGridView.Columns["BalanceDown"].Caption = "Công nợ giảm";
                sDBGridView.Columns["BalanceLast"].Caption = "Công nợ cuối kỳ";                
                sDBGridView.Splits[0].DisplayColumns["NameRoom"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Splits[0].DisplayColumns["ContactPhone"].Style.HorizontalAlignment = AlignHorzEnum.Center;

                sDBGridView.Columns["BalanceFirst"].NumberFormat = "#,##0";
                sDBGridView.Columns["BalanceUp"].NumberFormat = "#,##0";
                sDBGridView.Columns["BalanceDown"].NumberFormat = "#,##0";
                sDBGridView.Columns["BalanceLast"].NumberFormat = "#,##0";
            }
            catch { }
        }
        #endregion

        #region Product
        public void Set_GridViewBill(C1TrueDBGrid sDBGridView)
        {
            try
            {
                for (int i = 0; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                    sDBGridView.Splits[0].DisplayColumns[i].Visible = false;
                }
                sDBGridView.Columns["DateBill"].Caption = "Ngày hóa đơn";
                sDBGridView.Splits[0].DisplayColumns["DateBill"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Columns["DateBill"].NumberFormat = "dd/MM/yyyy";
                sDBGridView.Splits[0].DisplayColumns["DateBill"].Visible = true;
                sDBGridView.Splits[0].DisplayColumns["CodeBill"].Visible = true;
                sDBGridView.Columns["CodeBill"].Caption = "Số hóa đơn";
                sDBGridView.Splits[0].DisplayColumns["CodeBill"].Width = 125;
            }
            catch { }
        }

        public void Set_GridViewBillDetail(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[1].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["IDProduct"].Caption = "Vật tư";
                sDBGridView.Splits[0].DisplayColumns["IDProduct"].Width = 300;
                sDBGridView.Columns["IDUnit"].Caption = "ĐVT";
                sDBGridView.Splits[0].DisplayColumns["IDUnit"].Width = 60;
                sDBGridView.Columns["Number"].Caption = "Số lượng";
                sDBGridView.Columns["Number"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["Number"].Width = 70;
                sDBGridView.Columns["Price"].Caption = "Đơn giá";
                sDBGridView.Columns["Price"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["Price"].Width = 80;
                sDBGridView.Columns["VAT"].Caption = "VAT";
                sDBGridView.Columns["VAT"].NumberFormat = "#,##0.0";
                sDBGridView.Splits[0].DisplayColumns["VAT"].Width = 50;
                sDBGridView.Splits[0].DisplayColumns["VAT"].Style.HorizontalAlignment = AlignHorzEnum.Center;
                sDBGridView.Columns["Money"].Caption = "Thành tiền";
                sDBGridView.Columns["Money"].NumberFormat = "#,##0";
                sDBGridView.Columns["Note"].Caption = "Ghi chú";

                this.CreateControlTrueDBDropdown(sDBGridView, "IDProduct");
                this.CreateControlTrueDBDropdown(sDBGridView, "IDUnit");

                sDBGridView.Splits[0].DisplayColumns["Money"].Locked = true;
                sDBGridView.Splits[0].DisplayColumns["Money"].Style.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
                sDBGridView.Splits[0].DisplayColumns["Money"].Style.ForeColor = System.Drawing.Color.Blue;
                sDBGridView.Splits[0].DisplayColumns["Money"].HeadingStyle.ForeColor = System.Drawing.Color.Blue;
            }
            catch { }
        }

        public void Set_GridViewProductList(C1TrueDBGrid sDBGridView)
        {
            try
            {
                sDBGridView.Splits[0].DisplayColumns[0].Visible = false;
                for (int i = 1; i < sDBGridView.Columns.Count; i++)
                {
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.HorizontalAlignment = AlignHorzEnum.Center;
                    sDBGridView.Splits[0].DisplayColumns[i].HeadingStyle.WrapText = true;
                }
                sDBGridView.Columns["NameProduct"].Caption = "Vật tư";
                sDBGridView.Splits[0].DisplayColumns["NameProduct"].Width = 250;
                sDBGridView.Columns["NameUnit"].Caption = "ĐVT";
                sDBGridView.Splits[0].DisplayColumns["NameUnit"].Width = 60;
                sDBGridView.Columns["Price"].Caption = "Đơn giá";
                sDBGridView.Columns["Price"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["Price"].Width = 80;

                sDBGridView.Columns["NumberFirst"].Caption = "Tồn đầu";
                sDBGridView.Columns["NumberFirst"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["NumberFirst"].Width = 70;
                sDBGridView.Columns["MoneyFirst"].Caption = "Thành tiền";
                sDBGridView.Columns["MoneyFirst"].NumberFormat = "#,##0";
                //sDBGridView.Splits[0].DisplayColumns["MoneyFirst"].Width = 80;

                sDBGridView.Columns["NumberInput"].Caption = "Nhập hàng";
                sDBGridView.Columns["NumberInput"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["NumberInput"].Width = 75;
                sDBGridView.Columns["MoneyInput"].Caption = "Thành tiền";
                sDBGridView.Columns["MoneyInput"].NumberFormat = "#,##0";
                //sDBGridView.Splits[0].DisplayColumns["MoneyInput"].Width = 80;

                sDBGridView.Columns["NumberOutput"].Caption = "Xuất hàng";
                sDBGridView.Columns["NumberOutput"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["NumberOutput"].Width = 70;
                sDBGridView.Columns["MoneyOutput"].Caption = "Thành tiền";
                sDBGridView.Columns["MoneyOutput"].NumberFormat = "#,##0";
                //sDBGridView.Splits[0].DisplayColumns["MoneyOutput"].Width = 80;

                sDBGridView.Columns["NumberLast"].Caption = "Tồn cuối";
                sDBGridView.Columns["NumberLast"].NumberFormat = "#,##0";
                sDBGridView.Splits[0].DisplayColumns["NumberLast"].Width = 70;
                sDBGridView.Columns["MoneyLast"].Caption = "Thành tiền";
                sDBGridView.Columns["MoneyLast"].NumberFormat = "#,##0";
                //sDBGridView.Splits[0].DisplayColumns["MoneyLast"].Width = 80;
                sDBGridView.Columns["Note"].Caption = "Ghi chú";

                sDBGridView.Splits[0].DisplayColumns["NameProduct"].Frozen = true;

            }
            catch { }
        }
        #endregion

        #region method CreateControlTrueDBDropdown
        private void CreateControlTrueDBDropdown(C1TrueDBGrid sDBGridView, string sFieldID, string sFieldName, string sTable,string sColumn)
        {
            C1TrueDBDropdown objControl = new C1TrueDBDropdown();
            sDBGridView.FindForm().Controls.Add(objControl);
            objControl.ColumnHeaders = false;
            objControl.Height = 120;
            objControl.RowHeight = 22;
            objControl.Style.VerticalAlignment = AlignVertEnum.Center;
            objControl.Style.HorizontalAlignment = AlignHorzEnum.Far;
            objControl.Cursor = Cursors.Hand;
            objControl.Width = 250;
            objControl.ExtendRightColumn = true;
            try
            {
                TVSSys.Connection objCon = new TVSSys.Connection();
                objControl.DataSource = objCon.EXESelect("Select " + sFieldID + ", " + sFieldName + " from " + sTable + " order by " + sFieldName);
                sDBGridView.Columns[sColumn].DropDown = objControl;
                sDBGridView.Splits[0].DisplayColumns[sColumn].Style.HorizontalAlignment = AlignHorzEnum.Justify;
                objControl.DataField = sFieldID;
                objControl.ListField = sFieldName;
                sDBGridView.Columns[sColumn].ValueItems.Translate = true;
                objControl.ValueTranslate = true;
                objControl.DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[sColumn].FilterButton = true;
                sDBGridView.Splits[0].DisplayColumns[sColumn].AutoComplete = true;
            }
            catch
            {
            }
        }
        private void CreateControlTrueDBDropdown(C1TrueDBGrid sDBGridView, string sFieldID, string sFieldName, string sTable)
        {
            C1TrueDBDropdown objControl = new C1TrueDBDropdown();
            sDBGridView.FindForm().Controls.Add(objControl);
            objControl.ColumnHeaders = false;
            objControl.Height = 120;
            objControl.RowHeight = 22;
            objControl.Style.VerticalAlignment = AlignVertEnum.Center;
            objControl.Style.HorizontalAlignment = AlignHorzEnum.Far;
            objControl.Cursor = Cursors.Hand;
            objControl.Width = sDBGridView.Splits[0].DisplayColumns[sFieldID].Width;
            objControl.ExtendRightColumn = true;
            try
            {
                TVSSys.Connection objCon = new TVSSys.Connection();
                objControl.DataSource = objCon.EXESelect("Select " + sFieldID + ", " + sFieldName + " from " + sTable + " order by " + sFieldName);
                sDBGridView.Columns[sFieldID].DropDown = objControl;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].Style.HorizontalAlignment = AlignHorzEnum.Justify;
                objControl.DataField = sFieldID;
                objControl.ListField = sFieldName;
                sDBGridView.Columns[sFieldID].ValueItems.Translate = true;
                objControl.ValueTranslate = true;
                objControl.DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].FilterButton = true;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].AutoComplete = true; 
            }
            catch
            {
            }
        }
        public void CreateControlTrueDBDropdown(C1TrueDBGrid sDBGridView, string sFieldID, string sGroup)
        {
            string sFieldName, sTable;
            try
            {
                sFieldName = "Name" + sFieldID.Substring(2);
                sTable = "Tbl" + sFieldID.Substring(2);
                C1TrueDBDropdown objControl = new C1TrueDBDropdown();
                sDBGridView.FindForm().Controls.Add(objControl);
                objControl.ColumnHeaders = false;
                objControl.Height = 120;
                objControl.RowHeight = 22;
                objControl.Style.VerticalAlignment = AlignVertEnum.Center;
                objControl.Style.HorizontalAlignment = AlignHorzEnum.Far;
                objControl.Cursor = Cursors.Hand;
                objControl.Width = sDBGridView.Splits[0].DisplayColumns[sFieldID].Width; 
                objControl.ExtendRightColumn = true;

                TVSSys.Connection objCon = new TVSSys.Connection();
                objControl.DataSource = objCon.EXESelect("Select " + sFieldID + ", " + sFieldName + " from " + sTable + " WHERE IDGroupPaymentVoucherType=" + sGroup + " order by " + sFieldName);
                sDBGridView.Columns[sFieldID].DropDown = objControl;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].Style.HorizontalAlignment = AlignHorzEnum.Justify;
                objControl.DataField = sFieldID;
                objControl.ListField = sFieldName;
                sDBGridView.Columns[sFieldID].ValueItems.Translate = true;
                objControl.ValueTranslate = true;
                objControl.DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].FilterButton = true;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].AutoComplete = true; 
            }
            catch
            {
            }
        }
        public void CreateControlTrueDBDropdown(C1TrueDBGrid sDBGridView, string sFieldID)
        {
            string sFieldName, sTable;
            try
            {
                sFieldName = "Name" + sFieldID.Substring(2);
                sTable = "Tbl" + sFieldID.Substring(2);
                C1TrueDBDropdown objControl = new C1TrueDBDropdown();
                sDBGridView.FindForm().Controls.Add(objControl);
                objControl.ColumnHeaders = false;
                objControl.Height = 120;
                objControl.RowHeight = 22;
                objControl.Style.VerticalAlignment = AlignVertEnum.Center;
                objControl.Style.HorizontalAlignment = AlignHorzEnum.Far;
                objControl.Cursor = Cursors.Hand;
                objControl.Width = sDBGridView.Splits[0].DisplayColumns[sFieldID].Width;
                objControl.ExtendRightColumn = true;

                TVSSys.Connection objCon = new TVSSys.Connection();
                objControl.DataSource = objCon.EXESelect("Select " + sFieldID + ", " + sFieldName + " from " + sTable + " order by " + sFieldName);
                sDBGridView.Columns[sFieldID].DropDown = objControl;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].Style.HorizontalAlignment = AlignHorzEnum.Justify;
                objControl.DataField = sFieldID;
                objControl.ListField = sFieldName;
                sDBGridView.Columns[sFieldID].ValueItems.Translate = true;
                objControl.ValueTranslate = true;
                objControl.DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].FilterButton = true;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].AutoComplete = true;
            }
            catch
            {
            }
        }
        public void CreateControlTrueDBDropdownRoom(C1TrueDBGrid sDBGridView)
        {
            string sFieldID,sFieldName, sTable;
            try
            {
                sFieldID = "IDRoom";
                sFieldName = "NameRoom";
                sTable = "TblRoom";
                C1TrueDBDropdown objControl = new C1TrueDBDropdown();
                sDBGridView.FindForm().Controls.Add(objControl);
                objControl.ColumnHeaders = false;
                objControl.Height = 120;
                objControl.RowHeight = 22;
                objControl.Style.VerticalAlignment = AlignVertEnum.Center;
                objControl.Style.HorizontalAlignment = AlignHorzEnum.Far;
                objControl.Cursor = Cursors.Hand;
                objControl.Width = sDBGridView.Splits[0].DisplayColumns[sFieldID].Width;
                objControl.ExtendRightColumn = true;

                TVSSys.Connection objCon = new TVSSys.Connection();
                objControl.DataSource = objCon.EXESelect("Select IDRoom, (NameRoom + ': ' + ISNULL(ContactPerson,'') + '. ' + ISNULL(Address,'')) as NameRoom  from " + sTable + "  LEFT JOIN TblPartner ON TblPartner.IDPartner=" + sTable + ".IDPartner order by " + sFieldName);
                sDBGridView.Columns[sFieldID].DropDown = objControl;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].Style.HorizontalAlignment = AlignHorzEnum.Justify;
                objControl.DataField = sFieldID;
                objControl.ListField = sFieldName;
                sDBGridView.Columns[sFieldID].ValueItems.Translate = true;
                objControl.ValueTranslate = true;
                objControl.DisplayColumns[0].Visible = false;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].FilterButton = true;
                sDBGridView.Splits[0].DisplayColumns[sFieldID].AutoComplete = true;
            }
            catch
            {
            }
        }

        public void CreateControlTrueDBDropdownPartner(C1TrueDBGrid sDBGridView)
        {
            string sFieldID, sFieldName, sTable;
            try
            {
                sFieldID = "IDPartner";
                sFieldName = "ContactPerson";
                sTable = "TblPartner";
                C1TrueDBDropdown objControl = new C1TrueDBDropdown();
                sDBGridView.FindForm().Controls.Add(objControl);
                objControl.ColumnHeaders = false;
                objControl.Height = 120;
                objControl.RowHeight = 22;
                objControl.Style.VerticalAlignment = AlignVertEnum.Center;
                objControl.Style.HorizontalAlignment = AlignHorzEnum.Far;
                objControl.Cursor = Cursors.Hand;
                objControl.Width = sDBGridView.Splits[0].DisplayColumns[sFieldID].Width * 2;
                objControl.ExtendRightColumn = true;
                try
                {
                    TVSSys.Connection objCon = new TVSSys.Connection();
                    objControl.DataSource = objCon.EXESelect("Select " + sFieldID + ", " + sFieldName + ",Career,ContactPersonExt,CareerExt from " + sTable + " order by " + sFieldName);
                    sDBGridView.Columns[sFieldID].DropDown = objControl;
                    sDBGridView.Splits[0].DisplayColumns[sFieldID].Style.HorizontalAlignment = AlignHorzEnum.Justify;
                    objControl.DataField = sFieldID;
                    objControl.ListField = sFieldName;
                    sDBGridView.Columns[sFieldID].ValueItems.Translate = true;
                    objControl.ValueTranslate = true;
                    objControl.DisplayColumns[0].Visible = false;

                    objControl.DisplayColumns[1].Width = sDBGridView.Splits[0].DisplayColumns[sFieldID].Width;
                    objControl.DisplayColumns[3].Width = sDBGridView.Splits[0].DisplayColumns[sFieldID].Width;

                    sDBGridView.Splits[0].DisplayColumns[sFieldID].FilterButton = true;
                    sDBGridView.Splits[0].DisplayColumns[sFieldID].AutoComplete = true;
                }
                catch
                {
                }
            }
            catch
            {
            }
        }
        #endregion

        #region GetDataTableFromGridView
        public DataTable Get_DataView(C1TrueDBGrid sDBGrid)
        {
            try
            {
                DataTable objdt = new DataTable();
                DataColumn colAdd;
                DataRow dr;
                for (int i = 0; i < sDBGrid.Columns.Count; ++i)
                {
                    colAdd = new DataColumn(sDBGrid.Columns[i].DataField.ToString());
                    colAdd.DataType = System.Type.GetType("System.String");
                    objdt.Columns.Add(colAdd);
                }

                for (int sRow = 0; sRow < sDBGrid.RowCount; sRow++)
                {
                    dr = objdt.NewRow();
                    for (int i = 0; i < sDBGrid.Columns.Count; ++i)
                    {
                        dr[i] = " " + sDBGrid.Columns[i].CellText(sRow);
                    }
                    objdt.Rows.Add(dr);
                }
                return objdt;
            }
            catch
            {
                return null;
            }
        }


        public DataTable Get_DataViewScheduleOnline(C1TrueDBGrid sDBGrid)
        {
            try
            {
                DataTable objdt = new DataTable();
                DataColumn colAdd;
                DataRow dr;
                for (int i = 0; i < sDBGrid.Columns.Count; ++i)
                {
                    colAdd = new DataColumn(sDBGrid.Columns[i].DataField.ToString());
                    colAdd.DataType = System.Type.GetType("System.String");
                    objdt.Columns.Add(colAdd);
                }

                for (int sRow = 0; sRow < sDBGrid.RowCount; sRow++)
                {
                    dr = objdt.NewRow();
                    for (int i = 0; i < sDBGrid.Columns.Count; ++i)
                    {
                        if ((sDBGrid.Columns[i].DataField == "Morning") || (sDBGrid.Columns[i].DataField == "Afternoon") || (sDBGrid.Columns[i].DataField == "Evening"))
                        {
                            if (sDBGrid.Columns[i].CellText(sRow) == "True") dr[i] = "True";
                            else dr[i] = "False";
                        }
                        else dr[i] = " " + sDBGrid.Columns[i].CellText(sRow);
                    }
                    objdt.Rows.Add(dr);
                }
                return objdt;
            }
            catch
            {
                return null;
            }
        } 

        #endregion
    }
}
 