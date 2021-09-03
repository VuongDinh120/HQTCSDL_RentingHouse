using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RentingHouse.DTO;


namespace RentingHouse.DAO
{
    // chứa các hàm xử lý của lớp
    public class UserDAO
    {
        private static UserDAO instance;

        public static UserDAO Instance //Phương thức singleton
        {
            get { if (instance == null) instance = new UserDAO(); return instance; } 
            private set { instance = value; }
        }

        private UserDAO() { }

        // Các hàm chức năng của lớp user

        // Trong lớp DataProvider có chứa 3 phương thức chính: 
        // 1 - ExecuteQuery : thực thi truy vấn có trả về dữ liệu (SELECT)
        // 1 - ExecuteNonQuery : thực thi truy vấn trả dữ liệu 0-Fail,1-Success (INSERT, UPDATE, DELETE)
        // 1 - ExecuteScalar  : thực thi truy vấn trả về là data của cột đầu tiên ở dòng đầu tiên (INSERT, UPDATE, DELETE) thường dùng để lấy id của dữ liệu sau truy vấn
        public User Login(string userName, string passWord)
        {
            User user = null;

            string query = "USP_Login @userName , @passWord";// cấu truy vấn gọi procedure

            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, passWord });

            foreach (DataRow item in data.Rows)
            {
                user = new User(item);
                return user;
            }

            return user;
        }

        public User GetUserById(int id)
        {
            User user = null;

            string query = string.Format("SELECT * FROM dbo.users WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                user = new User(item);
                return user;
            }

            return user;
        }

        public float GetUserBalance(int id)
        {
            User user = null;

            string query = string.Format("SELECT * FROM dbo.users WHERE id = {0}", id);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                user = new User(item);
                return user.Balance;
            }
            
            return 0;
        }

        public DataTable GetAllUsers()
        {
            string query = string.Format("SELECT u.id, u.username, u.fullname, u.dob, u.phone, r.r_type FROM dbo.users u JOIN dbo.roles r ON u.role_id = r.id");
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool UpdateAccount(User user)
        {
            //Sài query proc phải để param cách nhau như thế này "@a , @b" ko là bị lỗi
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateAccountInfo @id , @username , @fullname , @dob , @phone , @idCard", new object[] { user.Id, user.UserName, user.FullName, user.Dob, user.Phone, user.IdCard });

            return result > 0;
        }

        public bool UpdatePassword(int id, string newpass)
        {
            string query = "usp_ChangPassword @id , @passWord";// cấu truy vấn gọi procedure
            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, newpass });

            return result > 0;
        }

        public bool UpdateBalance(int id, float newBalance)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateBalance @id , @balance", new object[] {id,newBalance});

            return result > 0;
        }
    }
}
