using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsLicenses
    {
       public int LicenaseID { get; set; }
       public int ApplicationID       {get; set;}
       public  int DriverID            {get; set;}
       public  int LicenseClass        {get; set;}
       public  DateTime IssueDate      {get; set;}
       public  DateTime ExpirationDate {get; set;}
       public  string Notes            {get; set;}
       public  decimal PaidFees        {get; set;}
       public  bool isActive           {get; set;}
       public  byte IssueReason        {get; set;}
       public int CreatedBy            {get; set; }

       public string IssueReasenstring { get; set;}  

       public clsLicenses() 
       {
            LicenaseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseClass = -1;
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.Now;
            Notes = "";
            PaidFees = -1;
            isActive = false;
            IssueReason = 10;
            CreatedBy = -1;
       }


       private clsLicenses(int licenaseID,  int driverID, int licenseClass, DateTime issueDate, DateTime expirationDate, string notes,  bool isActive, string issueReason)
        {
            LicenaseID = licenaseID;
            DriverID = driverID;
            LicenseClass = licenseClass;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            Notes = notes;
            this.isActive = isActive;
            IssueReasenstring = issueReason;
        }
       

       private clsLicenses(int licenaseID , int ApplcationID,int DriverID , int ClassID)
        {
            LicenaseID = licenaseID;
            this.ApplicationID = ApplcationID;
            this.DriverID = DriverID;
            this.LicenseClass = ClassID;
        }

        public static clsLicenses FindInfo(int LicneseClassID , int LocalID)
        {
            int LicenseID = -1;
            int driverID = -1; 
            DateTime issueDate = DateTime.Now; 
            DateTime expirationDate = DateTime.Now;
            string notes = "";
            bool xisActive = false;
            string issueReason = "";

            if (clsLicensesData.GetLicesneInfoToInfoCard(LicneseClassID, LocalID, ref LicenseID, ref driverID, ref issueDate, ref issueReason, ref notes, ref xisActive, ref expirationDate))
            {
                return new clsLicenses(LicenseID, driverID, LicneseClassID, issueDate, expirationDate, notes, xisActive, issueReason);
            }
            else
                return null;
        }

        public static clsLicenses FindShortInfo(int LicenseID)
        {
            int AppID = -1;
            int DriverID = -1;
            int Class = -1;

            if(clsLicensesData.GetShortLicenseInfo(LicenseID,ref AppID , ref DriverID , ref Class))
            {
                return new clsLicenses(LicenseID,AppID,DriverID,Class);
            }

            return null;    
        }

        public bool AddLicense()
        {
            this.LicenaseID = clsLicensesData.InsertNewLicense(ApplicationID, DriverID, LicenseClass, IssueDate, ExpirationDate, Notes, PaidFees, isActive, IssueReason, CreatedBy);

            return this.LicenaseID > 0;
        }

        public static bool IsLicenseExist(int LicenseID)
        {
           return clsLicensesData.IsLicenseExist(LicenseID);
        }
       
        public static int GetLicenseID(int ApplcationID)
        {
            return clsLicensesData.GetLicenseIDbyAppID(ApplcationID);
        }

        public static bool IsLicenseExpired(int LicenseID)
        {
            return clsLicensesData.IsLicenseExipred(LicenseID);
        }

        public static bool DeactiveLicense(int LicenseID)
        {
            return clsLicensesData.DeActiveLicenseByID(LicenseID);
        }


        public static bool isLicenseActive(int LicenseID)
        {
            return clsLicensesData.IsLicenseActive(LicenseID);
        }


    }
}
