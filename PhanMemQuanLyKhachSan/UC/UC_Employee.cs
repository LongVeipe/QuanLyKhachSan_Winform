using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhanMemQuanLyKhachSan.DAO;

namespace PhanMemQuanLyKhachSan.UC
{
    public partial class UC_Employee : UserControl
    {
        public UC_Employee()
        {
            InitializeComponent();
            Load();
        }

        #region method

        private void Load()
        {
            LoadListEmployee();
            dataGridView_ListEmployee.Focus();
            textBox_Name.Text = "";
            textBox_Id.Text = "";
            textBox_Username.Text = "";
            textBox_Cmnd.Text = "";
            textBox_PhoneNumber.Text = "";
            textBox_Address.Text = "";
            //radioButton_Employee.Checked = true;

            textBox_Name.ReadOnly = true;
            textBox_Id.ReadOnly = true;
            textBox_Username.ReadOnly = true;
            textBox_Cmnd.ReadOnly = true;
            textBox_PhoneNumber.ReadOnly = true;
            textBox_Address.ReadOnly = true;
            //radioButton_Admin.Enabled = false;
            //radioButton_Employee.Enabled = false;
            dataGridView_ListEmployee.Enabled = true;
        }

        private void LoadListEmployee()
        {
            dataGridView_ListEmployee.DataSource = EmployeeDAO.Instance.GetListEmployee();
        }

        private bool CheckEmpty()
        {
            if (textBox_Name.Text == "") return true;
            if (textBox_Id.Text == "") return true;
            if (textBox_Username.Text == "") return true;
            if (textBox_Cmnd.Text == "") return true;
            if(textBox_PhoneNumber.Text == "") return true;
            if(textBox_Address.Text == "") return true;
            return false;
        }

        #endregion

        #region event

        private void dataGridView_ListEmployee_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_ListEmployee.CurrentCell == null) return;
            int i = dataGridView_ListEmployee.CurrentCell.RowIndex;
            int n = dataGridView_ListEmployee.RowCount;
            if (i < 0) return;
            if (i >= n - 1)
                return;
            textBox_Name.Text = dataGridView_ListEmployee.Rows[i].Cells[0].Value.ToString();
            textBox_Id.Text = dataGridView_ListEmployee.Rows[i].Cells[1].Value.ToString();
            textBox_Username.Text = dataGridView_ListEmployee.Rows[i].Cells[2].Value.ToString();
            textBox_Cmnd.Text = dataGridView_ListEmployee.Rows[i].Cells[4].Value.ToString();
            textBox_PhoneNumber.Text = dataGridView_ListEmployee.Rows[i].Cells[5].Value.ToString();
            textBox_Address.Text = dataGridView_ListEmployee.Rows[i].Cells[6].Value.ToString();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            textBox_Name.Focus();
            Button btn = sender as Button;
            if(btn.Text == "THÊM")
            {
                btn.Text = "LƯU";
                button_Delete.Hide();
                button_Update.Hide();
                button_ResetPass.Hide();

                textBox_Name.Text = "";
                textBox_Id.Text = "Tạo tự động";
                textBox_Username.Text = "";
                textBox_Cmnd.Text = "";
                textBox_PhoneNumber.Text = "";
                textBox_Address.Text = "";

                textBox_Name.ReadOnly = false;
                textBox_Id.ReadOnly = true;
                textBox_Username.ReadOnly = false;
                textBox_Cmnd.ReadOnly = false;
                textBox_PhoneNumber.ReadOnly = false;
                textBox_Address.ReadOnly = false;
                dataGridView_ListEmployee.Enabled = false;
            }
            else
            {
                string name = textBox_Name.Text;
                string username = textBox_Username.Text;
                string cmnd = textBox_Cmnd.Text;
                string phonenumber = textBox_PhoneNumber.Text;
                string address = textBox_Address.Text;
                if (CheckEmpty())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }

