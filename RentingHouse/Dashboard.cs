using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RentingHouse.DAO;
using RentingHouse.DTO;

namespace RentingHouse
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private User loginUser;

        public User LoginUser
        {
            get{return loginUser;}
            set{loginUser = value;}
        }

        public Dashboard(User user)
        {

            InitializeComponent();
            LoginUser = user;
            //Design
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnHouses.Height;
            pnlNav.Top = btnHouses.Top;
            pnlNav.Left = btnHouses.Left;
            btnHouses.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Đăng ký thuê nhà";
            this.pnlFormHouses.Controls.Clear();
            fHouses frmDashboard = new fHouses(loginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoginUser = UserDAO.Instance.GetUserById(loginUser.Id);
            label1.Text = loginUser.UserName;
            label2.Text = RoleDAO.Instance.GetRoleNameById(loginUser.Role);
        }

        private void btnHouses_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHouses.Height;
            pnlNav.Top = btnHouses.Top;
            pnlNav.Left = btnHouses.Left;
            btnHouses.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Danh sách nhà";
            this.pnlFormHouses.Controls.Clear();
            fHouses frmDashboard = new fHouses(loginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            //design
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Thông tin tài khoản";
            this.pnlFormHouses.Controls.Clear();
            fAccount frmDashboard = new fAccount(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContract.Height;
            pnlNav.Top = btnContract.Top;
            btnContract.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Hợp đồng thuê nhà";
            this.pnlFormHouses.Controls.Clear();
            fContract frmDashboard = new fContract(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBooking.Height;
            pnlNav.Top = btnBooking.Top;
            btnBooking.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Lịch sử thuê nhà";
            this.pnlFormHouses.Controls.Clear();
            fBooking frmDashboard = new fBooking(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnRegisterHouse_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnRegisterHouse.Height;
            pnlNav.Top = btnRegisterHouse.Top;
            btnRegisterHouse.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Đăng ký giới thiệu nhà";
            this.pnlFormHouses.Controls.Clear();
            fRegisterHouse frmDashboard = new fRegisterHouse(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExit.Height;
            pnlNav.Top = btnExit.Top;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);

            Application.Exit();
        }

        private void btnHouses_Leave(object sender, EventArgs e)
        {
            btnHouses.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnAccount_Leave(object sender, EventArgs e)
        {
            btnAccount.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnContract_Leave(object sender, EventArgs e)
        {
            btnContract.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnBooking_Leave(object sender, EventArgs e)
        {
            btnBooking.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnRegisterHouse_Leave(object sender, EventArgs e)
        {
            btnRegisterHouse.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }

    }
}
