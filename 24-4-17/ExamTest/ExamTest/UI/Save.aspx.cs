using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ExamTest.BLL;
using ExamTest.Models;

namespace ExamTest.UI
{
    public partial class Save : System.Web.UI.Page
    {
        ProductManager productManager = new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            Product pro = new Product();

            //string s = txtProductCode.Text;
            //int q = Convert.ToInt32(txtQuantity.Text);
            /*
            if (s.Length>3)
            {
                pro.productCode = txtProductCode.Text;                    
            }
            else
            {
                msgLabel.Text = "You have to import at least three character for product code";
            }
             */
            pro.productCode = txtProductCode.Text;    
            pro.description = txtDescription.Text;
            //if (q < 0)
            //{
            //    pro.quantity = Convert.ToInt32(txtQuantity.Text);
            //}
            //else
            //{
            //    msgLabel.Text = "You Cannot import negetive number";
            //}
            pro.quantity = Convert.ToInt32(txtQuantity.Text);

            string message = productManager.Save(pro);
            msgLabel.Text = message;
        }
    }
}