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
    public partial class CreateEmployee : Form
    {
        public CreateEmployee()
        {
            InitializeComponent();
            StatusComboBox.DataSource = Enum.GetValues(typeof(EmployeesStatuses));//אתחול הקומבובוקס
            TypeComboBox.DataSource = Enum.GetValues(typeof(EmployeesTypes));//אתחול הקומבובוקס
            //StatusComboBox.DisplayMember = "Description";
         


        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CreateEmployee2_Click(object sender, EventArgs e)
        {
            Employee W = new Employee(Int32.Parse(IdTextBox.Text), NameTextBox.Text, Convert.ToInt32(numericUpDown.Value), Int32.Parse(SalaryTextBox.Text), (EmployeesTypes)Enum.Parse(typeof(EmployeesTypes), TypeComboBox.Text), (EmployeesStatuses)Enum.Parse(typeof(EmployeesStatuses), StatusComboBox.Text), 316104306, true);//יצירת עובד חדש
        }
    }
}
