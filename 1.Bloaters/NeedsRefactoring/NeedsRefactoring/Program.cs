using System;

namespace NeedsRefactoring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SalaryCalculator calculator = new SalaryCalculator();

            Employee emp1 = new Employee("John Doe", 50000, 5000, 2000);
            Employee emp2 = new Employee("Jane Smith", 60000, 6000, 3000);
            Employee emp3 = new Employee("Bob Johnson", 55000, 4500, 2500);

            calculator.AddEmployee(emp1);
            calculator.AddEmployee(emp2);
            calculator.AddEmployee(emp3);

            calculator.PrintPayrollDetails();

            double totalPayroll = calculator.CalculateTotalPayroll();
            Console.WriteLine("Total Payroll: " + totalPayroll);

            Console.ReadLine();
        }
    }
}
