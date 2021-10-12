using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }

        private BillDAO() { }

        public int GetUnCheckBillIDByRoomID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Bill WHERE IdRoom = " + id + "and status = 0");
            if (data.Rows.Count > 0)
            {
                Bill bill = new Bill(data.Rows[0]);
                return bill.IdBill;
            }

            return -1;
        }

        public Bill GetBillInfoByIdBill(int id)
        {
            string query = "select * from Bill where IdBill = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Bill bill = new Bill(data.Rows[0]);

            return bill;
        }

        public void InsertNewBill(int idRoom, int idCustomer)
        {
            string query = "insert into Bill (IdCustomer,IdRoom) values (" + idCustomer + "," + idRoom + ")";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void UpdateNullIdRoomByIdSizeRoom(String id)
        {
            string query = "update Bill set IdRoom = null where IdRoom in (select IdRoom from Room where IdSizeRoom = " + id + ")";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void UpdateNullIdRoomByIdRoom(String id)
        {
            string query = "update Bill set IdRoom = null where IdRoom = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetProceedsByYear(string year)
        {
            string query = "YearProceeds @year";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { year });
            return data;
        }

        public DataTable GetProceedsByMonth(string year, string month)
        {
            string query = "MonthProceeds @year , @month";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { year, month });
            return data;
        }
    }
}
