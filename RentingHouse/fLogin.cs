//Khai báo sử dụng lớp
using RentingHouse.DAO;
using RentingHouse.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void button1_Click(object sender, EventArgs e)
        {
            // Connect to DB
            //string login = "SELECT * FROM USERS WHERE username= '" + txtUsername.Text + "' and password= '" + txtPassword.Text + "'";

            // Validate

            if (txtUsername.Text == "Hoang" && txtPassword.Text == "123")
            {
                int userRoleId = 1;

                if (userRoleId == 1)
                {
                    new Dashboard().Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu, vui lòng thử lại", "Đăng Nhập Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtUsername.Focus();
            }
            
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
    }
}
