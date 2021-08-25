using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentingHouse.DTO;
using System.Data;

namespace RentingHouse.DAO
{
    public class BookingDetailDAO
    {
        private static BookingDetailDAO instance;

        public static BookingDetailDAO Instance
        {
            get { if (instance == null) instance = new BookingDetailDAO(); return instance; }
            private set { instance = value; }
        }

        private BookingDetailDAO() { }

        public BookingDetail GetBookingDetail(int bookingId, int houseId)
        {
            BookingDetail b = null;

            string query = string.Format("SELECT * FROM dbo.booking_detail WHERE booking_id = {0} AND house_id", bookingId, houseId);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                b = new BookingDetail(item);
                return b;
            }

            return b;
        }

        public int InsertBookingDetail(BookingDetail bd)
        {
            string query = string.Format($"INSERT INTO dbo.booking_detail(booking_id, house_id, meet_time, meet_address, meet_phone, is_rented) " +
                $"VALUES({bd.BookingId}, {bd.HouseId}, {(bd.MeetTime ?? "NULL")}, {(bd.MeetAddress ?? "NULL")}, {(bd.MeetPhone ?? "NULL")}, {bd.IsRented})");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateBookingDetail(BookingDetail bd)
        {
            string query = string.Format($"UPDATE dbo.booking_detail SET meet_time = {bd.MeetTime}, meet_address = {bd.MeetAddress}, meet_phone = {bd.MeetPhone}, is_rented = {bd.IsRented} WHERE booking_id = {bd.BookingId} AND house_id = {bd.HouseId}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteBookingDetail(int bookingId, int houseId)
        {
            string query = string.Format("DELETE FROM dbo.booking_detail WHERE booking_id = {0} AND house_id", bookingId, houseId);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
