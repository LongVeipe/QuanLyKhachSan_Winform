using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { RoomDAO.instance = value; }
        }

        private RoomDAO() { }

        public static int RoomWidth = 140;
        public static int RoomHeight = 68;

        public List<Room> FilterRoom(string status, string type, string size)
        {
            List<Room> roomList = new List<Room>();

            string query = "select r.* from Room r join SizeRoom s on r.IdSizeRoom = s.IdSizeRoom where (r.Status = "+ status +") and (r.TypeRoom = "+ type +") "+ size +" order by r.Name asc";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Room room = new Room(item);
                roomList.Add(room);
            }

            return roomList;
        }

        public DataTable GetRoomList()
        {
            string query = "select r.IdRoom as [Mã phòng], r.Name as [Tên phòng], s.SizeRoom as [Cỡ phòng], case TypeRoom when 0 then N'Thường' else N'Vip' end as [Loại phòng], r.Price as [Giá phòng] from Room r join SizeRoom s on r.IdSizeRoom = s.IdSizeRoom order by Name";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void SetFullRoom(int idRoom)
        {
            string query = "update Room set Status = 1 where IdRoom = " + idRoom;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void SetEmptyRoom(int idRoom)
        {
            string query = "update Room set Status = 0 where IdRoom = " + idRoom;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void CheckOut(int idRoom, float totalPrice)
        {
            int idBill = BillDAO.Instance.GetUnCheckBillIDByRoomID(idRoom);

            string query = "update Bill set Status = 1, TotalPrice = " + totalPrice + ", DateCheckOut = GETDATE() where idBill = " + idBill;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool CheckExistsNameRoom(string name)
        {
            string query = "select * from Room where Name = N'"+name+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool CheckExistsNameRoomNotInIdRoom(string name, string id)
        {
            string query = "select * from Room where Name = N'"+name+"' and IdRoom <> " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool CheckExistsRoomStatus1ByIdRoom(string id)
        {
            string query = "select * from Room where Status = 1 and IdRoom = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool isRoomUsing(string id)
        {
            string query = "select * from Room where Status = 1 and IdRoom = " + id;
            return DataProvider.Instance.ExecuteQuery(query).Rows.Count > 0;
        }

        public bool InsertRoom(string name, int idSize, int type, string price)
        {
            string query = "insert into Room (Name, IdSizeRoom, TypeRoom, Price) values (N'"+name+"',"+idSize+","+type+","+price+")";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateRoom(string id, string name, int idSizeRoom, int type, string price)
        {
            string query = "update Room set Name = N'"+name+"', IdSizeRoom = "+idSizeRoom+", TypeRoom = "+type+", Price = "+price+" where IdRoom = " + id;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public void DeleteRoomByIdSizeRoom(string id)
        {
            string query = "delete Room where IdSizeRoom = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool DeleteRoomByIdRoom(string id)
        {
            string query = "delete Room where IdRoom = " + id;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
