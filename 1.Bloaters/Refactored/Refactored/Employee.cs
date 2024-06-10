using System;

namespace Refactored
{
    public class Employee
    {
        public string Name { get; set; }
        public Salary Salary { get; set; }

        public Employee(string name, Salary salary)
        {
            Name = name;
            Salary = salary;
        }

        public void PrintEmployeeName() => Console.WriteLine("Employee Name: " + Name);
    }
}
