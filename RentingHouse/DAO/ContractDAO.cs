using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    class ContractDAO
    {
        private static ContractDAO instance;

        public static ContractDAO Instance
        {
            get { if (instance == null) instance = new ContractDAO(); return instance; }
            private set { instance = value; }
        }

        private ContractDAO() { }

        public Contract GetContract(int houseId, int order)
        {
            Contract c = null;

            string query = string.Format($"SELECT * FROM dbo.contracts WHERE house_id = {houseId} AND order = {order}");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                c = new Contract(item);
                return c;
            }

            return c;
        }

        public int InsertContract(Contract c)
        {
            string query = string.Format($"INSERT INTO dbo.contracts(house_id, c_order, begin_date, end_date, fee) " +
                $"VALUES({c.HouseId}, {c.Order}, {c.BeginDate}, {c.EndDate}, {c.Fee})");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateContract(Contract c)
        {
            string query = string.Format($"UPDATE dbo.contracts SET begin_date = {c.BeginDate}, end_date = {c.EndDate}, fee = {c.Fee} WHERE house_id = {c.HouseId} AND order = {c.Order}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteContract(int houseId, int order)
        {
            string query = string.Format($"DELETE FROM dbo.contracts WHERE house_id = {houseId} AND order = {order}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
