using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AccountOperation
{
    public partial class Index : System.Web.UI.Page
    {
        AccountHolder member = new AccountHolder();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            member.accountNumber = txtAccountNumber.Text;
            member.customerName = txtCustomerName.Text;

            ViewState["accountName"] = member.accountNumber;
            ViewState["customerName"] = member.customerName;

            txtAccountNumber.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
        }

        protected void btnDeposite_Click(object sender, EventArgs e)
        {
            member.Deposite(Convert.ToDouble(txtAmount.Text));
        }
    }
}