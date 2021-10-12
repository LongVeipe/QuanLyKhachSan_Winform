using PhanMemQuanLyKhachSan.DAO;
using PhanMemQuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhanMemQuanLyKhachSan
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        #region method


        bool Login(string Username, string Password)
        {
            return AccountDAO.Instance.Login(Username, Password);
        }

        #endregion

        #region event

        private void button_Login_Click(object sender, EventArgs e)
        {
            string Username = textBox_UserName.Text;
            string Password = textBox_Password.Text;
            if (Login(Username, Password))
            {
                Account loginAccount = AccountDAO.Instance.GetAccountByUsername(Username);

                fDashBoard fDashBoard = new fDashBoard(loginAccount);
                this.Hide();
                fDashBoard.ShowDialog();
                textBox_UserName.Text = "Username";
                textBox_Password.Text = "Password";
                this.Show();
            }
            else
                MessageBox.Show("Đăng nhập thất bại", "Thông báo");
        }

        private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát hay không", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void textBox_UserName_Click(object sender, EventArgs e)
        {
            if (textBox_Password.Text == "")
            {
                textBox_Password.Font = new Font("Arial", 12, FontStyle.Italic);
                textBox_Password.ForeColor = Color.Gray;
                textBox_Password.Text = "Password";
                textBox_Password.UseSystemPasswordChar = false;
            }
            if(textBox_UserName.Text == "Username")
                this.textBox_UserName.Text = "";

            this.textBox_UserName.Font = new Font("Arial", 12, FontStyle.Regular);
            this.pictureBox_Username.BackgroundImage = Properties.Resources.user2;
            this.panel_Username.BackColor = Color.FromArgb(75, 173, 247);
            this.textBox_UserName.ForeColor = Color.FromArgb(75, 173, 247);

            this.pictureBox_Password.BackgroundImage = Properties.Resources.password;
            this.panel_Password.BackColor = Color.White;
            this.textBox_Password.ForeColor = Color.White;
        }

        private void textBox_PassWord_Click(object sender, EventArgs e)
        {
            if (textBox_UserName.Text == "")
            {
                textBox_Password.Font = new Font("Arial", 12, FontStyle.Italic);
                textBox_UserName.ForeColor = Color.Gray;
                textBox_UserName.Text = "Username";

            }
            if (textBox_Password.Text == "Password")
            {
                this.textBox_Password.Text = "";
                if (this.pictureBox_Eye.BackgroundImage == Properties.Resources.closeEye1)
                    this.textBox_Password.UseSystemPasswordChar = true;
            }

            this.pictureBox_Password.BackgroundImage = Properties.Resources.password2;
            this.panel_Password.BackColor = Color.FromArgb(75, 173, 247);
            this.textBox_Password.ForeColor = Color.FromArgb(75, 173, 247);

            this.pictureBox_Username.BackgroundImage = Properties.Resources.user;
            this.panel_Username.BackColor = Color.White;
            this.textBox_UserName.ForeColor = Color.White;
        }

        

        private void textBox_UserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Tab)
            {
                if (textBox_UserName.Text == "")
                {
                    textBox_Password.Font = new Font("Arial", 12, FontStyle.Regular);
                    textBox_UserName.Text = "Username";
                }
                if (textBox_Password.Text == "Password")
                {
                    this.textBox_Password.Text = "";
                    if (this.pictureBox_Eye.BackgroundImage == Properties.Resources.closeEye1)
                        this.textBox_Password.UseSystemPasswordChar = true;
                }

                this.pictureBox_Password.BackgroundImage = Properties.Resources.password2;
                this.panel_Password.BackColor = Color.FromArgb(75, 173, 247);
                this.textBox_Password.ForeColor = Color.FromArgb(75, 173, 247);

                this.pictureBox_Username.BackgroundImage = Properties.Resources.user;
                this.panel_Username.BackColor = Color.White;
                this.textBox_UserName.ForeColor = Color.White;
            }
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.UseSystemPasswordChar = true;
        }

        #endregion

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_Eye_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.textBox_Password.UseSystemPasswordChar)

            {
                this.pictureBox_Eye.BackgroundImage = Properties.Resources.openEye;
                this.textBox_Password.UseSystemPasswordChar = false;
            }
            else
            {
                this.pictureBox_Eye.BackgroundImage = Properties.Resources.closeEye;
                this.textBox_Password.UseSystemPasswordChar = true;
            }
        }
    }
}
