using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AboutFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckShow_Click(object sender, EventArgs e)
        {
            if (evenCheckBox.Checked && oddCheckBox.Checked)
            {
                MessageBox.Show(@"both");
            }
            else if (oddCheckBox.Checked)
            {
                MessageBox.Show("Odd");
            }
            else if (evenCheckBox.Checked)
            {
                MessageBox.Show("Even");
            }
            else
            {
                MessageBox.Show("None");
            }
        }

        private void btnRadioShow_Click(object sender, EventArgs e)
        {
            if (evenRadioButton.Checked)
            {
                MessageBox.Show("Even");
            }
            else
            {
                MessageBox.Show("odd");
            }
        }
    }
}
