using System;
using System.Collections.Generic;
using System.Linq;

namespace NeedsRefactoring
{
    public class EmployeeService
    {
        private readonly List<Employee> _employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public void UpdateEmployeeAddress(int employeeId, string newAddress)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == employeeId);
            if (employee != null)
            {
                employee.UpdateAddress(newAddress);
            }
        }

        public void ChangeEmployeeDepartment(int employeeId, string newDepartment)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == employeeId);
            if (employee != null)
            {
                employee.ChangeDepartment(newDepartment);
            }
        }

        public void PrintEmployeeDetails(int employeeId)
        {
            var employee = _employees.FirstOrDefault(e => e.Id == employeeId);
            if (employee != null)
            {
                Console.WriteLine($"Employee ID: {employee.Id}");
                Console.WriteLine($"Name: {employee.Name}");
                Console.WriteLine($"Address: {employee.Address}");
                Console.WriteLine($"Department: {employee.Department}");
            }
        }
    }

}
