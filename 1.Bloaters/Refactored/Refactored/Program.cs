using System;

namespace Refactored
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("John Doe", new Salary(50000, 5000, 2000));
            Employee emp2 = new Employee("Jane Smith", new Salary(60000, 6000, 3000));
            Employee emp3 = new Employee("Bob Johnson", new Salary(55000, 4500, 2500));

            EmployeeDepartment employeeDepartment = new EmployeeDepartment();
            employeeDepartment.AddEmployee(emp1);
            employeeDepartment.AddEmployee(emp2);
            employeeDepartment.AddEmployee(emp3);

            Salary.PrintPayrollDetails(employeeDepartment.Employees);

            double totalPayroll = SalaryCalculator.CalculateTotalPayroll(employeeDepartment.Employees);
            Console.WriteLine("Total Payroll: " + totalPayroll);

            Console.ReadLine();
        }
    }
}
