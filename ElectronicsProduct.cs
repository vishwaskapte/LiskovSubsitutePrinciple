using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubsitutePrinciple
{
    // Derived class representing an electronic product
    public class ElectronicsProduct : Product
    {
        private int warrantyMonths;

        public ElectronicsProduct(double price, int warrantyMonths) : base(price)
        {
            this.warrantyMonths = warrantyMonths;
        }

        public override double CalculateDiscount()
        {
            // Custom discount calculation logic for electronic products
            return 0.1 * GetPrice(); // 10% discount for electronics
        }

        public int GetWarrantyMonths()
        {
            return warrantyMonths;
        }
    }
}
