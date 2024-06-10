using System;

namespace NeedsRefactoring
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Major { get; set; }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}, Address: {Address}, Student ID: {StudentId}, Major: {Major}");
        }
    }
}
