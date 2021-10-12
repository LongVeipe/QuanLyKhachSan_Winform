using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class Employee
    {
        public Employee(int idEmployee, string cmnd, string name, string address, string phone)
        {
            this.IdEmployee = idEmployee;
            this.Cmnd = cmnd;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public Employee(DataRow row)
        {
            this.IdEmployee = (int)row["IdEmployee"];
            this.Cmnd = row["Cmnd"].ToString();
            this.Name = row["Name"].ToString();
            this.Address = row["Address"].ToString();
            this.Phone = row["Phone"].ToString();
        }

        private int idEmployee;
        private string cmnd;
        private string name;
        private string address;
        private string phone;

        public int IdEmployee { get => idEmployee; set => idEmployee = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
