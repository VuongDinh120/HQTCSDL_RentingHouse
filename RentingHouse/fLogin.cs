//Khai báo sử dụng lớp
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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new fRegister().Show();
            this.Hide();
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            User user = null;
            try
            {
                user = UserDAO.Instance.Login(txtUsername.Text, txtPassword.Text);
                /*if (user!=null)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.None);
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại", "Thông báo",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString(), "Đăng nhập thất bại",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          

            // Validate
            if (user!=null)
            {
                int role = user.Role;
                switch (role){
                    case 1:
                        new Dashboard(user).Show();
                        break;
                    case 2:
                        new SurveyDashboard(user).Show();
                        break;
                    case 3:
                        new AdminDashboard(user).Show();
                        break;
                    default:
                        break;
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng thử lại", "Đăng Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
        }
    }
}
