using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsLicenseInfo
    {
       public int LicenseID                { get ; set;} 
       public string ClassName             { get ; set;}
       public string FullName              { get ; set;} 
       public string NationalNo            { get ; set;}
       public string Gendor                { get ; set;}
       public DateTime IssueDate           { get ; set;}
       public string IsssueReason          { get ; set;}
       public string Notes                 { get ; set;}
       public string isActive              { get ; set;}
       public DateTime DateOfBirth         { get ; set;}
       public int DriverID                 { get; set; }
       public DateTime ExpirationDate      { get; set; }
       public string ImagePath { get; set;}

       private clsLicenseInfo(int ID , string Class, string Name , string National,
         string Gen , DateTime Issue , string Reason , string Not ,
         string Active , DateTime BirthDate , int Driver , DateTime ExDate , string Path)
        {
            this.LicenseID = ID;
            this.ClassName = Class;
            this.FullName = Name;
            this.NationalNo = National;
            this.Gendor = Gen;
            this.IssueDate = Issue;
            this.IsssueReason = Reason;
            this.Notes = Not;
            this.isActive = Active;
            this.DateOfBirth = BirthDate;
            this.DriverID = Driver;
            this.ExpirationDate = ExDate;
            this.ImagePath = Path;
        }


        public static clsLicenseInfo Find(int LicenseID)
        {             
             string ClassName        = ""               ;
             string FullName         = ""               ;
             string NationalNo       = ""               ;
             string Gendor           = ""               ;
             DateTime IssueDate      = DateTime.Now     ;
             string IsssueReason     = ""               ;
             string Notes            = ""               ;
             string isActive         = ""               ;
             DateTime DateOfBirth    = DateTime.Now     ;
             int DriverID            = 0                ;
             DateTime ExpirationDate = DateTime.Now     ;
             string ImagePath        = ""               ;

            if(clsLicensesData.GetAllLicenseInfo(LicenseID, ref ClassName ,ref FullName ,ref NationalNo , ref Gendor,
                        ref IssueDate , ref IsssueReason ,ref Notes ,
                        ref isActive , ref DateOfBirth , ref DriverID , ref ExpirationDate,ref ImagePath))
            {
                return new clsLicenseInfo(LicenseID,ClassName,FullName, NationalNo, Gendor, IssueDate, IsssueReason,
                     Notes,  isActive, DateOfBirth, DriverID ,ExpirationDate,ImagePath);
            }

             return null ;
        }



    }
}
