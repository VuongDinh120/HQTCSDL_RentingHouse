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

        public DataTable GetAllNullMeeting()
        {
            string query = string.Format("SELECT bd.*,h.*,u.* FROM dbo.booking_detail bd JOIN dbo.houses h ON h.id = bd.house_id JOIN dbo.users u ON h.h_user_id = u.id WHERE bd.meet_address IS NULL OR bd.meet_phone IS NULL OR bd.meet_time IS NULL");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetListHouseById(int id)
        {
            string query = string.Format("SELECT bd.*, h.*, d.name AS district, u.fullname FROM booking_detail bd JOIN houses h ON bd.house_id=h.id JOIN districts d ON d.id = h.district_id JOIN users u ON u.id = h.h_user_id WHERE bd.booking_id = {0}",id);
            return DataProvider.Instance.ExecuteQuery(query);
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

        public bool DeclineBooking(int id)
        {
            //Sài query proc phải để param cách nhau như thế này "@a , @b" ko là bị lỗi
            int result = DataProvider.Instance.ExecuteNonQuery("usp_DeclineHouse @id ", new object[] {id});

            return result > 0;
        }

        public bool AccpectBooking(int houseId, int bookingId)
        {
            //Sài query proc phải để param cách nhau như thế này "@a , @b" ko là bị lỗi
            int result = DataProvider.Instance.ExecuteNonQuery("usp_AcceptHouse @booingId , @houseId", new object[] {bookingId, houseId});

            return result > 0;
        }
    }
}
