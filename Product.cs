using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubsitutePrinciple
{
    // Base class representing a product
    public class Product
    {
        protected double price;

        public Product(double price)
        {
            this.price = price;
        }

        public virtual double CalculateDiscount()
        {
            // Default discount calculation logic
            return 0.0;
        }

        public double GetPrice()
        {
            return price;
        }


    }
}
