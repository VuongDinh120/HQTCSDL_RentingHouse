using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RentingHouse.DTO;
using RentingHouse.DAO;

namespace RentingHouse
{
    public partial class fSurveyHouses : Form
    {
        private int housesId;

        public int HousesId
        {
            get { return housesId; }
            set { housesId = value; }
        }

        public fSurveyHouses(int ID)
        {
            InitializeComponent();
            HousesId = ID;
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(DistrictDAO.Instance.GetAllDistrict());
            cb_district.DataSource = myDataSet.Tables[0].DefaultView;
            cb_district.DisplayMember = "name";
            cb_district.ValueMember = "id";
        }

        private void fSurveyHouses_Load(object sender, EventArgs e)
        {
            House h = HouseDAO.Instance.GetHouseById(HousesId);
            User owner = UserDAO.Instance.GetUserById(h.Owner);
            txt_id.Text =h.Id.ToString();
            txt_area.Text = h.Area.ToString();
            txt_address.Text = h.Address;
            cb_district.SelectedValue = h.District;
            txt_numberPeople.Text = h.NumberPeople.ToString();
            txt_rental.Text = h.Rental.ToString();
            txt_status.Text = h.Status;
            txt_owner.Text = owner.FullName;
            txt_description.Text = h.Description;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
