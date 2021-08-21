using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class Survey
    {

        public Survey(string id,string detail, string status, string houseId, string userId) 
        {
            this.Id = id;
            this.Detail = detail;
            this.Status = status;
            this.HouseId = houseId;
            this.UserId = userId;
        }

        public Survey(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Detail = row["detail"].ToString();
            this.Status = row["status"].ToString();
            this.HouseId = row["house_id"].ToString();
            this.UserId = row["user_id"].ToString(); ;
        }

        // Khai báo thuộc tính
        private string id;
        private string detail;
        private string status;
        private string houseId;
        private string userId;



        public string Detail
        {
            get
            {
                return detail;
            }

            set
            {
                detail = value;
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
    }
}
