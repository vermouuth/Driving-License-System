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

namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalControls
{
    public partial class ctsNewLicenseApplication : UserControl
    {

        clsLicenses LicenseShortInfo;
        clsLicenseClasses ClassTypeInfo;
        clsApplicationTypes ApplicationTypeInfo;

        public ctsNewLicenseApplication()
        {
            InitializeComponent();
        }

        private bool LoadLicenseInfo(int LicensesID , int ApplicationTypeID)
        {
            if(!clsLicenses.IsLicenseExist(LicensesID))
            {
                return false;
            }

            LicenseShortInfo = clsLicenses.FindShortInfo(LicensesID);
            ClassTypeInfo = clsLicenseClasses.Find(LicenseShortInfo.LicenseClass);
            ApplicationTypeInfo = clsApplicationTypes.Find(ApplicationTypeID);
 
            return true;
        }

        public void LoadInfo(int LicenseInfo , int ApplicationID)
        {
            if (!LoadLicenseInfo(LicenseInfo , ApplicationID))
            {
                MessageBox.Show("Cannot Find this License or that application type.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



        }
    }
}
