using System.Collections.Generic;

namespace Refactored
{
    public class EmployeeDepartment
    {
        // List of employees
        public List<Employee> Employees = new List<Employee>();

        // Add an employee
        public void AddEmployee(Employee employee) => Employees.Add(employee);
    }
}
