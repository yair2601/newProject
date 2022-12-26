using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class UpdateCustomerInfo : Form
    {
        Customer c;
       public string customerID;
        public UpdateCustomerInfo()
        {
            InitializeComponent();
        }

        private void search_load( object sender, EventArgs e)
        {
            IDtext.Text = searchCustomer.setValueForPassID;
        }

        private void UpdateCustomerInfo_Load(object sender, EventArgs e)
        {
            c = Program.seekCustomer(Int32.Parse(IDtext.ToString()));
            Nametext.Text = c.getName().ToString();
            Contactname.Text = c.getContactName().ToString();
            Contactemail.Text = c.getEmail().ToString();
            Contactphone.Text = c.getContactPhone().ToString();
            password.Text = c.getPassword().ToString();
            importance.Value = c.getImportance();
            activeComboBox.SelectedValue = c.getActive().ToString();
            specialCountryComboBox.SelectedValue = c.getSpecialCountry().ToString();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            searchCustomer window = new searchCustomer();
            window.Show();
            this.Hide();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            Int32 ID;
            Customer cus;
            bool AllGood = true; //boolean to check if data is from the correct types
            if (Int32.TryParse(IDtext.Text, out ID)) //checking if it's int
            {
                ID = Int32.Parse(IDtext.Text);
            }
            else
            {
                intError window1 = new intError(); //if it's not int
                AllGood = false;
                window1.Show();
            }
            cus = Program.seekCustomer(ID); //looking for the customer
            if (AllGood & cus!=null) //if the data entered is ok and CUSTOMER'S ID IS VALID
            {
                // להוסיף עדכון לנתונים של הלקוחות!!!
                // אפשר פשוט להוסיף שורה לכל SET ואז לעשות כאן רק SET.
                customerUpdated w = new customerUpdated();
                w.Show();
                this.Hide();
            }
        }
    }
}
