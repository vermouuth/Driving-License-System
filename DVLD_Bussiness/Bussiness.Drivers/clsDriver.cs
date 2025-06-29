using System;
using System.Data;
using LicensesDataAccessLayer;


namespace BussinessLayer
{
    public class clsDriver
    {
        public int DriverID { get; set; }

        public int PersonID { get; set; }

        public int CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public clsDriver() 
        {
            DriverID = -1;
            PersonID = -1;
            CreatedBy = -1;
            CreatedDate = DateTime.Now;
        }

        private clsDriver(int DriverID , int PersonID, int CreatedBy, DateTime CreatedDate)
        {
            this.DriverID = DriverID;
            this.PersonID = PersonID;
            this.CreatedBy = CreatedBy;
            this.CreatedDate = CreatedDate;
        }

        public bool AddNewDriver()
        {
            this.DriverID = clsDriverData.AddNewDriver(this.PersonID, this.CreatedBy, this.CreatedDate);

            return (this.DriverID > 0);
        }
         
        public static clsDriver Find(int PersonID)
        {
            int DriverID = -1;
            int CreatedBy = -1;
            DateTime CrDate = DateTime.Now;

            if (clsDriverData.GetDriverInfoByPerson(PersonID, ref DriverID, ref CreatedBy, ref CrDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedBy, CrDate);
            }

            else
                return null;
        }

        public static clsDriver FindByDriverID(int DriverID)
        {
            int PersonID = -1;
            int CreatedBy = -1;
            DateTime CrDate = DateTime.Now;

            if (clsDriverData.GetDriverInfo(DriverID, ref PersonID, ref CreatedBy, ref CrDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedBy, CrDate);
            }

            else
                return null;

        }

        public static bool IsDriverExist(int PersonID)
        {
            return clsDriverData.isDriverExist(PersonID);
        }

        public static DataTable GetDrivers()
        {
            return clsDriverData.GetDriversData();
        }

        public static DataTable GetAllLocalPersonLicenses(int PersonID)
        {
            return clsDriverData.GetLocalDriverLicenses(PersonID);
        }

        public static DataTable GetInterNationalLicense(int PersonID)
        {
            return clsDriverData.GetInterNationalDriverLicenses(PersonID);
        }
    }
}
