using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MethodCallingForm
{
    public partial class Form1 : Form
    {
        public int firstnumber, lastnumber, result ;
        public Form1()
        {
            InitializeComponent();
        }

        private void Addition(object sender, EventArgs e)
        {
            firstnumber = Convert.ToInt32(txtFirst.Text);
            lastnumber = Convert.ToInt32(txtLast.Text);
            result = firstnumber + lastnumber;

            txtResult.Text = Convert.ToString(result);
        }

        private void Substract(object sender, EventArgs e)
        {
            firstnumber = Convert.ToInt32(txtFirst.Text);
            lastnumber = Convert.ToInt32(txtLast.Text);
            result = firstnumber - lastnumber;

            txtResult.Text = Convert.ToString(result);
        }
    }
}
