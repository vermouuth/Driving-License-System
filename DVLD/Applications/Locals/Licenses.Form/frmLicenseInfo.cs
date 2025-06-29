using BusinessLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms
{
    public partial class frmLicenseInfo : Form
    {
        enum enCalledBy { enLocalAPPID, LocalLicense};

        enCalledBy CurrentCall;

        clsLocalDrivingApplication LocalApp;

        int _ID;
        public frmLicenseInfo(int LocalID)
        {
            InitializeComponent();
            _ID = LocalID;
            CurrentCall = enCalledBy.enLocalAPPID;


        }

        public frmLicenseInfo(int LicenseID, bool found = true)
        {
            InitializeComponent();
            _ID = LicenseID;
            CurrentCall = enCalledBy.LocalLicense;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLicenseInfo_Load(object sender, EventArgs e)
        {
            switch (CurrentCall)
            {
                case enCalledBy.enLocalAPPID:
                    {
                        LocalApp = clsLocalDrivingApplication.Find(_ID);
                        int LicenseID = clsLicenses.GetLicenseID(LocalApp._AppID);
                        ctlDriverInfo1.LoadLicecnse(LicenseID);
                        break;

                    }
                case enCalledBy.LocalLicense:
                    {
                        ctlDriverInfo1.LoadLicecnse(_ID);
                        break;
                    }
            }

            
        }
    }
}