                if (EmployeeDAO.Instance.CheckExistsCmnd(cmnd))
                {
                    MessageBox.Show("Cmnd này đã được sử dụng", "Thông báo");
                    return;
                }

                if (AccountDAO.Instance.CheckExistsUsername(username))
                {
                    MessageBox.Show("Username này đã được sử dụng", "Thông báo");
                    return;
                }

                if(!EmployeeDAO.Instance.Insert(name,cmnd,phonenumber,address))
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                    return;
                }
                else
                {
                    if (!AccountDAO.Instance.Insert(username, EmployeeDAO.Instance.GetMaxIdEmployee()))
                    {
                        MessageBox.Show("Thêm thất bại", "Thông báo");
                        return;
                    }
                    else
                        MessageBox.Show("Thêm thành công", "Thông báo");
                }

                btn.Text = "THÊM";
                button_Delete.Show();
                button_Update.Show();
                button_ResetPass.Show();
                Load();
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            textBox_Name.Focus();

            string id = textBox_Id.Text;

            if (id == "")
                return;

            Button btn = sender as Button;
            if (btn.Text == "SỬA")
            {
                btn.Text = "LƯU";
                button_Delete.Hide();
                button_Add.Hide();
                button_ResetPass.Hide();

                textBox_Name.ReadOnly = false;
                textBox_Username.ReadOnly = false;
                textBox_Cmnd.ReadOnly = false;
                textBox_PhoneNumber.ReadOnly = false;
                textBox_Address.ReadOnly = false;
                dataGridView_ListEmployee.Enabled = false;
            }
            else
            {
                string name = textBox_Name.Text;
                string username = textBox_Username.Text;
                string cmnd = textBox_Cmnd.Text;
                string phonenumber = textBox_PhoneNumber.Text;
                string address = textBox_Address.Text;

                if (CheckEmpty())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }

                if (EmployeeDAO.Instance.CheckExistsCmndNotInIdEmployee(cmnd,id))
                {
                    MessageBox.Show("Cmnd này đã được sử dụng", "Thông báo");
                    return;
                }

                if (AccountDAO.Instance.CheckExistsUsernameNotInIdEmployee(username,id))
                {
                    MessageBox.Show("Username này đã được sử dụng", "Thông báo");
                    return;
                }

                if (!EmployeeDAO.Instance.Update(name,cmnd,phonenumber,address,id))
                {
                    MessageBox.Show("Cập nhật thất bại", "Thông báo");
                    return;
                }
                else
                {
                    if (!AccountDAO.Instance.Update(username ,id))
                    {
                        MessageBox.Show("Cập nhật thất bại", "Thông báo");
                        return;
                    }
                    else
                        MessageBox.Show("Cập nhật thành công", "Thông báo");
                }

                btn.Text = "SỬA";
                button_Delete.Show();
                button_Add.Show();
                button_ResetPass.Show();
                Load();
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            string Id = textBox_Id.Text;
            string Username = textBox_Username.Text;

            if (Id == "")
                return;

            if (AccountDAO.Instance.isAdmin(Id))
            {
                MessageBox.Show("Không thể xóa tài khoản quản lý");
                return;
            }

            if (!AccountDAO.Instance.DeleteByUsername(Username))
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
                return;
            }
            else
            {
                if (!EmployeeDAO.Instance.DeleteById(Id))
                {
                    MessageBox.Show("Xóa thất bại", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Xóa thành công", "Thông báo");
                    Load();
                }
            }
        }

        private void button_ResetPass_Click(object sender, EventArgs e)
        {
            string username = textBox_Username.Text;

            if (username == "")
                return;

            if(!AccountDAO.Instance.ResetPass(username))
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Đã đổi thành 123456", "Thông báo");
                Load();
            }
        }

        private void TextBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void TextBox_Cmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox_PhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox_Name_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase((sender as TextBox).Text.ToLower());
        }

        #endregion


    }
}
