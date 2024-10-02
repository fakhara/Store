using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    public class Store
    {
        public string Name { get; set; }
        public TimeOnly OpeningTime { get; set; }
        public TimeOnly ClosingTime { get; set; }

        public Store(string name, TimeOnly openingTime, TimeOnly closingTime)
        {
            Name = name;
            OpeningTime = openingTime;
            ClosingTime = closingTime;
        }
        public virtual List<Product> GetProducts()
        {
            // Either return an empty list or throw an exception to indicate it must be overridden
            throw new NotImplementedException("GetProducts method should be overridden in derived classes.");
        }

    }
}
