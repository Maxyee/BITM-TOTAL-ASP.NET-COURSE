using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateInterest
{
    public partial class Form1 : Form
    {
        public double balance, bank, times, value;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //balance = Convert.ToDouble(txtBalance.Text);
            //bank = Convert.ToDouble(comboName.SelectedItem)/100;
            //times = Convert.ToDouble(comboYear.SelectedItem);
            //MessageBox.Show(Calculate(balance,bank,times).ToString());


            balance = Convert.ToDouble(txtBalance.Text);
            bank = Convert.ToDouble(comboName.SelectedIndex);
            if (bank == 0)
            {
                value = 5/100;
            }
            else if (bank == 1)
            {
                value = 7/100;
            }
            else if (bank == 2)
            {
                value = 8/100;
            }
            times = Convert.ToDouble(comboYear.SelectedItem);
            MessageBox.Show(Calculate(balance, value, times).ToString());
        }

        private double Calculate(double x,double y,double z)
        {
            double total = (x*y)/z;
            return total;
        }
    }
}
