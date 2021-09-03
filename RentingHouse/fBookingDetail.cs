using RentingHouse.DTO;
using RentingHouse.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentingHouse
{
    public partial class fBookingDetail : Form
    {
        private int bookingId;
        private int userId;
        private float befBalance;

        public int BookingId
        {
            get { return bookingId; }
            set { bookingId = value; }
        }
       
        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public float BefBalance
        {
            get { return befBalance; }
            set { befBalance = value; }
        }

        public fBookingDetail(int bid, int uid)
        {
            InitializeComponent();
            BookingId = bid;
            UserId = uid;
            dgv_listHouseChecked.AutoGenerateColumns = false;
            BefBalance = UserDAO.Instance.GetUserBalance(uid);
        }

        private void fBookingDetail_Load(object sender, EventArgs e)
        {
            Booking b = BookingDAO.Instance.GetBookingById(BookingId);

            txt_begin_date.Text = b.BeginDate;
            txt_end_date.Text = b.EndDate;
            txt_received_date.Text = b.ReceiveDate;
            txt_rent_fee.Text = b.RentFee.ToString();
            txt_liability_fee.Text = b.LiabilityFee.ToString();
            txt_status.Text = b.Status;

            dgv_listHouseChecked.DataSource = BookingDetailDAO.Instance.GetListHouseById(BookingId);
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            var checkedList = new List<int>();
            float lia_fee = BookingDAO.Instance.GetBookingLiaFeeById(BookingId);

            foreach (DataGridViewRow dataGridRow in dgv_listHouseChecked.Rows)
            {
                string a = (string)dataGridRow.Cells["col_checkbox_houses"].Value;
                if (dataGridRow.Cells["col_checkbox_houses"].Value != null &&
                     a == "T")
                {
                    checkedList.Add((int)dataGridRow.Cells[0].Value);
                }
            }
            if (checkedList.Count == 1)
            {
                int houseId = checkedList[0];
                if (BookingDetailDAO.Instance.AccpectBooking(houseId, BookingId))
                {
                    float balance = UserDAO.Instance.GetUserBalance(UserId);
                    string msg = string.Format("Xác nhận thuê nhà thành công!!\nPhí trách nhiệm được trả lại: {0}\nSố dư ban đầu: {1}\nSố dư sau khi hoàn phí: {2}", lia_fee, BefBalance, balance);
                    MessageBox.Show(msg, "Thông báo");
                }
                else
                {
                    MessageBox.Show("Thất bại! Đã có lỗi xảy ra.", "Thông báo");
                }
            }
            else if(checkedList.Count == 0)
            {

                MessageBox.Show("Chưa chọn nhà", "Thông báo");
            }
            else
            {
                MessageBox.Show("Chỉ được chọn 1 nhà", "Thông báo");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            float lia_fee = BookingDAO.Instance.GetBookingLiaFeeById(BookingId);
            new fBookingDetail_Feedback(BookingId,UserId, lia_fee, BefBalance,this).Show();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_listHouseChecked_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Binding data
            if (txt_meet_time.DataBindings.Count > 0)
                txt_meet_time.DataBindings.RemoveAt(0);
            txt_meet_time.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "meet_time", false));

            if (txt_meet_phone.DataBindings.Count > 0)
                txt_meet_phone.DataBindings.RemoveAt(0);
            txt_meet_phone.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "meet_phone", false));

            if (txt_meet_address.DataBindings.Count > 0)
                txt_meet_address.DataBindings.RemoveAt(0);
            txt_meet_address.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "meet_address", false));

            if (txt_id_house.DataBindings.Count > 0)
                txt_id_house.DataBindings.RemoveAt(0);
            txt_id_house.DataBindings.Add(new Binding("Text", dgv_listHouseChecked.DataSource, "house_id", false));
        }

        
    }
}
