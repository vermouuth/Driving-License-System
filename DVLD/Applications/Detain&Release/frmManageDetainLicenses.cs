using BussinessLayer;
using MyLicensesSystem.ManagePeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Manage.Applications.Driving.Licenses.Services.LocalForms
{
    public partial class frmManageDetainLicenses : Form
    {

        BindingSource Bs = new BindingSource();
        public frmManageDetainLicenses()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ReleaseLicense_Click(object sender, EventArgs e)
        {
            Form Release = new frmReleaseLicense();
            Release.ShowDialog();
            LoadGridView();

        }

        private void btn_BlockLicense_Click(object sender, EventArgs e)
        {
            Form Block = new frmDetianLicense();
            Block.ShowDialog();
            LoadGridView();
        }

        private void LoadGridView()
        {
            txt_Searching.Visible = (cb_Filter.SelectedIndex != 0);
            cb_Filter.SelectedIndex = 0;

            DataTable Licenses = clsDetainedLicenses.GetDetainedLicenses();


            Licenses.Columns[0].ColumnName = "D.ID";
            Licenses.Columns[1].ColumnName = "L.ID";
            Licenses.Columns[2].ColumnName = "D.Date";
            Licenses.Columns[3].ColumnName = "Is Released";
            Licenses.Columns[4].ColumnName = "Fine Fees";
            Licenses.Columns[5].ColumnName = "Release Date";
            Licenses.Columns[6].ColumnName = "N.No.";
            Licenses.Columns[7].ColumnName = "Full Name";
            Licenses.Columns[8].ColumnName = "Release App.ID";

            Bs.DataSource = Licenses;
            dgv_DetianedLicenses.DataSource = Bs;

            dgv_DetianedLicenses.Columns[2].Width = 120;
            dgv_DetianedLicenses.Columns[5].Width = 120;
            dgv_DetianedLicenses.Columns[7].Width = 210;
            dgv_DetianedLicenses.Columns[8].Width = 120;


            lb_CurrentPeople.Text = dgv_DetianedLicenses.RowCount.ToString();


        }

        private void frmManageDetainLicenses_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void cb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Searching.Visible = (cb_Filter.SelectedIndex != 0);

        }

        private void txt_Searching_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_Searching.Text.Trim();
            string selectColumn = cb_Filter.SelectedItem?.ToString(); // Ensure it's not null

            if (string.IsNullOrEmpty(searchValue) || string.IsNullOrEmpty(selectColumn) || selectColumn == "None")
            {
                Bs.RemoveFilter();
                return;
            }

            // Mapping dropdown names to actual DataTable column names
            Dictionary<string, string> columnMap = new Dictionary<string, string>
             {
                 { "Detained ID", "D.ID" },
                 { "License ID", "L.ID" },
                 { "Detained Date", "D.Date" },
                 { "Is Released", "Is Released" },
                 { "Fine Fees", "Fine Fees" },
                 { "Release Date", "Release Date" },
                 { "National No", "N.No." },
                 { "Full Name", "Full Name" },
                 { "Release App ID", "Release App.ID" }
             };

            if (columnMap.ContainsKey(selectColumn))
            {
                string actualColumn = columnMap[selectColumn]; // Get correct column name

                if (actualColumn == "Full Name" || actualColumn == "N.No.")
                {
                    // Text-based filtering (LIKE for partial matches)
                    Bs.Filter = $"[{actualColumn}] LIKE '%{searchValue}%'";
                }
                else if (decimal.TryParse(searchValue, out _))
                {
                    // Numeric filtering (for integers and decimal values)
                    Bs.Filter = $"[{actualColumn}] = {searchValue}";
                }
                else if (DateTime.TryParse(searchValue, out _))
                {
                    // Date filtering (Assuming correct format)
                    Bs.Filter = $"CONVERT([{actualColumn}], 'System.String') LIKE '%{searchValue}%'";
                }
            }
        }

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_Filter.SelectedIndex == 1 || cb_Filter.SelectedIndex == 2 || cb_Filter.SelectedIndex == 5  || cb_Filter.SelectedIndex == 9)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the character input
                }
            }
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form PersonDetails = new frmPersonDetails(clsPerson.Find((string)dgv_DetianedLicenses.CurrentRow.Cells[6].Value).PersonID);
            PersonDetails.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LicesneDetails = new frmLicenseInfo((int)dgv_DetianedLicenses.CurrentRow.Cells[1].Value, true);
            LicesneDetails.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form LicenseHistory = new frmLicenseHistory(clsPerson.Find((string)dgv_DetianedLicenses.CurrentRow.Cells[6].Value).PersonID, true);
            LicenseHistory.ShowDialog();
        }
    }
}
