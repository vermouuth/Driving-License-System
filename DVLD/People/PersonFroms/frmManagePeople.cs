using MyLicensesSystem.ManagePeople;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;

namespace MyLicensesSystem
{
    public partial class frmManagePeople : Form
    {

        private static  DataTable _dtAllPeople = clsPerson.GetAllPeople();

        private DataTable _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID" ,
                        "NationalNo" , "FirstName", "SecondName", "ThirdName", "LastName", "Gendor",
                        "DateOfBirth","CountryName", "Phone" , "Email");

        public frmManagePeople()
        {
            InitializeComponent();
        }

        private void RefreshPeopleList()
        {
            

            DataTable _dtAllPeople = clsPerson.GetAllPeople();

            _dtPeople = _dtAllPeople.DefaultView.ToTable(false, "PersonID",
                        "NationalNo", "FirstName", "SecondName", "ThirdName", "LastName", "Gendor",
                        "DateOfBirth", "CountryName", "Phone", "Email");

            dgv_PeopleList.DataSource = _dtPeople;

            lb_CurrentPeople.Text = dgv_PeopleList.Rows.Count.ToString();

            

        }

       
        private void frmManagePeople_Load(object sender, EventArgs e)
        {
           dgv_PeopleList.DataSource= _dtPeople;
           
           cb_Filter.SelectedIndex = 0;
           lb_CurrentPeople.Text = dgv_PeopleList.Rows.Count.ToString();
            
            if(dgv_PeopleList.Rows.Count > 0)
            {
                dgv_PeopleList.Columns[0].HeaderText = "Person ID";
                dgv_PeopleList.Columns[0].Width = 110;

                dgv_PeopleList.Columns[1].HeaderText = "National No.";
                dgv_PeopleList.Columns[1].Width = 120;

                dgv_PeopleList.Columns[2].HeaderText = "First Name";
                dgv_PeopleList.Columns[2].Width = 120;

                dgv_PeopleList.Columns[3].HeaderText = "Second Name";
                dgv_PeopleList.Columns[3].Width = 140;

                dgv_PeopleList.Columns[4].HeaderText = "Third Name";
                dgv_PeopleList.Columns[4].Width = 120;

                dgv_PeopleList.Columns[5].HeaderText = "Last Name";
                dgv_PeopleList.Columns[5].Width = 120;

                dgv_PeopleList.Columns[6].HeaderText = "Gendor";
                dgv_PeopleList.Columns[6].Width = 100;

                dgv_PeopleList.Columns[7].HeaderText = "Date Of Birth";
                dgv_PeopleList.Columns[7].Width = 140;

                dgv_PeopleList.Columns[8].HeaderText = "Nationality";
                dgv_PeopleList.Columns[8].Width = 120;

                dgv_PeopleList.Columns[9].HeaderText = "Phone";
                dgv_PeopleList.Columns[9].Width = 120;

                dgv_PeopleList.Columns[10].HeaderText = "Email";
                dgv_PeopleList.Columns[10].Width = 170;
            }


        }

        private void txt_Searching_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";

            switch(cb_Filter.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                        break;

                case "National No.":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "Gendor";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;


                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;

            }

            if(txt_Searching.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtPeople.DefaultView.RowFilter = "";
                lb_CurrentPeople.Text = dgv_PeopleList.Rows.Count.ToString();
                return;
            }

            if(FilterColumn  == "PersonID")

                _dtPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, txt_Searching.Text.Trim());

            else
             
            _dtPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'" , FilterColumn, txt_Searching.Text.Trim());

            lb_CurrentPeople.Text = dgv_PeopleList.Rows.Count.ToString();


        }

        private void cb_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {         
            txt_Searching.Visible = (cb_Filter.SelectedIndex != 0);

            if(txt_Searching.Visible)
            {
                txt_Searching.Text = "";
                txt_Searching.Focus();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_Filter.SelectedIndex == 1)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the character input
                }
            }
        }

        private void btn_AddPerson_Click(object sender, EventArgs e)
        {
            Form frmAddingPerson = new frmAddUpdatePerson();
            frmAddingPerson.ShowDialog();
            RefreshPeopleList();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Buttion didn't implemented yet", "!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Buttion didn't implemented yet", "!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmShowDetails = new frmPersonDetails((int)dgv_PeopleList.CurrentRow.Cells[0].Value);
            frmShowDetails.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmEditingPerson = new frmAddUpdatePerson((int)dgv_PeopleList.CurrentRow.Cells[0].Value);
            frmEditingPerson.ShowDialog();
            RefreshPeopleList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAddingPerson = new frmAddUpdatePerson();
            frmAddingPerson.ShowDialog();
            RefreshPeopleList();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgv_PeopleList.CurrentRow.Cells[0].Value;

            if (clsPerson.isPersonExist(PersonID))
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to delete this Person: {PersonID}",
                    "Deleting", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                if (result == DialogResult.OK)
                {
                    MessageBox.Show("Person Deleted Successfully.");
                    clsPerson.DeletePerson(PersonID);
                    RefreshPeopleList();

                }

                else
                {
                    return;
                }
            }

        }
    }
}
