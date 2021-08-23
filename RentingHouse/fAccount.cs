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

        public fAccount(User user)
        {
            InitializeComponent();
            loginUser = user;

            //format Datetimepicker
            dtp_dob.Format = DateTimePickerFormat.Custom;
            dtp_dob.CustomFormat = "dd/MM/yyyy";
        }

        private void fAccount_Load(object sender, EventArgs e)
        {
            txt_username.Text = loginUser.UserName;
            txt_fullname.Text = loginUser.FullName;
            txt_phone.Text = loginUser.Phone;
            txt_idCard.Text = loginUser.IdCard;
            txt_balance.Text = loginUser.Balance.ToString();
            txt_role.Text = RoleDAO.Instance.GetRoleNameById(loginUser.Role);
        }
    }
}
