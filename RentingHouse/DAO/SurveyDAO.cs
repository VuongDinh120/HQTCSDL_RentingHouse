using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    class SurveyDAO
    {
        private static SurveyDAO instance;

        public static SurveyDAO Instance
        {
            get { if (instance == null) instance = new SurveyDAO(); return instance; }
            private set { instance = value; }
        }

        private SurveyDAO() { }

        public Survey GetSurveyById(int id)
        {
            Survey survey = null;

            string query = string.Format("SELECT * FROM dbo.surveys WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                survey = new Survey(item);
                return survey;
            }

            return survey;
        }

        public int InsertSurvey(Survey s)
        {
            string query = string.Format($"INSERT INTO dbo.surveys(detail, s_status, house_id, s_user_id) VALUES({s.Detail}, {s.Status}, {s.HouseId}, {s.UserId})");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateSurvey(Survey s)
        {
            string query = string.Format($"UPDATE dbo.surveys SET detail = {s.Detail}, s_status = {s.Status}, house_id = {s.HouseId}, s_user_id = {s.UserId} WHERE id = {s.Id}");

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteSurvey(int id)
        {
            string query = string.Format("DELETE FROM dbo.surveys WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
