namespace Refactored
{
    public class Product
    {
        public string Name { get; }
        public double Price { get; }
        public int Quantity { get; }
        public double TotalValue { get; set; }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TotalValue = ProductPriceCalculator.CalculateTotalValue(this);
        }
    }
}
