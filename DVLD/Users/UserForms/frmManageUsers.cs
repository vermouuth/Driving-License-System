using MyLicensesSystem.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using MyLicensesSystem.Manage.Users;
using MyLicensesSystem.Manage.Users.UserForms;

namespace MyLicensesSystem.Manage_Users
{
    public partial class frmManageUsers : Form
    {

        BindingSource bs = new BindingSource();

        public frmManageUsers()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form AddNewUser = new frmAddNewUser(-1);
            AddNewUser.ShowDialog();
            ReloadListUsers();
        }

        private void ReloadListUsers()
        {
            txt_Searching.Visible = (cb_Filter.SelectedIndex != 0);
            cb_Filter.SelectedIndex = 0;

            DataTable dtUsers = clsUser.GetData();
            bs.DataSource = dtUsers;
            dgv_ListUsers.DataSource = bs;

            dgv_ListUsers.Columns[2].Width = 545;

            lb_CurrentUsers.Text = dgv_ListUsers.RowCount.ToString();


        }
        private void frmManageUsers_Load(object sender, EventArgs e)
        {
            ReloadListUsers();
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
                if (selectColumn == "PersonID")
                {
                    // Ensure the search text is a valid number to prevent errors
                    if (int.TryParse(searchValue, out int personID))
                    {
                        bs.Filter = $"{selectColumn} = {personID}"; // Use '=' for exact match
                    }
                }

                else if (selectColumn == "UserID")
                {
                    if (int.TryParse(searchValue, out int UserID))
                    {
                        bs.Filter = $"{selectColumn} = {UserID}"; // Use '=' for exact match
                    }
                }

                else
                {
                    txt_Searching.Visible = true;
                    bs.Filter = $"{selectColumn} Like '%{searchValue}%'";
                }
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

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cb_Filter.SelectedIndex == 1 || cb_Filter.SelectedIndex == 2)   
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the character input
                }
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowUserDetails = new frmUserDetails((int)dgv_ListUsers.CurrentRow.Cells[0].Value);
            ShowUserDetails.ShowDialog();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form AddNew =  new frmAddNewUser(-1);
            AddNew.ShowDialog();
            ReloadListUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form EditUser = new frmAddNewUser((int)dgv_ListUsers.CurrentRow.Cells[1].Value);
            EditUser.ShowDialog();
            ReloadListUsers();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ChangePass = new frmChangePassword((int)dgv_ListUsers.CurrentRow.Cells[1].Value);
            ChangePass.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Buttion didn't implemented yet", "!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Buttion didn't implemented yet", "!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgv_ListUsers.CurrentRow.Cells[0].Value;

            if(UserID == clsLoggedInUser.GlobalUser.UserID)
            {
                MessageBox.Show("Cannot delete this user , caues there are conntion on data base with.");
                return;

            }

            DialogResult result = MessageBox.Show($"Are you sure you want to delete this user: {UserID}" , "Confirm",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(result == DialogResult.OK) 
            {
                MessageBox.Show("Usere delete Successfully.");
                clsUser.DeleteUser(UserID);
                ReloadListUsers();
            }

            else
            {
                return;
            }







        }
    }
}
