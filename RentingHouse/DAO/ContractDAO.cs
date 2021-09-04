using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentingHouse.DTO;
using System.Data;

namespace RentingHouse.DAO
{
    public class ContractDAO
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

        public string GetContractStatus(int houseId, int order)
        {
            int c = 0;
            string str = "";
            string query = string.Format("SELECT DATEDIFF(DAY,end_date,GETDATE())AS c_status FROM dbo.contracts WHERE house_id = {0} AND c_order = {1}",houseId,order);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                c = (int)item["c_status"];
                if (c>=0)
                {
                    str = "Đã hết hạn";
                }
                else { str = "Còn hiệu lực"; }

                return str;
            }

            return str;
        }

        public Contract GetNewestContract(int houseId)
        {
            Contract c = null;

            string query = string.Format("SELECT TOP 1 house_id, c_order,begin_date=CONVERT(varchar,begin_date,105), end_date=convert(varchar,end_date,105), fee FROM dbo.contracts WHERE house_id = {0} ORDER BY c_order DESC", houseId);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                c = new Contract(item);
                return c;
            }

            return c;
        }

        public DataTable GetAllContractByHouse(int id)
        {
            string query = string.Format("SELECT house_id, c_order,begin_date=CONVERT(varchar,begin_date,105), end_date=convert(varchar,end_date,105), fee FROM dbo.contracts WHERE house_id = {0}", id);
            return DataProvider.Instance.ExecuteQuery(query);
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
