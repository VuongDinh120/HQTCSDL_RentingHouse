using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RentingHouse.DAO;
using RentingHouse.DTO;

namespace RentingHouse
{
    public partial class fAccount : Form
    {
        private User loginUser;

        public User LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public fAccount(int user_id)
        {
            InitializeComponent();
            loginUser = UserDAO.Instance.GetUserById(user_id);

            //format Datetimepicker
            dtp_dob.Format = DateTimePickerFormat.Custom;
            dtp_dob.CustomFormat = "dd/MM/yyyy";
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            loginUser = UserDAO.Instance.GetUserById(loginUser.Id);

            txt_username.Text = loginUser.UserName;
            txt_fullname.Text = loginUser.FullName;
            dtp_dob.Text = loginUser.Dob;
            txt_phone.Text = loginUser.Phone;
            txt_idCard.Text = loginUser.IdCard;
            txt_balance.Text = loginUser.Balance.ToString();
            txt_role.Text = RoleDAO.Instance.GetRoleNameById(loginUser.Role);

            dgv_transaction.DataSource = TransactionDAO.Instance.GetTransactionByUserId(loginUser.Id);
        }

        private void btn_update_user_Click(object sender, EventArgs e)
        {
            string message = null;
            string formatdate = dtp_dob.Value.ToString("yyyy-MM-dd");
            User newUser = new User(loginUser.Id, txt_username.Text, txt_fullname.Text, formatdate, txt_phone.Text, txt_idCard.Text, loginUser.Balance, loginUser.Role);
            if (UserDAO.Instance.UpdateAccount(newUser))
            {
                message = "Cập nhật thành công";
                //loginUser = newUser;
                fAccount_Load(sender, e);
            }
            else
            {
                message = "Cập nhật không thành công";
            }
            string title = "Thông báo";
            MessageBox.Show(message, title);
        }

        private void btn_update_password_Click(object sender, EventArgs e)
        {
            string message = null;

            if (txt_new_password.Text == "")
            {
                message = "Mật khẩu không được để trống";
            }
            else
            {
                if (UserDAO.Instance.UpdatePassword(loginUser.Id, txt_new_password.Text))
                {
                    message = "Cập nhật thành công";
                    fAccount_Load(sender, e);
                }
                else
                {
                    message = "Cập nhật không thành công";
                }
            }
            txt_new_password.Text = "";
            txt_new_password.Focus();
            string title = "Thay đổi mật khẩu";
            MessageBox.Show(message, title);
        }

        private void btn_update_balance_Click(object sender, EventArgs e)
        {
            string message = null;

            if (txt_balance.Text == "")
            {
                message = "Chưa nhập số tiền nạp";
            }
            else
            {
                float balance = (float)Convert.ToDouble(txt_balance.Text);
                if (UserDAO.Instance.UpdateBalance(loginUser.Id, balance))
                {
                    message = "Nạp thành công";
                    fAccount_Load(sender, e);
                }
                else
                {
                    message = "Nạp không thành công";
                }
            }
            string title = "Nạp tiền vào tài khoản";
            MessageBox.Show(message, title);
        }
    }
}
