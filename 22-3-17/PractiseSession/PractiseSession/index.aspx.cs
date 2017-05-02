using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PractiseSession
{
    public partial class index : System.Web.UI.Page
    {
        //public string firstname;
        //public string middlename;
        //public string lastname;

        //public string FullName()
        //{
        //    return firstname + " " + middlename + " " + lastname;
        //}

        //public string ReverseName()
        //{
        //    char[] cArray = FullName().ToCharArray();
        //    string reverse = String.Empty;
        //    for (int i = cArray.Length - 1; i > -1; i--)
        //    {
        //        reverse += cArray[i];
        //    }
        //    return reverse;
        //}



        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Person person1 = new Person();
            person1.firstname = txtFirst.Text;
            person1.middlename = txtMiddle.Text;
            person1.lastname = txtLast.Text;

            txtFull.Text = person1.FullName();
            txtReverse.Text = person1.ReverseName();
        }
    }
}