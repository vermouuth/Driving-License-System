using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsLocalDrivingApplication
    {
       public int _LocalAppID { get; set; }
       public int _AppID {  get; set; }
       public int _ClassID { get; set; }

       public string ClassName { get; set; }

       public string NationalNo { get; set; }

       public string FullName { get; set; }

       public DateTime AppDate { get; set; }

       public string Status { get; set; }

       public int PassedTests {  get; set; }



        private clsLocalDrivingApplication(int localAppID, int appID, int classID)
        {
            _LocalAppID = localAppID;
            _AppID = appID;
            _ClassID = classID;
        }

        private clsLocalDrivingApplication(int localAppID, string ClassName, string National , string FullName , DateTime AppDate , int PassedTestCount , string Status)
     {
            _LocalAppID = localAppID;
            this.ClassName = ClassName;
            this.PassedTests = PassedTestCount;
            this.Status = Status;
            this.AppDate = AppDate;
            this.NationalNo = National;
            this.FullName = FullName;


     }

        public clsLocalDrivingApplication()
        {
            this._LocalAppID = -1;
            this._AppID = -1;
            this._ClassID = -1;
        }


        public static clsLocalDrivingApplication Find(int LocalID)
        {
            int AppID = -1;
            int ClassID = -1;

            if (clsLocalDrivingApplicationData.GetLocalAppByLocalID(LocalID, ref AppID, ref ClassID))
             {
                return new clsLocalDrivingApplication(LocalID, AppID, ClassID);
             }

            return null;
        }

        public static clsLocalDrivingApplication FindByAppID(int AppID)
        {
            int LocalApp = -1;
            int ClassID = -1;

            if (clsLocalDrivingApplicationData.GetLocalAppByID(AppID, ref LocalApp, ref ClassID))
            {
                return new clsLocalDrivingApplication(LocalApp, AppID, ClassID);
            }

            return null;
        }


        public static clsLocalDrivingApplication GetInfo(int LocalID)
        {
            string ClassName = "";
            string NationalNO = "";
            string FullName = "";
            DateTime ApplicatationDate = DateTime.Now;
            string Status = "";
            int PassedTest = -1;

            if(clsLocalDrivingApplicationData.GetLocalInfo(LocalID,ref ClassName , ref NationalNO , ref FullName , ref ApplicatationDate , ref PassedTest , ref Status))
            {
                return new clsLocalDrivingApplication(LocalID, ClassName, NationalNO, FullName, ApplicatationDate, PassedTest, Status); ;
            }

            return null;
        }


        public static DataTable GetLocalApps()
        {
            return clsApplicationsData.GetAllApplications();
        }


        public static bool DeleteLocalApp(int LocalAppID)
        {
            return clsLocalDrivingApplicationData.DeleteLocalApplication(LocalAppID);
        }


        public bool AddNewLocalLicenseApp()
        {
            this._LocalAppID = clsLocalDrivingApplicationData.InsertIntoLocalLicenses(this._AppID, this._ClassID);

            return this._LocalAppID != -1;
        }

        public bool UpdateLocalLicenseApp()
        {
            return clsLocalDrivingApplicationData.UpdateLocalApplication(this._AppID, this._ClassID);
        }
    }
}
