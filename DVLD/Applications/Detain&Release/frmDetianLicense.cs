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
    public partial class frmDetianLicense : Form
    {

        clsLicenses LicenseInfo;
        clsApplicationTypes _AppType;
        public frmDetianLicense()
        {
            InitializeComponent();
        }

        private void btn_LicneseSerch_Click(object sender, EventArgs e)
        {
            int LicenseID = int.Parse(txt_Searching.Text);

            if(!clsLicenses.IsLicenseExist(LicenseID))
            {
                MessageBox.Show("This License does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if(clsDetainedLicenses.IsLicenseDetained(LicenseID))
            {
                if(!clsDetainedLicenses.IsLicenseReleased(LicenseID))
                {
                    MessageBox.Show("This License is already detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btn_Save.Enabled = false;
                }
            }

            else
            {
                btn_Save.Enabled = true;

            }

            ll_ShowInfo.Enabled = true;
            ll_ShowHistory.Enabled = true;


            ctlDriverInfo1.LoadLicecnse(LicenseID);

            LicenseInfo = clsLicenses.FindShortInfo(LicenseID);
            lb_DetainDate.Text = DateTime.Now.ToShortDateString();
            lb_Fees.Text = clsApplicationTypes.Find(5)._Fees.ToString();
            lb_LicenseID.Text = LicenseID.ToString();
            lb_CreatedBy.Text = clsLoggedInUser.GlobalUser.UserName;

        }

        private void frmDetianLicense_Load(object sender, EventArgs e)
        {
            ll_ShowHistory.Enabled = false;
            ll_ShowInfo.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ll_ShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form ShowLicense = new frmLicenseInfo(LicenseInfo.LicenaseID, true);
            ShowLicense.ShowDialog();
        }

        private void ll_ShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form ShowHistory = new frmLicenseHistory(clsDriver.FindByDriverID(LicenseInfo.DriverID).PersonID,true);
            ShowHistory.ShowDialog();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (clsDetainedLicenses.IsLicenseDetained(LicenseInfo.LicenaseID))
            {
                if (!clsDetainedLicenses.IsLicenseReleased(LicenseInfo.LicenaseID))
                {
                    MessageBox.Show("This License is already detained.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            clsApplication NewApplication = new clsApplication();
            clsDetainedLicenses NewDetaind = new clsDetainedLicenses();

            NewApplication._ApplicantionPersonID = clsDriver.FindByDriverID(LicenseInfo.DriverID).PersonID;
            NewApplication._ApplicationDate = DateTime.Now;
            NewApplication._ApplicationStatus = 3;
            NewApplication._ApplicationTypeID = 5;
            NewApplication._CreatedByUserID = clsLoggedInUser.GlobalUser.UserID;
            NewApplication._LastStatusDate = DateTime.Now;
            NewApplication._PaidFees = clsApplicationTypes.Find(5)._Fees;

            if(NewApplication._AddNewApplication())
            {
                NewDetaind.LicensesID = LicenseInfo.LicenaseID;
                NewDetaind.DetainedDate = DateTime.Now;
                NewDetaind.Fees = clsApplicationTypes.Find(5)._Fees;
                NewDetaind.CreatedBy = clsLoggedInUser.GlobalUser.UserID;

                if(NewDetaind.AddDetainedLicense())
                {

                    MessageBox.Show("License Detaind Successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lb_DetainId.Text = NewDetaind.DetainedID.ToString();
                    clsDetainedLicenses.DetainAllLicense(LicenseInfo.LicenaseID);
                    btn_Save.Enabled = false;
                }


                
            }

        }
    }
}
