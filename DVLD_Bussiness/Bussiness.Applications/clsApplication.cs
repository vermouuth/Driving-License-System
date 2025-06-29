using LicensesDataAccessLayer;
using System.Data;
using System;

namespace BussinessLayer
{
    public class clsApplication
    {
        public enum enMode { AddNew = 1, UpdateMode = 2 };

        public enMode _CurrentMode = enMode.UpdateMode;

        public int _ApplicationID { get; set; }

        public int _ApplicantionPersonID { get; set; }

        public clsPerson _Person { get; }

        public DateTime _ApplicationDate { get; set; }

        public byte _ApplicationStatus { get; set; }

        public int _ApplicationTypeID { get; set; }

        public int _CreatedByUserID { get; set; }

        public clsUser _User { get;}

        public DateTime _LastStatusDate { get; set; }

        public decimal _PaidFees { get; set; }

        public string ClassName { get; set; }

        public string FullName { get; set; }

        public string Status { get; set; }

        public  string CreatedBy { get; set; }

        public string AppTypeName { get; set; }

        public int PassedTests {  get; set; }

        public clsApplication()
        {
            _ApplicationID = -1;
            _ApplicantionPersonID = -1;
            _ApplicationDate = DateTime.Now;
            _ApplicationStatus = 0;
            _ApplicationTypeID = -1;
            _CreatedByUserID = -1;
            _LastStatusDate = DateTime.Now;
            _PaidFees = 0;

            _CurrentMode = enMode.AddNew;
        }


        private clsApplication(int AppID  , string ClassName , int PassedTests)
        {
            this._ApplicationID = AppID;
            this.ClassName = ClassName;
            this.PassedTests = PassedTests;
        }

        private clsApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate,
            int ApplicationTypeID, byte ApplicationStatus, int CreatedByUserID, DateTime LastStatusDate, decimal PaidFees)
        {
            _ApplicationID = ApplicationID;
            _ApplicantionPersonID = ApplicantPersonID;
            _ApplicationDate = ApplicationDate;
            _ApplicationStatus = ApplicationStatus;
            _ApplicationTypeID = ApplicationTypeID;
            _CreatedByUserID = CreatedByUserID;
            _LastStatusDate = LastStatusDate;
            _PaidFees = PaidFees;

            _Person = clsPerson.Find(ApplicantPersonID);
            _User = clsUser.Find(CreatedByUserID);
            _CurrentMode = enMode.UpdateMode;
        }

        private clsApplication(int AppID , string Status , decimal Fees , string AppType , string FullName ,  DateTime AppDate , DateTime StatusDate , string UserName)
        {
            this._ApplicationID = AppID;
            this.Status = Status;
            this._PaidFees = Fees;
            this.AppTypeName = AppType;
            this.FullName = FullName;
            this._ApplicationDate = AppDate;
            this._LastStatusDate = StatusDate;
            this.CreatedBy = UserName;
        }

        public bool _UpdateApplication()
        {
            return clsApplicationsData.UpdateApplication(_ApplicationID, _ApplicationStatus,
               _LastStatusDate, _PaidFees);
        }

        public bool _AddNewApplication()
        {
            _ApplicationID = clsApplicationsData.AddNewApplication(_ApplicantionPersonID, _ApplicationDate, _ApplicationStatus,
                _ApplicationTypeID, _CreatedByUserID, _LastStatusDate, _PaidFees);

            return (_ApplicationID != -1);
        }

        public static clsApplication Find(int ApplicationID)
        {
            int AppPersonID = -1;
            DateTime ApplicationDate = DateTime.Now;
            byte ApplicationStatus = 0;
            int ApplicationTypeID = -1;
            int CreatedByUserID = -1;
            DateTime LastStatusDate = DateTime.Now;
            decimal PaidFees = 0;

            if (clsApplicationsData.GetApplicationByID(ApplicationID, ref AppPersonID, ref ApplicationDate,
                ref ApplicationTypeID, ref ApplicationStatus, ref CreatedByUserID, ref LastStatusDate, ref PaidFees))
            {
                return new clsApplication(ApplicationID, AppPersonID, ApplicationDate, ApplicationTypeID,
                    ApplicationStatus, CreatedByUserID, LastStatusDate, PaidFees);
            }
            else
                return null;
        }


        public bool Save()
        {
            if (_CurrentMode == enMode.AddNew)
            {
                if (_AddNewApplication())
                {
                    _CurrentMode = enMode.UpdateMode;
                    return true;
                }
            }
            else
            {
                if (_UpdateApplication())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool DeleteApplication(int ApplicationID)
        {
            return clsApplicationsData.DeleteApplication(ApplicationID);
        }



        public static bool CheackPersonHasApp(int PersonID,  int ClassID , ref int ApplicationID )
        {
            return clsApplicationsData.CheackPersonHasApp(PersonID, ClassID , ref ApplicationID);
        }

        public static clsApplication BasicApplicationInfo(int AppID)
        {
            string status = "";
            decimal fees = -1;
            string AppType = "";
            string FullName = "";
            DateTime AppDate = DateTime.Now;
            DateTime StatusDate = DateTime.Now;
            string UserNAME = "";

            if(clsApplicationsData.GetAllAppBasicInfoByID(AppID , ref status ,ref fees,ref AppType,ref FullName ,ref AppDate ,ref StatusDate ,ref UserNAME))
            {
                return  new clsApplication(AppID, status, fees, AppType, FullName, AppDate, StatusDate,UserNAME);
            }
            else
                return null;
        }

        public static bool IsAppHasLicense(int AppID)
        {
            return clsApplicationsData.isApplicationHasLicense(AppID);
        }

        public static bool PersonHasActiveLicense(int PersonID, int ClassTypeID)
        {
            return clsApplicationsData.PersonHasActiveLicense(PersonID, ClassTypeID);
        }

        public static bool UpdateApplcationStatus(int ApplcaitonID , int StatusID)
        {
            return clsApplicationsData.UpdateApplcaitonStatus(ApplcaitonID, StatusID);
        }
     
    }
}
