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
    public partial class fDashBoard : Form
    {
        private Account loginAccount;

        private Point FirstPoint;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(LoginAccount.TypeAccount); }
        }

        public fDashBoard(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;

            Load();
        }

        #region method

        void Load()
        {
            LoadListRoom("0 or r.Status = 1", "0 or r.TypeRoom = 1", "");
            LoadListService();
            LoadFilter();
            textBox_CustomerName.Text = "";
            textBox_CustomerCmnd.Text = "";
            textBox_CustomerPhone.Text = "";
            textBox_RoomName.Text = "";
            textBox_RoomPrice.Text = "";
            textBox_DateCheckIn.Text = "";
            textBox_Stay.Text = "";
            textBox_TotalPrice.Text = "";
            textBox_CustomerName.ReadOnly = true;
            textBox_CustomerCmnd.ReadOnly = true;
            textBox_CustomerPhone.ReadOnly = true;
            listView_Service.Items.Clear();
        }

        void ChangeAccount(bool typeAccount)
        {
            if (typeAccount)
                button_Admin.Show();
            else
                button_Admin.Hide();
        }

        // Tải lên danh sách phòng
        void LoadListRoom(string status, string type, string size)
        {
            flowLayoutPanel_RoomList.Controls.Clear();

            // Cài đặt khóa ban đầu 
            {
                textBox_CustomerName.ReadOnly = true;
                textBox_CustomerCmnd.ReadOnly = true;
                textBox_CustomerPhone.ReadOnly = true;

                button_CheckOut.Enabled = false;
                button_AddService.Enabled = false;
                button_CheckIn.Enabled = false;
            }
            
            List<Room> roomList = RoomDAO.Instance.FilterRoom(status,type,size);

            foreach (Room item in roomList)
            {
                Button btn = new Button() { Width = RoomDAO.RoomWidth, Height = RoomDAO.RoomHeight };

                btn.Font = new Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;

                btn.Text = item.Name;

                if (item.TypeRoom)
                    btn.Text += Environment.NewLine + "VIP";
                else
                    btn.Text += Environment.NewLine + "THƯỜNG";

                btn.Text += " - " + SizeRoomDAO.Instance.GetSizeRoom(item.IdSizeRoom);

                btn.Tag = item;

                Color color;
                if (!item.Status)
                    color = Color.FromArgb(121, 188, 108);
                else
                    color = Color.FromArgb(220, 93, 98);
                btn.BackColor = color;

                btn.Click += btn_Click;

                flowLayoutPanel_RoomList.Controls.Add(btn);
            }
        }

        void LoadListService()
        {
            List<Service> ListService = ServiceDAO.Instance.GetListService();
            comboBox_Service.DataSource = ListService;
            comboBox_Service.DisplayMember = "Name";
        }

        void LoadFilter()
        {
            // Trạng thái
            List<string> list_1 = new List<string>();
            string tmp = "Tất cả"; list_1.Add(tmp);
            tmp = "Trống"; list_1.Add(tmp);
            tmp = "Có người"; list_1.Add(tmp);
            comboBox_FilterStatus.DataSource = list_1;

            // Loại phòng
            List<string> list_2 = new List<string>();
            tmp = "Tất cả"; list_2.Add(tmp);
            tmp = "Thường"; list_2.Add(tmp);
            tmp = "Vip"; list_2.Add(tmp);
            comboBox_FilterTypeRoom.DataSource = list_2;

            // Cỡ phòng
            List<string> list_3 = new List<string>();
            tmp = "Tất cả"; list_3.Add(tmp);
            List<string> list_tmp = SizeRoomDAO.Instance.GetListSizeRoom_Str();
            foreach (string s in list_tmp)
                list_3.Add(s);
            comboBox_FilterSizeRoom.DataSource = list_3;
        }

        void LoadBill(Room room)
        {
            textBox_CustomerName.Focus();
            textBox_RoomName.Text = room.Name;
            textBox_RoomPrice.Text = room.Price.ToString();
            //textBox_TotalPrice.Text = "0";

            listView_Service.Items.Clear();

            double TotalPriceRoom = 0;

            int idBill = BillDAO.Instance.GetUnCheckBillIDByRoomID(room.IdRoom);

            if (idBill == -1)
            {
                LockTool();
                textBox_CustomerName.Text = "";
                textBox_CustomerCmnd.Text = "";
                textBox_CustomerPhone.Text = "";
                textBox_DateCheckIn.Text = "";
                textBox_Stay.Text = "";
            }
            else
            {
                UnLockTool();
                LoadBillByIdBill(BillDAO.Instance.GetUnCheckBillIDByRoomID(room.IdRoom));
                double TotalPriceService = LoadListMenuServiceByIdBill(idBill);
                TotalPriceRoom = Convert.ToDouble(textBox_Stay.Text) * Convert.ToDouble(textBox_RoomPrice.Text) + TotalPriceService;

            }

            textBox_TotalPrice.Text = TotalPriceRoom.ToString() + " VND";
        }

        void LoadBillByIdBill(int id)
        {
            Bill bill = BillDAO.Instance.GetBillInfoByIdBill(id);

            DateTime DateCheckIn = bill.DateCheckIn.Value;

            textBox_DateCheckIn.Text =DateCheckIn.Day.ToString() + "/" + DateCheckIn.Month.ToString() + "/" + DateCheckIn.Year.ToString();

            DateTime Now = DateTime.Now;

            TimeSpan TimeStay = Now - DateCheckIn;

            int Stay = TimeStay.Days + 1;

            textBox_Stay.Text = Stay.ToString();

            Customer customer = CustomerDAO.Instance.GetCustomerById(bill.IdCustomer);

            textBox_CustomerName.Text = customer.Name;
            textBox_CustomerCmnd.Text = customer.Cmnd;
            textBox_CustomerPhone.Text = customer.Phone;
        }

        double LoadListMenuServiceByIdBill(int id)
        {
            double TotalPriceService = 0;
            List<MenuService> ListMenuService = MenuServiceDAO.Instance.LoadListServiceByIdbill(id);

            foreach (MenuService item in ListMenuService)
            {
                ListViewItem lsvItem = new ListViewItem(item.ServiceName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                listView_Service.Items.Add(lsvItem);

                TotalPriceService += item.TotalPrice;
            }

            return TotalPriceService;
        }

        // Nếu trùng Cmnd nhưng sai tên với tên đã có trước thì xuất -1
        // Nếu trùng Cmnd và trùng tên với khách hàng đã có thì xuất IdCustomer của khách hàng đó
        // Nế chưa tồn tại Cmnd này thì Inser khách hàng và xuất ra IdCustomer lớn nhất trong bảng Customer
        int AddNewCustomer(string name, string cmnd, string phone)
        {
            int GetExistCustomerByCmnd = CustomerDAO.Instance.GetExistCustomerByCmnd(cmnd);

            if (GetExistCustomerByCmnd == -1)
            {
                // Thêm khách mới
                CustomerDAO.Instance.AddNewCustomer(name, cmnd, phone);
                return CustomerDAO.Instance.GetMaxIdCustomer();
            }
            else
            {
                if (name != CustomerDAO.Instance.GetCustomerNameById(GetExistCustomerByCmnd))
                {
                    // Báo lỗi
                    return -1;
                }
                else
                {
                    // Trả về Id Khách hàng có cmnd đã nhập
                    CustomerDAO.Instance.UpdatePhoneNumber(GetExistCustomerByCmnd.ToString(), phone);
                    return GetExistCustomerByCmnd;
                }
            }
        }

        private void CheckIn(int idRoom, int idCustomer)
        {
            BillDAO.Instance.InsertNewBill(idRoom, idCustomer);
        }

        private void CheckOut(int idRoom, float totalPrice)
        {
            RoomDAO.Instance.CheckOut(idRoom, totalPrice);
        }

        void LockTool()
        {
            textBox_CustomerName.ReadOnly = false;
            textBox_CustomerCmnd.ReadOnly = false;
            textBox_CustomerPhone.ReadOnly = false;

            button_AddService.Enabled = false;
            button_CheckOut.Enabled = false;
            button_CheckIn.Enabled = true;
        }

        void UnLockTool()
        {
            textBox_CustomerName.ReadOnly = true;
            textBox_CustomerCmnd.ReadOnly = true;
            textBox_CustomerPhone.ReadOnly = true;

            button_AddService.Enabled = true;
            button_CheckOut.Enabled = true;
            button_CheckIn.Enabled = false;
        }

        #endregion

        #region event

        private void button_Profile_Click(object sender, EventArgs e)
        {
            fProfile fProfile = new fProfile(LoginAccount);
            fProfile.ShowDialog();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Room room = ((sender as Button).Tag as Room);

            LoadBill(room);

            listView_Service.Tag = (sender as Button).Tag;
        }

        private void button_CheckIn_Click(object sender, EventArgs e)
        {
            Room room = listView_Service.Tag as Room;

            string CustomerName = textBox_CustomerName.Text;
            string CustomerCmnd = textBox_CustomerCmnd.Text;
            string CustomerPhone = textBox_CustomerPhone.Text;

            if (CustomerName == "" || CustomerCmnd == "")
            {
                MessageBox.Show("Cần điền đầy đủ thông tin khách hàng trước khi đặt phòng", "Thông báo");
                return;
            }

            int IdNewCustomer = AddNewCustomer(CustomerName, CustomerCmnd, CustomerPhone);

            if (IdNewCustomer == -1)
                MessageBox.Show("Đã tồn tại khách hành có CMND này nhưng không khớp với tên đã nhập. Vui lòng kiểm tra lại thông tin đăng ký", "Thông báo");
            else
            {
                // Thêm khách hàng thành công
                // Tiến hành CheckIn cho khách hàng có IdCustomer là IdNewCustomer và IdRoom là room.IdRoom
                CheckIn(room.IdRoom, IdNewCustomer);
                RoomDAO.Instance.SetFullRoom(room.IdRoom);
                LoadListRoom("0 or r.Status = 1", "0 or r.TypeRoom = 1", "");
                LoadFilter();
                LoadBill(room);
                UnLockTool();
            }

        }

        private void button_Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            fAdmin frmAdmin = new fAdmin();
            frmAdmin.ShowDialog();
            this.Show();
            Load();
        }

        private void button_AddService_Click(object sender, EventArgs e)
        {
            Room room = listView_Service.Tag as Room;
            int idBill = BillDAO.Instance.GetUnCheckBillIDByRoomID(room.IdRoom);

            if (comboBox_Service.SelectedItem == null) return;

            int idService = (comboBox_Service.SelectedItem as Service).IdService;
            int count = (int)numericUpDown_Count.Value;

            // Xét xem idService của Bill đó đã tồn tại chưa
            if(DetailServiceDAO.Instance.isExitsServiceByIdBill(idBill,idService))
            {
                // Đã tồn tại >> Cần update
                DetailServiceDAO.Instance.UpdateDetailService(idBill, idService, count);
            }
            else
            {
                // Chưa tồn tại >> Cần Insert
                DetailServiceDAO.Instance.InserteDetailService(idBill, idService, count);
            }

            LoadBill(room);
        }

        private void button_CheckOut_Click(object sender, EventArgs e)
        {
            Room room = listView_Service.Tag as Room;
            int idRoom = room.IdRoom;

            if (MessageBox.Show("Bạn có chắc chắn muốn thanh toán cho hóa đơn phòng " + room.Name + Environment.NewLine + "Giá trị hóa đơn: " + textBox_TotalPrice.Text, "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                return;

            string TotalPriceRoomSTR = textBox_TotalPrice.Text.Remove(textBox_TotalPrice.Text.Length - 4, 4);

            float TotalPriceRoom = (float)Convert.ToDouble(TotalPriceRoomSTR);

            CheckOut(idRoom, TotalPriceRoom);
            RoomDAO.Instance.SetEmptyRoom(room.IdRoom);
            LoadListRoom("0 or r.Status = 1", "0 or r.TypeRoom = 1", "");
            LoadFilter();
            LoadBill(room);
            LockTool();
        }

        private void button_Filter_Click(object sender, EventArgs e)
        {
            string status = comboBox_FilterStatus.Text;
            switch (status)
            {
                case "Trống": status = "0"; break;
                case "Có người": status = "1"; break;
                default: status = "0 or r.Status = 1"; break;
            }

            string type = comboBox_FilterTypeRoom.Text;
            switch (type)
            {
                case "Thường": type = "0"; break;
                case "Vip": type = "1"; break;
                default: type = "0 or r.TypeRoom = 1"; break;
            }

            string size = comboBox_FilterSizeRoom.Text;
            if (size != "Tất cả")
            {
                string tmp = "and(s.SizeRoom = " + size + ")";
                size = tmp;
            }
            else
                size = "";
            
            // Load lại
            LoadListRoom(status, type, size);
            LoadListService();
            textBox_CustomerName.Text = "";
            textBox_CustomerCmnd.Text = "";
            textBox_CustomerPhone.Text = "";
            textBox_RoomName.Text = "";
            textBox_RoomPrice.Text = "";
            textBox_DateCheckIn.Text = "";
            textBox_Stay.Text = "";
            textBox_CustomerName.ReadOnly = true;
            textBox_CustomerCmnd.ReadOnly = true;
            textBox_CustomerPhone.ReadOnly = true;
        }

        private void pictureBox_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox_Exit_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBox_Exit.BackgroundImage = Properties.Resources.LogoutIcon2;
        }

        private void pictureBox_Exit_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox_Exit.BackgroundImage = Properties.Resources.LogoutIcon;
        }

        private void textBox_CustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void textBox_CustomerCmnd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_CustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TextBox_CustomerName_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).Text = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase((sender as TextBox).Text.ToLower());
        }

        #endregion

        private void fDashBoard_Load(object sender, EventArgs e)
        {

        }

        private void panel_Top_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                FirstPoint = MousePosition; ;
        }

        private void panel_Top_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point temp = MousePosition;
                Point res = new Point(temp.X - FirstPoint.X, temp.Y - FirstPoint.Y);
                this.Location = new Point(this.Location.X + res.X, this.Location.Y + res.Y);
                FirstPoint = temp;
            }
        }
    }
}
