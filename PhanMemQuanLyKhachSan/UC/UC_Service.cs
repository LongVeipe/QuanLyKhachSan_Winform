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
    public partial class UC_Service : UserControl
    {
        public UC_Service()
        {
            InitializeComponent();
            Load();
        }
        #region method
        void Load()
        {
            LoadListService();

            textBox_NameService.Text = "";
            textBox_ID.Text = "";
            textBox_PriceService.Text = "";

            textBox_NameService.ReadOnly = true;
            //textBox_ID.ReadOnly = true;
            textBox_PriceService.ReadOnly = true;
            dataGridView_ListService.Enabled = true;
        }

        void LoadListService()
        {
            dataGridView_ListService.DataSource = ServiceDAO.Instance.GetListService_Admin();
        }

        private bool CheckEmpty()
        {
            if (textBox_NameService.Text == "") return true;
            if (textBox_PriceService.Text == "") return true;
            return false;
        }

        #endregion

        #region event

        private void button_AddService_Click(object sender, EventArgs e)
        {
            textBox_NameService.Focus();
            Button btn = sender as Button;

            if (button_AddService.Text == "THÊM")
            {
                button_AddService.Text = "LƯU";
                textBox_ID.Text = "Tạo tự động";
                textBox_NameService.Text = "";
                textBox_PriceService.Text = "";

                textBox_NameService.ReadOnly = false;
                textBox_PriceService.ReadOnly = false;
                button_UpdateService.Visible = false;
                button_DeleteService.Visible = false;
                dataGridView_ListService.Enabled = false;
            }
            else
            {
                string name = textBox_NameService.Text;
                string price = textBox_PriceService.Text;

                if (CheckEmpty())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }

                if (ServiceDAO.Instance.CheckExistServiceName(name))
                {
                    MessageBox.Show("Dịch vụ này đã tồn tại!");
                    return;
                }

                if (!ServiceDAO.Instance.InsertService(name, price))
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                }

                button_AddService.Text = "THÊM";
                button_UpdateService.Visible = true;
                button_DeleteService.Visible = true;

                Load();
            }
        }

        private void button_UpdateService_Click(object sender, EventArgs e)
        {
            textBox_NameService.Focus();
            Button btn = sender as Button;

            string id = textBox_ID.Text;

            if (id == "")
            {
                MessageBox.Show("Hãy chọn dịch vụ muốn sửa.", "Thông báo");
                return;
            }

            if (DetailServiceDAO.Instance.isServiceExistInBill(id))
            {
                MessageBox.Show("Không thể sửa dịch vụ đang được sử dụng.", "Thông báo");
                return;
            }

            if (button_UpdateService.Text == "SỬA")
            {
                button_UpdateService.Text = "LƯU";
                textBox_NameService.ReadOnly = false;
                textBox_PriceService.ReadOnly = false;
                button_AddService.Visible = false;
                button_DeleteService.Visible = false;
            }
            else
            {
                string name = textBox_NameService.Text;
                string price = textBox_PriceService.Text;

                if (CheckEmpty())
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }

                if (ServiceDAO.Instance.CheckExistServiceNameNotInIdService(name, id))
                {
                    MessageBox.Show("Dịch vụ đã tồn tại.", "Thông báo");
                    return;
                }
                else
                {
                    if (!ServiceDAO.Instance.UpdateService(name, id, price))
                    {
                        MessageBox.Show("Cập nhật thất bại.", "Thông báo");
                        return;
                    }
                    else
                        MessageBox.Show("Cập nhật thành công.", "Thông báo");
                }

                button_UpdateService.Text = "SỬA";
                button_AddService.Visible = true;
                button_DeleteService.Visible = true;

                Load();
            }
        }

        private void button_DeleteService_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            string id = textBox_ID.Text;

            if (id == "")
            {
                MessageBox.Show("Hãy chọn dịch vụ muốn xóa.", "Thông báo");
                return;
            }
                
            string name = textBox_NameService.Text;
            string price = textBox_PriceService.Text;

            if (DetailServiceDAO.Instance.isServiceExistInBill(id))
            {
                MessageBox.Show("Không thể xóa dịch vụ đang được sử dụng.", "Thông báo");
                return;
            }
            else
            {
                DetailServiceDAO.Instance.DeleteDetailService(id);
                ServiceDAO.Instance.DeleteService(id);
                MessageBox.Show("Xóa thành công.", "Thông báo");
                Load();
            }
        }

        private void dataGridView_ListService_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_ListService.CurrentCell == null) return;
            int i = dataGridView_ListService.CurrentCell.RowIndex;
            int n = dataGridView_ListService.RowCount;
            if (i < 0 || i >= n - 1) return;

            textBox_NameService.Text = dataGridView_ListService.Rows[i].Cells[0].Value.ToString();
            textBox_ID.Text = dataGridView_ListService.Rows[i].Cells[1].Value.ToString();
            textBox_PriceService.Text = dataGridView_ListService.Rows[i].Cells[2].Value.ToString();
        }

        private void textBox_NameService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox_PriceService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_NameService_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase((sender as TextBox).Text.ToLower());
        }


        #endregion
    }
}
