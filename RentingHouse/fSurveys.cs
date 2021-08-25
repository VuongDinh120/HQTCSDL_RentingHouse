﻿using System;
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
    public partial class fSurveys : Form
    {
        private int loginUser;

        public int LoginUser
        {
            get { return loginUser; }
            set { loginUser = value; }
        }

        public fSurveys(int loginUser)
        {
            InitializeComponent();
            LoginUser = loginUser;
            dgvSurveys.AutoGenerateColumns = false;
        }

        private void fSurveys_Load(object sender, EventArgs e)
        {
            dgvSurveys.DataSource = SurveyDAO.Instance.GetAllSurveys();
        }
    }
}
