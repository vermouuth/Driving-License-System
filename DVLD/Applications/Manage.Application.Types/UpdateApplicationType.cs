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
    public partial class UpdateApplicationType : Form
    {
        clsApplicationTypes _App;
        int _ID;
        public UpdateApplicationType(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }

        private void UpdateApplicationType_Load(object sender, EventArgs e)
        {
            _App = clsApplicationTypes.Find(_ID);

            if(_App == null)
            {
                MessageBox.Show($"Cant Find AppType With this ID: {_ID}");
                this.Close();
            }

            lb_ID.Text = _App._ID.ToString();
            Txt_Title.Text = _App._ApplicationTypeTile;
            Txt_Fees.Text = _App._Fees.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            _App._Fees = Convert.ToDecimal(Txt_Fees.Text);
            _App._ApplicationTypeTile = Txt_Title.Text;

            if(_App.UpdateAppFees())
            {
                MessageBox.Show("Application type updated successfully.");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Some thing wrong.");

            }

        }
    }
}
