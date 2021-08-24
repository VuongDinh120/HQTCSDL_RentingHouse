using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentingHouse.DTO;
using System.Data;

namespace RentingHouse.DAO
{
    public class FeeDAO
    {
        private static FeeDAO instance;

        public static FeeDAO Instance //Phương thức singleton
        {
            get { if (instance == null) instance = new FeeDAO(); return instance; }
            private set { instance = value; }
        }

        private FeeDAO() { }

        public float GetLiabilityFee()
        {
            Fee fee = null;

            string query = string.Format("SELECT * FROM dbo.fees WHERE id = {0}", 1);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                fee = new Fee(item);
                return fee.Price;
            }

            return fee.Price;
        }

        public float GetRentFee()
        {
            Fee fee = null;

            string query = string.Format("SELECT * FROM dbo.fees WHERE id = {0}", 2);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                fee = new Fee(item);
                return fee.Price;
            }

            return fee.Price;
        }

        public float GetHouseFee()
        {
            Fee fee = null;

            string query = string.Format("SELECT * FROM dbo.fees WHERE id = {0}", 3);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                fee = new Fee(item);
                return fee.Price;
            }

            return fee.Price;
        }
    }
}
