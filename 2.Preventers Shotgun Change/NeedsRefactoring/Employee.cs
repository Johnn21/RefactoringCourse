namespace NeedsRefactoring
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public string Address { get; private set; }
        public string Department { get; private set; }

        public Employee(int id, string name, string address, string department)
        {
            Id = id;
            Name = name;
            Address = address;
            Department = department;
        }

        public void UpdateAddress(string newAddress)
        {
            Address = newAddress;
        }

        public void ChangeDepartment(string newDepartment)
        {
            Department = newDepartment;
        }
    }
}
