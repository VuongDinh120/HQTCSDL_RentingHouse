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
    public partial class fRegisterHouse : Form
    {
        private int loginUser;

        public int LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public fRegisterHouse(int loginUser)
        {
            InitializeComponent();
            LoginUser = loginUser;
          
        }

        private void fRegisterHouse_Load(object sender, EventArgs e)
        {
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(DistrictDAO.Instance.GetAllDistrict());
            cb_district.DataSource = myDataSet.Tables[0].DefaultView;
            cb_district.DisplayMember = "name";
            cb_district.ValueMember = "id";
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            int district_id = (int)cb_district.SelectedValue;
            decimal area = Convert.ToDecimal(txt_area.Text);
            int numberPeople = Convert.ToInt16(txt_numberPeople.Text);
            float rental = float.Parse(txt_rental.Text);
            
            House h = new House(0,area,rental,numberPeople,txt_address.Text,district_id,txt_description.Text,null,"pending",null,LoginUser);

            try
            {
                if (HouseDAO.Instance.RegisterHouse(h))
                {
                    MessageBox.Show("Đăng ký thành công", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Đăng ký thất bại", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Đăng ký thất bại",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
