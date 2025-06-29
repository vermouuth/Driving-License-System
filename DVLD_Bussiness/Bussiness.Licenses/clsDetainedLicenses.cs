using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsDetainedLicenses
    {


        public int DetainedID { get; set; }
        public int LicensesID { get; set; }
        public DateTime DetainedDate { get; set; }
        public decimal Fees { get; set; }
        public int CreatedBy { get; set; }
        public bool IsReleased { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByID { get; set; }
        public int ReleaseAppID { get; set; }

        public clsDetainedLicenses() 
        {
            DetainedID = 0;
            LicensesID = 0;
            DetainedDate = new DateTime();
            Fees = 0;
            CreatedBy = 0;
            IsReleased = false;
            ReleaseDate = new DateTime();
            ReleasedByID = 0;
            ReleaseAppID = 0;
        }

        private clsDetainedLicenses(int DetainID , int LicenseID , DateTime DetainDate ,
            decimal fees , int CreatedBy , bool IsReleased , DateTime ReleasedDate ,int ReleasedBy ,int ReleasedAppID  )
        {
           this.DetainedID = DetainID;
           this.LicensesID = LicenseID;
           this.DetainedDate = DetainDate;
           this.Fees = fees;
           this.CreatedBy = CreatedBy;
           this.IsReleased = IsReleased;
           this. ReleaseDate = ReleasedDate;
           this.ReleasedByID = ReleasedBy;
           this. ReleaseAppID = ReleasedAppID;
        }

        

        public static clsDetainedLicenses Find(int LicesneID)
        {
            int DETAINID = -1;
            DateTime ReleaseDate = new DateTime();
            decimal Fee = 0;
            int CreateID = -1;
            bool IsReleased = false;
            ReleaseDate = new DateTime();
            int ReleasedByID = 0;  
            int ReleaseAppID = 0;

            if(clsDetainedLicensesData.GetDetaindLicense(LicesneID,ref DETAINID,ref ReleaseDate,ref Fee , ref CreateID,
                                            ref IsReleased,ref  ReleaseDate,ref ReleasedByID,ref ReleaseAppID))
            {
                return new clsDetainedLicenses(DETAINID, LicesneID, ReleaseDate, Fee, CreateID,
                                            IsReleased, ReleaseDate, ReleasedByID, ReleaseAppID);
            }

            return null;
        }

        public bool AddDetainedLicense()
        {
            this.DetainedID = clsDetainedLicensesData.InsertNewDetaindLicense(this.LicensesID, this.DetainedDate, this.Fees, this.CreatedBy, this.IsReleased, this.ReleaseDate, this.ReleasedByID, this.ReleaseAppID);

            return this.DetainedID > 0;
        }

        public bool ReleaseLicense()
        {
            return clsDetainedLicensesData.UpdateReleaseDetaindLicense(this.LicensesID, this.IsReleased , this.ReleaseDate , this.ReleasedByID , this.ReleaseAppID);
        }

        public static bool IsLicenseDetained(int LicenseID)
        {
            return clsDetainedLicensesData.IsLicenseDetaind(LicenseID);
        }

        public static bool IsLicenseReleased(int LicenseID)
        {
            return clsDetainedLicensesData.IsLicenseReleased(LicenseID);
        }


        public static DataTable GetDetainedLicenses()
        { 
            return clsDetainedLicensesData.GetAllDetainedLicenses();
        }


        public static bool DetainAllLicense(int LicenseID)
        {
            return clsDetainedLicensesData.DetianAllLicense(LicenseID);
        }

        public static bool ReleaseAllLicense(int LicenseID)
        {
            return clsDetainedLicensesData.ReleaseAllLicense(LicenseID);
        }
    }
}
