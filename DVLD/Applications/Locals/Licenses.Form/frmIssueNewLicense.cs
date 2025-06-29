using BusinessLayer;
using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalForms
{
    public partial class frmIssueNewLicense : Form
    {
        clsLocalDrivingApplication _LocalApp;
        clsApplication _Application;
        clsDriver _Driver;
        private int LocalID = -1;
        private int PersonID;
        public frmIssueNewLicense(int ID)
        {
            InitializeComponent();
            LocalID = ID;

        }

        private void ClassHandler()
        {
            _LocalApp = clsLocalDrivingApplication.Find(LocalID);
            _Application = clsApplication.Find(_LocalApp._AppID);

          
           
        }
        private void frmIssueNewLicense_Load(object sender, EventArgs e)
        {          
            ClassHandler();
            ctlAppInfo1.LoadApplicationData(LocalID);
            ctlApplicationBasicInfo1.LoadApplicationInfo(_Application._ApplicationID);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (clsDriver.IsDriverExist(_Application._ApplicantionPersonID))
            {
                _Driver = clsDriver.Find(_Application._ApplicantionPersonID);
            }

            else
            {
                _Driver = new clsDriver();
                _Driver.PersonID = _Application._ApplicantionPersonID;
                _Driver.CreatedBy = clsLoggedInUser.GlobalUser.UserID;
                _Driver.CreatedDate = DateTime.Now;
                _Driver.AddNewDriver();

            }

            decimal Fees = clsLicenseClasses.Find(_LocalApp._ClassID)._ClassFees;

            clsLicenses NewLicense = new clsLicenses();
            NewLicense.ApplicationID = _Application._ApplicationID;
            NewLicense.DriverID = _Driver.DriverID;
            NewLicense.LicenseClass = _LocalApp._ClassID;
            NewLicense.IssueDate = DateTime.Now;      
            NewLicense.ExpirationDate = DateTime.Now.AddYears(clsLicenseClasses.Find(_LocalApp._ClassID)._DefaultValidityLength);
            NewLicense.Notes = txt_Notes.Text;
            NewLicense.PaidFees = Fees;
            NewLicense.isActive = true;
            NewLicense.IssueReason = 1;
            NewLicense.CreatedBy = clsLoggedInUser.GlobalUser.UserID;


            if (NewLicense.AddLicense())
            {
                clsApplication.UpdateApplcationStatus(_Application._ApplicationID, 3);
                MessageBox.Show("License Created Succssfully.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
