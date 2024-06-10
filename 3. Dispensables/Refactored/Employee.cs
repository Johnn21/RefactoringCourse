using System;

namespace Refactored
{
    public class Employee : Person
    {
        public string EmployeeId { get; set; }
        public string Department { get; set; }

        public void PrintEmployeeDetails()
        {
            PrintDetails();
            Console.WriteLine($"Employee ID: {EmployeeId}, Department: {Department}");
        }
    }
}
