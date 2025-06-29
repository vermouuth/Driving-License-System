using BussinessLayer;
using MyLicensesSystem.Manage.Applications.Manage.Application.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.TestTyeps
{
    public partial class frmManageTestTyeps : Form
    {
        public frmManageTestTyeps()
        {
            InitializeComponent();
        }



        private void ReloadDataView()
        {
            DataTable dt = clsTestTypes.GetTests();

            dgv_TestTypes.DataSource = dt;

            dgv_TestTypes.Columns[1].Width = 150;
            dgv_TestTypes.Columns[2].Width = 350;

            lb_records.Text = dt.Rows.Count.ToString();

        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form UpdateTest = new UpdateTestType((int)dgv_TestTypes.CurrentRow.Cells[0].Value);
            UpdateTest.ShowDialog();

            ReloadDataView();
        }

        private void frmManageTestTyeps_Load(object sender, EventArgs e)
        {
            ReloadDataView();
        }

        private void btn_Close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
