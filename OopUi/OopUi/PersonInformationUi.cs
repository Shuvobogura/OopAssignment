using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopUi
{
    public partial class PersonInformationUi : Form
    {
        Person ePerson=new Person();
        public PersonInformationUi()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ePerson.FirstName = firstNameTextBox.Text;
            ePerson.MiddleName = middleNameTextBox.Text;
            ePerson.LastName = lastNameTextBox.Text;

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            fullNameTextBox.Text = ePerson.FirstName + " " + ePerson.MiddleName + " " + ePerson.LastName;
        }
    }
}
