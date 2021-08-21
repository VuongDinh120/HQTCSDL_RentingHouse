using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class District
    {
      

        public District(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public District(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Name = row["name"].ToString();

        }

        // Khai báo thuộc tính
        private string id;
        private string name;
    
        // get,set
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

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
    }
}
