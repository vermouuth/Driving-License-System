using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsInternationalInfo
    {
        public string FullName                       { get; set; }
        public int InternationalLicenseID            { get; set; }
        public int LicenseID                          { get; set; }
        public string NationalNo                       { get; set; }
        public string Gendor                           { get; set; }
        public DateTime IssueDate                  { get; set; }
        public int ApplicationID                     { get; set; }
        public string isActive                  { get; set; }
        public DateTime DateOfBirth                 { get; set; }
        public int DriverID                      { get; set; }
        public DateTime ExpirationDate          { get; set; }

        public string ImagePath { get; set; }

        private clsInternationalInfo(string Name , int InterID , int License , string No , string Gen,
            DateTime Issue , int App , string active , DateTime BirthDate , int Driver , DateTime exDate , string Image)
        {
            FullName = Name;
            InternationalLicenseID = InterID;
            LicenseID = License;
            NationalNo = No;
            Gendor = Gen;
            IssueDate = Issue;
            ApplicationID = App;
            isActive = active;
            DateOfBirth = BirthDate;
            DriverID = Driver;
            ExpirationDate = exDate;
            ImagePath = Image;
        }


        public static clsInternationalInfo FindByLicenseID(int LicenseID)
        {
            string FullName = "";
            int InternationalLicense = 0;
            string NationalNo = "";
            string Gendor = "";
            DateTime IssueDate = DateTime.Now;
            int ApplicationID = 0;
            string isActive = "";
            DateTime DateOfBirth  = DateTime.Now;
            int DriverID = 0;
            DateTime ExpirationDate = DateTime.Now;
            string ImagePath = "";

            if(clsInternationalLicensesData.GetInternationalInfo(LicenseID,ref FullName,ref InternationalLicense,
                ref NationalNo, ref Gendor, ref IssueDate,ref ApplicationID,ref isActive , ref DateOfBirth , ref DriverID , ref ExpirationDate, ref ImagePath))
            {
                return new clsInternationalInfo(FullName, InternationalLicense, LicenseID,NationalNo, Gendor,  IssueDate,
                     ApplicationID,  isActive ,  DateOfBirth,   DriverID,  ExpirationDate, ImagePath);
            }
            else
            { return null; }
        }


    }
}
