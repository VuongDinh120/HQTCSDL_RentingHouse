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
    public partial class fRegister : Form
    {
        public fRegister()
        {
            InitializeComponent();
        }

        // Connect to DB

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Đăng Ký Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                // Insert to DB
                string register = "INSERT INTO USERS VALUES ('" + txtUsername.Text + "', '" + txtPassword.Text + "')";

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("Tài khoản của bạn đã được tạo", "Đăng Ký Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại", "Đăng Ký Thất Bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new fLogin().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
