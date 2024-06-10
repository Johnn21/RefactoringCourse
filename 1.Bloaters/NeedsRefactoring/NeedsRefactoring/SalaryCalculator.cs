using System;
using System.Collections.Generic;

namespace NeedsRefactoring
{
    public class SalaryCalculator
    {
        // List of employees
        private List<Employee> employees;

        public SalaryCalculator()
        {
            employees = new List<Employee>();
        }

        // Add an employee
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        // Calculate total payroll
        public double CalculateTotalPayroll()
        {
            double totalPayroll = 0;
            foreach (var employee in employees)
            {
                totalPayroll += employee.CalculateTotalSalary();
            }
            return totalPayroll;
        }

        // Print payroll details
        public void PrintPayrollDetails()
        {
            foreach (var employee in employees)
            {
                Console.WriteLine("Employee Name: " + employee.Name);
                Console.WriteLine("Base Salary: " + employee.BaseSalary);
                Console.WriteLine("Bonus: " + employee.Bonus);
                Console.WriteLine("Deduction: " + employee.Deduction);
                Console.WriteLine("Total Salary: " + employee.CalculateTotalSalary());
                Console.WriteLine();
            }
        }
    }
}
