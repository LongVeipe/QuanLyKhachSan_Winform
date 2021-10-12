using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class Service
    {
        public Service(int idService, string name, float price)
        {
            this.IdService = idService;
            this.Name = name;
            this.Price = price;
        }

        public Service(DataRow row)
        {
            this.IdService = (int)row["IdService"];
            this.Name = row["name"].ToString();
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
        }

        private int idService;
        private string name;
        private float price;

        
        public string Name { get => name; set => name = value; }
        public float Price { get => price; set => price = value; }
        public int IdService { get => idService; set => idService = value; }
    }
}
