﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class Contract
    {
        

        public Contract(int houseId, DateTime beginDate, DateTime endDate,float fee, int order = 1)
        {
            this.HouseId = houseId;
            this.Order = order;
            this.BeginDate = beginDate;
            this.EndDate = endDate;
            this.Fee = fee;
        }

        public Contract(DataRow row)
        {
            this.HouseId = (int)row["house_id"];
            this.Order = (int)row["c_order"];
            this.BeginDate = (DateTime)row["begin_date"];
            this.EndDate = (DateTime)row["end_date"];
            this.Fee = (float)row["fee"];
        }

        // Khai báo thuộc tính
        private int houseId;
        private int order;
        private DateTime beginDate;
        private DateTime endDate;
        private float fee;




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

        public int Order
        {
            get
            {
                return order;
            }

            set
            {
                order = value;
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

        public float Fee
        {
            get
            {
                return fee;
            }

            set
            {
                fee = value;
            }
        }
    }
}
