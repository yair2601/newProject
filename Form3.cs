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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CreateEnployee_Click(object sender, EventArgs e)
        {
            CreateEmployee f = new CreateEmployee();
            f.Show();
            this.Hide();
        }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {

        }
    }
}
