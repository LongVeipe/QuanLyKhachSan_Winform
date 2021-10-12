using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class MenuService
    {
        public MenuService(string serviceName, int count, float price, float totalPrice = 0)
        {
            this.ServiceName = serviceName;
            this.Count = count;
            this.Price = price;
            this.TotalPrice = totalPrice;
        }

        public MenuService(DataRow row)
        {
            this.ServiceName = row["Name"].ToString();
            this.Count = (int)row["Count"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.TotalPrice = (float)Convert.ToDouble(row["TotalPrice"].ToString());
        }

        private string serviceName;
        private int count;
        private float price;
        private float totalPrice;

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int Count { get => count; set => count = value; }
        public float Price { get => price; set => price = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
    }
}
