using MyLicensesSystem.ManagePeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage_Users
{
    public partial class frmUserDetails : Form
    {
        private int _PersonID;
        public frmUserDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctlPersonCard1.LoadPerson(_PersonID);
            ctlUserInfo1.LoadUser(_PersonID);
        }

        private void ctlPersonCard1_OnEditClicked(int obj)
        {
            Form frmEditPerson = new frmAdd_EditPerson(_PersonID);
            frmEditPerson.ShowDialog();
        }
    }
}
