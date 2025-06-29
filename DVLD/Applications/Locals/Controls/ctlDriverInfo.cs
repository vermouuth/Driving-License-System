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
    public partial class ctlDriverInfo : UserControl
    {

        clsLicenseInfo _LiceneseInfo;  
        public ctlDriverInfo()
        {
            InitializeComponent();
        }


        private bool LoadClasses(int LicenseID)
        {
            _LiceneseInfo = clsLicenseInfo.Find(LicenseID);
            return _LiceneseInfo == null ? false : true;
        }

        public void LoadLicecnse(int LicenseID)
        {
            if(!LoadClasses(LicenseID))
            {
                MessageBox.Show($"Cannot Find _LocalLicense With This ID {LicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



         
            if (_LiceneseInfo.Gendor == "Male")
            {
                picGendor.Image = Properties.Resources.Male;

                if (_LiceneseInfo.ImagePath == "")
                {
                    Pic_DriverPic.Image = Properties.Resources.PersonMan;
                }
            }

            else
            {
                picGendor.Image = Properties.Resources.Female;

                if (_LiceneseInfo.ImagePath ==  "")
                {
                    Pic_DriverPic.Image = Properties.Resources.PersonGirl;
                }
            }

            if(_LiceneseInfo.ImagePath != null)
            {
              Pic_DriverPic.ImageLocation = _LiceneseInfo.ImagePath;

            }


            lb_ClassName.Text = _LiceneseInfo.ClassName;
            lb_FullName.Text = _LiceneseInfo.FullName;
            lb_LicenseID.Text = _LiceneseInfo.LicenseID.ToString();
            lb_NationalNo.Text = _LiceneseInfo.NationalNo;
            lb_Gendor.Text = _LiceneseInfo.Gendor;
            lb_IssueDate.Text = _LiceneseInfo.IssueDate.ToShortDateString();
            lb_Reason.Text = _LiceneseInfo.IsssueReason;
            lb_Notes.Text = _LiceneseInfo.Notes;
            lb_DateOfBirth.Text = _LiceneseInfo.DateOfBirth.ToShortDateString();
            lb_DriverID.Text = _LiceneseInfo.DriverID.ToString();
            lb_ExDate.Text = _LiceneseInfo.ExpirationDate.ToShortDateString();
            lb_Acitve.Text = _LiceneseInfo.isActive;

            
             if(!clsDetainedLicenses.IsLicenseReleased(LicenseID))
             {
                     lb_Detained.Text = "No";
             }          

             else
             {
                lb_Detained.Text = "Yes";
             }

        }
    }
}
