﻿using System;
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
    public partial class customerCreated : Form
    {
        public customerCreated()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            CustomerManagerOpen window = new CustomerManagerOpen();
            window.Show();
            this.Hide();
        }
    }
}
