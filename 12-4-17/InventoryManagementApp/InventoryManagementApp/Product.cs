using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InventoryManagementApp
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
    }
}