using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDefineAppPersonUI
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        Person person = new Person();
        Person person1 = new Person();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            //Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.FathersName = txtFathersName.Text;
            person.MothersName = txtMothersName.Text;
            person.Address = txtAddress.Text;

            person1.FirstName = txtFirstName.Text;
            person1.LastName = txtLastName.Text;
            person1.FathersName = txtFathersName.Text;
            person1.MothersName = txtMothersName.Text;
            person1.Address = txtAddress.Text;

            persons.Add(person);
            persons.Add(person1);

            MessageBox.Show(person.ShowAllData(person.FirstName,person.LastName,person.FathersName,person.MothersName,person.Address));
            MessageBox.Show(person1.ShowAllData(person1.FirstName, person1.LastName, person1.FathersName, person1.MothersName, person1.Address));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            person.FathersName = txtFathersName.Text;
            person.MothersName = txtMothersName.Text;
            person.Address = txtAddress.Text;

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFathersName.Text = string.Empty;
            txtMothersName.Text = string.Empty;
            txtAddress.Text = string.Empty;
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            //Person person = new Person();
            person.FathersName = txtFathersName.Text;
            person.MothersName = txtMothersName.Text;
            MessageBox.Show(person.ParentName(person.FathersName, person.MothersName));
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            //Person person = new Person();
            person.Address = txtAddress.Text;
            MessageBox.Show(person.thikana(person.Address));
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            //Person person = new Person();
            person.FirstName = txtFirstName.Text;
            person.LastName = txtLastName.Text;
            MessageBox.Show(person.naam(person.FirstName,person.LastName));
        }
    }
}
