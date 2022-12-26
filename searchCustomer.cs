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
    public partial class searchCustomer : Form
    {
        bool CustomerIsGood = false;
        public static string setValueForPassID;
        public searchCustomer()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void IDcheck_TextChanged(object sender, EventArgs e)
        {

        }

        private void Check_Click(object sender, EventArgs e)
        {
            int ID;
            bool AllGood = true; //boolean to check if data is ok
            if (Int32.TryParse(IDcheck.Text, out ID)) //checking if data entered is int
            {
                ID = Int32.Parse(IDcheck.Text);
            }
            else
            {
                intError window1 = new intError(); //if not int
                AllGood = false;
                window1.Show();
            }
            if (AllGood)
            {
                Customer cus = Program.seekCustomer(Int32.Parse(IDcheck.Text)); //looking for the customer with the ID entered
                if (cus != null) //if customer desn't exist
                {
                    CustomerNotInSystemError window = new CustomerNotInSystemError();
                    AllGood = false; //changing the bool to false
                    window.Show();
                }
                else
                {
                    CustomerIsGood = true; 
                }
            }
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            if (CustomerIsGood)
            {
                UpdateCustomerInfo window1 = new UpdateCustomerInfo();
                window1.Show();
                setValueForPassID =IDcheck.ToString();
                this.Hide();
            }
        }
    }
}
