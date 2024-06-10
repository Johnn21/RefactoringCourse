namespace Refactored
{
    public class Employee
    {
        public int Id { get; }
        public string Name { get; }
        public string Address { get; set; }
        public string Department { get; set; }

        public Employee(int id, string name, string address, string department)
        {
            Id = id;
            Name = name;
            Address = address;
            Department = department;
        }
    }
}
