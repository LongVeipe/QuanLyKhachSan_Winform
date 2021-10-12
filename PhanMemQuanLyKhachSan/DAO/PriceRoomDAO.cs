using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class PriceRoomDAO
    {
        private static PriceRoomDAO instance;

        public static PriceRoomDAO Instance
        {
            get { if (instance == null) instance = new PriceRoomDAO(); return PriceRoomDAO.instance; }
            private set { PriceRoomDAO.instance = value; }
        }

        private PriceRoomDAO() { }

        public void InsertPriceRoom(string id, string type)
        {
            string query = "insert into PriceRoom (IdSizeRoom,TypeRoom,Price) values ("+id+","+type+",0)";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetListPriceRoom()
        {
            string query = "select s.SizeRoom as [Cỡ phòng], case p.TypeRoom when 0 then N'Thường' else N'Vip' end as [Loại phòng], p.Price as [Giá phòng] from SizeRoom s join PriceRoom p on s.IdSizeRoom = p.IdSizeRoom order by s.SizeRoom ASC, p.TypeRoom ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdatePriceRoom(string id, int type, string price)
        {
            string query = "update PriceRoom set Price = "+price+" where IdSizeRoom = "+id+" and TypeRoom = " + type;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public void DeletePriceRoomByIdSizeRoom(string id)
        {
            string query = "delete PriceRoom where IdSizeRoom = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public string GetPriceBySizeAndType(string size, int type)
        {
            string query = "select p.Price from SizeRoom s join PriceRoom p on s.IdSizeRoom = p.IdSizeRoom where s.SizeRoom = "+size+" and p.TypeRoom = " + type.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            string result = data.Rows[0].ItemArray[0].ToString();
            return result;
        }
    }
}
