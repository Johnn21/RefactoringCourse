using System;

namespace Refactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employee1 = new Employee(1, "Alice", "123 Main St", "Engineering");
            var employee2 = new Employee(2, "Bob", "456 Oak St", "Marketing");

            var employeeService = new EmployeeService();
            employeeService.AddEmployee(employee1);
            employeeService.AddEmployee(employee2);

            employeeService.UpdateEmployeeAddress(1, "789 Maple St");
            employeeService.ChangeEmployeeDepartment(2, "Sales");

            employeeService.PrintEmployeeDetails(1);
            employeeService.PrintEmployeeDetails(2);

            Console.ReadLine();
        }
    }
}
