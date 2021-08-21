using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class Transaction
    {
        public Transaction(string id, DateTime datetime, float money, string feeId, string userId)
        {
            this.Id = id;
            this.Datetime = datetime;
            this.Money = money;
            this.FeeId = feeId;
            this.UserId = userId;
        }

        public Transaction(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Datetime = (DateTime)row["datetime"];
            this.Money = (int)row["money"];
            this.FeeId = row["fee_id"].ToString();
            this.UserId = row["user_id"].ToString();
        }



        // Khai báo thuộc tính
        private string id;
        private DateTime datetime;
        private float money;
        private string feeId;
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

        public DateTime Datetime
        {
            get
            {
                return datetime;
            }

            set
            {
                datetime = value;
            }
        }

        public float Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }

        public string FeeId
        {
            get
            {
                return feeId;
            }

            set
            {
                feeId = value;
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
