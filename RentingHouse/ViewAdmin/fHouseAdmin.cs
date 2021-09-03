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
    public partial class fHouseAdmin : Form
    {

        public fHouseAdmin()
        {
            InitializeComponent();
            dgvHouses.AutoGenerateColumns = false;
        }

        private void fHouseAdmin_Load(object sender, EventArgs e)
        {
            dgvHouses.DataSource = HouseDAO.Instance.GetAllHouses();
        }

        private void dgvHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int id = (int)dgvHouses.Rows[e.RowIndex].Cells[0].Value;
                new fHouseDetailAdmin(id).Show();
            }
        }
    }
}
