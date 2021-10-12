using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class Room
    {
        public Room(int idRoom, string name, int idSizeRoom, bool typeRoom, float price, bool status)
        {
            this.IdRoom = idRoom;
            this.Name = name;
            this.IdSizeRoom = idSizeRoom;
            this.TypeRoom = typeRoom;
            this.Price = price;
            this.Status = status;
        }

        public Room(DataRow row)
        {
            this.IdRoom = (int)row["IdRoom"];
            this.Name = row["Name"].ToString();
            this.IdSizeRoom = (int)row["IdSizeRoom"];
            this.TypeRoom = (bool)row["TypeRoom"];
            this.Price = (float)Convert.ToDouble(row["Price"].ToString());
            this.Status = (bool)row["Status"];
        }

        private int idRoom;
        private string name;
        private int idSizeRoom;
        private bool typeRoom;
        private float price;
        private bool status;

        public int IdRoom { get => idRoom; set => idRoom = value; }
        public string Name { get => name; set => name = value; }
        public int IdSizeRoom { get => idSizeRoom; set => idSizeRoom = value; }
        public bool TypeRoom { get => typeRoom; set => typeRoom = value; }
        public float Price { get => price; set => price = value; }
        public bool Status { get => status; set => status = value; }
    }
}
