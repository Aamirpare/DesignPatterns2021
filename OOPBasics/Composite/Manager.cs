using System;
using System.Collections.Generic;

namespace OOPBasics.Composite
{
    public class Manager : IEmployee
    {
        public List<IEmployee> Subordinates { get; set; } 
        public string FullName { get; set; }
        public string Department { get; set; }

        public void DisplayEmployeeDetails(int indent)
        {
            Console.WriteLine($"{"".PadLeft(indent, '-')} + Name : {FullName}, Department : {Department}, Total Subordinates : {Subordinates.Count}");
            foreach (var so in Subordinates)
            {
                so.DisplayEmployeeDetails(indent + 3);
            }

        }
    }
}
