using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool Login(string Username, string Password)
        {
            string query = "USP_Login @userName , @passWord";

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { Username, Password });

            return data.Rows.Count > 0;
        }

        public Account GetAccountByUsername(string username)
        {
            string query = "select * from Account where Username = '" + username + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Account account = new Account(data.Rows[0]);
            return account;
        }

        public bool EditPass(string username, string currentPass, string newPass)
        {
            string query = "update Account set Password = '" + newPass + "' where Username = '" + username + "' and Password = '" + currentPass + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool CheckExistsUsername(string username)
        {
            string query = "select * from Account where Username  = '" + username + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool CheckExistsUsernameNotInIdEmployee(string username, string IdEmployee)
        {
            string query = "select * from Account where Username  = '"+username+"' and IdEmployee <> " + IdEmployee;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool Insert(string Username, int IdEmployee)
        {
            string query = "insert into Account (Password,TypeAccount,IdEmployee,Username) values ('123456', 0,'"+IdEmployee+"','"+Username+"')";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool Update(string Username, string IdEmployee)
        {
            string query = "update Account set Username = '"+Username+"' where IdEmployee = "+IdEmployee;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteByUsername(string Userename)
        {
            string query = "delete Account where Username = '"+Userename+"'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool isAdmin(string idEmployee)
        {
            string query = "select * from Account where TypeAccount = 1 and IdEmployee = " + idEmployee;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool ResetPass(string Username)
        {
            string query = "update Account set Password = '123456' where Username = '"+Username+"'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
