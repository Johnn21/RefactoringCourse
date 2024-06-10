﻿using System.Collections.Generic;
using System;

namespace NeedsRefactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inventory = new Inventory();

            var products = new List<Product>
            {
            new Product("Laptop", 1000, 5),
            new Product("Smartphone", 500, 20),
            new Product("Tablet", 300, 15)
            };

            products.ForEach(inventory.AddProduct);

            inventory.PrintInventoryDetails();
            Console.WriteLine($"Total Inventory Value: {inventory.TotalInventoryValue}");
            Console.WriteLine($"Total Discount: {inventory.CalculateTotalDiscount()}");

            Console.ReadLine();
        }
    }
}
