using MyLicensesSystem.Main;
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

namespace MyLicensesSystem.Manage.Users
{



    public partial class frmFindingPerson : Form
    {


        public delegate void SendPersonBack(object sender, int PersonID);

        public event SendPersonBack xPersonBack;


        public frmFindingPerson()
        {
            InitializeComponent();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            int PersonID = ctlSearchinPerson1.ID;

         
            xPersonBack?.Invoke(this, PersonID);


            this.Close();   
        }

        private void ctlSearchinPerson1_OnEditClicked(int obj)
        {
            frmAddUpdatePerson EditPerson = new frmAddUpdatePerson(obj);

            EditPerson.DataBack += (object sender, int id) =>
            {
                ctlSearchinPerson1.LoadPerson(id);
            };

            EditPerson.ShowDialog();
        }

        private void ctlSearchinPerson1_OnAddClicked_1(int obj)
        {
            frmAddUpdatePerson AddNewPerson = new frmAddUpdatePerson();

            AddNewPerson.DataBack += (object sender, int id) =>
            {
                ctlSearchinPerson1.LoadPerson(id);
            };

            AddNewPerson.ShowDialog();
        }
    }
}
