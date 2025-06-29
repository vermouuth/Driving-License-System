using LicensesDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer
{
    public class clsTestAppiontment
    {

        enum enMode { enAddNew , enUpdate};
        enMode CurrentMode;
        public int TestAppiontmentID { get; set; }  
        public int TesteTypeID { get; set; }
        public int LocalDrivingID { get; set; } 
        public DateTime TestDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID {  get; set; }  

        public bool IsLocked { get; set; }

        public clsTestAppiontment()
        {
            this.TestAppiontmentID = -1;
            this.LocalDrivingID = -1;
            this.TestDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;
            this.TesteTypeID = -1;
            CurrentMode = enMode.enAddNew;
        }

        private clsTestAppiontment(int TestAppoitmentID , int TestTypeID , int LocalDrivingLicenseID, DateTime AppDate , decimal Fees , int CreatedBy , bool isLoocked)
        {
            this.TestAppiontmentID = TestAppoitmentID;
            this.TesteTypeID = TestTypeID;
            this.LocalDrivingID = LocalDrivingLicenseID;
            this.TestDate = AppDate;
            this.PaidFees = Fees;
            this.CreatedByUserID = CreatedBy;
            this.IsLocked = isLoocked;
            CurrentMode = enMode.enUpdate;
        }


        public bool AddTestAppointment()
        {
            this.TestAppiontmentID = clsTestAppointmentsData.InsertTestAppointment(this.TesteTypeID,this.LocalDrivingID, this.TestDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
            return (this.TestAppiontmentID > 0);
        }

        public bool UpdateTestAppiontment()
        {
            return clsTestAppointmentsData.UpdateAppointmentDate(this.TestAppiontmentID,this.TestDate);
        }

        public bool Save()
        {
            switch (CurrentMode)
            {
                case enMode.enAddNew:
                {
                  if (AddTestAppointment())
                  {
                     return true;
                  }

                  else
                    return false;
                }

                case enMode.enUpdate:
                {
                    if(UpdateTestAppiontment())
                    {
                          return true;
                    }

                    else
                    {
                            return false;
                    }
                }
            }

            return false;

        }

        public static clsTestAppiontment Find(int TestAppID)
        {
            int TestType = -1;
            int LocalID = -1;
            DateTime Date = DateTime.Now;
            decimal fees = -1;
            int CreatedBy = 0;
            bool isLocked = false;

            if(clsTestAppointmentsData.GetTestAppInfo(TestAppID , ref TestType , ref LocalID , ref Date , ref fees , ref CreatedBy , ref isLocked))
            {
                return new clsTestAppiontment(TestAppID, TestType, LocalID, Date, fees, CreatedBy, isLocked);
            }
            else 
                return null;
        }

        public static int GetTrials(int  TestTypeID, int LocalDrivingID)
        {
            return clsTestAppointmentsData.Trials(TestTypeID, LocalDrivingID);
        }

        public static int GetTestAppointmentID(int LocalAppID , int TestTypeID)
        {
           return clsTestAppointmentsData.GetTestAppointmentID(LocalAppID , TestTypeID);  
        }

        public static DataTable GetListOfTestsRelateToApplication(int LocalID , int TestTypeID)
        {
            return clsTestAppointmentsData.GetListOfTestsRelateToApplication(LocalID, TestTypeID);
        }

        public static bool HasSuceededTest(int LocalDrivingID, int TestTypeID)
        {
            return clsTestAppointmentsData.SucceededTested(LocalDrivingID, TestTypeID);
        }

        public static bool isLocalApplicationHadTested(int LocalAppID, int TestType)
        {
          return  clsTestAppointmentsData.IsLocalAppHasTestsWithTestType(LocalAppID, TestType);
        }

        public static bool isThereNonLockedTest(int LocalAppID,int TestType)
        {
            return clsTestAppointmentsData.isThereNonLockedTest(LocalAppID,TestType);
        }

        public static bool UpdateTestLocker(int TestAppID, bool isLocked)
        {
            return clsTestAppointmentsData.UpdateAppointmentLocker(TestAppID, isLocked);
        }
    }
}
