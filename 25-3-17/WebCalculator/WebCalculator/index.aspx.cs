using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebCalculator
{
    public partial class index : System.Web.UI.Page
    {
        Calculation calculate = new Calculation();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            double fnumber = Convert.ToDouble(txtFirstNumber.Text);
            double lnumber = Convert.ToDouble(txtLastNumber.Text);
            txtResult.Text= calculate.AddNumber(fnumber, lnumber).ToString();


        }

        protected void btnSubstract_Click(object sender, EventArgs e)
        {
            double fnumber = Convert.ToDouble(txtFirstNumber.Text);
            double lnumber = Convert.ToDouble(txtLastNumber.Text);
            txtResult.Text = calculate.SubstactNumber(fnumber, lnumber).ToString();
        }

        protected void btnMultiply_Click(object sender, EventArgs e)
        {
            double fnumber = Convert.ToDouble(txtFirstNumber.Text);
            double lnumber = Convert.ToDouble(txtLastNumber.Text);
            txtResult.Text = calculate.MultiplicationNumber(fnumber, lnumber).ToString();
        }

        protected void btnDivide_Click(object sender, EventArgs e)
        {
            double fnumber = Convert.ToDouble(txtFirstNumber.Text);
            double lnumber = Convert.ToDouble(txtLastNumber.Text);
            txtResult.Text = calculate.DivideNumber(fnumber, lnumber).ToString();
        }
    }
}