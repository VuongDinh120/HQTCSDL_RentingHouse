using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class BookingDetail
    {

        public BookingDetail(string bookingId, string houseId, DateTime meetTime, string meetAddress, string meetPhone, bool isRented, string feedback)
        {
            this.BookingId = bookingId;
            this.HouseId = houseId;
            this.MeetTime = meetTime;
            this.MeetAddress = meetAddress;
            this.MeetPhone = meetPhone;
            this.Feedback = feedback;
        }

        public BookingDetail(DataRow row)
        {
            this.BookingId = row["booking_id"].ToString();
            this.HouseId = row["house_id"].ToString();
            this.MeetTime = (DateTime)row["meet_time"];
            this.MeetAddress = row["meet_address"].ToString();
            this.MeetPhone = row["meet_phone"].ToString();
            this.Feedback = row["feedback"].ToString();
        }

        // Khai báo thuộc tính
        private string bookingId;
        private string houseId;
        private DateTime meetTime;
        private string meetAddress;
        private string meetPhone;
        private bool isRented;
        private string feedback;



        public string BookingId
        {
            get
            {
                return bookingId;
            }

            set
            {
                bookingId = value;
            }
        }

        public string HouseId
        {
            get
            {
                return houseId;
            }

            set
            {
                houseId = value;
            }
        }

        public DateTime MeetTime
        {
            get
            {
                return meetTime;
            }

            set
            {
                meetTime = value;
            }
        }

        public string MeetAddress
        {
            get
            {
                return meetAddress;
            }

            set
            {
                meetAddress = value;
            }
        }

        public string MeetPhone
        {
            get
            {
                return meetPhone;
            }

            set
            {
                meetPhone = value;
            }
        }

        public bool IsRented
        {
            get
            {
                return isRented;
            }

            set
            {
                isRented = value;
            }
        }

        public string Feedback
        {
            get
            {
                return feedback;
            }

            set
            {
                feedback = value;
            }
        }
    }
}
