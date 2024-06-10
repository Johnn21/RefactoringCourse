using System.Collections.Generic;
using System.Linq;

namespace Refactored
{
    public static class InventoryPriceCalculator
    {
        public static double CalculateTotalValue(List<Product> products) 
            => products.Sum(product => product.TotalValue);

        public static double CalculateTotalDiscount(List<Product> products) =>
            products.Sum(product => ProductPriceCalculator.CalculateDiscount(product));
    }
}
