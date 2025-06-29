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
    public partial class ctlApplicationBasicInfo : UserControl
    {

        public event Action<int> OnViewClicked;


        private clsApplication BasicApplcation;
        private int ApplicationID = -1;

        protected virtual void ShowClicked(int PersonID)
        {
            Action<int> handler = OnViewClicked;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public void LoadApplicationInfo(int ApplicationID)
        {
            BasicApplcation = clsApplication.BasicApplicationInfo(ApplicationID);

            if (BasicApplcation == null)
            {
                MessageBox.Show($"Cannot Find Application you did enter ID: {ApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ApplicationID = BasicApplcation._ApplicationID;
            lb_AppID.Text = BasicApplcation._ApplicationID.ToString();
            lb_Status.Text = BasicApplcation.Status;
            lb_Fees.Text = BasicApplcation._PaidFees.ToString();
            lb_Type.Text = BasicApplcation.AppTypeName;
            lb_Name.Text = BasicApplcation.FullName;
            lb_Date.Text = BasicApplcation._ApplicationDate.ToString("dd/MMM/yyyy");
            lb_StatusDate.Text = BasicApplcation._LastStatusDate.ToString("dd/MMM/yyyy");
            lb_UserName.Text = BasicApplcation.CreatedBy;



        }


        public ctlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(OnViewClicked != null)
            {
                OnViewClicked(ApplicationID);
            }
        }
    }
}
