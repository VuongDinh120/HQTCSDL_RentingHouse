using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

//Phải khai báo 2 cái này mới sử dụng đc DAO, DTO
using RentingHouse.DAO;
using RentingHouse.DTO;

namespace RentingHouse
{
    public partial class fHouses : Form
    {
        private int loginUser;

        public int LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public fHouses(int loginUser)
        {
            InitializeComponent();
            LoginUser = loginUser;
            dgvHouses.AutoGenerateColumns = false;
        }

        private void fHouses_Load(object sender, EventArgs e)
        {
            dgvHouses.DataSource = HouseDAO.Instance.GetAllHouses();
        }

        private void btn_rentHouse_Click(object sender, EventArgs e)
        {
            var checkedList = new List<int>();
           
            foreach (DataGridViewRow dataGridRow in dgvHouses.Rows) {
               string a = (string)dataGridRow.Cells["col_checkbox_houses"].Value;
                if (dataGridRow.Cells["col_checkbox_houses"].Value != null &&
                     a=="T")
                {
                    checkedList.Add((int)dataGridRow.Cells[0].Value);
                }
            }
            if (checkedList.Count != 0)
            {
                new fRegisterRentHouse(checkedList, loginUser).Show();
            }
            else
            {

            }
        }
    }
}
