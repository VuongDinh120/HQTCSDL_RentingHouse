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
    public partial class fBookingDetail_Feedback : Form
    {
        private int bookingId;
        private int userId;
        private float fee;
        private float befBalance;
        private Form bookingForm;

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
        public float Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public float BefBalance
        {
            get { return befBalance; }
            set { befBalance = value; }
        }
        public Form BookingForm
        {
            get { return bookingForm; }
            set { bookingForm = value; }
        }

        public fBookingDetail_Feedback(int bid, int uid, float fee, float balance, Form f)
        {
            InitializeComponent();
            BookingId = bid;
            UserId = uid;
            BefBalance = balance;
            BookingForm = f;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            string str = txt_feedback.Text;
            if (BookingDetailDAO.Instance.DeclineBooking(BookingId))
            {
                float lia_fee = Fee;
                float balance = UserDAO.Instance.GetUserBalance(UserId);
                string msg = string.Format("Xác nhận thuê nhà thành công!!\nPhí trách nhiệm được trả lại: {0}\nSố dư ban đầu: {1}\nSố dư sau khi hoàn phí: {2}", lia_fee, BefBalance, balance);
                MessageBox.Show(msg, "Thông báo");
            }
            else
            {
                MessageBox.Show("Thất bại! Đã có lỗi xảy ra.", "Thông báo");
            }
            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
