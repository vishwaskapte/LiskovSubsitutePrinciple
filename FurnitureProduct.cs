using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubsitutePrinciple
{
    public class FurnitureProduct : Product
    {
        private int warrantyMonths;

        public FurnitureProduct(double price, int warrantyMonths) : base(price)
        {
            this.warrantyMonths = warrantyMonths;
        }

        public override double CalculateDiscount()
        {
            // Custom discount calculation logic for furniture products
            return 0.15 * GetPrice(); // 15% discount for furniture
        }

        public int GetWarrantyMonths()
        {
            return warrantyMonths;
        }
    }
}
