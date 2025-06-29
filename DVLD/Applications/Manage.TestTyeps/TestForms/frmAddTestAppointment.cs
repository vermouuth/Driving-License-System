using BussinessLayer;
using MyLicensesSystem.Manage.Tests.TestControls;
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
    public partial class frmAddTestAppointment : Form
    {
        
        int _LocalID = -1;
        int _TestType = -1;
        int _TestID = -1;
        public frmAddTestAppointment(int LocalID, int TestType, int TestID)
        {
            InitializeComponent();
            this._LocalID = LocalID;
            this._TestType = TestType;
            this._TestID = TestID;
        }
      
        private void frmAddTestAppointment_Load(object sender, EventArgs e)
        {
          
          ctlTestAppiontment1.LoadTestInfo(_LocalID, _TestType, _TestID);

        }

        private void ctlTestAppiontment1_OnSaveClicked(int obj)
        {
            this.Close();
        }

        
    }
}
