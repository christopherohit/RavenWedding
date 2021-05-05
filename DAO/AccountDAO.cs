using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Raven.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value; 
        }
        private AccountDAO() { }
        public bool Login(string username , string password)
        {
            //string query1 = "SELECT * FROM dbo.nhanvien WHERE Email = N'" + username + "' AND Pass = N'" + password + "'";
            string query = "Exec dbo.getaccount @emails , @pass ";
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
        public bool GetPhone(string username)
        {
            string getPhone = "Select Phone from nhanvien where Email = N'" + username + "'";
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
        public string Image(string username)
        {
            string getImage = "Select * From nhanvien where Email = N'" + username + "'";
            DataTable ExportImag = DataProvider.Instance.ExecuteQuery(getImage);
            var catchs = ExportImag.Rows[0].ItemArray[5];
            var Image = (Byte[])(catchs);
            var stream = new MemoryStream(Image);
            return stream.ToString() ;
        }
        public bool ICMCheck(string username)
        {
            string checkICM = "select cmnd from nhanvien where Email = N'" + username + "'";
            DataTable exportICM = DataProvider.Instance.ExecuteQuery(checkICM);
            return exportICM.Rows.Count > 0;
        }
        public bool ChangePass(string Username , string password)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC CapNhapPass @Emails , @pass", new object[] { Username, password });
            return result > 0;
        }
    }
}
