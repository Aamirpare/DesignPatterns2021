using System;

namespace OOPBasics.Composite
{
    public class Employee : IEmployee
    {
        public string FullName { get; set; }
        public string Department { get; set; }

        public void DisplayEmployeeDetails(int indent)
        {
            Console.WriteLine($"{"".PadLeft(indent, '-')} Name : {FullName}, Department : {Department}");
        }
    }
}
