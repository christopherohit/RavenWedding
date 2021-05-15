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
    public class AccountDAO
    {
        string username;
        string password;
        private static AccountDAO instance;
        
        public static AccountDAO Instance {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value; 
        }
        private AccountDAO() { }
        public bool Login(string username , string password)
        {
            //string query1 = "SELECT * FROM dbo.nhanvien WHERE Email = N'" + username + "' AND Pass = N'" + password + "'";
            string query = "Exec dbo.getaccount @emails , @pass";
            DataTable result = DataProvider.Instance.ExecuteQuery(query , new object[] { username , password }) ;
            return result.Rows.Count > 0;
        }
        public string GetName(string username)
        {
            string getname = "select * From nhanvien where Email = N'" + username + "'";
            DataTable ExportName = DataProvider.Instance.ExecuteQuery(getname);
            string Fullname=ExportName.Rows[0].ItemArray[1].ToString();
            return Fullname;
        }
        public string GetCareer(string username)
        {
            string getcareer = "select * From nhanvien where Email = N'" + username + "'";
            DataTable ExportCareer = DataProvider.Instance.ExecuteQuery(getcareer);
            string career = ExportCareer.Rows[0].ItemArray[12].ToString();
            return career;
        }
        public string GetICM(string username)
        {
            string getICM = "select * from nhanvien where Email = N'" + username + "'";
            DataTable exportICM = DataProvider.Instance.ExecuteQuery(getICM);
            string ICM = exportICM.Rows[0].ItemArray[8].ToString();
            return ICM;

        }
        public string GETID (string username)
        {
            string Id = "SELECT * FROM nhanvien WHERE Email = N'" + username + "'";
            DataTable exportID = DataProvider.Instance.ExecuteQuery(Id);
            string GID = exportID.Rows[0].ItemArray[0].ToString();
            return GID;
        }
        public bool GetPhone(string Phone)
        {
            string getPhone = "Select Phone from nhanvien where Phone = N'" + Phone + "'";
            DataTable exportPhone = DataProvider.Instance.ExecuteQuery(getPhone);
            return  exportPhone.Rows.Count > 0;
        }  
        public string Getame(string username)
        {
            string getName = "select * from nhanvien where Email = N'" + username + "'";
            DataTable exportName = DataProvider.Instance.ExecuteQuery(getName);
            string name = exportName.Rows[0].ItemArray[1].ToString();
            return name;
        }
        public Image Images(string username)
        {
            string getImage = "Select * From nhanvien where Email = N'" + username + "'";
            DataTable ExportImag = DataProvider.Instance.ExecuteQuery(getImage);
            var catchs = ExportImag.Rows[0].ItemArray[5];
            var Images = (Byte[])(catchs);
            var stream = new MemoryStream(Images);
            return Image.FromStream(stream);
        }
        public bool ICMCheck(string ICM)
        {
            string checkICM = "select cmnd from nhanvien where Email = N'" + ICM + "'";
            DataTable exportICM = DataProvider.Instance.ExecuteQuery(checkICM);
            return exportICM.Rows.Count > 0;
        }
        public bool ChangePass(string Username , string password)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC CapNhapPass @Emails , @pass", new object[] { Username, password });
            return result > 0;
        }
        public bool UpdateInfo(string username , string gender , string phone , string address , string icm , DateTime DOB , string Des)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC FillIn4InFormation @Emails  , @gender  , @phone , @Address  , @ICM  , @DOB  , @DES ", new object[] { username , gender , phone , address , icm , DOB , Des });
            return result > 0;
        }
        public bool Block(string username, bool block)
        {
            int Result = DataProvider.Instance.ExecuteNonQuery("EXEC BlockAccount @Emails , @isblock", new object[] { username, block });
            return Result > 0;
        }
        public bool InsertUser (string fullname , string mails , string pass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC InsertMember @name  , @email  , @pass ", new object[] { fullname, mails, pass });
            return result > 0;
        }
        public string GetDate(string username)
        {
            string GetDate = "Select * From nhanvien where Email = N'" + username + "'";
            DataTable ExportDate = DataProvider.Instance.ExecuteQuery(GetDate);
            string Date = ExportDate.Rows[0].ItemArray[9].ToString();
            return Date;
        }
        public string GetDes(string username)
        {
            string GetDesc = "Select * From NhanVien where Email = N'" + username + "'";
            DataTable ExportDesc = DataProvider.Instance.ExecuteQuery(GetDesc);
            string Desc = ExportDesc.Rows[0].ItemArray[10].ToString();
            return Desc;
        }
        public string GetGender(string username)
        {
            string Gender = "Select * from nhanvien where Email = N'" + username + "'";
            DataTable ExportGender = DataProvider.Instance.ExecuteQuery(Gender);
            string GetGender = ExportGender.Rows[0].ItemArray[4].ToString();
            return GetGender;
        }
        public string GetAddress(string username)
        {
            string GetAddress = "SELECT * FROM nhanvien WHERE Email = N'" + username + "'";
            DataTable ExportAddress = DataProvider.Instance.ExecuteQuery(GetAddress);
            string OutAddress = ExportAddress.Rows[0].ItemArray[7].ToString();
            return OutAddress;
        }
        public string Emails (string ID)
        {
            string GetEmails = "SELECt * FROM nhanvien WHERE ID = N'" + ID + "'";
            DataTable ExportID = DataProvider.Instance.ExecuteQuery(GetEmails);
            string GetEmail = ExportID.Rows[0].ItemArray[2].ToString();
            return GetEmail;
        }
        public string SetPhone (string username)
        {
            string Phone = "SELECT * FROM nhanvien WHERE Email = N'" + username + "'";
            DataTable ExportPhone = DataProvider.Instance.ExecuteQuery(Phone);
            string OutPhone = ExportPhone.Rows[0].ItemArray[6].ToString();
            return OutPhone;
        }

    }
}
