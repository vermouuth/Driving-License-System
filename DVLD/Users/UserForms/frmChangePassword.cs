using BussinessLayer;
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

namespace MyLicensesSystem.Manage.Users
{
    public partial class frmChangePassword : Form
    {
        private clsUser _User;
        private int _PersonID;
        public frmChangePassword(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ctlPersonCard1.LoadPerson(_PersonID);
            ctlUserInfo1.LoadUser(_PersonID);

            _User = clsUser.FindByID(_PersonID);

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

            if( _User == null )
            {
                MessageBox.Show("User Does not exist.");
                return;
            }

            if(txt_Current.Text != _User.Password)
            {
                MessageBox.Show("Current password you did enter, is wrong.");
                return;
            }

            if(txt_New.Text != txt_Confirm.Text)
            {
                MessageBox.Show("Password did not match the Confirm password");
                return;
            }


            _User.Password = txt_Confirm.Text;

            if(_User.UpdateUserPass())
            {
                MessageBox.Show("Password changed successfully.");
            }

            else
            {
                MessageBox.Show("Error with User");
            }




            
        }

        private void txt_Current_Validating(object sender, CancelEventArgs e)
        {
            if(_User.Password != txt_Current.Text)
            {
                errorProvider1.SetError(txt_Current, "Password is not in the system.");
                e.Cancel = true;
            }    
            else
            {
                errorProvider1.SetError(txt_Current,"");
            }
        }

        private void txt_Confirm_Validating(object sender, CancelEventArgs e)
        {
            if(txt_New.Text!= txt_Confirm.Text) { errorProvider1.SetError(txt_Confirm, "Password does not match"); }


            else
            {
                errorProvider1.SetError(txt_Confirm, "");

            }


        }

        private void ctlPersonCard1_OnEditClicked(int obj)
        {
            frmAddUpdatePerson EditPerson = new frmAddUpdatePerson(_PersonID);
            EditPerson.ShowDialog(); 
        }
    }
}
