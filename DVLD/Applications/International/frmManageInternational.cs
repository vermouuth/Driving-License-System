using BussinessLayer;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalControls;
using MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms;
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

namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.InternationalForms
{
    public partial class frmManageInternational : Form
    {
        BindingSource bs = new BindingSource();

        public frmManageInternational()
        {
            InitializeComponent();
        }

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Form AddInternationalLicense = new frmAddInterLicense();
            AddInternationalLicense.ShowDialog();
        }

        private void frmManageInternational_Load(object sender, EventArgs e)
        {
            txt_Searching.Visible = (cb_Filter.SelectedIndex != 0);
            cb_Filter.SelectedIndex = 0;

            // Load Data
            DataTable Licenses = clsInternationalLicense.GetAllInternationalLicenses();
           
            // Rename DataTable Columns to match ComboBox
            Licenses.Columns[0].ColumnName = "Int.License ID";
            Licenses.Columns[1].ColumnName = "Application ID";
            Licenses.Columns[2].ColumnName = "Driver ID";
            Licenses.Columns[3].ColumnName = "L.License ID";
            Licenses.Columns[4].ColumnName = "Issue Date";
            Licenses.Columns[5].ColumnName = "Expiration Date";
            Licenses.Columns[6].ColumnName = "Is Active?";

            // Bind DataTable to BindingSource
            bs.DataSource = Licenses;
            dgv_InterList.DataSource = bs; // Use bs instead of DataTable directly

            // Update Row Count
            lb_CurrentPeople.Text = dgv_InterList.RowCount.ToString();
            
        }

        private void txt_Searching_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_Searching.Text.Trim();
            string selectColumn = cb_Filter.SelectedItem.ToString();

            if (string.IsNullOrEmpty(searchValue) || selectColumn == "None")
            {
                bs.RemoveFilter();
            }
            else
            {
                // Ensure column names match DataTable names
                Dictionary<string, string> columnMap = new Dictionary<string, string>
            {
                { "Int.License ID", "Int.License ID" }, // Matches DataTable columns
                { "Application ID", "Application ID" },
                { "Driver ID", "Driver ID" },
                { "L.License ID", "L.License ID" }
            };

                if (columnMap.ContainsKey(selectColumn))
                {
                    string actualColumn = columnMap[selectColumn]; // Get correct column name

                    if (int.TryParse(searchValue, out int ID))
                    {
                        bs.Filter = $"[{actualColumn}] = {ID}"; // Wrap column name in []
                    }
                }
            }
        }

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
           
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the character input
                }
            
        }

        private void cb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Searching.Visible = (cb_Filter.SelectedIndex != 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.FindByDriverID((int)dgv_InterList.CurrentRow.Cells[2].Value);
            Form PersonDetails = new frmPersonDetails(Driver.PersonID);
            PersonDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LicenseDetials = new frmInternationalInfo((int)dgv_InterList.CurrentRow.Cells[3].Value);
            LicenseDetials.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsDriver Driver = clsDriver.FindByDriverID((int)dgv_InterList.CurrentRow.Cells[2].Value);
            Form LicenseHistory = new frmLicenseHistory(Driver.PersonID, true);
            LicenseHistory.ShowDialog();
        } 
    }
}
