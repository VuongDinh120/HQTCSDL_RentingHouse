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

        public bool UpdateAccount(User user)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccountInfo @id, @username, @fullname, @dob, @phone, @idCard", 
                                new object[] { user.Id,user.UserName, user.FullName, user.Dob, user.Phone, user.IdCard });

            return result > 0;
        }
    }
}
