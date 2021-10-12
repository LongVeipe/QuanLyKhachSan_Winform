using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class Account
    {
        public Account(int idAccount, string username, bool typeAccount, int idEmployee, string password = null)
        {
            this.IdAccount = idAccount;
            this.Username = username;
            this.TypeAccount = typeAccount;
            this.IdEmployee = idEmployee;            this.Password = password;
        }

        public Account(DataRow row)
        {
            this.IdAccount = (int)row["IdAccount"];
            this.Username = row["Username"].ToString();
            this.TypeAccount = (bool)row["TypeAccount"];
            this.IdEmployee = (int)row["IdEmployee"];
            this.Password = row["Password"].ToString();
        }

        private int idAccount;
        private string username;
        private string password;
        private bool typeAccount;
        private int idEmployee;
        public int IdAccount { get => idAccount; set => idAccount = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool TypeAccount { get => typeAccount; set => typeAccount = value; }
        public int IdEmployee { get => idEmployee; set => idEmployee = value; }    }
}
