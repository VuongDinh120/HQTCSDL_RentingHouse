using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    class TransactionDAO
    {
        private static TransactionDAO instance;

        public static TransactionDAO Instance
        {
            get { if (instance == null) instance = new TransactionDAO(); return instance; }
            private set { instance = value; }
        }

        private TransactionDAO() { }

        public Transaction GetTransactionById(int id)
        {
            Transaction trans = null;

            string query = string.Format("SELECT * FROM dbo.transactions WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                trans = new Transaction(item);
                return trans;
            }

            return trans;
        }

        public int InsertTransaction(Transaction t)
        {
            string query = string.Format($"INSERT INTO dbo.transactions(t_money, t_fee_id, t_user_id) VALUES({t.Money}, {t.FeeId}, {t.UserId})");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateTransaction(Transaction t)
        {
            string query = string.Format($"UPDATE dbo.transactions SET t_money = {t.Money}, t_fee_id = {t.FeeId}, t_user_id = {t.UserId} WHERE id = {t.Id}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteTransaction(int id)
        {
            string query = string.Format("DELETE FROM dbo.transactions WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
