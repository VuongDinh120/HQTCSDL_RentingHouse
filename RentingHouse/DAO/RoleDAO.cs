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

        public int InsertRole(string type)
        {
            string query = string.Format("INSERT INTO dbo.roles(r_type) VALUES({0})", type);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int UpdateRole(Role r)
        {
            string query = string.Format("UPDATE dbo.roles SET r_type = {0} WHERE id = {1}", r.Type, r.Id);   

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }

        public int DeleteRole(int id)
        {
            string query = string.Format("DELETE FROM dbo.roles WHERE id = {0}", id);

            int numAffectedRows = DataProvider.Instance.ExecuteNonQuery(query);

            return numAffectedRows;
        }
    }
}
