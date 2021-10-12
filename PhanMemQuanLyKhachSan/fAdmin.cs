using PhanMemQuanLyKhachSan.UC;
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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private Point FirstPoint;

        #region method

        
        void MovePanel_Side(Button btn)
        {
            panel_Side.Top = btn.Top;
        }

        void AddUCtoPanel_Control(Control c)
        {
            c.Dock = DockStyle.Fill;
            this.panel_Control.Controls.Clear();
            this.panel_Control.Controls.Add(c);
        }

        void ResetbuttonStatus()
        {
            //button_Home.Image = Properties.Resources.home;
            //button_Home.ForeColor = Color.White;
            button_Room.Image = Properties.Resources.RoomIcon1;
            button_Room.ForeColor = Color.White;
            button_Customers.Image = Properties.Resources.CustomersIcon;
            button_Customers.ForeColor = Color.White;
            button_Employees.Image = Properties.Resources.EmployeesIcon;
            button_Employees.ForeColor = Color.White;
            button_Services.Image = Properties.Resources.ServiceIcon;
            button_Services.ForeColor = Color.White;
            button_Proceeds.Image = Properties.Resources.Proceeds;
            button_Proceeds.ForeColor = Color.White;
        }

        #endregion

        #region event

        private void button_Room_Click(object sender, EventArgs e)
        {
            ResetbuttonStatus();
            MovePanel_Side(button_Room);
            button_Room.Image = Properties.Resources.RoomIcon2;
            button_Room.ForeColor = Color.FromArgb(75, 173, 247);
            AddUCtoPanel_Control(new UC_Room());
        }

        private void button_Customers_Click(object sender, EventArgs e)
        {
            ResetbuttonStatus();
            MovePanel_Side(button_Customers);
            button_Customers.Image = Properties.Resources.CustomersIcon2;
            button_Customers.ForeColor = Color.FromArgb(75, 173, 247);
            AddUCtoPanel_Control(new UC_Customer());
        }

        private void button_Employees_Click(object sender, EventArgs e)
        {
            ResetbuttonStatus();
            MovePanel_Side(button_Employees);
            button_Employees.Image = Properties.Resources.EmployeesIcon2;
            button_Employees.ForeColor = Color.FromArgb(75, 173, 247);
            AddUCtoPanel_Control(new UC_Employee());
        }

        private void button_Services_Click(object sender, EventArgs e)
        {
            ResetbuttonStatus();
            MovePanel_Side(button_Services);
            button_Services.Image = Properties.Resources.ServiceIcon2;
            button_Services.ForeColor = Color.FromArgb(75, 173, 247);
            AddUCtoPanel_Control(new UC_Service());
        }

        private void button_Proceeds_Click(object sender, EventArgs e)
        {
            ResetbuttonStatus();
            MovePanel_Side(button_Proceeds);
            button_Proceeds.Image = Properties.Resources.Proceeds1;
            button_Proceeds.ForeColor = Color.FromArgb(75, 173, 247);
            AddUCtoPanel_Control(new UC_Proceeds());
        }


        private void pictureBox2_Click(object sender, EventArgs e)
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


        private void fAdmin_Load(object sender, EventArgs e)
        {
            button_Proceeds_Click(sender, e);
        }

        #endregion
    }
}
