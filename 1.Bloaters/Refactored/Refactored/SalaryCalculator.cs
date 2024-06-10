using System.Collections.Generic;
using System.Linq;

namespace Refactored
{
    public static class SalaryCalculator
    {
        // Calculate total payroll
        public static double CalculateTotalPayroll(List<Employee> employees) 
            => employees.Sum(employee => CalculateTotalSalary(employee.Salary));

        // Calculate total salary
        public static double CalculateTotalSalary(Salary salary) 
            => salary.BaseSalary + salary.Bonus - salary.Deduction;
    }
}
