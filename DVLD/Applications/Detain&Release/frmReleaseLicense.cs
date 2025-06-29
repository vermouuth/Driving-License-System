using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms
{
    public partial class frmReleaseLicense : Form
    {
        clsLicenses LicenseInfo;
        clsDetainedLicenses DetaindLicense;
        public frmReleaseLicense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ll_ShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form ShowLicenseInfo = new frmLicenseInfo(LicenseInfo.LicenaseID, true);
            ShowLicenseInfo.ShowDialog();
        }

        private void frmReleaseLicense_Load(object sender, EventArgs e)
        {
            ll_ShowHistory.Enabled = false;
            ll_ShowInfo.Enabled = false;
        }

        private void btn_LicneseSerch_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(txt_Searching.Text);

            if (!clsLicenses.IsLicenseExist(LicenseID))
            {
                MessageBox.Show("This DetaindLcensed does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsDetainedLicenses.IsLicenseDetained(LicenseID))
            {
                if (clsDetainedLicenses.IsLicenseReleased(LicenseID))
                {
                    MessageBox.Show("This DetaindLcensed is already Released.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_Save.Enabled = false;
                }
            }
            else
            {
                btn_Save.Enabled =true;
            }

            ctlDriverInfo1.LoadLicecnse(LicenseID);

            ll_ShowHistory.Enabled = true;
            ll_ShowInfo.Enabled = true;

            LicenseInfo = clsLicenses.FindShortInfo(LicenseID);
            DetaindLicense = clsDetainedLicenses.Find(LicenseInfo.LicenaseID);


            lb_DetainDate.Text = DateTime.Now.ToShortDateString();
            lb_Fees.Text = clsApplicationTypes.Find(5)._Fees.ToString();
            lb_LicenseID.Text = LicenseID.ToString();
            lb_CreatedBy.Text = clsLoggedInUser.GlobalUser.UserName;
            lb_DetainId.Text = DetaindLicense.DetainedID.ToString();

        }

        private void ll_ShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LicenseHisotry = new frmLicenseHistory(clsDriver.FindByDriverID(LicenseInfo.DriverID).PersonID, true);
            LicenseHisotry.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (!clsDetainedLicenses.IsLicenseDetained(LicenseInfo.LicenaseID))
            {
                if (clsDetainedLicenses.IsLicenseReleased(LicenseInfo.LicenaseID))
                {
                    MessageBox.Show("This License is already Released.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            clsApplication NewApplication = new clsApplication();
            NewApplication._ApplicantionPersonID = clsDriver.FindByDriverID(LicenseInfo.DriverID).PersonID;
            NewApplication._ApplicationDate = DateTime.Now;
            NewApplication._ApplicationStatus = 3;
            NewApplication._ApplicationTypeID = 5;
            NewApplication._CreatedByUserID = clsLoggedInUser.GlobalUser.UserID;
            NewApplication._LastStatusDate = DateTime.Now;
            NewApplication._PaidFees = clsApplicationTypes.Find(5)._Fees;

            if (NewApplication._AddNewApplication())
            {
                DetaindLicense.IsReleased = true;
                DetaindLicense.ReleaseDate = DateTime.Now;
                DetaindLicense.ReleasedByID = clsLoggedInUser.GlobalUser.UserID;
                DetaindLicense.ReleaseAppID = NewApplication._ApplicationID;

                if(DetaindLicense.ReleaseLicense())
                {
                    MessageBox.Show("Done License Released.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsDetainedLicenses.ReleaseAllLicense(LicenseInfo.LicenaseID);   
                    btn_Save.Enabled = false;
                }

            }
        }
    }
}
