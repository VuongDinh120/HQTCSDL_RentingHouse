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
    public partial class AdminDashboard : Form
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
            get { return loginUser; }
            set { loginUser = value; }
        }

        public AdminDashboard(User user)
        {

            InitializeComponent();
            LoginUser = user;
            //Design
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnAccount.Height;
            pnlNav.Top = btnAccount.Top;
            pnlNav.Left = btnAccount.Left;
            btnAccount.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Quản lý tài khoản";
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

            lblTitle.Text = "Quản lý nhà";
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

            lblTitle.Text = "Quản lý tài khoản";
            this.pnlFormHouses.Controls.Clear();
            fAccount frmDashboard = new fAccount(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBooking.Height;
            pnlNav.Top = btnBooking.Top;
            btnBooking.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Quản lý đơn thuê nhà";
            this.pnlFormHouses.Controls.Clear();
            fSurveys frmDashboard = new fSurveys(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            //design
            pnlNav.Height = btnSurvey.Height;
            pnlNav.Top = btnSurvey.Top;
            btnSurvey.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Quản lý khảo sát";
            this.pnlFormHouses.Controls.Clear();
            fSurveys frmDashboard = new fSurveys(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnMeeting_Click(object sender, EventArgs e)
        {
            //design
            pnlNav.Height = btnMeeting.Height;
            pnlNav.Top = btnMeeting.Top;
            btnMeeting.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Quản lý lịch hẹn";
            this.pnlFormHouses.Controls.Clear();
            fSurveys frmDashboard = new fSurveys(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

        private void btnBooking_Leave(object sender, EventArgs e)
        {
            btnBooking.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSurvey_Leave(object sender, EventArgs e)
        {
            btnSurvey.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnMeeting_Leave(object sender, EventArgs e)
        {
            btnMeeting.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }

        
    }
}
