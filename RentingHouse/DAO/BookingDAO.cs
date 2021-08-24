using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    class BookingDAO
    {
        private static BookingDAO instance;

        public static BookingDAO Instance
        {
            get { if (instance == null) instance = new BookingDAO(); return instance; }
            private set { instance = value; }
        }

        private BookingDAO() { }

        public Booking GetBookingById(int id)
        {
            Booking b = null;

            string query = string.Format("SELECT * FROM dbo.booking WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                b = new Booking(item);
                return b;
            }
            return b;
        }

        public int InsertBooking(Booking b)
        {
            string query = string.Format($"INSERT INTO dbo.booking(begin_date, end_date, b_status, number_house, rent_fee, liability_fee, b_user_id) " +
                $"VALUES({b.BeginDate}, {b.EndDate}, {b.EndDate}, {b.Status}, {b.NumberHouse}, {b.RentFee}, {b.LiabilityFee}, {b.UserId})");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateBooking(Booking b)
        {
            string query = string.Format($"UPDATE dbo.booking SET begin_date = {b.BeginDate}, end_date = {b.EndDate}, b_status = {b.Status}, number_house = {b.NumberHouse}," +
                $" rent_fee = {b.RentFee}, liability_fee = {b.LiabilityFee}, b_user_id = {b.UserId} WHERE id = {b.Id}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteBooking(int id)
        {
            string query = string.Format("DELETE FROM dbo.booking WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
