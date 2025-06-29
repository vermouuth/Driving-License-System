using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using MyLicensesSystem.ManagePeople;


namespace MyLicensesSystem.MyControls
{
    public partial class ctlPersonCard : UserControl
    {

        public event Action<int> OnEditClicked;

        public delegate void LoadDataAgain(object sender, int PersonID);
        
        public event LoadDataAgain OnLoadDataAgain;

        protected virtual void EditClicked(int PersonID)
        {
            Action<int> handler = OnEditClicked;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        private clsPerson _Person;

        public int xID = -1;
        public ctlPersonCard()
        {
            InitializeComponent();
            OnLoadDataAgain += (object sender, int persondid) =>
            {
                LoadPerson(persondid);
            };
        }


        public bool LoadPerson(int PersonID)
        {
            bool isFound =  false;

            _Person = clsPerson.Find(PersonID);

            if (_Person == null ) 
            {
                MessageBox.Show($"Person Cannot Found! ID: {PersonID} " ,"Erorr", MessageBoxButtons.OK , MessageBoxIcon.Error);
                isFound = false;
                return isFound;
            }

            isFound = true;

            xID = _Person.PersonID;
            lb_PersonID.Text = _Person.PersonID.ToString();
            lb_Name.Text = _Person.FullName;
            lb_NationalNo.Text = _Person.NationalNo;
            
            if(_Person.Gendor != 0)
            {
                lb_Gendor.Text = "Female";
                Pic_Gendor.Image = Properties.Resources.Female;

                if (_Person._ImagePath == "")
                {
                    px_PersonPic.Image = Properties.Resources.PersonGirl;

                }
                else
                {
                    px_PersonPic.Load(_Person._ImagePath);
                }


            }

            else
            {
                lb_Gendor.Text = "Male";
                Pic_Gendor.Image = Properties.Resources.Male;
                if (_Person._ImagePath == "")
                {
                    px_PersonPic.Image = Properties.Resources.PersonMan;

                }
                else
                {
                    px_PersonPic.Load(_Person._ImagePath);
                }


            }



            lb_Email.Text = _Person.Email;
            lb_Address.Text = _Person.Address;
            lb_DateOfBirth.Text = _Person.DateOfBirth.ToString("yyyy-MM-dd");
            lb_Phone.Text = _Person.Phone;
            lb_Country.Text = _Person.CountryInfo._CountryName;

            return isFound;
            
        }

        public bool LoadPerson(string NationalNo)
        {
            bool isFound = false;   

            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                MessageBox.Show($"Person Cannot Found! NationalNo: {NationalNo} ", "Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isFound = false;

                return isFound;     
            }


             isFound = true;
             xID = _Person.PersonID;
             lb_PersonID.Text = _Person.PersonID.ToString();
             lb_Name.Text = _Person.FullName;
             lb_NationalNo.Text = _Person.NationalNo;

            if (_Person.Gendor != 0)
            {
                lb_Gendor.Text = "Female";
                Pic_Gendor.Image = Properties.Resources.Female;

                if (_Person._ImagePath == "")
                {
                    px_PersonPic.Image = Properties.Resources.PersonGirl;

                }
                else
                {
                    px_PersonPic.Load(_Person._ImagePath);
                }


            }

            else
            {
                lb_Gendor.Text = "Male";
                Pic_Gendor.Image = Properties.Resources.Male;
                if (_Person._ImagePath == "")
                {
                    px_PersonPic.Image = Properties.Resources.PersonMan;

                }
                else
                {
                    px_PersonPic.Load(_Person._ImagePath);
                }


            }



            lb_Email.Text = _Person.Email;
            lb_Address.Text = _Person.Address;
            lb_DateOfBirth.Text = _Person.DateOfBirth.ToString("yyyy-MM-dd");
            lb_Phone.Text = _Person.Phone;
            lb_Country.Text = _Person.CountryInfo._CountryName;

            return isFound;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddUpdatePerson updatePerson = new frmAddUpdatePerson(xID);
            updatePerson.ShowDialog();
            OnLoadDataAgain?.Invoke(sender, xID);

        }


    }
}
