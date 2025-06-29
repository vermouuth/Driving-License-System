using MyLicensesSystem.Login.Screen;
using MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalForms;
using MyLicensesSystem.Manage.Applications.Driving.Licens.Services.New.Local.License;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.InternationalForms;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalControls;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms;
using MyLicensesSystem.Manage.Applications.Manage.Application.Types;
using MyLicensesSystem.Manage.Drivers;
using MyLicensesSystem.Manage.TestTyeps;
using MyLicensesSystem.Manage.Users;
using MyLicensesSystem.Manage.Users.UserForms;
using MyLicensesSystem.Manage_Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem
{
    public partial class MainScreen : Form
    {

        frmLoginScreen _frmLogin;
        public MainScreen(frmLoginScreen login)
        {
            InitializeComponent();
            _frmLogin = login;
            
        }

       
        enum enApplicationTypes { enLocalLicenseApplication = 1 , enRenewDrivingLicense = 2 , enReplacementOflLost = 3 , enReplacementOfDamage = 4 , enReleaseLicense = 5 , enNewInterNationalLicense= 6};

     
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManagePeople = new frmManagePeople();
            ManagePeople.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManageUsers = new frmManageUsers();
            ManageUsers.ShowDialog();
        }

        private void currentUserInforamtiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form CurrentUserDetails = new frmUserDetails(clsLoggedInUser.GlobalUser.PersonID);
            CurrentUserDetails.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword ChangeLocalPassword = new frmChangePassword(clsLoggedInUser.GlobalUser.PersonID);
            ChangeLocalPassword.ShowDialog();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsLoggedInUser.GlobalUser = null;
            this.Close();
            _frmLogin.Show();

        }

        private void mangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManageAppTypes = new frmApplicationTypes();
            ManageAppTypes.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManageTestTypes = new frmManageTestTyeps();
            ManageTestTypes.ShowDialog();
        }

        private void LocalLicense_Click(object sender, EventArgs e)
        {
            Form AddLocalApp = new frmAddLocalApp(-1,(int)enApplicationTypes.enLocalLicenseApplication);
            AddLocalApp.ShowDialog();
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MangeLocalApps = new frmManageLocalApplications();
            MangeLocalApps.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowDrivers = new frmMainDrivers();
            ShowDrivers.ShowDialog();
        }

        private void GlobalLicense_Click(object sender, EventArgs e)
        {
            Form InterNationalLicense = new frmAddInterLicense();
            InterNationalLicense.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManageInternational = new frmManageInternational();
            ManageInternational.ShowDialog();
        }

        private void RenewLicenseApp_Click(object sender, EventArgs e)
        {
            Form RenewLicense = new frmRenewLiceense();
            RenewLicense.ShowDialog();
        }

        private void ReplaceLicenseApp_Click(object sender, EventArgs e)
        {
            Form Replacement = new frmReplacment();
            Replacement.ShowDialog();
        }

        private void dentainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DetainLicense = new frmDetianLicense();
            DetainLicense.ShowDialog();
        }

        private void reToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ReleaseLicesne = new frmReleaseLicense();
            ReleaseLicesne.ShowDialog();
        }

        private void ReTestLicenseApp_Click(object sender, EventArgs e)
        {
            Form RetakeTest = new frmManageLocalApplications();
            RetakeTest.ShowDialog();
        }

        private void manageDentainedLicnesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ManageDetaindLicenses = new frmManageDetainLicenses();
            ManageDetaindLicenses.ShowDialog();
        }
    }
}
