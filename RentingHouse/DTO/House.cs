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

        public House(int id,Decimal area, float retal, int numberPeople, string address, int district, string description,string addInfo,string status, string reason, int owner) 
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
            this.Id = (int)row["id"];
            this.Area = (Decimal)row["area"];
            this.Rental = (float)Convert.ToDouble(row["rental"].ToString());
            this.NumberPeople = (int)row["number_people"];
            this.Address = row["h_address"].ToString();
            this.District = (int)row["district_id"];
            this.Description = row["h_description"].ToString();
            this.AddInfo = row["h_add_info"].ToString(); ;
            this.Status = row["h_status"].ToString(); ;
            this.Reason = row["reason"].ToString(); ;
            this.Owner = (int)row["h_user_id"]; ;
        }


        // Khai báo thuộc tính
        private int id;
        private Decimal area;
        private float rental;
        private int numberPeople;
        private string address;
        private string description;
        private string addInfo;
        private string status;
        private string reason;
        private int district;
        private int owner;


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

        public int District
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

        public int Owner
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
