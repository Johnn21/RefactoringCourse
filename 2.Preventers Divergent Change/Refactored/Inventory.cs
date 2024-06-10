using System.Collections.Generic;

namespace Refactored
{
    public class Inventory
    {
        public readonly List<Product> Products = new List<Product>();
        public double TotalInventoryValue => InventoryPriceCalculator.CalculateTotalValue(Products);

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
    }
}
