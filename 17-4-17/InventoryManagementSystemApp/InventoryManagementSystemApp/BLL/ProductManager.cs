using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InventoryManagementSystemApp.DAL;
using InventoryManagementSystemApp.Models;

namespace InventoryManagementSystemApp.BLL
{
    public class ProductManager
    {
        ProductGateway productGateway=new ProductGateway();
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
            return products;
        }

        public Product GetProductByCode(string code)
        {
            Product product = productGateway.GetProductByCode(code);
            return product;
        }

        public int SaveProduct(Product aProduct)
        {
            bool isCodeExist = IsCodeIsExist(aProduct.Code);
            if (isCodeExist)
            {
                throw new Exception("Product code is already Exist!");
            }
            int row = productGateway.SaveProduct(aProduct);
            return row;

        }
    }
}