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

            lblTitle.Text = "Danh sách nhà";
            this.pnlFormHouses.Controls.Clear();
            fHouses frmDashboard = new fHouses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
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
            fHouses frmDashboard = new fHouses() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
            fAccount frmDashboard = new fAccount(LoginUser) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormHouses.Controls.Add(frmDashboard);
            frmDashboard.Show();
        }

        private void btnContract_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContract.Height;
            pnlNav.Top = btnContract.Top;
            btnContract.BackColor = Color.FromArgb(46, 51, 73);
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

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
