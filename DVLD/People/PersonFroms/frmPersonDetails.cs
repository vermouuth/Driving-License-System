using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.ManagePeople
{
    public partial class frmPersonDetails : Form
    {
        int _PersonID;
        public frmPersonDetails(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            ctlPersonCard1.LoadPerson(_PersonID);
        }

        private void ctlPersonCard1_OnEditClicked(int obj)
        {
            Form frmEditPerson = new frmAddUpdatePerson(obj);
            frmEditPerson.ShowDialog();   
        }

      
    }
}
