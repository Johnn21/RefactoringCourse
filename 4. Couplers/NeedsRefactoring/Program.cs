using System;

namespace NeedsRefactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = new Address { Street = "123 Main St", City = "City", State = "State", ZipCode = "12345" };
            var person = new Person { FirstName = "John", LastName = "Doe", Address = address };
            var order = new Order { Customer = person, OrderNumber = "123", OrderDate = DateTime.Now };

            Console.WriteLine($"Customer: {order.GetCustomerFullName()}");
            Console.WriteLine($"Customer Address: {order.GetCustomerFullAddress()}");

            Console.ReadLine();
        }
    }
}
