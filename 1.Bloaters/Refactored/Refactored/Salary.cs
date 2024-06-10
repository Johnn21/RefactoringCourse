using System;
using System.Collections.Generic;

namespace Refactored
{
    public class Salary
    {
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }
        public double Deduction { get; set; }

        public Salary(double baseSalary, double bonus, double deduction)
        {
            BaseSalary = baseSalary;
            Bonus = bonus;
            Deduction = deduction;
        }

        public static void PrintPayrollDetails(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                employee.PrintEmployeeName();
                PrintSalaryDetails(employee);
                Console.WriteLine();
            }
        }

        private static void PrintSalaryDetails(Employee employee)
        {
            Console.WriteLine("Base Salary: " + employee.Salary.BaseSalary);
            Console.WriteLine("Bonus: " + employee.Salary.Bonus);
            Console.WriteLine("Deduction: " + employee.Salary.Deduction);
            Console.WriteLine("Total Salary: " + SalaryCalculator.CalculateTotalSalary(employee.Salary));
        }
    }
}
