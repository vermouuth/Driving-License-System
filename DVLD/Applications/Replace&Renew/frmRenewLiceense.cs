using BusinessLayer;
using BussinessLayer;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms;
using MyLicensesSystem.Manage.Tests.TestControls;
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
using static System.Net.Mime.MediaTypeNames;

namespace MyLicensesSystem
{
    public partial class frmRenewLiceense : Form
    {
        clsLicenses _LicenseInfo;
        clsApplicationTypes _ApplicationTYPE;
        clsLicenseClasses _ClassType;

        public frmRenewLiceense()
        {
            InitializeComponent();
        }
       

        private void btn_LicneseSerch_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(txt_Searching.Text);

            if (!clsLicenses.IsLicenseExist(LicenseID))
            {
                MessageBox.Show("This License does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            

            if(!clsLicenses.IsLicenseExpired(LicenseID))
            {
                MessageBox.Show("License is not expired you cannot issue a new license .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Save.Enabled = false;
            }
            else
            {
                btn_Save.Enabled = true;

            }

            ll_ShowHistory.Enabled = true;
            ll_ShowInfo.Enabled = true;

            ctlDriverInfo1.LoadLicecnse(LicenseID);

            _LicenseInfo = clsLicenses.FindShortInfo(LicenseID);
            _ApplicationTYPE = clsApplicationTypes.Find(2);
            _ClassType = clsLicenseClasses.Find(_LicenseInfo.LicenseClass);

            decimal TotalFees = _ApplicationTYPE._Fees + _ClassType._ClassFees;

            lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            lb_IssueDate.Text = DateTime.Now.ToShortDateString();
            lb_AppFees.Text = _ApplicationTYPE._Fees.ToString();
            lb_LicenseFees.Text = _ClassType._ClassFees.ToString();
            lb_OldLicense.Text = _LicenseInfo.LicenaseID.ToString(); 
            lb_ExDate.Text = DateTime.Now.AddYears(10).ToShortDateString();
            lb_TotalFees.Text = TotalFees.ToString();
            lb_CreatedBy.Text = clsLoggedInUser.GlobalUser.UserName;
            






        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ll_ShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LicenseInfo = new frmLicenseInfo(_LicenseInfo.LicenaseID, true);
            LicenseInfo.ShowDialog();
        }

        private void TestingForm_Load(object sender, EventArgs e)
        {
            ll_ShowHistory.Enabled = false;
            ll_ShowInfo.Enabled = false;
        }

        private void ll_ShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LicenseHistory = new frmLicenseHistory(clsDriver.FindByDriverID(_LicenseInfo.DriverID).PersonID, true);
            LicenseHistory.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsApplication NewApplication = new clsApplication();
            clsLicenses NewLicenses = new clsLicenses();

            NewApplication._ApplicantionPersonID = clsDriver.FindByDriverID(_LicenseInfo.DriverID).PersonID;
            NewApplication._ApplicationDate = DateTime.Now;
            NewApplication._ApplicationStatus = 3;
            NewApplication._ApplicationTypeID = _ApplicationTYPE._ID;
            NewApplication._CreatedByUserID = clsLoggedInUser.GlobalUser.UserID;
            NewApplication._LastStatusDate = DateTime.Now;
            NewApplication._PaidFees = _ApplicationTYPE._Fees;

         

           

            if(NewApplication.Save())
            {
                NewLicenses.ApplicationID = NewApplication._ApplicationID;
                NewLicenses.DriverID = _LicenseInfo.DriverID;
                NewLicenses.LicenseClass = _LicenseInfo.LicenseClass;
                NewLicenses.IssueDate = DateTime.Now;
                NewLicenses.ExpirationDate = DateTime.Now.AddYears(10);
                NewLicenses.Notes = txtNotes.Text;
                NewLicenses.isActive = true;
                NewLicenses.IssueReason = (byte)_ApplicationTYPE._ID;
                NewLicenses.CreatedBy   = clsLoggedInUser.GlobalUser.UserID;
                NewLicenses.PaidFees = _ClassType._ClassFees + _ApplicationTYPE._Fees;

                if(NewLicenses.AddLicense())
                {
                    clsLicenses.DeactiveLicense(_LicenseInfo.LicenaseID);

                    MessageBox.Show("License Renwed Successfully.","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lb_RenewdLicense.Text = NewLicenses.LicenaseID.ToString();
                    lb_NewLicenseAppID.Text = NewApplication._ApplicationID.ToString();
                    return;

                }
             


            }

        }
    }
}
