namespace Refactored
{
    public static class ProductPriceCalculator
    {
        public static double CalculateTotalValue(Product product) 
            => product.Price * product.Quantity;

        // Calculate discount for the product
        public static double CalculateDiscount(Product product) 
            => product.Quantity > 10 ? product.TotalValue * 0.1 : 0;
    }
}
