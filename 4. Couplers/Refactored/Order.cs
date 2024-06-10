using System;

namespace Refactored
{
    public class Order
    {
        public Person Customer { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
