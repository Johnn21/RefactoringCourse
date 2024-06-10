using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedsRefactoring
{
    public class Inventory
    {
        private readonly List<Product> _products = new List<Product>();

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public double TotalInventoryValue => _products.Sum(p => p.TotalValue);

        // Calculate total discount for all products
        public double CalculateTotalDiscount()
        {
            return _products.Sum(p => p.CalculateDiscount());
        }

        // Print inventory details with discount information
        public void PrintInventoryDetails()
        {
            foreach (var product in _products)
            {
                product.PrintProductReport();
                Console.WriteLine();
            }
        }
    }
}
