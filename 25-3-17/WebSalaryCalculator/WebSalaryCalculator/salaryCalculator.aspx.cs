using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSalaryCalculator
{
    public partial class salaryCalculator : System.Web.UI.Page
    {
        SalaryCalculator calculate = new SalaryCalculator();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnResult_Click(object sender, EventArgs e)
        {
            string employee = txtEmployee.Text;
            double bAmount = Convert.ToDouble(txtBasicAmount.Text);
            double hRent = Convert.ToDouble(txtHouseRent.Text);
            double mRent = Convert.ToDouble(txtMedicalRent.Text);
           
            calculate.HouseRent(bAmount, hRent);
            calculate.MedicalRent(bAmount, mRent);

            Label1.Text = employee;
            txtResult.Text = calculate.TotalAmount(bAmount).ToString();
        }
    }
}