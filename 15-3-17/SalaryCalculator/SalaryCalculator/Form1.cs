using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryCalculator
{
    public partial class Form1 : Form
    {
        private string ename;
        private double salary, mrent, malliance, mallianceResult, mrentResult, nettotal;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            ename = txtEmpName.Text;
            salary = Convert.ToDouble(txtBasicAmount.Text);
            nettotal = salary + mrentResult + mallianceResult;
            
            mrent = Convert.ToDouble(txtRent.Text) / 100;
            mrentResult = mrent * Convert.ToDouble(txtBasicAmount);
            malliance = Convert.ToDouble(txtMedical.Text) / 100;
            mallianceResult = malliance * Convert.ToDouble(txtBasicAmount.Text);

            MessageBox.Show(ename + " " + Convert.ToDouble(nettotal) + " ");
        }

        private void btnAmount_Click(object sender, EventArgs e)
        {

            MessageBox.Show(txtBasicAmount.Text);
            
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

            mrent = Convert.ToDouble(txtRent.Text)/100;
            mrentResult = mrent*Convert.ToDouble(txtBasicAmount);
            MessageBox.Show(mrent.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            malliance = Convert.ToDouble(txtMedical.Text)/100;
            mallianceResult = malliance*Convert.ToDouble(txtBasicAmount.Text);
            MessageBox.Show(mallianceResult.ToString());
        }
    }
}
