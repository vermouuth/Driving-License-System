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

namespace MyLicensesSystem.MyControls.UserControls
{
    public partial class ctlUserInfo : UserControl
    {
       private clsUser _User;
        public ctlUserInfo()
        {
            InitializeComponent();
        }

        public void LoadUser(int UserID)
        {
            _User = clsUser.FindByID(UserID);

            if (_User == null ) 
            {
                MessageBox.Show("User does not exist");
                return;
            }

            lb_UserName.Text = _User.UserName;
            lb_UserID.Text = _User.UserID.ToString();
            if(_User.isActive) { lb_IsActie.Text = "1"; }
            if(!_User.isActive) { lb_IsActie.Text = "0"; }
                
            
        }

    }
}
