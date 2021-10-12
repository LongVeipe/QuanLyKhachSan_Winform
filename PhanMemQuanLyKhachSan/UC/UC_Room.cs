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
using PhanMemQuanLyKhachSan.DTO;

namespace PhanMemQuanLyKhachSan.UC
{
    public partial class UC_Room : UserControl
    {
        public UC_Room()
        {
            InitializeComponent();
            Load();
        }

        #region method

        void Load()
        {
            LoadRoom();
            LoadSizeRoom();
            LoadPriceRoom();
        }

        void LoadRoom()
        {
            LoadListRoom();

            textBox_NameRoom.ReadOnly = true;
            textBox_NameRoom.Text = "";
            textBox_IdRoom.Text = "";
            comboBox_SizeRoom.Enabled = false;
            radioButton_TypeRoom0_.Enabled = false;
            radioButton_TypeRoom0_.Checked = true;
            radioButton_TypeRoom1_.Enabled = false;
            button_AddRoom.Show();
            button_AddRoom.Enabled = true;
            button_UpdateRoom.Show();
            button_UpdateRoom.Enabled = true;
            button_DeleteRoom.Show();
            button_DeleteRoom.Enabled = true;
            dataGridView_ListRoom.Enabled = true;
            comboBox_SizeRoom.DropDownStyle = ComboBoxStyle.DropDown;
            
            comboBox_SizeRoom.DataSource = SizeRoomDAO.Instance.GetListSizeRoomToComboBox();
            comboBox_SizeRoom.DisplayMember = "Size";

            textBox_PriceRoom_.Text = "0";
        }

        void LoadSizeRoom()
        {
            LoadListSizeRoom();

            textBox_SizeRoom.ReadOnly = true;
            textBox_SizeRoom.Text = "";
            textBox_IdSizeRoom.Text = "";

            button_AddSizeRoom.Enabled = true;
            button_AddSizeRoom.Show();
            button_DeleteSizeRoom.Enabled = true;
            button_DeleteSizeRoom.Show();

            dataGridView_ListSizeRoom.Enabled = true;
        }

        void LoadPriceRoom()
        {
            LoadListPriceRoom();

            textBox_PriceRoom.ReadOnly = true;
            textBox_PriceRoom.Text = "";
            textBox_SizeRoom_.Text = "";
            
            dataGridView_ListPriceRoom.Enabled = true;
        }

        void LoadListSizeRoom()
        {
            dataGridView_ListSizeRoom.DataSource = SizeRoomDAO.Instance.GetListSizeRoom();
        }

        void LoadListPriceRoom()
        {
            dataGridView_ListPriceRoom.DataSource = PriceRoomDAO.Instance.GetListPriceRoom();
        }

        void LoadListRoom()
        {
            dataGridView_ListRoom.DataSource = RoomDAO.Instance.GetRoomList();
        }

        #endregion

        #region event

        private void dataGridView_ListSizeRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_ListSizeRoom.CurrentCell == null) return;
            int i = dataGridView_ListSizeRoom.CurrentCell.RowIndex;
            int n = dataGridView_ListSizeRoom.RowCount;
            if (i < 0) return;
            if (i >= n - 1) return;

