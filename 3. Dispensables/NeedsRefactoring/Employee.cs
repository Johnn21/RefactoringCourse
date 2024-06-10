using System;

namespace NeedsRefactoring
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        public void PrintEmployeeDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}, Employee ID: {EmployeeId}, Department: {Department}");
        }
    }
}
