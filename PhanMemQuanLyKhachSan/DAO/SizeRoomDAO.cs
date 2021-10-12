using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class SizeRoomDAO
    {
        private static SizeRoomDAO instance;

        public static SizeRoomDAO Instance
        {
            get { if (instance == null) instance = new SizeRoomDAO(); return SizeRoomDAO.instance; }
            private set { SizeRoomDAO.instance = value; }
        }

        private SizeRoomDAO() { }

        public int GetSizeRoom(int id)
        {
            string query = "select SizeRoom from SizeRoom where IdSizeRoom = " + id;
            int SizeRoom = (int)DataProvider.Instance.ExecuteScalar(query);

            return SizeRoom;
        }

        public DataTable GetListSizeRoom()
        {
            string query = "select IdSizeRoom as [Mã số], SizeRoom as [Cỡ phòng] from SizeRoom order by SizeRoom ASC";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public List<SizeRoom> GetListSizeRoomToComboBox()
        {
            List<SizeRoom> list = new List<SizeRoom>();

            string query = "select * from SizeRoom order by SizeRoom";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SizeRoom size = new SizeRoom(item);
                list.Add(size);
            }

            return list;
        }

        public List<string> GetListSizeRoom_Str()
        {
            List<string> list = new List<string>();

            string query = "select * from SizeRoom where IdSizeRoom in (select distinct IdSizeRoom from Room) order by SizeRoom";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SizeRoom size = new SizeRoom(item);
                list.Add(size.Size.ToString());
            }

            return list;
        }

        public bool CheckExistsSize(string size)
        {
            string query = "select SizeRoom from SizeRoom where SizeRoom = " + size;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        
        public bool InsertSize(string size)
        {
            string query = "insert into SizeRoom (SizeRoom) values ("+size+")";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        
        public bool CheckExistsRoomStatus1ByIdSizeRoom(string id)
        {
            string query = "select * from Room where IdSizeRoom = " + id + " and Status = 1";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count > 0;
        }

        public bool DeleteSizeRoomByIdSizeRoom(string id)
        {
            string query = "delete SizeRoom where IdSizeRoom = " + id;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public int GetMaxId()
        {
            string query = "select IdSizeRoom from SizeRoom order by IdSizeRoom DESC";
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }

        public int GetIdBySize(string size)
        {
            string query = "select IdSizeRoom from SizeRoom where SizeRoom = " + size;
            return (int)DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
