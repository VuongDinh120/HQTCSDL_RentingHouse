using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    class FeeDAO
    {
        private static FeeDAO instance;

        public static FeeDAO Instance
        {
            get { if (instance == null) instance = new FeeDAO(); return instance; }
            private set { instance = value; }
        }

        private FeeDAO() { }

        public Fee GetFeeById(int id)
        {
            Fee fee = null;

            string query = string.Format("SELECT * FROM dbo.fees WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                fee = new Fee(item);
                return fee;
            }

            return fee;
        }

        public int InsertFee(string name, float price)
        {
            string query = string.Format("INSERT INTO dbo.fees(name, price) VALUES({0}, {1})", name, price);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateFee(Fee f)
        {
            string query = string.Format("UPDATE dbo.fees SET name = {0}, price = {1} WHERE id = {2}", f.Name, f.Price, f.Id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteFee(int id)
        {
            string query = string.Format("DELETE FROM dbo.fees WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
