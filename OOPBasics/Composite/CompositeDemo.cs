using System;
using System.Collections.Generic;

namespace OOPBasics.Composite
{
    public static class CompositeDemo
    {
        public static void Main(string[] args)
        {
            //Leaves
            IEmployee emp1 = new Employee { FullName = "Aamir", Department = "CS" };
            IEmployee emp2 = new Employee { FullName = "Faiza", Department = "CS" };
            IEmployee emp3 = new Employee { FullName = "Sara", Department = "IT" };
            IEmployee emp4 = new Employee { FullName = "Maria", Department = "IT" };

            emp1.DisplayEmployeeDetails();

            Console.WriteLine("=============================");
            emp2.DisplayEmployeeDetails();
            Console.WriteLine("=============================");



            //Composties
            IEmployee emp5 = new Manager { FullName = "Alexandra", Department = "HR", Subordinates = new List<IEmployee> { emp1, emp3} };
            IEmployee emp6 = new Manager { FullName = "Riyan Khan", Department = "Finance", Subordinates = new List<IEmployee> { emp2, emp4 } };

            Console.WriteLine("Employees under Alexandra");
            emp5.DisplayEmployeeDetails();
            Console.WriteLine("=============================");

            Console.WriteLine("Employees under Riyan Khan");
            emp6.DisplayEmployeeDetails();
            Console.WriteLine("=============================");

            IEmployee bigBoss = new Manager { FullName = "Royando Kaprio", Department = "Head Of Organization", Subordinates = new List<IEmployee> { emp5, emp6 } };

            Console.WriteLine("Employees under the head");
            bigBoss.DisplayEmployeeDetails();
            Console.WriteLine("=============================");
            Console.ReadKey();
        }

    }
}
