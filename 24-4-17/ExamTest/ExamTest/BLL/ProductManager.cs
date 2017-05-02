using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ExamTest.DAL;
using ExamTest.Models;

namespace ExamTest.BLL
{
    public class ProductManager
    {
        ProductGateway productGateway = new ProductGateway();
        public string Save(Product pro)
        {
            string message = "";
            int row = productGateway.Insert(pro);
            if (row > 0)
            {
                message = "Saved Successful";
            }
            else
            {
                message = "Saved Failed";
            }
            return message;
        }

        public List<Product> GetAllProducts()
        {
            return productGateway.GetAllProducts();
        }
    }
}