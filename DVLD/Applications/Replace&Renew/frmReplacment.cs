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
    public partial class frmReplacment : Form
    {
        clsLicenses _LicenseInfo;
        clsApplicationTypes _ApplicationTypeeInfo;
        clsLicenseClasses _ClassType;

        public frmReplacment()
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

            if(!clsLicenses.isLicenseActive(LicenseID))
            {
                MessageBox.Show("This License is not active.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btn_Save.Enabled = false;   
            }
            else
            {
                btn_Save.Enabled = true;
            }

            ll_ShowHistory.Enabled = true;

            ctlDriverInfo1.LoadLicecnse(LicenseID);

            _LicenseInfo = clsLicenses.FindShortInfo(LicenseID);
            _ClassType = clsLicenseClasses.Find(_LicenseInfo.LicenseClass);

            lb_ApplicationDate.Text = DateTime.Now.ToShortDateString();
            lb_Fees.Text = _ApplicationTypeeInfo._Fees.ToString();
            lb_OldLicense.Text = _LicenseInfo.LicenaseID.ToString();
            lb_CreatedBy.Text = clsLoggedInUser.GlobalUser.UserName;

        }

        private void frmReplacment_Load(object sender, EventArgs e)
        {
            rd_Damage.Checked = true;
            _ApplicationTypeeInfo = clsApplicationTypes.Find(4);
            ll_ShowHistory.Enabled = false;
            ll_ShowInfo.Enabled = false;
        }

        private void rd_Damage_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Damage.Checked)
            {
                _ApplicationTypeeInfo = clsApplicationTypes.Find(4);
            }

            lb_Fees.Text = _ApplicationTypeeInfo._Fees.ToString();
        }

        private void rd_Lost_CheckedChanged(object sender, EventArgs e)
        {
            if (rd_Lost.Checked)
            {
                _ApplicationTypeeInfo = clsApplicationTypes.Find(3);
            }
            lb_Fees.Text = _ApplicationTypeeInfo._Fees.ToString();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsApplication NewApplication = new clsApplication();
            clsLicenses NewLicenses = new clsLicenses();

            NewApplication._ApplicantionPersonID = clsDriver.FindByDriverID(_LicenseInfo.DriverID).PersonID;
            NewApplication._ApplicationDate = DateTime.Now;
            NewApplication._ApplicationStatus = 3;
            NewApplication._ApplicationTypeID = _ApplicationTypeeInfo._ID;
            NewApplication._CreatedByUserID = clsLoggedInUser.GlobalUser.UserID;
            NewApplication._LastStatusDate = DateTime.Now;
            NewApplication._PaidFees = _ApplicationTypeeInfo._Fees;

            if (NewApplication.Save())
            {
                NewLicenses.ApplicationID = NewApplication._ApplicationID;
                NewLicenses.DriverID = _LicenseInfo.DriverID;
                NewLicenses.LicenseClass = _LicenseInfo.LicenseClass;
                NewLicenses.IssueDate = DateTime.Now;
                NewLicenses.ExpirationDate = DateTime.Now.AddYears(10);
                NewLicenses.Notes = "";
                NewLicenses.isActive = true;
                NewLicenses.IssueReason = (byte)_ApplicationTypeeInfo._ID;
                NewLicenses.CreatedBy = clsLoggedInUser.GlobalUser.UserID;
                NewLicenses.PaidFees = _ClassType._ClassFees + _ApplicationTypeeInfo._Fees;

                if (NewLicenses.AddLicense())
                {
                    clsLicenses.DeactiveLicense(_LicenseInfo.LicenaseID);

                    MessageBox.Show("License Renwed Successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lb_RenewdLicense.Text = NewLicenses.LicenaseID.ToString();
                    lb_NewLicenseAppID.Text = NewApplication._ApplicationID.ToString();
                    ll_ShowInfo.Enabled = true;
                    btn_Save.Enabled = false;
                    return;

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void ll_ShowInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LicenseInfo = new frmLicenseInfo(int.Parse(lb_RenewdLicense.Text),true);
            LicenseInfo.ShowDialog();
        }

        private void ll_ShowHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form LicenseHistory = new frmLicenseHistory(clsDriver.FindByDriverID(_LicenseInfo.DriverID).PersonID, true);
            LicenseHistory.ShowDialog();
        }
    }
}
