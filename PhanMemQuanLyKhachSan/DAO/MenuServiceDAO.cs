using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class MenuServiceDAO
    {
        private static MenuServiceDAO instance;

        public static MenuServiceDAO Instance
        {
            get { if (instance == null) instance = new MenuServiceDAO(); return instance; }
            private set { instance = value; }
        }

        private MenuServiceDAO() { }

        public List<MenuService> LoadListServiceByIdbill(int id)
        {
            List<MenuService> menuServiceList = new List<MenuService>();

            string query = " select s.Name, d.Count, s.Price, d.Count*s.Price as TotalPrice from Service s join DetailService d on s.IdService = d.IdService where d.IdBill = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                MenuService menuService = new MenuService(item);
                menuServiceList.Add(menuService);
            }

            return menuServiceList;
        }
    }
}
