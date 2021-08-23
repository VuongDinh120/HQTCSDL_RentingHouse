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

        public Booking(int id, string beginDate, string endDate, string receiveDate, string status, int numberHouse, float rentFee, float liabilityFee, int userId) 
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
            this.Id = (int)row["id"];
            this.BeginDate = row["begin_date"].ToString();
            this.EndDate = row["end_date"].ToString();
            this.ReceiveDate = row["received_date"].ToString();
            this.Status = row["b_status"].ToString();
            this.NumberHouse = (int)row["number_house"];
            this.RentFee = (float)Convert.ToDouble(row["rent_fee"].ToString());
            this.LiabilityFee = (float)Convert.ToDouble(row["liability_fee"].ToString());
            this.UserId = (int)row["b_user_id"];
        }

        // Khai báo thuộc tính
        private int id;
        private string beginDate;
        private string endDate;
        private string receiveDate;
        private string status;
        private int numberHouse;
        private float rentFee;
        private float liabilityFee;
        private int userId;


        public int Id
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

        public string BeginDate
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

        public string EndDate
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

        public string ReceiveDate
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

        public int UserId
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
