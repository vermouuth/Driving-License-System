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

namespace MyLicensesSystem.Manage.Users.UserForms
{
    public partial class frmUserDetails : Form
    {

        private int _PersonID;

        public frmUserDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void ctlPersonCard1_OnEditClicked(int obj)
        {
            Form EditPerson = new frmAddUpdatePerson(_PersonID);
            EditPerson.ShowDialog();    
        }

        private void frmUserDetails_Load(object sender, EventArgs e)
        {
            ctlPersonCard1.LoadPerson(_PersonID); 
            ctlUserInfo1.LoadUser(_PersonID);
        }
    }
}
