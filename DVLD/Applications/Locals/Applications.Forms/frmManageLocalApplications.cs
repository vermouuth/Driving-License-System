using BussinessLayer;
using MyLicensesSystem.Manage.Applications.Driving.Licens.Services.New.Local.License;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms;
using MyLicensesSystem.Manage.Applications.Manage.TestTyeps.TestForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalForms
{
    public partial class frmManageLocalApplications : Form
    {

        private static DataTable dtAllApps = clsLocalDrivingApplication.GetLocalApps();

        private DataTable _dtApps = dtAllApps.DefaultView.ToTable(false, "LocalDrivingLicenseApplicationID", "ClassName"
                                   , "NationalNo", "FullName", "ApplicationDate", "PassedTestCount", "Status");


        int CurrentApplicationID = -1;
        int CurrentLocalAppID = -1;
        public frmManageLocalApplications()
        {
            InitializeComponent();
        }

        private void RefreshApplicationList()
        {

            DataTable dtAllApps = clsLocalDrivingApplication.GetLocalApps();

             _dtApps = dtAllApps.DefaultView.ToTable(false, "LocalDrivingLicenseApplicationID", "ClassName"
                                   , "NationalNo", "FullName", "ApplicationDate", "PassedTestCount", "Status");


            dgv_LocalApplicationList.DataSource = _dtApps;

            lb_CurrentApps.Text = dgv_LocalApplicationList.RowCount.ToString();


        }

        private void frmManageLocalApplications_Load(object sender, EventArgs e)
        {
            dgv_LocalApplicationList.DataSource = _dtApps;

            cb_Filter.SelectedIndex = 0;
            lb_CurrentApps.Text = dgv_LocalApplicationList.Rows.Count.ToString();

            if(dgv_LocalApplicationList.Rows.Count > 0)
            {
                dgv_LocalApplicationList.Columns[0].HeaderText = "Local.App.ID";
                dgv_LocalApplicationList.Columns[0].Width = 150;


                dgv_LocalApplicationList.Columns[1].HeaderText = "Class";
                dgv_LocalApplicationList.Columns[1].Width = 220;


                dgv_LocalApplicationList.Columns[2].HeaderText = "National No.";
                dgv_LocalApplicationList.Columns[2].Width = 120;


                dgv_LocalApplicationList.Columns[3].HeaderText = "Full Name";
                dgv_LocalApplicationList.Columns[3].Width = 220;


                dgv_LocalApplicationList.Columns[4].HeaderText = "App Date";
                dgv_LocalApplicationList.Columns[4].Width = 160;


                dgv_LocalApplicationList.Columns[5].HeaderText = "Passed Tests";
                dgv_LocalApplicationList.Columns[5].Width = 120;


                dgv_LocalApplicationList.Columns[6].HeaderText = "Stauts";
                dgv_LocalApplicationList.Columns[6].Width = 150;
            }



        }

        private void txt_Searching_TextChanged(object sender, EventArgs e)
        {

            string FilterCoulmn = "";

            switch (cb_Filter.Text)
            {
                case "Local.App.ID":
                    FilterCoulmn = "LocalDrivingLicenseApplicationID";
                    break;

                case "Class":
                    FilterCoulmn = "ClassName";
                    break;

                case "National No.":
                    FilterCoulmn = "NationalNo";
                    break;

                case "Full Name":
                    FilterCoulmn = "FullName";
                    break;

                case "Passed Tests":
                    FilterCoulmn = "PassedTestCount";
                    break;

                case "Status":
                    FilterCoulmn = "Stauts";
                    break;

                default:
                    FilterCoulmn = "None";
                    break;
            }


            if(txt_Searching.Text.Trim() == "" || FilterCoulmn == "None")
            {
                _dtApps.DefaultView.RowFilter = "";
                lb_CurrentApps.Text = dgv_LocalApplicationList.Rows.Count.ToString();
                return;
            }

            if (FilterCoulmn == "LocalDrivingLicenseApplicationID")

                _dtApps.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCoulmn, txt_Searching.Text.Trim());


            else

                _dtApps.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterCoulmn, txt_Searching.Text.Trim());

            lb_CurrentApps.Text = dgv_LocalApplicationList.Rows.Count.ToString();





        }

        private void cb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Searching.Visible = (cb_Filter.SelectedIndex != 0);

            if(txt_Searching.Visible)
            {
                txt_Searching.Text = "";
                txt_Searching.Focus();
            }

        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_Filter.SelectedIndex == 1 || cb_Filter.SelectedIndex == 6)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the character input
                }
            }
        }
        
        private void cts_TestDetails_Opened(object sender, EventArgs e)
        {

            CurrentLocalAppID = (int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value;
            CurrentApplicationID = clsLocalDrivingApplication.Find((CurrentLocalAppID))._AppID;

            ToolStripMenuItem stripMenuItem = (ToolStripMenuItem)cts_TestDetails.Items[6];

            // Sechedule Tests Item
            cts_TestDetails.Items[6].Enabled = (int)dgv_LocalApplicationList.CurrentRow.Cells[5].Value != 3;
            stripMenuItem.DropDownItems[0].Enabled = (int)dgv_LocalApplicationList.CurrentRow.Cells[5].Value == 0;
            stripMenuItem.DropDownItems[1].Enabled = (int)dgv_LocalApplicationList.CurrentRow.Cells[5].Value == 1;
            stripMenuItem.DropDownItems[2].Enabled = (int)dgv_LocalApplicationList.CurrentRow.Cells[5].Value == 2;




            cts_TestDetails.Items[8].Enabled = ((int)dgv_LocalApplicationList.CurrentRow.Cells[5].Value == 3) && (!clsApplication.IsAppHasLicense(CurrentApplicationID));
            cts_TestDetails.Items[11].Enabled = clsApplication.IsAppHasLicense(CurrentApplicationID);
            cts_TestDetails.Items[13].Enabled = clsApplication.IsAppHasLicense(CurrentApplicationID);
            cts_TestDetails.Items[2].Enabled = (string)dgv_LocalApplicationList.CurrentRow.Cells[6].Value == "New";
            cts_TestDetails.Items[3].Enabled = (string)dgv_LocalApplicationList.CurrentRow.Cells[6].Value == "New";
            cts_TestDetails.Items[5].Enabled = (string)dgv_LocalApplicationList.CurrentRow.Cells[6].Value == "New";





        }

        private void showApplicationDetails_Click(object sender, EventArgs e)
        {
            Form ShowAppDetails = new frmShowAppDetails((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value);
            ShowAppDetails.ShowDialog();
        }

        private void btn_AddLocalApp_Click(object sender, EventArgs e)
        {
            Form AddNewApp = new frmAddLocalApp(-1,1);
            AddNewApp.ShowDialog();

            RefreshApplicationList();
        }

        private void EditApplicationDetials_Click(object sender, EventArgs e)
        {
            Form EditApp = new frmAddLocalApp((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value, 1);
            EditApp.ShowDialog();

            RefreshApplicationList();
        }

        private void deleteApplicationdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LocalApplication = (int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value;
            DialogResult Result = MessageBox.Show($"Are you sure you want to delete this All Applcation {LocalApplication}", "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

          
            if(Result == DialogResult.OK)
            {
                if(!clsApplication.IsAppHasLicense(CurrentApplicationID))
                {
                    clsLocalDrivingApplication.DeleteLocalApp(CurrentLocalAppID);
                    clsApplication.DeleteApplication(CurrentApplicationID);

                    MessageBox.Show("Application Deleted Successfully.","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Application Has License Cannot Delete it.", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }

            RefreshApplicationList();
            
        }

        private void VisionTest_Click(object sender, EventArgs e)
        {
            Form VisionTest = new frmMainTest((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value,1);
            VisionTest.ShowDialog();
            RefreshApplicationList();
                

        }

        private void segoeUI9ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form TheoryTest = new frmMainTest((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value, 2);
            TheoryTest.ShowDialog();
            RefreshApplicationList();
        }

        private void secheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PracticalTest = new frmMainTest((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value, 3);
            PracticalTest.ShowDialog();
            RefreshApplicationList();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form IssueLicense = new frmIssueNewLicense((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value);
            IssueLicense.ShowDialog();
            RefreshApplicationList();
        }

        private void showLicenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form LicenseInfo = new frmLicenseInfo((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value);
            LicenseInfo.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowLicenses = new frmLicenseHistory((int)dgv_LocalApplicationList.CurrentRow.Cells[0].Value);
            ShowLicenses.ShowDialog();
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This strip didn't Impleminted yet." , "Implemtation" , MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return;
        }
    }
}
