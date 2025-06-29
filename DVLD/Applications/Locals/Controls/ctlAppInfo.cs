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

namespace MyLicensesSystem.Manage.Applications.Driving.Licens.Services.LocalControls
{
    public partial class ctlAppInfo : UserControl
    {
        public event Action<int> OnShowClicked;

        private int LicenseID = -1;
        protected virtual void ShowClicked(int PersonID)
        {
            Action<int> handler = OnShowClicked;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public ctlAppInfo()
        {
            InitializeComponent();
             
        }

        public void LoadApplicationData(int AppID)
        {
            clsLocalDrivingApplication LocalApplication = clsLocalDrivingApplication.GetInfo(AppID);

            if (LocalApplication == null)
            {
                MessageBox.Show($"Cannot find the LocalApplication with this CurrentApplicationID: {AppID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LicenseID = LocalApplication._LocalAppID;
            lb_AppID.Text = LocalApplication._LocalAppID.ToString();
            lb_LicenseClassName.Text = LocalApplication.ClassName;
            lb_Tests.Text = $"{LocalApplication.PassedTests}/3";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(OnShowClicked != null)
            {
                OnShowClicked(LicenseID);
            }
        }
    }
}
