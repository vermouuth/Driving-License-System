using BussinessLayer;
using MyLicensesSystem.Manage.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLicensesSystem.Main
{
    public partial class frmAddNewUser : Form
    {


        enum enCurrentMode { Addnew, Edit};
        enCurrentMode _Current;

        clsUser _User;
        int _PersonID;

        public frmAddNewUser(int PersonID)
        {
            InitializeComponent();

            if(PersonID == -1)
            {
                _Current = enCurrentMode.Addnew;
            }
            else
            {
                _Current = enCurrentMode.Edit;
            }

            _PersonID = PersonID;
            
        }


        private void btn_SelectPerson_Click(object sender, EventArgs e)
        {
            frmFindingPerson SearchPerson = new frmFindingPerson();

            SearchPerson.xPersonBack += (object Sender, int personID) =>
            {
                ctlPersonCard1.LoadPerson(personID);
            };

            // SerchPerson.xPeersonBack += PersonBack;


            SearchPerson.ShowDialog();


        }


        //private void PersonBack(object sender, int PersonID)
        //{
        //    ctlPersonCard1.LoadPerson(PersonID);
        //}


        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_UserName_Validating(object sender, CancelEventArgs e)
        {

            if(clsUser.IsUserExist(txt_UserName.Text))
            {
                errorProvider1.SetError(txt_UserName, "User with this username is already exist");

            }

            else
            {
                errorProvider1.SetError(txt_UserName, "");  // Clears error when valid
            }
        }

        private void txt_Confirm_Validating(object sender, CancelEventArgs e)
        {
            if(txt_Password.Text != txt_Confirm.Text)
            {
                errorProvider1.SetError(txt_Confirm, "Must match password");
                
            }

            else
            {
                errorProvider1.SetError(txt_Confirm, "");  // Clears error when valid
            }
        }

      
        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (ctlPersonCard1.xID == -1)
            {

                MessageBox.Show("You must select a person first.");
                return;
            }

            if (clsUser.IsUserExist(ctlPersonCard1.xID) && _Current == enCurrentMode.Addnew)
            {
                MessageBox.Show("User is already exist enter another Person.");
                return;
            }

             tb_Logininfo.Enabled = true;
             tab_Control.SelectedTab = tb_Logininfo;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            if (txt_UserName.Text == string.Empty || txt_Password.Text == string.Empty || txt_Confirm.Text == string.Empty)
            {
                MessageBox.Show("Must Fill All Fields.");
                return;
            }
       
            _User.PersonID = ctlPersonCard1.xID;
            _User.UserName = txt_UserName.Text;
            _User.Password = txt_Password.Text;
         

            if (chb_isActive.Checked == true)
            {
                _User.isActive = true;
            }
            else
            {
                _User.isActive = false;
            }



            if (_User.Save())
            {
                MessageBox.Show($"User Saved Successfuly.");
                lb_UserID.Text = _User.UserID.ToString();
            }
            else
            {
                MessageBox.Show("SomeThing Wrong");
            }
        }

        private void frmAddNewUser_Load(object sender, EventArgs e)
        {

            if(_Current == enCurrentMode.Addnew)
            {
                btn_SelectPerson.Enabled = true;
                lb_Modeling.Text = "Add New User";
                tb_Logininfo.Enabled = false;    
                _User = new clsUser();
                return;
            }

            lb_Modeling.Text = "Editing User";
            tb_Logininfo.Enabled = true;

            tb_Logininfo.IsAccessible = true;
            ctlPersonCard1.LoadPerson(_PersonID);
            _User = clsUser.FindByID(_PersonID);
            txt_UserName.Text = _User.UserName;
            lb_UserID.Text = _User.UserID.ToString();

        }
    }
}
