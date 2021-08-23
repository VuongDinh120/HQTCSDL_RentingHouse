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
        public Transaction(int id, DateTime datetime, float money, string feeId, string userId)
        {
            this.Id = id;
            this.Datetime = datetime;
            this.Money = money;
            this.FeeId = feeId;
            this.UserId = userId;
        }

        public Transaction(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Datetime = (DateTime)row["t_datetime"];
            this.Money = (int)row["t_money"];
            this.FeeId = row["t_fee_id"].ToString();
            this.UserId = row["t_user_id"].ToString();
        }



        // Khai báo thuộc tính
        private int id;
        private DateTime datetime;
        private float money;
        private string feeId;
        private string userId;


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
