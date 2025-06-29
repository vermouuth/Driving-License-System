using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.Applications.Manage.TestTyeps.TestsControls
{
    public partial class ctlTakeTest : UserControl
    {

        enum enTest { VisionTest = 1 , TheoryTest = 2 , PracticalTest = 3};
        enTest CurrentTest;

        clsLocalDrivingApplication _LocalApp;
        clsTestAppiontment _TestAppointment;
        clsTestTypes _TestType;

        public ctlTakeTest()
        {
            InitializeComponent();
        }

        private void LoadHeader(int TestAppointmentID)
        {
            _TestAppointment = clsTestAppiontment.Find(TestAppointmentID);
            _LocalApp = clsLocalDrivingApplication.GetInfo(_TestAppointment.LocalDrivingID);
            _TestType = clsTestTypes.Find(_TestAppointment.TesteTypeID);
            CurrentTest = (enTest)_TestAppointment.TesteTypeID;

            switch (CurrentTest)
            {
                case enTest.VisionTest:
                    {
                        Pic_Model.Image = Properties.Resources.eye_scan;
                        lb_Model.Text = "Do Vision Test";
                        break;
                    }
                case enTest.TheoryTest:
                    {
                        Pic_Model.Image = Properties.Resources.Theory;
                        lb_Model.Text = "Do Theory Test";
                        break;
                    }
                    case enTest.PracticalTest:
                    {
                        Pic_Model.Image = Properties.Resources.Practical__Street__Test;
                        lb_Model.Text = "Do Practical Test";
                        break;
                    }
            }
        }

        public void LoadTestInfo(int TestAppointmentID)
        {
            LoadHeader(TestAppointmentID);
            lb_LocalApp.Text = _TestAppointment.LocalDrivingID.ToString();
            lb_ClassName.Text = _LocalApp.ClassName;
            lb_FullName.Text = _LocalApp.FullName;
            lb_Trials.Text = clsTestAppiontment.GetTrials(_TestType._ID, _LocalApp._LocalAppID).ToString();
            dt_TestDate.Value = _TestAppointment.TestDate;
            lb_Fees.Text = _TestAppointment.PaidFees.ToString();

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            clsTests NewTest= new clsTests();


            NewTest.TestAppiontmentID = _TestAppointment.TestAppiontmentID;
            NewTest.TestResult = rb_Pass.Checked ? true : false;
            NewTest.Note = txt_Notes.Text;
            NewTest.CratedBy = 1;

            DialogResult result =
                    MessageBox.Show($"Are you sure you want to Save the Test",
                   "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

            if (result == DialogResult.OK) 
            {

              if(NewTest.AddNewTest())
              {
                  clsTestAppiontment.UpdateTestLocker(_TestAppointment.TestAppiontmentID,true);
                  MessageBox.Show("Test Added Successfully.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  Form parentForm = this.FindForm();
                  if (parentForm != null)
                  {
                        parentForm.Close();
                  }
              }
                
            }
        }
    }
}
