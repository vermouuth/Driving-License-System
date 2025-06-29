using BussinessLayer;
using MyLicensesSystem.ManagePeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.Applications.Manage.TestTyeps.TestForms
{
    public partial class frmMainTest : Form
    {

        enum enTestType { enVisionTest = 1, enTheoryTest = 2, enPracticalTest = 3 }
        enTestType CurrentTest;

        int _LocalID = -1;
        int _TestTypeID = -1;

        public frmMainTest(int Local, int TypeID)
        {
            InitializeComponent();
            _LocalID = Local;
            _TestTypeID = TypeID;

            CurrentTest = (enTestType)TypeID;
            
        }


        private void HandleHeader()
        {
            switch (CurrentTest)
            {
                case enTestType.enVisionTest:
                    {
                        lb_Modling.Text = "Vision Test Appointment";
                        Pic_TestPic.Image = Properties.Resources.eye_scan;
                        break;
                    }
                case enTestType.enTheoryTest:
                    {
                        lb_Modling.Text = "Theory Test Appointment";
                        Pic_TestPic.Image = Properties.Resources.Theory;
                        break;
                    }
                case enTestType.enPracticalTest:
                    {
                        lb_Modling.Text = "Theory Test Practical";
                        Pic_TestPic.Image = Properties.Resources.Practical__Street__Test;
                        break;
                    }
            }
        }

        private void LoadData()
        {


           

            HandleHeader();
            ctlAppInfo1.LoadApplicationData(_LocalID);
            int ApplcationID = clsLocalDrivingApplication.Find(_LocalID)._AppID;
            ctlApplicationBasicInfo1.LoadApplicationInfo(ApplcationID);
           

            DataTable Appointments = clsTestAppiontment.GetListOfTestsRelateToApplication(_LocalID, _TestTypeID);
            bool TestAppointmentEmpty = Appointments == null;

            if (!TestAppointmentEmpty)
            {
                dgv_Appointments.DataSource = Appointments;
                if (dgv_Appointments.Columns.Count > 0)
                {
                    dgv_Appointments.Columns[1].Width = 135;

                }
                lb_CurrentAppointments.Text = dgv_Appointments.RowCount.ToString();
            }



        }

        private void frmMainTest_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_AddAppointment_Click(object sender, EventArgs e)
        {
          
           if (clsTestAppiontment.HasSuceededTest(_LocalID, _TestTypeID) || clsTestAppiontment.isThereNonLockedTest(_LocalID, _TestTypeID))
           {
               MessageBox.Show("Applcation Alreadey has a Succeeded Test", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
               return ;
           }

            Form AddNewAppointment = new frmAddTestAppointment(_LocalID, _TestTypeID,-1);
            AddNewAppointment.ShowDialog(); 
            LoadData();
        }

        private void ctlApplicationBasicInfo1_OnViewClicked(int obj)
        {
            int ApplicationID = clsLocalDrivingApplication.Find(_LocalID)._AppID;
            Form PersonDetails = new frmPersonDetails(clsApplication.Find(ApplicationID)._ApplicantionPersonID);
            PersonDetails.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((bool)dgv_Appointments.CurrentRow.Cells[3].Value == true)
            {
              MessageBox.Show("Cannot Edit This Appointment, Cause it is Locked.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
              return ;
            }

            Form AddNewAppointment = new frmAddTestAppointment(_LocalID, _TestTypeID, (int)dgv_Appointments.CurrentRow.Cells[0].Value);
            AddNewAppointment.ShowDialog();
            LoadData();
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            contextMenuStrip1.Items[1].Enabled = !(bool)dgv_Appointments.CurrentRow.Cells[3].Value == true;
            
            
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TakeTest = new frmTakeTest((int)dgv_Appointments.CurrentRow.Cells[0].Value);
            TakeTest.ShowDialog();
            LoadData();
        }
    }
}
