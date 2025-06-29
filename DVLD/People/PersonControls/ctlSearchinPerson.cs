using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyLicensesSystem.MyControls.ctlPersonCard;

namespace MyLicensesSystem
{
    public partial class ctlSearchinPerson : UserControl
    {


        public event Action<int> OnEditClicked;

        public event Action<int> OnAddClicked;

        public delegate void LoadPersonAgain(object sender, int PersonID);

        public event LoadPersonAgain OnLoadPersonAgain;


        public void LoadPerson(int PersonID)
        {
            ctlPersonCard1.LoadPerson(PersonID);
            ID = PersonID;
            txt_Searching.Text = PersonID.ToString();
        }

        public void DisableFilterBox()
        {
            groupBox1.Enabled = false;
        }
    
        protected virtual void EditClicked(int PersonID)
        {
            Action<int> handler = OnEditClicked;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        protected virtual void AddClicked(int PersonID)
        {
            Action<int> handler = OnAddClicked;
            if (handler != null)
            {
                handler(PersonID);
            }
        }

        public int ID = 0;

        public ctlSearchinPerson()
        {
            InitializeComponent();

            OnLoadPersonAgain += (object sender, int id) =>
            {
                ctlPersonCard1.LoadPerson(id);
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cb_Finding.SelectedIndex == 0)
            {
                if (ctlPersonCard1.LoadPerson(int.Parse(txt_Searching.Text)))
                {
                    ID = ctlPersonCard1.xID;
                    ll_EditInfo.Enabled = true;
                }
               
                              
            }
            else
            {
                if (ctlPersonCard1.LoadPerson(txt_Searching.Text))
                {
                    ID = ctlPersonCard1.xID;
                    ll_EditInfo.Enabled = true;

                }
            }
         }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow only numbers and control keys (Backspace, Delete, etc.)
            if (cb_Finding.SelectedIndex ==  0)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true; // Block the character input
                }
            }
           
        }

        private void txt_Searching_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox1_KeyPress(sender, e);
        }

        private void ctlSearchinPerson_Load(object sender, EventArgs e)
        {
            cb_Finding.SelectedIndex = 0;
            ll_EditInfo.Enabled=false;
        }

        private void ll_EditInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if( OnEditClicked != null )
            {
                OnEditClicked(ID);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (OnAddClicked != null)
            {
                OnAddClicked(ID);
                OnLoadPersonAgain?.Invoke(this, ID);
            }
            
        }
    }
}
