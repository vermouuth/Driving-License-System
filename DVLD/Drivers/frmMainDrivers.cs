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

namespace MyLicensesSystem.Manage.Drivers
{
    public partial class frmMainDrivers : Form
    {

        BindingSource bs = new BindingSource();


        public frmMainDrivers()
        {
            InitializeComponent();
        }


        private void ReLoadDataInGridView()
        {
            txt_Searching.Visible = (cbxFilter.SelectedIndex != 0);
            cbxFilter.SelectedIndex = 0;


            DataTable dtPeople = clsDriver.GetDrivers();

            dtPeople.Columns[4].ColumnName = "Date";
            dtPeople.Columns[5].ColumnName = "Active Licenses";


            bs.DataSource = dtPeople;
            dgv_DriversList.DataSource = bs;

            dgv_DriversList.Columns[3].Width = 200;
            dgv_DriversList.Columns[4].Width = 120;



            lb_Records.Text = dgv_DriversList.RowCount.ToString();



        }
        private void txt_Searching_TextChanged(object sender, EventArgs e)
        {
            string searchValue = txt_Searching.Text.Trim();
            string selectColumn = cbxFilter.SelectedItem.ToString();


            if (string.IsNullOrEmpty(searchValue) || selectColumn == "None")
            {
                bs.RemoveFilter();
            }


            else
            {
                if (selectColumn == "NationalNo" || selectColumn == "Full Name")
                {
                    // Ensure the search text is a valid number to prevent errors


                    txt_Searching.Visible = true;
                    bs.Filter = $"{selectColumn} Like '%{searchValue}%'";

                  
                }
                else
                {
                    if (int.TryParse(searchValue, out int ID))
                    {
                        bs.Filter = $"{selectColumn} = {ID}"; // Use '=' for exact match
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainDrivers_Load(object sender, EventArgs e)
        {
            ReLoadDataInGridView();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Searching.Visible = (cbxFilter.SelectedIndex != 0);

        }

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbxFilter.SelectedIndex == 1 || cbxFilter.SelectedIndex == 2)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the character input
                }
            }
        }
    }
}
