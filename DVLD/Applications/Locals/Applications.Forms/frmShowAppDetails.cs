using BussinessLayer;
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

namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalForms
{
    public partial class frmShowAppDetails : Form
    {
        private int LocalID = -1;
        private int PersonID;
        public frmShowAppDetails(int ID)
        {
            InitializeComponent();
            LocalID = ID;
        }

        private void frmShowAppDetails_Load(object sender, EventArgs e)
        {
            ctlAppInfo1.LoadApplicationData(LocalID);
            int ApplicationID = clsLocalDrivingApplication.Find(LocalID)._AppID;
            PersonID = clsApplication.Find(ApplicationID)._ApplicantionPersonID;
            ctlApplicationBasicInfo1.LoadApplicationInfo(ApplicationID);
        }

        private void ctlApplicationBasicInfo1_OnViewClicked(int obj)
        {
            Form PersonDetails = new frmPersonDetails(PersonID);
            PersonDetails.ShowDialog();
        }
    }
}
