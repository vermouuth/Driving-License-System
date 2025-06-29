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
    public partial class ctsInternationalCard : UserControl
    {
        clsInternationalInfo InternationalLicense;
        public ctsInternationalCard()
        {
            InitializeComponent();
        }

        public void LoadInternationalData(int LicenseID)
        {
            InternationalLicense = clsInternationalInfo.FindByLicenseID(LicenseID);

            lb_Name.Text = InternationalLicense.FullName;
            lb_Interid.Text = InternationalLicense.InternationalLicenseID.ToString();
            lb_LicenseID.Text = LicenseID.ToString();
            lb_NationalNo.Text = InternationalLicense.NationalNo;

           

            lb_Gendor.Text = InternationalLicense.Gendor;

            lb_IssueDate.Text = InternationalLicense.IssueDate.ToShortDateString ();
            lb_AppID.Text = InternationalLicense.ApplicationID.ToString();
            lb_Acitve.Text = InternationalLicense.isActive;
            lb_DateOfBirth.Text = InternationalLicense.DateOfBirth.ToShortDateString ();
            lb_DriverID.Text = InternationalLicense.DriverID.ToString();
            lb_ExDate.Text = InternationalLicense.ExpirationDate.ToShortDateString ();
            Pic_DriverPic.ImageLocation = InternationalLicense.ImagePath;

            if (InternationalLicense.Gendor == "Male")
            {
                picGendor.Image = Properties.Resources.Male;

                if (InternationalLicense.ImagePath == "")
                {
                    Pic_DriverPic.Image = Properties.Resources.PersonMan;
                }
            }
            else
            {
                picGendor.Image = Properties.Resources.Female;

                if (InternationalLicense.ImagePath == "")
                {
                    Pic_DriverPic.Image = Properties.Resources.PersonGirl;
                }
            }
        }
        
    }
}
