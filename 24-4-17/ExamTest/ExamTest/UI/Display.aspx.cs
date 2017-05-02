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
    public partial class Display : System.Web.UI.Page
    {
        ProductManager productManager = new ProductManager();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            List<Product> pruList = productManager.GetAllProducts();
            GridView.DataSource = pruList;
            GridView.DataBind();
        }
    }
}