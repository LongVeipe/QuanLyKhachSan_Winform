using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class Customer
    {
        public Customer(int idCustomer, string name, string cmnd, string phone)
        {
            this.IdCustomer = idCustomer;
            this.Name = name;
            this.Cmnd = cmnd;
            this.Phone = phone;
        }

        public Customer(DataRow row)
        {
            this.IdCustomer = (int)row["IdCustomer"];
            this.Name = row["Name"].ToString();
            this.Cmnd = row["Cmnd"].ToString();
            var phoneTemp = row["Phone"];
            if (phoneTemp.ToString() != "")
                this.Phone = phoneTemp.ToString();
        }

        private int idCustomer;
        private string name;
        private string cmnd;
        private string phone;

        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string Name { get => name; set => name = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
