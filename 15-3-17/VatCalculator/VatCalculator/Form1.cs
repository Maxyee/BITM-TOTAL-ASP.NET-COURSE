using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VatCalculator
{
    //public double rice, fish, meat, total, discounttotal, vattotal;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            double rice = Convert.ToDouble(txtRice.Text)*30;
            double fish = Convert.ToDouble(txtFish.Text)*80;
            double meat = Convert.ToDouble(txtMeat.Text)*120;

            //txtTotal.Text = Convert.ToString(rice + fish + meat);
            txtTotal.Text = CalculateTotal(rice , fish, meat).ToString();
        }

        private void btnNet_Click(object sender, EventArgs e)
        {
            double rice = Convert.ToDouble(txtRice.Text) * 30;
            double fish = Convert.ToDouble(txtFish.Text) * 80;
            double meat = Convert.ToDouble(txtMeat.Text) * 120;

            double totalprice = rice + fish + meat;

            double dicount = (totalprice*Convert.ToDouble(txtDiscount.Text)/100);
            double discounttotal = totalprice - dicount;
            double vat = (discounttotal*5)/100;
            double vattotal = discounttotal + vat;

            MessageBox.Show("Net Bill = " + vattotal.ToString());

        }

        private double CalculateTotal(double x, double y, double z)
        {
            double i = x + y + z;
            return i;
        }
    }
}
