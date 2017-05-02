using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SessionWebFormAsp
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            Session["name"] = name;
            txtName.Text = string.Empty;
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm.aspx");
        }
    }
}