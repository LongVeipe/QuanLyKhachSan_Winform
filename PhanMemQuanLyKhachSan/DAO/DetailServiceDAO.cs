using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class DetailServiceDAO
    {
        private static DetailServiceDAO instance;

        public static DetailServiceDAO Instance
        {
            get { if (instance == null) instance = new DetailServiceDAO(); return instance; }
            private set { instance = value; }
        }

        private DetailServiceDAO() { }

        // Trả về 0 nếu idBill đó chưa tồn tại idService
        // Ngược lại trả về 1
        public bool isExitsServiceByIdBill(int idBill, int idService)
        {
            string query = " select * from DetailService where IdBill = " + idBill + " and IdService = " + idService;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count == 1)
                return true;
            return false;
        }

        public void UpdateDetailService(int idBill, int idService, int count)
        {
            string query = "update DetailService set count = count + " + count + " where IdBill = " + idBill + " and IdService = " + idService;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public void InserteDetailService(int idBill, int idService, int count)
        {
            string query = "insert into DetailService(IdBill,IdService,Count) values (" + idBill + "," + idService + "," + count + ")";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public bool isServiceExistInBill(string idService)
        {
            string query = "select * from DetailService d join Bill b on d.IdBill = b.IdBill where d.IdService = " + idService + " and b.Status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public void DeleteDetailService(string idService)
        {
            string query = "delete from DetailService where IdService = " + idService;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
