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
            string query = string.Format("SELECT s.*, h.h_address,h.area, d.name as district, u.fullname FROM dbo.surveys s JOIN dbo.houses h ON s.house_id = h.id JOIN dbo.users u ON s.s_user_id = u.id JOIN districts d ON d.id = h.district_id");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetAllHousesNotSurveys()
        {
            string query = string.Format("SELECT h.*,d.name as district, u.fullname FROM dbo.houses h JOIN dbo.users u ON h.h_user_id = u.id JOIN districts d ON d.id = h.district_id WHERE h.id NOT IN (SELECT house_id FROM surveys)");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
