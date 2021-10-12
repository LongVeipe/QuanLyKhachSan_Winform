using PhanMemQuanLyKhachSan.DAO;
using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class fProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount); }
        }

        public fProfile(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
        }

        #region method

        void ChangeAccount(Account acc)
        {
            Employee employee = EmployeeDAO.Instance.GetEmployeeById(acc.IdEmployee);

            textBox_UserName.Text = acc.Username;
            textBox_Name.Text = employee.Name;
            textBox_Cmnd.Text = employee.Cmnd;
            textBox_Phone.Text = employee.Phone;
            textBox_Address.Text = employee.Address;
        }

        void UpdateInfoProfile()
        {
            Account acc = AccountDAO.Instance.GetAccountByUsername(textBox_UserName.Text);
            Employee employee = EmployeeDAO.Instance.GetEmployeeById(acc.IdEmployee);

            string adress = textBox_Address.Text;
            string phone = textBox_Phone.Text;

            if (EmployeeDAO.Instance.UpdateInfoProfile(acc.IdEmployee, phone, adress))
                MessageBox.Show("Cập nhật thành công", "Thông báo");
            else
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
        }

        #endregion

        #region event

        private void button_EditPass_Click(object sender, EventArgs e)
        {
            fEditPass fEditPass = new fEditPass(LoginAccount);
            fEditPass.ShowDialog();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            UpdateInfoProfile();
        }

        #endregion
    }
}
