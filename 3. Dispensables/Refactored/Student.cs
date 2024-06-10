using System;

namespace Refactored
{
    public class Student : Person
    {
        public string StudentId { get; set; }
        public string Major { get; set; }

        public void PrintStudentDetails()
        {
            PrintDetails();
            Console.WriteLine($"Student ID: {StudentId}, Major: {Major}");
        }
    }
}
