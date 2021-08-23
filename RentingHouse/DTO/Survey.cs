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

        public Survey(int id,string detail, string status, int houseId, int userId) 
        {
            this.Id = id;
            this.Detail = detail;
            this.Status = status;
            this.HouseId = houseId;
            this.UserId = userId;
        }

        public Survey(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Detail = row["detail"].ToString();
            this.Status = row["s_status"].ToString();
            this.HouseId = (int)row["house_id"];
            this.UserId = (int)row["s_user_id"]; ;
        }

        // Khai báo thuộc tính
        private int id;
        private string detail;
        private string status;
        private int houseId;
        private int userId;



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
    }
}
