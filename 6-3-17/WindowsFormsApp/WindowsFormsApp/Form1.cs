using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(nameofperson);
        }

        private void TextBox1(object sender, EventArgs e)
        {
            string nameofperson = name.Text;
        }

        private void PhoneNo_TextChanged(object sender, EventArgs e)
        {
            string 
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        // hoy nai try at home...
    }
}
