using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ViewStateAsp
{
    public partial class Index : System.Web.UI.Page
    {
        //List<string> mynameList = new List<string>();
        //List<string> myregList = new List<string>();
        //List<string> myemailList = new List<string>(); 


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //string name = txtName.Text;
            //string reg = txtRegi.Text;
            //string email = txtEmail.Text;
            //ViewState["name"] = name;
            //ViewState["regi"] = reg;
            //ViewState["email"] = email;
            //mynameList.Add(ViewState["name"].ToString());
            //myregList.Add(ViewState["regi"].ToString());
            //myemailList.Add(ViewState["email"].ToString());

            //txtName.Text = String.Empty;
            //txtRegi.Text = String.Empty;
            //txtEmail.Text = String.Empty;
            
            // For name List
            if (ViewState["name"]==null)
            {
                List<string> mynameList = new List<string>();
                mynameList.Add(txtName.Text);
                ViewState["name"] = mynameList;
                txtName.Text = String.Empty;
            }
            else
            {
                List<string> mynameList = (List<string>) ViewState["name"];
                mynameList.Add(txtName.Text);
                ViewState["name"] = mynameList;
                txtName.Text = string.Empty;
            }
            
            //For Registration ID List
            if (ViewState["regi"] == null)
            {
                List<string> myregiList = new List<string>();
                myregiList.Add(txtRegi.Text);
                ViewState["regi"] = myregiList;
                txtRegi.Text = String.Empty;
            }
            else
            {
                List<string> myregiList = (List<string>)ViewState["regi"];
                myregiList.Add(txtRegi.Text);
                ViewState["regi"] = myregiList;
                txtRegi.Text = string.Empty;
            }

            //For Email List
            if (ViewState["email"] == null)
            {
                List<string> myemailList = new List<string>();
                myemailList.Add(txtEmail.Text);
                ViewState["email"] = myemailList;
                txtEmail.Text = String.Empty;
            }
            else
            {
                List<string> myemailList = (List<string>)ViewState["email"];
                myemailList.Add(txtEmail.Text);
                ViewState["email"] = myemailList;
                txtEmail.Text = String.Empty;
            }

        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            //foreach (var listitem in mynameList)
            //{
            //    nameLabel.Text = ViewState["name"].ToString();
            //    regiLabel.Text = ViewState["regi"].ToString();
            //    emailLabel.Text = ViewState["email"].ToString();    
            //}

            //foreach (string VARIABLE in myregList)
            //{
                
            //}

            List<string> names = (List<string>)ViewState["name"];
            foreach (string name in names)
            {
                Response.Write(name+ "<br/>");
            }

            List<string> names1 = (List<string>)ViewState["regi"];
            foreach (string name1 in names1)
            {
                Response.Write(name1+"<br/>");
            }

            List<string> names2 = (List<string>)ViewState["email"];
            foreach (string name2 in names2)
            {
                Response.Write(name2+"<br/>");
                //emailLabel.Text = name2;
            }
            
        }
    }
}