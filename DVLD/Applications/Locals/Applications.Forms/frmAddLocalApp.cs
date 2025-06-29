using BusinessLayer;
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

namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.New.Local.License
{
   
    public partial class frmAddLocalApp : Form
    {



        enum enMode { AddNewApp = 1  , UpdateApp = 2};
        enMode CurrentMode;


        private clsApplicationTypes _ApplicationType;
        private clsApplication TheApplication;
        private clsLocalDrivingApplication _LocalDrivingApplication;

        int _LocadDrivingID;

        public frmAddLocalApp(int LocalID,int AppType)
        {
            InitializeComponent();

            if(LocalID > 0)
            {
                CurrentMode = enMode.UpdateApp;
            }
            else 
            {
                CurrentMode = enMode.AddNewApp;
            }

            _LocadDrivingID = LocalID;

            _ApplicationType = clsApplicationTypes.Find(AppType);
        }


        private void LoadData()
        {
            DataTable ClassTyeps = clsLicenseClasses.GetLicenseClasses();

            foreach (DataRow ClassRow in ClassTyeps.Rows)
            {
                cb_Classes.Items.Add(ClassRow["ClassName"]);
            }

            if(CurrentMode == enMode.AddNewApp)
            {
                TheApplication = new clsApplication();
                _LocalDrivingApplication = new clsLocalDrivingApplication();
                lb_AppFees.Text = _ApplicationType._Fees.ToString();

                return;

            }

            _LocalDrivingApplication = clsLocalDrivingApplication.Find(_LocadDrivingID);  
            TheApplication = clsApplication.Find(_LocalDrivingApplication._AppID);

            int ClassID = _LocalDrivingApplication._ClassID;

            lb_Modeling.Text = "Editing Applcation";
            cb_Classes.SelectedIndex = cb_Classes.FindString(clsLicenseClasses.Find(ClassID)._ClassName);
            ctlSearchinPerson1.LoadPerson(TheApplication._ApplicantionPersonID);
            ctlSearchinPerson1.Enabled = false;
            lb_AppDate.Text = TheApplication._ApplicationDate.ToShortDateString();
            lb_AppFees.Text = TheApplication._PaidFees.ToString();
            Lb_CreatedBY.Text = TheApplication._CreatedByUserID.ToString();

        }

        private void frmNewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ctlSearchinPerson1_OnEditClicked(int obj)
        {
            frmAddUpdatePerson EditPerson = new frmAddUpdatePerson(obj);

            EditPerson.DataBack += (object sender, int id) =>
            {
                ctlSearchinPerson1.LoadPerson(id);  
            };

            EditPerson.ShowDialog();


        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if(ctlSearchinPerson1.ID == -1) 
            {
                MessageBox.Show("You did not enter a Person to do next button.");
                return;
            }

            tab_Control.SelectedTab = tb_Applicationinfo;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {


            int ClassID = clsLicenseClasses.Find(cb_Classes.Text)._ID;

            int  ApplicationID = -1;
            int PersonID = ctlSearchinPerson1.ID;

            if (clsApplication.CheackPersonHasApp(PersonID, ClassID, ref ApplicationID))
            {
                MessageBox.Show($"Person Has an opened Application ID: {ApplicationID}  , on this ClassType.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if(clsApplication.PersonHasActiveLicense(PersonID, ClassID))
            {
                MessageBox.Show($"Person Has an Active License With This Class Type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



            if (CurrentMode == enMode.AddNewApp)
            {
                TheApplication._ApplicantionPersonID = ctlSearchinPerson1.ID;
                TheApplication._ApplicationDate = DateTime.Now;
                TheApplication._ApplicationTypeID = 1;
                TheApplication._CreatedByUserID = clsLoggedInUser.GlobalUser.UserID;
                TheApplication._LastStatusDate = DateTime.Now;
                TheApplication._ApplicationStatus = 1;
                TheApplication._PaidFees = _ApplicationType._Fees;

                         

                if (TheApplication._AddNewApplication())
                {

                    _LocalDrivingApplication._AppID = TheApplication._ApplicationID;
                    _LocalDrivingApplication._ClassID = clsLicenseClasses.Find(cb_Classes.Text)._ID;

                    _LocalDrivingApplication.AddNewLocalLicenseApp();

                    MessageBox.Show($"Application Added Successfully. ID:{TheApplication._ApplicationID}");
                    this.Close();
                    return;

                }
            }



            TheApplication._ApplicationDate = DateTime.Now;
            TheApplication._LastStatusDate = DateTime.Now;
            TheApplication._CreatedByUserID = clsLoggedInUser.GlobalUser.UserID;
            _LocalDrivingApplication._ClassID = clsLicenseClasses.Find(cb_Classes.Text)._ID;

            if( TheApplication._UpdateApplication())
            {
                if(_LocalDrivingApplication.UpdateLocalLicenseApp())
                {
                    MessageBox.Show("Application Updated Successfully.");
                    this.Close();
                    return;
                }
            }
            

        }

        private void ctlSearchinPerson1_OnAddClicked_1(int obj)
        {
            frmAddUpdatePerson addNewPerson = new frmAddUpdatePerson();

            addNewPerson.DataBack += (object sender, int personID) =>
            {
                ctlSearchinPerson1.LoadPerson(personID);
            };

            addNewPerson.ShowDialog();


        }
    }
}
