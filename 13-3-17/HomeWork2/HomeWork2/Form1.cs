using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork2
{
    public partial class Form1 : Form
    {
        //public List<double> numbers = new List<double>(); 
        private double number;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(txtNumber.Text);
           // numbers.Add(number);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double total = 0;

            for (int i = 0; i < number; i++)
            {
                lstBoxNumber.Items.Add(i);
                total += i;
            }
            //foreach (var aNumber in numbers)
            //{
            //    lstBoxNumber.Items.Add(i);
            //    total += i;
            //}
            txtResult.Text = total.ToString();
        }
    }
}
