using System;

namespace Refactored
{
    public static class ProductPrinter
    {
        public static void PrintProductReport(Product product)
        {
            Console.WriteLine($"Product Name: {product.Name}");
            Console.WriteLine($"Price: {product.Price}");
            Console.WriteLine($"Quantity: {product.Quantity}");
            Console.WriteLine($"Total Value: {product.TotalValue}");
            Console.WriteLine($"Discount: {ProductPriceCalculator.CalculateDiscount(product)}");
        }
    }
}
