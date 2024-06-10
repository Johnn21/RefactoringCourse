using System;

namespace NeedsRefactoring
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValue => Price * Quantity;

        // Calculate discount for the product
        public double CalculateDiscount()
        {
            if (Quantity > 10)
            {
                return TotalValue * 0.1; // 10% discount for bulk purchase
            }
            return 0;
        }

        // Print detailed product report
        public void PrintProductReport()
        {
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Total Value: {TotalValue}");
            Console.WriteLine($"Discount: {CalculateDiscount()}");
        }
    }
}
