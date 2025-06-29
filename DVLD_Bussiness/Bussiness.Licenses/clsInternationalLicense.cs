using LicensesDataAccessLayer;
using System;
using System.Data;

namespace BussinessLayer
{
    public class clsInternationalLicense
    {
        public int InternationalID { get; set; }    
        public int ApplicationId { get; set; }
        public int DriverID { get; set; }
        public int LicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive {  get; set; }
        public int CreatedBy { get; set; }

        public clsInternationalLicense() 
        {
            InternationalID = 0;
            ApplicationId = 0;
            DriverID = 0;
            LicenseID = 0;
            IssueDate= DateTime.Now;
            ExpirationDate = DateTime.Now;
            IsActive = false;
            CreatedBy = 0;

        }

        public bool AddInterNationalLicense()
        {
            this.InternationalID = clsInternationalLicensesData.InsertInterNationalLicense(this.ApplicationId, this.DriverID, this.LicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedBy);

            return this.InternationalID > 0;
        }

        public static bool IsDriverHasActiveLicense(int DriverID)
        {
            return clsInternationalLicensesData.IsDriverHasActiveInterNationalLicense(DriverID);
        }

        public static bool IsLicenseExist(int LicenseID)
        {
            return clsInternationalLicensesData.IsInternationalLicenseExist(LicenseID); 
        }

        public static DataTable GetAllInternationalLicenses()
        {
            return clsInternationalLicensesData.GetAllInternationalLicenses();
        }

    }
}