            textBox_IdSizeRoom.Text = dataGridView_ListSizeRoom.Rows[i].Cells[0].Value.ToString();
            textBox_SizeRoom.Text = dataGridView_ListSizeRoom.Rows[i].Cells[1].Value.ToString();
        }

        private void button_AddSizeRoom_Click(object sender, EventArgs e)
        {
            textBox_SizeRoom.Focus();
            Button btn = sender as Button;
            if (btn.Text == "THÊM")
            {
                btn.Text = "LƯU";
                button_DeleteSizeRoom.Hide();

                textBox_SizeRoom.Text = "";
                textBox_IdSizeRoom.Text = "Tạo tự động";

                textBox_SizeRoom.ReadOnly = false;
                dataGridView_ListSizeRoom.Enabled = false;
            }
            else
            {
                string size = textBox_SizeRoom.Text;
                if (textBox_SizeRoom.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }
                if (SizeRoomDAO.Instance.CheckExistsSize(size))
                {
                    MessageBox.Show("Cỡ phòng này đã tồn tại", "Thông báo");
                    return;
                }
                if (!SizeRoomDAO.Instance.InsertSize(size))
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                    return;
                }
                else
                {
                    PriceRoomDAO.Instance.InsertPriceRoom(SizeRoomDAO.Instance.GetMaxId().ToString(), "0");
                    PriceRoomDAO.Instance.InsertPriceRoom(SizeRoomDAO.Instance.GetMaxId().ToString(), "1");
                    MessageBox.Show("Thêm thành công", "Thông báo");

                    comboBox_SizeRoom.DataSource = SizeRoomDAO.Instance.GetListSizeRoomToComboBox();
                    comboBox_SizeRoom.DisplayMember = "Size";

                    btn.Text = "THÊM";
                    //LoadSizeRoom();
                    //LoadPriceRoom();
                    Load();
                }
            }
        }

        private void button_DeleteSizeRoom_Click(object sender, EventArgs e)
        {
            string id = textBox_IdSizeRoom.Text;
            string size = textBox_SizeRoom.Text;
            if (id == "")
            {
                MessageBox.Show("Hãy chọn cỡ phòng muốn xóa.", "Thông báo");
                return;
            }

            if (MessageBox.Show("Nếu bạn xóa cỡ phòng này, tất cả các phòng có cỡ phòng này cũng sẽ bị xóa đi, bạn có chắc chắn muốn tiếp tục hay không", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                return;

            if (SizeRoomDAO.Instance.CheckExistsRoomStatus1ByIdSizeRoom(id))
            {
                MessageBox.Show("Hiện tại vẫn còn phòng có cỡ phòng " + size + " đang được sử dụng, nên tạm thời không thể xóa được. Chỉ có thể xóa khi không phòng nào có cỡ phòng này đang được sử dụng", "Thông báo");
                return;
            }

            BillDAO.Instance.UpdateNullIdRoomByIdSizeRoom(id);
            RoomDAO.Instance.DeleteRoomByIdSizeRoom(id);
            PriceRoomDAO.Instance.DeletePriceRoomByIdSizeRoom(id);

            if (!SizeRoomDAO.Instance.DeleteSizeRoomByIdSizeRoom(id))
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Xóa thành công", "Thông báo");
                //LoadSizeRoom();
                //LoadPriceRoom();

                //comboBox_SizeRoom.Enabled = true;
                //LoadRoom();
                //comboBox_SizeRoom.Enabled = false;
                Load();
            }
        }

        private void dataGridView_ListPriceRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_ListPriceRoom.CurrentCell == null) return;
            int i = dataGridView_ListPriceRoom.CurrentCell.RowIndex;
            int n = dataGridView_ListPriceRoom.RowCount;
            if (i < 0) return;
            if (i >= n - 1) return;

            textBox_SizeRoom_.Text = dataGridView_ListPriceRoom.Rows[i].Cells[0].Value.ToString();
            textBox_PriceRoom.Text = dataGridView_ListPriceRoom.Rows[i].Cells[2].Value.ToString();
            if (dataGridView_ListPriceRoom.Rows[i].Cells[1].Value.ToString() == "Thường")
                radioButton_TypeRoom0.Checked = true;
            else
                radioButton_TypeRoom1.Checked = true;
        }

        private void button_UpdatePriceRoom_Click(object sender, EventArgs e)
        {
            textBox_PriceRoom.Focus();

            string size = textBox_SizeRoom_.Text;
            int type = 0;
            if (radioButton_TypeRoom1.Checked) type = 1;
            if (size == "")
            {
                MessageBox.Show("Hãy chọn loại phòng muốn sửa.", "Thông báo");
                return;
            }

            Button btn = sender as Button;

            if (btn.Text == "SỬA")
            {
                btn.Text = "LƯU";

                textBox_PriceRoom.ReadOnly = false;
                dataGridView_ListPriceRoom.Enabled = false;
            }
            else
            {
                String price = textBox_PriceRoom.Text;
                if (textBox_PriceRoom.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }
                int id = SizeRoomDAO.Instance.GetIdBySize(size);
                if(!PriceRoomDAO.Instance.UpdatePriceRoom(id.ToString(),type,price))
                {
                    MessageBox.Show("Sửa thất bại", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");

                    string _size = comboBox_SizeRoom.Text;
                    int _type = 0;
                    if (radioButton_TypeRoom1_.Checked) type = 1;
                    if (size != "")
                    {
                        string _price = PriceRoomDAO.Instance.GetPriceBySizeAndType(_size, _type);
                        textBox_PriceRoom_.Text = _price.ToString();
                    }

                    btn.Text = "SỬA";
                    //LoadPriceRoom();
                    Load();
                }
            }
        }

        private void dataGridView_ListRoom_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_ListRoom.CurrentCell == null) return;
            int i = dataGridView_ListRoom.CurrentCell.RowIndex;
            int n = dataGridView_ListRoom.RowCount;
            if (i < 0) return;
            if (i >= n - 1) return;

            textBox_IdRoom.Text = dataGridView_ListRoom.Rows[i].Cells[0].Value.ToString();
            textBox_NameRoom.Text = dataGridView_ListRoom.Rows[i].Cells[1].Value.ToString();
            textBox_PriceRoom_.Text = dataGridView_ListRoom.Rows[i].Cells[4].Value.ToString();
            if (dataGridView_ListRoom.Rows[i].Cells[3].Value.ToString() == "Thường")
                radioButton_TypeRoom0_.Checked = true;
            else
                radioButton_TypeRoom1_.Checked = true;
            comboBox_SizeRoom.Text = dataGridView_ListRoom.Rows[i].Cells[2].Value.ToString();
        }

        private void button_AddRoom_Click(object sender, EventArgs e)
        {
            textBox_NameRoom.Focus();
            Button btn = sender as Button;

            string size = comboBox_SizeRoom.Text;
            int type = 0;
            if (radioButton_TypeRoom1_.Checked) type = 1;

            if (btn.Text == "THÊM")
            {
                btn.Text = "LƯU";
                button_UpdateRoom.Hide();
                button_DeleteRoom.Hide();

                textBox_NameRoom.Text = "";
                textBox_IdRoom.Text = "Tạo tự động";
                textBox_PriceRoom_.Text = "0";
                comboBox_SizeRoom.DropDownStyle = ComboBoxStyle.DropDownList;
                if (size != "")
                {
                    string price = PriceRoomDAO.Instance.GetPriceBySizeAndType(size, type);
                    textBox_PriceRoom_.Text = price.ToString();
                }

                radioButton_TypeRoom0_.Checked = true;

                textBox_NameRoom.ReadOnly = false;
                comboBox_SizeRoom.Enabled = true;
                radioButton_TypeRoom0_.Enabled = true;
                radioButton_TypeRoom1_.Enabled = true;
                dataGridView_ListRoom.Enabled = false;
            }
            else
            {
                string name = textBox_NameRoom.Text;
                if (textBox_NameRoom.Text == "" || comboBox_SizeRoom.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }
                if (RoomDAO.Instance.CheckExistsNameRoom(name))
                {
                    MessageBox.Show("Tên phòng này đã tồn tại", "Thông báo");
                    return;
                }
                if (textBox_PriceRoom_.Text == "0" || textBox_PriceRoom_.Text == "0.0000")
                {
                    string type_STR = (type == 0) ? "thường" : "Vip";
                    MessageBox.Show("Phòng " + size + " người loại " + type_STR + " hiện chưa được cập nhật giá, xin hãy cập nhật giá trước khi thêm phòng", "Thông báo");
                    return;
                }

                SizeRoom sizeRoom = comboBox_SizeRoom.SelectedItem as SizeRoom;

                if (!RoomDAO.Instance.InsertRoom(name,sizeRoom.IdSizeRoom,type, textBox_PriceRoom_.Text))
                {
                    MessageBox.Show("Thêm thất bại", "Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo");
                    btn.Text = "THÊM";
                    LoadRoom();
                    Load();
                }
            }
        }

        private void button_UpdateRoom_Click(object sender, EventArgs e)
        {
            string id = textBox_IdRoom.Text;
            if (id == "")
            {
                MessageBox.Show("Hãy chọn dịch vụ muốn sửa.", "Thông báo");
                return;
            }

            if (RoomDAO.Instance.isRoomUsing(id))
            {
                MessageBox.Show("Phòng này đang được sử dụng", "Thông báo");
                return;
            }

            textBox_NameRoom.Focus();
            Button btn = sender as Button;
            
            string size = comboBox_SizeRoom.Text;
            int type = 0;
            if (radioButton_TypeRoom1_.Checked) type = 1;

            if (btn.Text == "SỬA")
            {
                if (RoomDAO.Instance.CheckExistsRoomStatus1ByIdRoom(id))
                {
                    MessageBox.Show("Phòng này đang được sử dụng", "Thông báo");
                    return;
                }

                btn.Text = "LƯU";
                button_AddRoom.Hide();
                button_DeleteRoom.Hide();

                comboBox_SizeRoom.DropDownStyle = ComboBoxStyle.DropDownList;
                if (size != "")
                {
                    string price = PriceRoomDAO.Instance.GetPriceBySizeAndType(size, type);
                    textBox_PriceRoom_.Text = price.ToString();
                }

                textBox_NameRoom.ReadOnly = false;
                comboBox_SizeRoom.Enabled = true;
                radioButton_TypeRoom0_.Enabled = true;
                radioButton_TypeRoom1_.Enabled = true;
                dataGridView_ListRoom.Enabled = false;
            }
            else
            {
                string name = textBox_NameRoom.Text;

                if (textBox_NameRoom.Text == "" || comboBox_SizeRoom.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin trước khi Lưu", "Thông báo");
                    return;
                }

                if (RoomDAO.Instance.CheckExistsNameRoomNotInIdRoom(name, id))
                {
                    MessageBox.Show("Tên phòng này đã tồn tại", "Thông báo");
                    return;
                }

                if (textBox_PriceRoom_.Text == "0" || textBox_PriceRoom_.Text == "0.0000")
                {
                    string type_STR = (type == 0) ? "thường" : "Vip";
                    MessageBox.Show("Phòng " + size + " người loại " + type_STR + " hiện chưa được cập nhật giá, xin hãy cập nhật giá trước khi thêm phòng", "Thông báo");
                    return;
                }

                SizeRoom sizeRoom = comboBox_SizeRoom.SelectedItem as SizeRoom;

                if (!RoomDAO.Instance.UpdateRoom(id,name,sizeRoom.IdSizeRoom,type,textBox_PriceRoom_.Text))
                {
                    MessageBox.Show("Sửa thất bại","Thông báo");
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thành công", "Thông báo");
                    LoadRoom();
                }
            }
        }

        private void button_DeleteRoom_Click(object sender, EventArgs e)
        {
            string id = textBox_IdRoom.Text;
            if (id == "") return;

            if (RoomDAO.Instance.CheckExistsRoomStatus1ByIdRoom(id))
            {
                MessageBox.Show("Phòng này đang được sử dụng", "Thông báo");
                return;
            }

            BillDAO.Instance.UpdateNullIdRoomByIdRoom(id);
            if (!RoomDAO.Instance.DeleteRoomByIdRoom(id))
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
                return;
            }
            else
            {
                MessageBox.Show("Xóa thành công","Thông báo");
                LoadRoom();
            }
        }

        private void textBox_PriceRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_SizeRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_PriceRoom__KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void comboBox_SizeRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (button_AddRoom.Text != "LƯU" && button_UpdateRoom.Text != "LƯU") return;
            string size = comboBox_SizeRoom.Text;
            int type = 0;
            if (radioButton_TypeRoom1_.Checked) type = 1;
            if (size != "")
            {
                string price = PriceRoomDAO.Instance.GetPriceBySizeAndType(size, type);
                textBox_PriceRoom_.Text = price.ToString();
            }
        }

        private void radioButton_TypeRoom0__Click(object sender, EventArgs e)
        {
            if (button_AddRoom.Text != "LƯU" && button_UpdateRoom.Text != "LƯU") return;
            string size = comboBox_SizeRoom.Text;
            int type = 0;
            if (radioButton_TypeRoom1_.Checked) type = 1;
            if (size != "")
            {
                string price = PriceRoomDAO.Instance.GetPriceBySizeAndType(size, type);
                textBox_PriceRoom_.Text = price.ToString();
            }
        }

        private void radioButton_TypeRoom1__Click(object sender, EventArgs e)
        {
            if (button_AddRoom.Text != "LƯU" && button_UpdateRoom.Text != "LƯU") return;
            string size = comboBox_SizeRoom.Text;
            int type = 0;
            if (radioButton_TypeRoom1_.Checked) type = 1;
            if (size != "")
            {
                string price = PriceRoomDAO.Instance.GetPriceBySizeAndType(size, type);
                textBox_PriceRoom_.Text = price.ToString();
            }
        }

        #endregion
    }
}
