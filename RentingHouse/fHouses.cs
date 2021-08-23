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

namespace RentingHouse
{
    public partial class fHouses : Form
    {
        private string connectionSTR = "Data Source=HCM-HOANGVNH\\SQLEXPRESS;Initial Catalog=QLTN;Integrated Security=True";

        public fHouses()
        {
            InitializeComponent();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM houses", connection);
                DataTable dtbl = new DataTable();
                adapter.Fill(dtbl);

                dgvHouses.AutoGenerateColumns = false;
                dgvHouses.DataSource = dtbl;

                connection.Close();
            }
        }

        private void fHouses_Load(object sender, EventArgs e)
        {

        }
    }
}
