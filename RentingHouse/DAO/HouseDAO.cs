using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    class HouseDAO
    {
        private static HouseDAO instance;

        public static HouseDAO Instance
        {
            get { if (instance == null) instance = new HouseDAO(); return instance; }
            private set { instance = value; }
        }

        private HouseDAO() { }

        public House GetHouseById(int id)
        {
            House house = null;

            string query = string.Format("SELECT * FROM dbo.fees WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                house = new House(item);
                return house;
            }

            return house;
        }

        public int InsertHouse(House h)
        {
            string query = string.Format($"INSERT INTO dbo.houses(area, rental, number_people, h_address, h_description, add_info, h_status, reason, district_id, h_user_id)" +
                $" VALUES({h.Area}, {h.Rental}, {h.NumberPeople}, {h.Address}, {h.Description}, {h.AddInfo} ,{h.Status}, {h.Reason}, {h.District}, {h.Owner})");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateHouse(House h)
        {
            string query = string.Format($"UPDATE dbo.houses SET area = {h.Area}, rental = {h.Rental}, number_people = {h.NumberPeople}, h_address = {h.Address}, " +
                $"h_description = {h.Description}, add_info = {h.AddInfo}, h_status = {h.Status}, reason = {h.Reason}, district_id = {h.District}, h_user_id = {h.Owner} WHERE id = {h.Id}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteHouse(int id)
        {
            string query = string.Format("DELETE FROM dbo.houses WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
