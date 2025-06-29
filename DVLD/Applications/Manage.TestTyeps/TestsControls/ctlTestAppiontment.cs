using BussinessLayer;
using System;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.Tests.TestControls
{
    public partial class ctlTestAppiontment : UserControl
    {

        enum enTestOprations { enAddNewTest = 1 , enUpdateTestDate = 2};
        enTestOprations CurrentTestOpration;
        enum enTestType { enVisionTest = 1, enTheoryTest = 2, enPracticalTest = 3 }
        enTestType CurrentTestType;

        clsTestTypes TestType;
        clsLocalDrivingApplication localDrivingApplication;
        clsTestAppiontment _TestApp;

        int _TestTypeID = -1;
        int _LocalDrivingID = -1;

        public ctlTestAppiontment()
        {
            InitializeComponent();
            dt_TestDate.MaxDate = DateTime.Now.AddDays(220);
            

        }

        private void HandelHeader(int LocalID, int TestTypeID , int TestAppID)
        {

            _TestTypeID = TestTypeID;
            _LocalDrivingID = LocalID;

            _TestApp = clsTestAppiontment.Find(TestAppID);


            if (_TestApp == null)
            {
                _TestApp = new clsTestAppiontment();
                CurrentTestOpration = enTestOprations.enAddNewTest;


            }
            else
            {
                CurrentTestOpration = enTestOprations.enUpdateTestDate;

            }


           CurrentTestType = (enTestType)TestTypeID;
           TestType = clsTestTypes.Find(TestTypeID);

           switch (CurrentTestType)
           {
               case enTestType.enVisionTest:
                   {
                       Pic_Model.Image = Properties.Resources.eye_scan;
                       grbBox.Text = "Vision Test";
                       break;
                   }
               case enTestType.enTheoryTest:
                   {
                       Pic_Model.Image = Properties.Resources.Theory;
                       grbBox.Text = "Theory Test";
                       break;
                   }
               case enTestType.enPracticalTest:
                   {
                       Pic_Model.Image = Properties.Resources.Practical__Street__Test;
                       grbBox.Text = "Practical Test";
                       break;
                   }
           }

            grbRetake.Enabled = clsTestAppiontment.GetTrials(LocalID, TestTypeID) > 0;

        }

        public void LoadTestInfo(int LocalID, int TestTypeID , int TestAppID)
        {

            HandelHeader(LocalID,TestTypeID , TestAppID);

            localDrivingApplication = clsLocalDrivingApplication.GetInfo(LocalID);

            grbRetake.Enabled =  clsTestAppiontment.GetTrials(TestTypeID, LocalID) > 0;

            if (localDrivingApplication == null)
            {
                MessageBox.Show($"Cannot Find Local Driving License With this Current ApplicationID: {_LocalDrivingID}");
                return;
            }

            if (CurrentTestOpration == enTestOprations.enUpdateTestDate)
            {


                lb_TestAppID.Text = _TestApp.LocalDrivingID.ToString();                
                dt_TestDate.Value = _TestApp.TestDate;
                lb_Fees.Text = TestType._Fees.ToString();
            }

            else
            {

                if (grbRetake.Enabled)
                {
                    lb_TestAppID.Text = clsTestAppiontment.GetTestAppointmentID(_LocalDrivingID, _TestTypeID).ToString();
                }
          
                dt_TestDate.Value = DateTime.Now;
               

            }

            lb_TestAppID.Text = localDrivingApplication._LocalAppID.ToString() ;
            lb_Trials.Text = clsTestAppiontment.GetTrials(TestTypeID, LocalID).ToString();
            lb_ClassName.Text = localDrivingApplication.ClassName;
            lb_FullName.Text = localDrivingApplication.FullName;
            lb_Fees.Text = TestType._Fees.ToString();
            lb_RFees.Text = "5";
            lb_TotalFees.Text = $"{TestType._Fees + 5}";

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            decimal TotalFees = TestType._Fees;
            if (grbRetake.Enabled)
            {
                TotalFees += 5;
            }

           
       
            _TestApp.TesteTypeID = _TestTypeID;
            _TestApp.LocalDrivingID = _LocalDrivingID;
            _TestApp.TestDate = dt_TestDate.Value;
            _TestApp.PaidFees = TotalFees;                              
            _TestApp.CreatedByUserID = 1;
            _TestApp.IsLocked = false;

          


            if( _TestApp.Save())
            {
                MessageBox.Show("Done Successfully.","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }
                return;
            }



          



        }


    }
}
