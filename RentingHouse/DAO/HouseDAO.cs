using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentingHouse.DTO;
using System.Data;

namespace RentingHouse.DAO
{
    public class HouseDAO
    {
        private static HouseDAO instance;

        public static HouseDAO Instance //Phương thức singleton
        {
            get { if (instance == null) instance = new HouseDAO(); return instance; }
            private set { instance = value; }
        }

        private HouseDAO() { }

        public House GetHouseById(int id)
        {
            House house = null;

            string query = string.Format("SELECT * FROM dbo.houses WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                house = new House(item);
                return house;
            }
            return house;
        }
    }
}
