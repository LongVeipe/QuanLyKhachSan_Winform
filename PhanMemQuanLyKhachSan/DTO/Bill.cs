using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DTO
{
    public class Bill
    {
        public Bill(int idBill, int idCustomer, int idRoom, DateTime? dateCheckIn, DateTime? dateCheckOut, float totalPrice, bool status)
        {
            this.IdBill = idBill;
            this.IdCustomer = idCustomer;
            this.IdRoom = idRoom;
            this.DateCheckIn = dateCheckIn;
            this.DateCheckOut = dateCheckOut;
            this.TotalPrice = totalPrice;
            this.Status = status;
        }

        public Bill(DataRow row)
        {
            this.IdBill = (int)row["IdBill"];
            this.IdCustomer = (int)row["IdCustomer"];
            this.IdRoom = (int)row["IdRoom"];
            this.DateCheckIn = (DateTime?)row["DateCheckIn"];

            var dateCheckOutTemp = row["DateCheckOut"];
            if (dateCheckOutTemp.ToString() != "")
                this.DateCheckOut = (DateTime?)dateCheckOutTemp;

            var totalPriceTemp = row["TotalPrice"];
            if (totalPriceTemp.ToString() != "")
                this.TotalPrice = (float)Convert.ToDouble(totalPriceTemp.ToString());
            
            this.Status = (bool)row["Status"];
        }

        private int idBill;
        private int idCustomer;
        private int idRoom;
        private DateTime? dateCheckIn;
        private DateTime? dateCheckOut;
        private float totalPrice;
        private bool status;

        public int IdBill { get => idBill; set => idBill = value; }
        public int IdCustomer { get => idCustomer; set => idCustomer = value; }
        public int IdRoom { get => idRoom; set => idRoom = value; }
        public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public float TotalPrice { get => totalPrice; set => totalPrice = value; }
        public bool Status { get => status; set => status = value; }
    }
}
