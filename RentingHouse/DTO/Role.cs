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
        public Role(int id, string type)
        {
            this.Id = id;
            this.Type = type;
        }

        public Role(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Type = row["r_type"].ToString();
           
        }


        // Khai báo thuộc tính
        private int id;
        private string type;

        //
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
