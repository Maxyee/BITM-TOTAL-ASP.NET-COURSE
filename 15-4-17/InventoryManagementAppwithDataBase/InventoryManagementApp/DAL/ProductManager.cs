using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementApp.DAL
{
    public class ProductManager
    {
        ProductGateway product = new ProductGateway();

        public bool IsCodeIsExist(string code)
        {
            bool isCodeExist = false;
            Product aProduct = productGateway.GetProductByCode(code);
            if (aProduct.Code != null)
            {
                isCodeExist = true;
            }
            return isCodeExist;
        }

        public List<Product> GetAllProducts()
        {
            List<Product> products = productGateway.GetAllProducts();
        } 
    }
}