using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DAO
{
    public class SurveyDAO
    {
        private static SurveyDAO instance;

        public static SurveyDAO Instance
        {
            get { if (instance == null) instance = new SurveyDAO(); return instance; }
            private set { instance = value; }
        }

        private SurveyDAO() { }

        public DataTable GetAllSurveys()
        {
            string query = string.Format("SELECT s.*, h.h_address, u.fullname FROM dbo.surveys s JOIN dbo.houses h ON s.house_id = h.id JOIN dbo.users u ON s.s_user_id = u.id");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
