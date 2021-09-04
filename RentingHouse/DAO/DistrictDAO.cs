using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    public class DistrictDAO
    {
        private static DistrictDAO instance;

        public static DistrictDAO Instance
        {
            get { if (instance == null) instance = new DistrictDAO(); return instance; }
            private set { instance = value; }
        }

        private DistrictDAO() { }

        public string GetDistrictNameById(int id)
        {
            District districtname = null;

            string query = string.Format("SELECT * FROM dbo.districts WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                districtname = new District(item);
                return districtname.Name;
            }

            return districtname.Name;
        }

        public DataTable GetAllDistrict()
        {
            string query = string.Format("SELECT * FROM dbo.districts");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public int InsertDistrict(string name)
        {
            string query = string.Format("INSERT INTO dbo.districts(name) VALUES({0})", name);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateDistrict(District d)
        {
            string query = string.Format("UPDATE dbo.districts SET name = {0} WHERE id = {1}", d.Name, d.Id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteDistrict(int id)
        {
            string query = string.Format("DELETE FROM dbo.districts WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
