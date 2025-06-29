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

namespace MyLicensesSystem.Manage.Applications.Manage.Application.Types
{
    public partial class frmApplicationTypes : Form
    {
        public frmApplicationTypes()
        {
            InitializeComponent();
        }

        private void ReloadDataView()
        {
            DataTable dt = clsApplicationTypes.GetApps();
            dgv_ApplicationTypes.DataSource = dt;

            dgv_ApplicationTypes.Columns[1].Width = 500;

            lb_records.Text = dt.Rows.Count.ToString();
                      
        }

        private void frmApplicationTypes_Load(object sender, EventArgs e)
        {
           ReloadDataView();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form UpdateApp = new UpdateApplicationType((int)dgv_ApplicationTypes.CurrentRow.Cells[0].Value);
            UpdateApp.ShowDialog();

            ReloadDataView();
        }
    }
}
