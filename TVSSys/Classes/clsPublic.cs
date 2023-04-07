using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace TVSSys
{
    public class clsPublic
    {       
        #region method Declare ...
        private TVSSys.Connection objCon = new TVSSys.Connection();
        string[] numberArr = new string[10];
        string[] moneyArr = new string[4];
        #endregion


        #region method clsPublic
        public clsPublic()
        {
           
        } 
        #endregion

        #region LoadComboBox
        public void LoadComboBox(string SQL, System.Windows.Forms.ComboBox objCbb, string _ValueNumber, string _ValueText)
        {
            
            objCbb.BindingContext = new System.Windows.Forms.BindingContext();
            SqlConnection cn = new SqlConnection(objCon.strConnectionString);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(SQL, cn);
            DataSet ds = new DataSet();
            try
            {
                da.Fill(ds);
                objCbb.DataSource = ds.Tables[0].DefaultView;
                objCbb.ValueMember = _ValueNumber;
                objCbb.DisplayMember = _ValueText;
                objCbb.SelectedIndex = 0;
            }
            catch
            {

            }
            finally
            {
                ds.Dispose();
                cn.Close();
                cn.Dispose();
            }
        }

        public void LoadComboBox(string SQL, System.Windows.Forms.ComboBox objCbb)
        {
            try
            {
                DataTable dt = objCon.EXESelect(SQL);
                objCbb.Items.Add(new TVSSys.ItemCombobox(" - Tất cả - ", "0"));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    objCbb.Items.Add(new TVSSys.ItemCombobox(dt.Rows[i][1].ToString(), dt.Rows[i][0].ToString()));

                }
                objCbb.SelectedIndex = 1; 
            }
            catch { }
        }
        #endregion

        #region SelectValueCombobox
        public void SelectValueCombobox(ComboBox objCbb, string objValue)
        {
            TVSSys.ItemCombobox  objItem;
            for (int i = 0; i < objCbb.Items.Count; i++)
            {
                objItem = (TVSSys.ItemCombobox)objCbb.Items[i];
                if (objItem.Value == objValue)
                {
                    objCbb.SelectedIndex = i;
                    break;
                }
            }
        }
        #endregion

        #region method changeNumberToWord1
        public string changeNumberToWord1(System.Int64 NumberChange)
        {
            string moneyChegedToWord = "";
            int[] positionArr = new int[4];
            System.Int64 num = 0;
            int times = 0;
            this.numberArr[0] = "";
            this.numberArr[1] = "Một ";
            this.numberArr[2] = "Hai ";
            this.numberArr[3] = "Ba ";
            this.numberArr[4] = "Bốn ";
            this.numberArr[5] = "Năm ";
            this.numberArr[6] = "Sáu ";
            this.numberArr[7] = "Bảy ";
            this.numberArr[8] = "Tám ";
            this.numberArr[9] = "Chín ";

            this.moneyArr[0] = "Đồng ";
            this.moneyArr[1] = "Ngàn ";
            this.moneyArr[2] = "Triệu ";
            this.moneyArr[3] = "Tỷ ";

            if (NumberChange < 0)
            {
                moneyChegedToWord = "Trừ ";
            }
            if (Math.Abs(NumberChange) > 999999999999)
            {
                NumberChange = 0;
            }
            num = Math.Abs(NumberChange);
            positionArr[3] = int.Parse((num / 1000000000).ToString());
            num = num - System.Int64.Parse(positionArr[3].ToString() + "000000000");

            positionArr[2] = int.Parse((num / 1000000).ToString());

            positionArr[1] = int.Parse(((num % 1000000) / 1000).ToString());

            positionArr[0] = int.Parse((num % 1000).ToString());

            if (positionArr[3] > 0)
            {
                times = 3;
            }
            else if (positionArr[2] > 0)
            {
                times = 2;
            }
            else if (positionArr[1] > 0)
            {
                times = 1;
            }
            else
            {
                times = 0;
            }
            for (int i = times; i >= 0; i--)
            {
                try
                {
                    moneyChegedToWord += ChangeNumToWord(positionArr[i]);
                }
                catch
                {
                }
                moneyChegedToWord += moneyArr[i].ToString() + " ";
            }
            moneyChegedToWord = moneyChegedToWord.ToLower().Trim();
            moneyChegedToWord = moneyChegedToWord.Substring(0, 1).ToUpper() + moneyChegedToWord.Remove(0, 1);
            return moneyChegedToWord.Trim().Replace("  ", " ").Replace("triệu ngàn đồng", "triệu đồng").Replace("tỷ triệu ngàn đồng", "tỷ đồng");

        }
        #endregion

        #region ChangeNumToWord
        private string ChangeNumToWord(int NumVar)
        {
            int hundred, ten, unit;
            string resultStr = "";
            hundred = int.Parse((NumVar / 100).ToString());
            ten = int.Parse(((NumVar % 100) / 10).ToString());
            unit = NumVar % 10;
            if (hundred == 0 && ten == 0 && unit == 0)
            {
                resultStr = "";
            }
            if (hundred != 0)
            {
                resultStr += numberArr[hundred].ToString() + " Trăm ";
                if (ten == 0 && unit != 0)
                {
                    resultStr += "Lẻ ";
                }
            }
            if (ten != 0 && ten != 1)
            {
                resultStr += numberArr[ten].ToString() + " Mươi ";
                if (ten == 0 && unit != 0)
                {
                    resultStr += " Lẻ ";
                }
            }
            if (ten == 1)
            {
                resultStr += " Mười ";
            }
            switch (unit)
            {
                case 1:
                    {
                        if (ten != 0 && ten != 1)
                        {
                            resultStr += " Mốt ";
                        }
                        else
                        {
                            resultStr += numberArr[unit].ToString();
                        }
                        break;
                    }
                case 5:
                    {
                        if (ten == 0)
                        {
                            resultStr += numberArr[unit].ToString();
                        }
                        else
                        {
                            resultStr += " Lăm ";
                        }
                        break;
                    }
                default:
                    {
                        resultStr += numberArr[unit].ToString();
                        break;
                    }
            }
            return resultStr;
        }
        #endregion

        #region method getCompanyInfor
        public string getCompanyInfor(string Field)
        {
            string sqlQuery = "SELECT " + Field + " FROM [TabCompany] WHERE [ComID] = 'COM01'";
            return objCon.Get_EXESelect(sqlQuery); 
        }
        #endregion

        #region Get_ConfigInfo
        public int Get_ConfigInfo(string IntField)
        {
            try
            {
                DataTable dt = objCon.EXESelect("SELECT " + IntField + " FROM TabConfig");
                if (dt.Rows.Count > 0) return int.Parse(dt.Rows[0][0].ToString());
                else return 0;
            }
            catch
            {
                return 0;
            }
        }
        public string Get_ConfigValue(string strField)
        {
            try
            {
                DataTable dt = objCon.EXESelect("SELECT " + strField + " FROM TabConfig");
                if (dt.Rows.Count > 0) return dt.Rows[0][0].ToString();
                else return ""; 
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region Set_ConfigInfo
        public bool Set_ConfigInfo(string IntField,int sValue)
        {
            try
            {
                string sqlQuery = "Update  TabConfig set " + IntField + "=" + sValue;
                return objCon.EXEUpdate(sqlQuery);
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region LocdauKitu
        public string LocdauKitu(string tmpstr)
        {
            try
            {
                string str = tmpstr;
                for (int i = 1; i < VietNamChar.Length; i++)
                {
                    for (int j = 0; j < VietNamChar[i].Length; j++)
                        str = str.Replace(VietNamChar[i][j], VietNamChar[0][i - 1]);
                }
                return str;
            }
            catch
            {
                return "";
            }
        }
        #endregion

        #region VietNamChar
        private static readonly string[] VietNamChar = new string[]   
        {   
            "aAeEoOuUiIdDyY",   
            "áàạảãâấầậẩẫăắằặẳẵ",   
            "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",   
            "éèẹẻẽêếềệểễ",   
            "ÉÈẸẺẼÊẾỀỆỂỄ",   
            "óòọỏõôốồộổỗơớờợởỡ",   
            "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",   
            "úùụủũưứừựửữ",   
            "ÚÙỤỦŨƯỨỪỰỬỮ",   
            "íìịỉĩ",   
            "ÍÌỊỈĨ",   
            "đ",   
            "Đ",   
            "ýỳỵỷỹ",   
            "ÝỲỴỶỸ"  
        };
        #endregion
    }
}
 