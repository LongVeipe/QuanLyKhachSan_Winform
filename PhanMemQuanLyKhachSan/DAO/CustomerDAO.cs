using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class CustomerDAO
    {
        private static CustomerDAO instance;

        public static CustomerDAO Instance
        {
            get { if (instance == null) instance = new CustomerDAO(); return CustomerDAO.instance; }
            private set { CustomerDAO.instance = value; }
        }

        private CustomerDAO() { }
        
        public Customer GetCustomerById(int id)
        {
            string query = "select * from Customer where IdCustomer = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Customer customer = new Customer(data.Rows[0]);

            return customer;
        }

        // Xuất -1 nếu chưa tồn tại Cmnd này
        // Xuất IdCustomer nếu đã tồn tại Cmnd đó
        public int GetExistCustomerByCmnd(string cmnd)
        {
            string query = "select * from Customer where Cmnd = '" + cmnd + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count <= 0)
                return -1;
            Customer customer = new Customer(data.Rows[0]);
            return customer.IdCustomer;
        }

        public string GetCustomerNameById(int id)
        {
            string query = "select * from Customer where IdCustomer = " + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Customer customer = new Customer(data.Rows[0]);

            return customer.Name;
        }

        public void AddNewCustomer(string name, string cmnd, string phone)
        {
            string query = "insert into Customer (Name,Cmnd, Phone) values (N'" + name + "', '" + cmnd + "', '"+ phone +"')";

            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetMaxIdCustomer()
        {
            string query = "select * from Customer where IdCustomer = (select MAX(IdCustomer) from Customer)";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Customer customer = new Customer(data.Rows[0]);

            return customer.IdCustomer;
        }

        public void UpdatePhoneNumber(string id, string phoneNumber)
        {
            if (phoneNumber == "")
                return;
            string query = "update Customer set Phone = '"+phoneNumber+"' where IdCustomer = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public DataTable GetCurrentCustomerList()
        {
            string query = "select c.Name as [Tên khách hàng], c.IdCustomer as [Mã khách hàng], c.Phone as [Điện thoại], c.Cmnd as [CMND], r.Name as [Phòng đang thuê] from (Bill b join Room r on b.IdRoom = r.IdRoom) join Customer c on b.IdCustomer = c.IdCustomer where b.Status = 0";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetTop10CustomerList()
        {
            string query = "select c.Name as [Tên khách hàng], c.IdCustomer as [Mã khách hàng], c.Phone as [Điện thoại], c.Cmnd as [CMND] from Customer c join (select TOP 10 IdCustomer from Bill where Status = 1 group by IdCustomer order by SUM(TotalPrice) DESC) d on c.IdCustomer = d.IdCustomer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
