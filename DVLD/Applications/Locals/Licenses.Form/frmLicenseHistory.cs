using BussinessLayer;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.InternationalForms;
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

namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms
{
    public partial class frmLicenseHistory : Form
    {
        int PersonID;

        DataTable InterNationalLicenses;
        DataTable LocalLicenses;

        bool LocalOpend;
        bool InterOpend;
        public frmLicenseHistory(int LocalID)
        {
            InitializeComponent();
            this.PersonID = clsApplication.Find(clsLocalDrivingApplication.Find(LocalID)._AppID)._ApplicantionPersonID;
        }

        public frmLicenseHistory(int Person, bool isTrue = true)
        {
            InitializeComponent();
            PersonID = Person;
        }

        private void LoadGirdViews()
        {
            InterNationalLicenses = clsDriver.GetInterNationalLicense(PersonID);
            LocalLicenses = clsDriver.GetAllLocalPersonLicenses(PersonID);


            if(LocalLicenses != null) 
            {
                LocalLicenses.Columns[0].ColumnName = "Loc.Li.ID";
                LocalLicenses.Columns[1].ColumnName = "Application ID";
                LocalLicenses.Columns[2].ColumnName = "Class Name";
                LocalLicenses.Columns[3].ColumnName = "Issue Date";
                LocalLicenses.Columns[4].ColumnName = "Expiration Date";
                LocalLicenses.Columns[5].ColumnName = "Is Active ?";

                dgv_LocalList.DataSource = LocalLicenses;
                dgv_LocalList.Columns[2].Width = 180;
                dgv_LocalList.Columns[3].Width = 120;
                dgv_LocalList.Columns[4].Width = 120;
            }
            

            if(InterNationalLicenses != null)
            {
                InterNationalLicenses.Columns[0].ColumnName = "International ID";
                InterNationalLicenses.Columns[1].ColumnName = "Application ID";
                InterNationalLicenses.Columns[2].ColumnName = "License ID";
                InterNationalLicenses.Columns[3].ColumnName = "Issue Date";
                InterNationalLicenses.Columns[4].ColumnName = "Expiration Date";
                InterNationalLicenses.Columns[5].ColumnName = "Is Active ?";

                dgv_InternationalList.DataSource = InterNationalLicenses;
                dgv_InternationalList.Columns[0].Width = 110;
                dgv_InternationalList.Columns[3].Width = 120;
                dgv_InternationalList.Columns[4].Width = 120;
            }


            return;
          
        }

        private void frmLicenseHistory_Load(object sender, EventArgs e)
        {
            ctlSearchinPerson1.LoadPerson(PersonID);
            ctlSearchinPerson1.DisableFilterBox();
            LoadGirdViews();
        }

        private void ctlSearchinPerson1_OnEditClicked(int obj)
        {
            frmAddUpdatePerson Edit = new frmAddUpdatePerson(ctlSearchinPerson1.ID);
            Edit.ShowDialog();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showLicesneInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(LocalOpend)
            {
                if(LocalLicenses != null)
                {
                    Form LocalDetails = new frmLicenseInfo((int)dgv_LocalList.CurrentRow.Cells[0].Value , true);
                    LocalDetails.ShowDialog();
                    return;
                }
                
            }

            if(InterNationalLicenses != null)
            {
                Form InternationalDetials = new frmInternationalInfo((int)dgv_InternationalList.CurrentRow.Cells[2].Value);
                InternationalDetials.ShowDialog();

            }

        }

        private void dgv_LocalList_MouseDown(object sender, MouseEventArgs e)
        {
            LocalOpend = true;
            InterOpend = false;
        }

        private void dgv_InternationalList_MouseDown(object sender, MouseEventArgs e)
        {
            LocalOpend = false;
            InterOpend = true;
        }
    }
}
