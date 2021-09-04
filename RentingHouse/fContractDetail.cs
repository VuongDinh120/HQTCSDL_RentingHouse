using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RentingHouse.DAO;
using RentingHouse.DTO;

namespace RentingHouse
{
    public partial class fContractDetail : Form
    {
        private int houseId;

        public int HouseId
        {
            get { return houseId; }
            set { houseId = value; }
        }

        public fContractDetail(int idHouse)
        {
            InitializeComponent();
            HouseId = idHouse;
        }

        private void fContractDetail_Load(object sender, EventArgs e)
        {
            House h = HouseDAO.Instance.GetHouseById(HouseId);
            Contract c = ContractDAO.Instance.GetNewestContract(HouseId);

            txt_contract_status.Text = ContractDAO.Instance.GetContractStatus(c.HouseId,c.Order);
            txt_beginDate.Text = c.BeginDate;
            txt_endDate.Text = c.EndDate;

            loadComboBoxDistrict(h.District);
            txt_address.Text = h.Address;
            txt_area.Text = h.Area.ToString();
            txt_numberPeople.Text = h.NumberPeople.ToString();
            txt_rental.Text = h.Rental.ToString();
            txt_id.Text = h.Id.ToString();
            txt_reason.Text = h.Reason;
            txt_status.Text = h.Status;
            txt_detail.Text = h.Description;

            dgv_contract_history.DataSource = ContractDAO.Instance.GetAllContractByHouse(HouseId);
        }

        private void loadComboBoxDistrict(int id)
        {
            DataSet myDataSet = new DataSet();
            myDataSet.Tables.Add(DistrictDAO.Instance.GetAllDistrict());
            cb_district.DataSource = myDataSet.Tables[0].DefaultView;
            cb_district.DisplayMember = "name";
            cb_district.ValueMember = "id";
            cb_district.SelectedValue = id;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_add_contract_Click(object sender, EventArgs e)
        {

        }
    }
}
