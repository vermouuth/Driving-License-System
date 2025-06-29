using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using System.IO;
using MyLicensesSystem.Properties;

namespace MyLicensesSystem.MyControls
{
    public partial class ctlUpdate_AddPerson : UserControl
    {
        public enum enMode { AddNew = 1, UpdateMode = 2 };
        enMode _Current = enMode.UpdateMode;

        clsPerson _Person;
        int _PersonID;

      
        public ctlUpdate_AddPerson()
        {
            InitializeComponent();

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
        }

        private void _ResetDefualtValues()
        {
            //this will initialize the reset the defaule values
            FillComboBoxWithCountries();

            if (_Current == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update Person";
            }

            //set default image for the person.
            if (rbMale.Checked)
                pbPersonImage.Image = Resources.PersonMan;
            else
                pbPersonImage.Image = Resources.PersonGirl;

            //hide/show the remove linke incase there is no image for the person.
            llRemoveImage.Visible = (pbPersonImage.ImageLocation != null);

            //we set the max date to 18 years from today, and set the default value the same.
            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;

            //should not allow adding age more than 100 years
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //this will set default country to jordan.
            cbCountry.SelectedIndex = cbCountry.FindString("Jordan");

            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            rbMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";


        }

        private void FillComboBoxWithCountries()
        {
            DataTable Countries = clsCountry.GetCountries();
            
            foreach( DataRow dataRow in Countries.Rows )
            {
                cbCountry.Items.Add(dataRow["CountryName"]);
            }

            cbCountry.SelectedIndex = 0;

        }

        public void GetPersonID(int PersonID)
        {

            if (PersonID != -1)
            {
                _Current = enMode.UpdateMode;
                _Person = clsPerson.Find(PersonID);  
            }
            else
            {
                _Current = enMode.AddNew;
                _Person = new clsPerson();  
            }

            _PersonID = PersonID;
        }

        public void LoadPerson()
        {

            FillComboBoxWithCountries();

            if( _Current == enMode.AddNew )
            { 
                lblTitle.Text = "Adding New Person";
                return;
            }
    
            if( _Person == null )
            {
                MessageBox.Show("This form will be closed because No Contact with ID = " + _PersonID);
                return;

            }
           

            
            lblTitle.Text = "Editing Person's Data";

            lblPersonID.Text = _Person.PersonID.ToString();
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;
            rbFemale.Checked = (_Person.Gendor == 1);
            rbMale.Checked = (_Person.Gendor == 0);
            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;  
            txtAddress.Text = _Person.Address;
            cbCountry.SelectedIndex = cbCountry.FindString(clsCountry.Find(_Person.NationalityCountryID)._CountryName);
            llRemoveImage.Visible = _Person._ImagePath == "" ? false : true;


            if (_Person._ImagePath != "")
            {
                pbPersonImage.ImageLocation = _Person._ImagePath;
                
            }
            else
            {
                if(_Person.Gendor != 0 ) 
                {
                    pbPersonImage.Image = Properties.Resources.PersonMan;
                }
                if(_Person.Gendor == 1)
                {
                    pbPersonImage.Image = Properties.Resources.PersonGirl;

                }



            }


        }

        private void linkb_SetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "Image Filter|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = openFileDialog1.FileName;
                string saveFolderPath = @"C:\SavedImages";
                if(!Directory.Exists(saveFolderPath))
                {
                    Directory.CreateDirectory(saveFolderPath);
                }

                string newfilename = $"{Guid.NewGuid()}{Path.GetExtension(SelectedFilePath)}";
                string newFilePath = Path.Combine(saveFolderPath, newfilename);

                File.Copy(SelectedFilePath, newfilename);   

                pbPersonImage.Load(SelectedFilePath);
                llRemoveImage.Visible= true;

            }
        }

        private void linkb_Remove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(pbPersonImage.ImageLocation == "")
            {
                llRemoveImage.Visible = false;
            }

            pbPersonImage.ImageLocation = "";

        }

        private void rd_Male_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked && pbPersonImage.ImageLocation == null)
              { 
                pbPersonImage.Image = Properties.Resources.PersonMan;
              }
        }

        private void rd_Female_CheckedChanged(object sender, EventArgs e)
        {
            if(rbFemale.Checked && pbPersonImage.ImageLocation == null)
            { 
                pbPersonImage.Image = Properties.Resources.PersonGirl;
            }
        }

        private void txt_Email_Validating(object sender, CancelEventArgs e)
        {

            if(!IsValidEmail(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "Invalid email format! Must be xxxxx@xxxx.com or .net");
                txtEmail.Focus();
                e.Cancel = true; // Prevents losing focus until corrected
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEmail, ""); // Clears the error
            }
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|net)$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private void txt_NationalNo_Validating(object sender, CancelEventArgs e)
        {
            if(clsPerson.isPersonExist(txtNationalNo.Text))
            {
                errorProvider1.SetError(txtNationalNo, "National No is already Exist.");
                txtNationalNo.Focus();
                e.Cancel= true;
            }
            
            else
            {
                errorProvider1.SetError(txtNationalNo, ""); // Clears the error
                e.Cancel = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == string.Empty || txtSecondName.Text == string.Empty || txtLastName.Text == string.Empty ||
                    txtNationalNo.Text == string.Empty || txtAddress.Text == string.Empty || txtPhone.Text == string.Empty)
            {
                MessageBox.Show("You must fill all fields", "Erorr");
                return;
            }


            int CountryID = clsCountry.Find(cbCountry.Text)._CountryID;
            _Person.FirstName = txtFirstName.Text;
            _Person.SecondName = txtSecondName.Text;
            _Person.ThirdName = string.IsNullOrEmpty(txtThirdName.Text) ? null : txtThirdName.Text;
            _Person.LastName = txtLastName.Text;
            _Person.NationalNo = txtNationalNo.Text;
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Gendor = rbMale.Checked ? (byte)0 : (byte)1;
            _Person.Email = txtEmail.Text;
            _Person.Phone = txtPhone.Text;
            _Person.NationalityCountryID = CountryID;
            _Person.Address = txtAddress.Text;

            if (pbPersonImage.ImageLocation != "")
            {
                _Person._ImagePath = pbPersonImage.ImageLocation;
            }

            else
            {
                _Person._ImagePath = DBNull.Value.ToString();
            }

            if (_Person.Save())
            {
             
                MessageBox.Show("Person saved Succssuffly.","Added",MessageBoxButtons.OK,MessageBoxIcon.Information);

                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }
            }
            else
            {
                MessageBox.Show("Failed to save Person");
            }



            lblTitle.Text = "Editing Person's Data";
            lblPersonID.Text = _Person.PersonID.ToString();

        }
    }
}
