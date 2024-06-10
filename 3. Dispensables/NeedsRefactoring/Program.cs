using System;

namespace NeedsRefactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student { Name = "Alice", Age = 20, Address = "123 Maple St", StudentId = "S123", Major = "Computer Science" };
            var employee = new Employee { Name = "Bob", Age = 30, Address = "456 Oak St", EmployeeId = "E456", Department = "HR" };

            student.PrintStudentDetails();
            employee.PrintEmployeeDetails();

            var utility = new Utility();
            Console.WriteLine(utility.ReverseString("Hello World"));
            Console.WriteLine(utility.ReverseStringDuplicate("Hello World"));
        }
    }
}
