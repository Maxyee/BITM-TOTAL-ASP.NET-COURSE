using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using InventoryManagementSystemApp.BLL;
using InventoryManagementSystemApp.Models;

namespace InventoryManagementSystemApp.UI
{
    public partial class Index : System.Web.UI.Page
    {
        ProductManager productManager=new ProductManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            /*
            if (Request.QueryString["ProductCode"]!=null)
            {
                                
            }
             */
        }
     
        protected void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Product aProduct = new Product();
                aProduct.Code = codeTextBox.Text;
                aProduct.Name = nameTextBox.Text;
                aProduct.UnitPrice = Convert.ToDouble(unitPriceTextBox.Text);
                aProduct.Quantity = Convert.ToInt32(quantityTextBox.Text);
          
                int rowAffected = productManager.SaveProduct(aProduct);

                if (rowAffected > 0)
                {
                    msgLabel.Text = "Saved Successfull!";
                }
                else
                {
                    msgLabel.Text = "Save Failed!";
                }
            }
            catch (Exception exception)
            {
               msgLabel.Text= exception.Message;
            }
           
            
            
        }

        

        protected void showButton_Click(object sender, EventArgs e)
        {
            List<Product> productList = productManager.GetAllProducts();
            productGridView.DataSource = productList;
            productGridView.DataBind();

        }

        

      

       

    }
}