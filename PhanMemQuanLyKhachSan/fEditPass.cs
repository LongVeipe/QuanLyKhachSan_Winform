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
    public partial class fEditPass : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; }
        }

        public fEditPass(Account acc)
        {
            InitializeComponent();

            LoginAccount = acc;
        }

        #region method

        void EditPass()
        {
            string currentPass = textBox_CurrentPass.Text;
            string newPass = textBox_NewPass.Text;
            string reEnterPass = textBox_ReEnterPass.Text;

            if (currentPass == "" || newPass == "" || reEnterPass == "")
            {
                MessageBox.Show("Vui lòng điền đẩy đủ thông tin", "Thông báo");
                return;
            }

            if (newPass != reEnterPass)
            {
                MessageBox.Show("Nhập lại mật khẩu không chính xác", "Lỗi");
                return;
            }

            if (AccountDAO.Instance.EditPass(LoginAccount.Username, currentPass, newPass))
            {
                MessageBox.Show("Cập nhật mật khẩu thành công");
                textBox_CurrentPass.Text = "";
                textBox_NewPass.Text = "";
                textBox_ReEnterPass.Text = "";
            }
            else
                MessageBox.Show("Mật khẩu không chính xác","Lỗi");
        }

        #endregion

        #region event

        private void button_EditPass_Click(object sender, EventArgs e)
        {
            EditPass();
        }

        #endregion
    }
}
