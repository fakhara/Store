using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    //subclass ElGiganten
    public class ElGiganten : Store
    {
        public ElGiganten() : base("ElGiganten" , new TimeOnly(9,0), new TimeOnly(22,0) {  }

        public override List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product("Laptop", 15000m),
                new Product("Smartphone", 8000m),
                new Product("Television", 12000m)
             
            };
        }

    }
}
