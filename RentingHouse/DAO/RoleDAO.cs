using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentingHouse.DTO;

namespace RentingHouse.DAO
{
    class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance //Phương thức singleton
        {
            get { if (instance == null) instance = new RoleDAO(); return instance; }
            private set { instance = value; }
        }

        private RoleDAO() { }

        public string GetRoleNameById(int id)
        {
            Role rolename = null;

            string query = string.Format("SELECT * FROM dbo.roles WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                rolename = new Role(item);
                return rolename.Type;
            }

            return rolename.Type;
        }
    }
}
