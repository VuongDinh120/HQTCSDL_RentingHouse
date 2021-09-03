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
    public partial class fMeetingAdmin: Form
    {
        public fMeetingAdmin()
        {
            InitializeComponent();
            dgvBooking.AutoGenerateColumns = false;
        }


        private void fMeetingAdmin_Load(object sender, EventArgs e)
        {
            dgvBooking.DataSource = BookingDetailDAO.Instance.GetAllNullMeeting();
        }

        private void dgvBooking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                int bookingid = (int)dgvBooking.Rows[e.RowIndex].Cells[0].Value;
                int houseid = (int)dgvBooking.Rows[e.RowIndex].Cells[1].Value;
                // new fBookingDetailAdmin(id).Show();
            }
        }
    }
}
