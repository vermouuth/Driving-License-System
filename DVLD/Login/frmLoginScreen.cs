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

namespace MyLicensesSystem.Login.Screen
{
    public partial class frmLoginScreen : Form
    {
        public frmLoginScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsLoggedInUser.GlobalUser = clsUser.Find(txt_username.Text,txt_password.Text);

            if (clsLoggedInUser.GlobalUser != null)
            {
                if (clsLoggedInUser.GlobalUser.isActive != true)
                {

                    MessageBox.Show("Access Denaied Contact Admin!", "In Active", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                this.Hide();

                Form frmMainScreen = new MainScreen(this);
                frmMainScreen.ShowDialog();

                this.Show();
            }


            else
            {
                MessageBox.Show("Invalid Username/Passowrd", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
