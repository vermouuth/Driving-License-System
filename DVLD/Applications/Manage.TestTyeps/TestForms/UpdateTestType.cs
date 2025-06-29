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

namespace MyLicensesSystem.Manage.TestTyeps
{
    public partial class UpdateTestType : Form
    {
        clsTestTypes Test;
        int _ID;
        public UpdateTestType(int ID)
        {
            InitializeComponent();
            _ID = ID;
        }
     
        private void btn_Save_Click_1(object sender, EventArgs e)
        {
            Test._Fees = Convert.ToDecimal(Txt_Fees.Text);
            Test._TestTitle = Txt_Title.Text;
            Test._TestDescription = txt_Description.Text;

            if (Test.UpdateTestInfo())
            {
                MessageBox.Show("Test type updated successfully.");
                this.Close();
                return;
            }
            else
            {
                MessageBox.Show("Some thing wrong.");

            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void UpdateTestType_Load(object sender, EventArgs e)
        {
            Test = clsTestTypes.Find(_ID);

            if (Test == null)
            {
                MessageBox.Show($"Cant Find Test With this ID: {_ID}");
                this.Close();
            }

            lb_ID.Text = Test._ID.ToString();
            Txt_Title.Text = Test._TestTitle.ToString();
            txt_Description.Text = Test._TestDescription.ToString();
            Txt_Fees.Text = Test._Fees.ToString();
        }
    }
}
