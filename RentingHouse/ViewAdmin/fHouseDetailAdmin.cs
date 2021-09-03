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
    public partial class fHouseDetailAdmin : Form
    {
        private int housesId;

        public int HousesId
        {
            get { return housesId; }
            set { housesId = value; }
        }
        public fHouseDetailAdmin(int ID)
        {
            InitializeComponent();
            HousesId = ID;
        }
    }
}
