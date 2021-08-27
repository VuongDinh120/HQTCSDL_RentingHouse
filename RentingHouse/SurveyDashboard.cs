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
    public partial class SurveyDashboard : Form
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

        public SurveyDashboard(User user)
        {
            InitializeComponent();
            LoginUser = user;
            // Design
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btnSurvey.Height;
            pnlNav.Top = btnSurvey.Top;
            pnlNav.Left = btnSurvey.Left;
            btnSurvey.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlSurveys.Controls.Clear();
            fSurveys frmDashboard = new fSurveys(loginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlSurveys.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoginUser = UserDAO.Instance.GetUserById(loginUser.Id);
            label1.Text = loginUser.UserName;
            label2.Text = RoleDAO.Instance.GetRoleNameById(loginUser.Role);
        }

        private void btnSurvey_Click(object sender, EventArgs e)
        {
            //design
            pnlNav.Height = btnSurvey.Height;
            pnlNav.Top = btnSurvey.Top;
            btnSurvey.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Danh sách Nhà chưa khảo sát";
            this.pnlSurveys.Controls.Clear();
            fSurveys frmDashboard = new fSurveys(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlSurveys.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnAlreadySurvey_Click(object sender, EventArgs e)
        {
            //design
            pnlNav.Height = btnSurvey.Height;
            pnlNav.Top = btnSurvey.Top;
            btnSurvey.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Quản lý khảo sát";
            this.pnlSurveys.Controls.Clear();
            fSurveyAdmin frmDashboard = new fSurveyAdmin(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlSurveys.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btn_account_Click(object sender, EventArgs e)
        {
            //design
            pnlNav.Height = btn_account.Height;
            pnlNav.Top = btn_account.Top;
            btn_account.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Thông tin tài khoản";
            this.pnlSurveys.Controls.Clear();
            fAccount frmDashboard = new fAccount(LoginUser.Id) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlSurveys.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnExit.Height;
            pnlNav.Top = btnExit.Top;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);

            Application.Exit();
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }

    }
}
