using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentingHouse.DTO
{
    //Lớp đối tượng khởi tạo định nghĩa lơp User (ko chứa các hàm xử lý chỉ để khởi tạo)
    public class User
    {
        //Các phương thức khởi tạo
        public User(string userName, string fullName, string dob, string phone, string idCard, string role, string password = null) //tham số passWord  khai báo optional, có gtri mặc định null nên để cuối hàng
        {
            this.UserName = userName;
            this.FullName = fullName;
            this.Dob = dob;
            this.Phone = phone;
            this.IdCard = idCard;
            this.Role = role;
            this.Password = password;
        }

        public User(DataRow row)
        {
            this.UserName = row["user_name"].ToString();
            this.Password = row["password"].ToString();
            this.FullName = row["full_name"].ToString();
            this.Dob = row["dob"].ToString();
            this.Phone = row["phone"].ToString();
            this.IdCard = row["id_card"].ToString();
            this.Role = row["role"].ToString();
        }

        // Khai báo thuộc tính
        //Khai báo hết tất cả thuộc tính rồi CTRL+R+E nó tự động xuất ra các phương thức get set
        private string userName;
        private string password;
        private string fullName;
        private string dob;
        private string phone;
        private string idCard;
        private string role;

        //các phương thức get set
        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string FullName
        {
            get
            {
                return fullName;
            }

            set
            {
                fullName = value;
            }
        }

        public string Dob
        {
            get
            {
                return dob;
            }

            set
            {
                dob = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string IdCard
        {
            get
            {
                return idCard;
            }

            set
            {
                idCard = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }
    }
}
