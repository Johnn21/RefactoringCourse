namespace Refactored
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
