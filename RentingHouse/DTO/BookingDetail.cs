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

        public BookingDetail(int bookingId, int houseId, DateTime meetTime, string meetAddress, string meetPhone, int isRented, string feedback)
        {
            this.BookingId = bookingId;
            this.HouseId = houseId;
            this.MeetTime = meetTime;
            this.MeetAddress = meetAddress;
            this.IsRented = isRented;
            this.Feedback = feedback;
        }

        public BookingDetail(DataRow row)
        {
            this.BookingId = (int)row["booking_id"];
            this.HouseId = (int)row["house_id"];
            this.MeetTime = (DateTime)row["meet_time"];
            this.MeetAddress = row["meet_address"].ToString();
            this.MeetPhone = row["meet_phone"].ToString();
            this.IsRented = (int)row["is_rented"];
            this.Feedback = row["feedback"].ToString();
        }

        // Khai báo thuộc tính
        private int bookingId;
        private int houseId;
        private DateTime meetTime;
        private string meetAddress;
        private string meetPhone;
        private int isRented;
        private string feedback;



        public int BookingId
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

        public int HouseId
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

        public int IsRented
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
