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
    public partial class CustomerManagerOpen : Form
    {
        public CustomerManagerOpen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            createCustomer window = new createCustomer();
            window.Show();
            this.Hide();
        }

        private void update_Customer_Click(object sender, EventArgs e)
        {
            searchCustomer window2 = new searchCustomer();
            window2.Show();
            this.Hide();
        }
    }
}
