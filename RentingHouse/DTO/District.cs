﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    public class District
    {
      

        public District(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }

        public District(DataRow row)
        {
            this.Id = (int)row["id"];
            this.Name = row["name"].ToString();

        }

        // Khai báo thuộc tính
        private int id;
        private string name;
    
        // get,set
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
