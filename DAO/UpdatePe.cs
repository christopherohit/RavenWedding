using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raven.DAO
{
    public class UpdatePe
    {
        private static UpdatePe instances;

        public static UpdatePe Instances 
        { 
            get { if (instances == null) instances = new UpdatePe(); return instances; }
            private set => instances = value; 
        }
        private UpdatePe() { }

        public bool UpdateInfo( string name , string gender, string phone, string address, string icm, DateTime DOB, string Des , string username , string id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC UpdatePerson  @username , @name  , @gender  , @phone , @Address  , @ICM  , @DOB  , @DES , @id ",  new object[] { username , name , gender , phone , address , icm , DOB , Des , Convert.ToInt32(id) });
            return result > 0;
        }
        public bool DeleteUser(int id)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC DeleteUser @id", new object[] { id });
            return result > 0;
        }
        public string name(int id)
        {
            string query = "Select * from nhanvien where id = N'" + id + "'";
            DataTable ExportName = DataProvider.Instance.ExecuteQuery(query);
            string Fullname = ExportName.Rows[0].ItemArray[1].ToString();
            return Fullname;
        }
        public string Emails(int id)
        {
            string GetMails = " Select * from nhanvien where id = N'" + id + "'";
            DataTable ExportMails = DataProvider.Instance.ExecuteQuery(GetMails);
            string whatMails = ExportMails.Rows[0].ItemArray[2].ToString();
            return whatMails;
        }
        public string OldMem(int id)
        {
            string GetPass = " Select * from nhanvien where id = N' " + id + " ' ";
            DataTable ExportPass = DataProvider.Instance.ExecuteQuery(GetPass);
            string WhatPass = ExportPass.Rows[0].ToString();
            return WhatPass;
        }
        public string Gender(int id)
        {
            string GetGen = "Select * from nhanvien where id = N'" + id + "'";
            DataTable ExportGen = DataProvider.Instance.ExecuteQuery(GetGen);
            string WhatGen = ExportGen.Rows[0].ItemArray[4].ToString();
            return WhatGen;
        }
        public Image Pic(int id)
        {
            string getImage = "Select * From nhanvien where id = N'" + id + "'";
            DataTable ExportImag = DataProvider.Instance.ExecuteQuery(getImage);
            var catchs = ExportImag.Rows[0].ItemArray[5];
            var Images = (Byte[])(catchs);
            var stream = new MemoryStream(Images);
            return Image.FromStream(stream);
        }
        public string Phone(int id)
        {
            string GetPhone = "Select * from nhanvien where id = N'" + id + "'";
            DataTable ExportPhone = DataProvider.Instance.ExecuteQuery(GetPhone);
            string WhatPhone = ExportPhone.Rows[0].ItemArray[6].ToString();
            return WhatPhone;
        }
        public string Address (int id)
        {
            string GetAddress = "Select * From nhanvien where id = N'" + id + "'";
            DataTable ExportAddress = DataProvider.Instance.ExecuteQuery(GetAddress);
            string WhatAddress = ExportAddress.Rows[0].ItemArray[7].ToString();
            return WhatAddress;
        }
        public string Identity(int id)
        {
            string GetIdentity = "Select * From nhanvien where id = N'" + id + "'";
            DataTable ExportIdentity = DataProvider.Instance.ExecuteQuery(GetIdentity);
            string WhatIdentity = ExportIdentity.Rows[0].ItemArray[8].ToString();
            return WhatIdentity;
        }
        public string Birthday (int id)
        {
            string GetBirthday = "Select * From nhanvien where id = N'" + id + "'";
            DataTable ExportBirthday = DataProvider.Instance.ExecuteQuery(GetBirthday);
            string WhatBirth = ExportBirthday.Rows[0].ItemArray[9].ToString();
            return WhatBirth;
        }
        public string Desc(int id)
        {
            string GetDesc = "Select * From nhanvien where id = N'" + id + "'";
            DataTable ExportDesc = DataProvider.Instance.ExecuteQuery(GetDesc);
            string WhatDesc = ExportDesc.Rows[0].ItemArray[10].ToString();
            return WhatDesc;
        }
        public string GetPass(int id)
        {
            string GetPassword = " SELECT * FROM nhanvien WHERE id = N'" + id + "'";
            DataTable ExportPass = DataProvider.Instance.ExecuteQuery(GetPassword);
            string WhatPass = ExportPass.Rows[0].ItemArray[3].ToString();
            return WhatPass;
        }
    }
}
