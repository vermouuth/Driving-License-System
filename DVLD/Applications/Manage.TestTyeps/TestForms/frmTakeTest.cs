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
    public partial class frmTakeTest : Form
    {
        int TestApp;
        public frmTakeTest(int TestAppID)
        {
            InitializeComponent();
            TestApp = TestAppID;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctlTakeTest1.LoadTestInfo(TestApp);
        }
    }
}
