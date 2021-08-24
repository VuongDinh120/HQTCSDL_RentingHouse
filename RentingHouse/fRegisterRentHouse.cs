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
    public partial class fRegisterRentHouse : Form
    {
        private List<int> idList;
        private int loginUser;

        public List<int> IdList
        {
            get { return idList; }
            set { idList = value; }
        }
        public int LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public fRegisterRentHouse(List<int> listId, int loginUser)
        {
            InitializeComponent();
            IdList = listId;
            LoginUser = loginUser;
        }

        private void fRegisterRentHouse_Load(object sender, EventArgs e)
        {
            dgv_listHouseChecked.DataSource = HouseDAO.Instance.GetListHouseById(IdList);
            float rentFee = FeeDAO.Instance.GetRentFee();
            float liabilityFee = FeeDAO.Instance.GetLiabilityFee();
            float totalFee = liabilityFee + rentFee;
            lb_rentFee.Text = rentFee.ToString();
            lb_liabilityFee.Text = liabilityFee.ToString();
            lb_totalFee.Text = totalFee.ToString();
        }

        private void dgv_listHouseChecked_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Binding data
            if (txt_id.DataBindings.Count > 0)
                txt_id.DataBindings.RemoveAt(0);
            txt_id.DataBindings.Add( new Binding("Text", dgv_listHouseChecked.DataSource, "id", false));

            if (txt_district.DataBindings.Count > 0)
                txt_district.DataBindings.RemoveAt(0);
            txt_district.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "district", false));

            if (txt_numberPeople.DataBindings.Count > 0)
                txt_numberPeople.DataBindings.RemoveAt(0);
            txt_numberPeople.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "number_people", false));

            if (txt_area.DataBindings.Count > 0)
                txt_area.DataBindings.RemoveAt(0);
            txt_area.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "area", false));

            if (txt_rental.DataBindings.Count > 0)
                txt_rental.DataBindings.RemoveAt(0);
            txt_rental.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "rental", false));

            if (txt_status.DataBindings.Count > 0)
                txt_status.DataBindings.RemoveAt(0);
            txt_status.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "h_status", false));

            if (txt_address.DataBindings.Count > 0)
                txt_address.DataBindings.RemoveAt(0);
            txt_address.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "h_address", false));

            if (txt_detail.DataBindings.Count > 0)
                txt_detail.DataBindings.RemoveAt(0);
            txt_detail.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "h_description", false));

            if (txt_owner.DataBindings.Count > 0)
                txt_owner.DataBindings.RemoveAt(0);
            txt_owner.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "fullname", false));
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            float rentFee = FeeDAO.Instance.GetRentFee();
            float liabilityFee = FeeDAO.Instance.GetLiabilityFee();
            Booking newBooking = new Booking(-1, now.ToString("yyyy-MM-dd"), now.ToString("yyyy-MM-dd"), null, "ChoXuLy", IdList.Count, rentFee, liabilityFee, loginUser);
            int bookingId = BookingDAO.Instance.InsertBooking(newBooking);
            if (bookingId > -1)
            {
                int detailInserted = 0;
                for (int i = 0, n = IdList.Count; i < n; i++)
                {
                    BookingDetail bd = new BookingDetail(bookingId, IdList[i], null, null, null, -1, null);
                    detailInserted += BookingDetailDAO.Instance.InsertBookingDetail(bd);
                }

                DialogResult result;
                if (detailInserted >= IdList.Count)
                {
                    result = MessageBox.Show("Đăng ký thành công", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    result = MessageBox.Show("Đăng ký không thành công", "Thông báo", MessageBoxButtons.OK);
                }

                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
