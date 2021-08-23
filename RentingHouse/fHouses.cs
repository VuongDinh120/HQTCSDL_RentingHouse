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
        public fHouses()
        {
            InitializeComponent();
        }

        private void fHouses_Load(object sender, EventArgs e)
        {
            dgvHouses.AutoGenerateColumns = false;
            dgvHouses.DataSource = HouseDAO.Instance.GetAllHouses();
        }
    }
}
