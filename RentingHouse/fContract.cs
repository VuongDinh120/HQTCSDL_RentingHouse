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
    public partial class fContract : Form
    {
        private int loginUser;

        public int LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public fContract(int loginUser)
        {
            InitializeComponent();
            LoginUser = loginUser;
            dgvContract.AutoGenerateColumns = false;
        }


        private void fContract_Load(object sender, EventArgs e)
        {
            dgvContract.DataSource = HouseDAO.Instance.GetHousesByUserId(loginUser);
        }


        private void dgvContract_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
