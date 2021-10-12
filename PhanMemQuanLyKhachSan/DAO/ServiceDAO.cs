using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get { if (instance == null) instance = new ServiceDAO(); return instance; }
            private set { instance = value; }
        }

        private ServiceDAO() { }

        public List<Service> GetListService()
        {
            List<Service> List = new List<Service>();

            string query = "select * from Service";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                List.Add(service);
            }

            return List;
        }

        public DataTable GetListService_Admin()
        {
            string query = "select Name as [Tên dịch vụ], IdService as [Mã dịch vụ], Price as [Giá dịch vụ] from Service ";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }

        public bool InsertService(string name, string price)
        {
            string query = "insert into Service (Name, Price) values (N'" + name + "'," + price + ")";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool UpdateService(string name, string IdService, string price)
        {
            string query = "update Service set Name = N'" + name + "', Price = " + price + " where IdService = " + IdService;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool DeleteService(string IdService)
        {
            string query = "delete from Service where IdService = " + IdService;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool CheckExistServiceName(string name)
        {
            string query = "select * from Service where Name = N'" + name + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count > 0;
        }

        public bool CheckExistServiceNameNotInIdService(string name, string IdService)
        {
            string query = "select * from Service where Name = N'" + name + "' and IdService <>" + IdService;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data.Rows.Count > 0;
        }
    }
}
