using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class House
    {

        public House(string id,Decimal area, float retal, int numberPeople, string address, string district, string description,string addInfo,string status, string reason, string owner) 
        {
            this.Id = id;
            this.Area = area;
            this.Rental = rental;
            this.NumberPeople = numberPeople;
            this.Address = address;
            this.District = district;
            this.Description = description;
            this.AddInfo = addInfo;
            this.Status = status;
            this.Reason = reason;
            this.Owner = owner;
        }

        public House(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Area = (Decimal)row["area"];
            this.Rental = (int)row["rental"];
            this.NumberPeople = (int)row["number_people"];
            this.Address = row["address"].ToString();
            this.District = row["district"].ToString();
            this.Description = row["description"].ToString();
            this.AddInfo = row["add_info"].ToString(); ;
            this.Status = row["status"].ToString(); ;
            this.Reason = row["reason"].ToString(); ;
            this.Owner = row["user_id"].ToString(); ;
        }


        // Khai báo thuộc tính
        private string id;
        private Decimal area;
        private float rental;
        private int numberPeople;
        private string address;
        private string district;
        private string description;
        private string addInfo;
        private string status;
        private string reason;
        private string owner;


        // get,set
        public decimal Area
        {
            get
            {
                return area;
            }

            set
            {
                area = value;
            }
        }

        public float Rental
        {
            get
            {
                return rental;
            }

            set
            {
                rental = value;
            }
        }

        public int NumberPeople
        {
            get
            {
                return numberPeople;
            }

            set
            {
                numberPeople = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string District
        {
            get
            {
                return district;
            }

            set
            {
                district = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public string AddInfo
        {
            get
            {
                return addInfo;
            }

            set
            {
                addInfo = value;
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

        public string Reason
        {
            get
            {
                return reason;
            }

            set
            {
                reason = value;
            }
        }

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
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
