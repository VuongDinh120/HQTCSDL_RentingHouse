using RentingHouse.DAO;
using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentingHouse
{
    public partial class fAccountDetailAdmin : Form
    {
        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        public fAccountDetailAdmin(int ID)
        {
            InitializeComponent();
            UserId = ID;

            //format Datetimepicker
            dtp_dob.Format = DateTimePickerFormat.Custom;
            dtp_dob.CustomFormat = "dd/MM/yyyy";
        }

        private void fAccountDetailAdmin_Load(object sender, EventArgs e)
        {
            User iUser = UserDAO.Instance.GetUserById(UserId);

            txt_id.Text = iUser.Id.ToString();
            txt_username.Text = iUser.UserName;
            txt_fullname.Text = iUser.FullName;
            dtp_dob.Text = iUser.Dob;
            txt_phone.Text = iUser.Phone;
            txt_id_card.Text = iUser.IdCard;
            txt_balance.Text = iUser.Balance.ToString();
            txt_role.Text = RoleDAO.Instance.GetRoleNameById(iUser.Role);
        }

        private void btn_change_pass_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserDAO.Instance.UpdatePassword(userId, txt_new_password.Text.ToString()))
                {
                    MessageBox.Show("Thay đổi thành công", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Thay đổi thất bại", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Thay đổi thất bại",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
