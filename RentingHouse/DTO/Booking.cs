using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class Booking
    {

        public Booking(string id, DateTime beginDate, DateTime endDate, DateTime receiveDate) 
        {
            this.Id = id;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.ReceiveDate = receiveDate;
            this.Status = status;
            this.NumberHouse = numberHouse;
            this.RentFee = rentFee;
            this.LiabilityFee = liabilityFee;
            this.UserId = userId;
        }

        public Booking(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.BeginDate = (DateTime)row["begin_date"];
            this.EndDate = (DateTime)row["end_date"];
            this.ReceiveDate = (DateTime)row["received_date"];
            this.Status = row["status"].ToString();
            this.NumberHouse = (int)row["number_house"];
            this.RentFee = (int)row["rent_fee"];
            this.LiabilityFee = (int)row["liability_fee"];
            this.UserId = row["user_id"].ToString();
        }

        // Khai báo thuộc tính
        private string id;
        private DateTime beginDate;
        private DateTime endDate;
        private DateTime receiveDate;
        private string status;
        private int numberHouse;
        private float rentFee;
        private float liabilityFee;
        private string userId;


        public string Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public DateTime BeginDate
        {
            get
            {
                return beginDate;
            }

            set
            {
                beginDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public DateTime ReceiveDate
        {
            get
            {
                return receiveDate;
            }

            set
            {
                receiveDate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int NumberHouse
        {
            get
            {
                return numberHouse;
            }

            set
            {
                numberHouse = value;
            }
        }

        public float RentFee
        {
            get
            {
                return rentFee;
            }

            set
            {
                rentFee = value;
            }
        }

        public float LiabilityFee
        {
            get
            {
                return liabilityFee;
            }

            set
            {
                liabilityFee = value;
            }
        }

        public string UserId
        {
            get
            {
                return userId;
            }

            set
            {
                userId = value;
            }
        }
    }
}
