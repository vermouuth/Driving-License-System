using BussinessLayer;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.InternationalForms;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms;
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
    public partial class frmAddInterLicense : Form
    {
        public frmAddInterLicense()
        {
            InitializeComponent();
        }

        clsLicenses _LocalLicense;
        clsLicenseInfo _LocalLicenseInfo;

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Block the character input
            }
        }

     

        private void btn_LicneseSerch_Click(object sender, EventArgs e)
        {



            if(!clsLicenses.IsLicenseExist(int.Parse(txt_Searching.Text)))
            {
                MessageBox.Show("This License does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btn_Save.Enabled = true;
            ll_ShowHistory.Enabled = true;
            ll_ShowInfo.Enabled = true;


            ctlDriverInfo1.LoadLicecnse(int.Parse(txt_Searching.Text));
            _LocalLicense = clsLicenses.FindShortInfo(int.Parse(txt_Searching.Text));
            lb_LicenseID.Text = _LocalLicense.LicenaseID.ToString();
            lb_CreatedBy.Text = clsLoggedInUser.GlobalUser.UserName;
            lb_Fees.Text = clsApplicationTypes.Find(6)._Fees.ToString();
            lb_IssueDate.Text = DateTime.Now.ToShortDateString();
            lb_AppDate.Text = DateTime.Now.ToShortDateString();
            lb_ExDate.Text = DateTime.Now.AddYears(1).ToShortDateString();

            _LocalLicenseInfo = clsLicenseInfo.Find(_LocalLicense.LicenaseID);

        }

        private bool HandleConditions()
        {
            if (_LocalLicenseInfo.isActive == "No")
            {
                MessageBox.Show("This License is not Active cannot issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (_LocalLicense.LicenseClass != 3 || clsInternationalLicense.IsDriverHasActiveLicense(_LocalLicense.DriverID))
            {
                MessageBox.Show("This License class does not meet the requirments to issue international license", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (!HandleConditions())
            {
                return;
            }


            clsApplication NewApplication = new clsApplication();

            NewApplication._ApplicantionPersonID = clsApplication.Find(_LocalLicense.ApplicationID)._ApplicantionPersonID;
            NewApplication._ApplicationDate = DateTime.Now;
            NewApplication._ApplicationTypeID = 6;
            NewApplication._ApplicationStatus = 3;
            NewApplication._LastStatusDate = DateTime.Now;
            NewApplication._PaidFees = clsApplicationTypes.Find(6)._Fees;
            NewApplication._CreatedByUserID = clsLoggedInUser.GlobalUser.UserID;



            clsInternationalLicense NewInteNationalLicense = new clsInternationalLicense();

            NewInteNationalLicense.ApplicationId = _LocalLicense.ApplicationID;
            NewInteNationalLicense.DriverID = _LocalLicense.DriverID;
            NewInteNationalLicense.LicenseID = _LocalLicense.LicenaseID;
            NewInteNationalLicense.IssueDate = DateTime.Now;
            NewInteNationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            NewInteNationalLicense.IsActive = true;
            NewInteNationalLicense.CreatedBy = clsLoggedInUser.GlobalUser.UserID;


            if(NewApplication._AddNewApplication())
            {
                if(NewInteNationalLicense.AddInterNationalLicense())
                {
                    MessageBox.Show("InterNational Licesned Added Succcfully","Info",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lb_InterLicenseID.Text = NewInteNationalLicense.InternationalID.ToString();
                    lb_AppID.Text = NewApplication._ApplicationID.ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void frmAddInterLicense_Load(object sender, EventArgs e)
        {
            btn_Save.Enabled = false;
            ll_ShowHistory.Enabled = false;
            ll_ShowInfo.Enabled = false;

        }

        private void ll_ShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!clsInternationalLicense.IsLicenseExist(_LocalLicense.LicenaseID))
            {
                MessageBox.Show("This License doesn't has an International License.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form InternationalCard = new frmInternationalInfo(_LocalLicense.LicenaseID);
            InternationalCard.ShowDialog();
        }

        private void ll_ShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LicenseHistory = new frmLicenseHistory(clsDriver.FindByDriverID(_LocalLicense.DriverID).PersonID , true);
            LicenseHistory.ShowDialog();
        }
    }
}
