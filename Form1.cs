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
    public partial class createCustomer : Form
    {
        public createCustomer()
        {
            InitializeComponent();
            activeComboBox.DataSource = Enum.GetValues(typeof(isActive)); //initiating the active comboBox
            specialCountryComboBox.DataSource = Enum.GetValues(typeof(isSpecialCountry)); //initiating the special country comboBox
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerManagerOpen window = new CustomerManagerOpen();
            window.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //creating the new customer
            Int32 ID;
            Employee emp;
            Customer c;
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
            emp = Program.seekEmployee(888); //לתקן!!!!
            c = Program.seekCustomer(ID);
            if (AllGood & c==null) //if the data entered is ok
            {
                Customer C = new Customer(ID, Nametext.ToString(), Contactname.ToString(), Contactemail.ToString(), Contactphone.ToString(), password.ToString(), Int32.Parse(importance.Text),
                    activeComboBox.ToString(), specialCountryComboBox.ToString(), emp, true);
            
            }

            customerCreated window = new customerCreated();
            window.Show();
            this.Hide();
        }
    }
}
