using System;

namespace NeedsRefactoring
{
    public class Order
    {
        public Person Customer { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }

        public string GetCustomerFullName()
        {
            return Customer.GetFullName();
        }

        public string GetCustomerFullAddress()
        {
            return Customer.GetFullAddress();
        }
    }

}
