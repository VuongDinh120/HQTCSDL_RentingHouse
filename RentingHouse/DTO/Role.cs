using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class Role
    {
        //
        public Role(string id, string type)
        {
            this.Id = id;
            this.Type = type;
        }

        public Role(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.Type = row["type"].ToString();
           
        }


        // Khai báo thuộc tính
        private string id;
        private string type;

        //
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

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }
    }
}
