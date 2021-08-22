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
        public User(int id,string userName, string fullName, string dob, string phone, string idCard, float balance, int role, string password = null) //tham số passWord  khai báo optional, có gtri mặc định null nên để cuối hàng
        {
            this.Id = id;
            this.UserName = userName;
            this.FullName = fullName;
            this.Dob = dob;
            this.Phone = phone;
            this.IdCard = idCard;
            this.Balance = balance;
            this.Role = role;
            this.Password = password;
        }

        public User(DataRow row)
        {
            this.Id = (int)row["id"];
            this.UserName = row["user_name"].ToString();
            this.Password = row["u_password"].ToString();
            this.FullName = row["fullname"].ToString();
            this.Dob = row["dob"].ToString();
            this.Phone = row["phone"].ToString();
            this.IdCard = row["id_card"].ToString();
            this.Balance = (int)row["account_balance"];
            this.Role = (int)row["role_id"];
        }

        // Khai báo thuộc tính
        //Khai báo hết tất cả thuộc tính rồi CTRL+R+E nó tự động xuất ra các phương thức get set
        private int id;
        private string userName;
        private string password;
        private string fullName;
        private string dob;
        private string phone;
        private string idCard;
        private float balance;
        private int role;

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

        public int Role
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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public float Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
        }
    }
}
