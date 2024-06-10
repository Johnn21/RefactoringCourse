using System;

namespace Refactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var address = new Address { Street = "123 Main St", City = "City", State = "State", ZipCode = "12345" };
            var person = new Person { FirstName = "John", LastName = "Doe", Address = address };
            var order = new Order { Customer = person, OrderNumber = "123", OrderDate = DateTime.Now };

            Console.WriteLine($"Customer: {order.Customer.GetFullName()}");
            Console.WriteLine($"Customer Address: {order.Customer.Address.GetFullAddress()}");

            Console.ReadLine();
        }
    }
}
