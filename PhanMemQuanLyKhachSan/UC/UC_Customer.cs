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
    public partial class UC_Customer : UserControl
    {
        public UC_Customer()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            LoadCurrentCustomerList();
            LoadTop10CustomerList();
        }

        void LoadCurrentCustomerList()
        {
            dataGridView_CurrentCustomerList.DataSource = CustomerDAO.Instance.GetCurrentCustomerList();

        }

        void LoadTop10CustomerList()
        {
            dataGridView_Top10CustomerList.DataSource = CustomerDAO.Instance.GetTop10CustomerList();
        }

        private void dataGridView_CurrentCustomerList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
