namespace NeedsRefactoring
{
    public class Employee
    {
        public string Name { get; set; }
        public double BaseSalary { get; set; }
        public double Bonus { get; set; }
        public double Deduction { get; set; }

        public Employee(string name, double baseSalary, double bonus, double deduction)
        {
            Name = name;
            BaseSalary = baseSalary;
            Bonus = bonus;
            Deduction = deduction;
        }

        // Calculate total salary
        public double CalculateTotalSalary()
        {
            double totalSalary = BaseSalary + Bonus - Deduction;
            return totalSalary;
        }
    }
}
