using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemQuanLyKhachSan.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get { if (instance == null) instance = new EmployeeDAO(); return instance; }
            private set { instance = value; }
        }

        private EmployeeDAO() { }

        public DataTable GetListEmployee()
        {
            string query = "select emp.Name as [Họ tên], emp.IdEmployee as [Mã nhân viên], acc.Username as [Tên đăng nhập], case acc.TypeAccount when 0 then N'Nhân viên' else N'Quản lý' end as [Chức vụ], emp.Cmnd as [CMND], emp.Phone as [Điện thoại], emp.Address as [Địa chỉ] from Employee emp join Account acc on emp.IdEmployee = acc.IdEmployee";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public Employee GetEmployeeById(int id)
        {
            string query = "select * from Employee where IdEmployee =" + id;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Employee employee = new Employee(data.Rows[0]);
            return employee;
        }

        public bool UpdateInfoProfile(int idEmployee, string phone, string address)
        {
            string query = "update Employee set Phone = '" + phone + "', Address = N'" + address + "' where IdEmployee =" + idEmployee;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool Insert(string Name, string Cmnd, string PhoneNumber, string Address)
        {
            string query = "insert into Employee (Name,Cmnd,Address,Phone) values (N'"+Name+"','"+Cmnd+"',N'"+Address+"','"+PhoneNumber+"')";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool Update(string Name, string Cmnd, string PhoneNumber, string Address, string IdEmployee)
        {
            string query = "update Employee set Name = N'"+Name+"', Cmnd = '"+Cmnd+"', Address = N'"+Address+"', Phone = '"+PhoneNumber+"' where IdEmployee = "+ IdEmployee;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool CheckExistsCmnd(string cmnd)
        {
            string query = "select * from Employee where Cmnd = '" + cmnd + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public bool CheckExistsCmndNotInIdEmployee(string cmnd, string IdEmployee)
        {
            string query = "select * from Employee where Cmnd = '"+cmnd+"' and IdEmployee <> " + IdEmployee;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public int GetMaxIdEmployee()
        {
            string query = "select * from Employee order by IdEmployee DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            Employee emp = new Employee(data.Rows[0]);

            return emp.IdEmployee;
        }

        public bool DeleteById(string id)
        {
            string query = "delete Employee where IdEmployee = " + id;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
