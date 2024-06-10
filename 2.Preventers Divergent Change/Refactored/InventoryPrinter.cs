using System.Collections.Generic;

namespace Refactored
{
    public static class InventoryPrinter
    {
        public static void PrintInventoryDetails(List<Product> products) 
            => products.ForEach(product => ProductPrinter.PrintProductReport(product));
    }
}
