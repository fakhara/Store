﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Product
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
    }
}
