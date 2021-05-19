/*
 * Author       : Aamir Shabbir Parre
 * Description  : Lab Sessional-2 for BSSE 7(A,B)
 * Date         : 6th May, 2021
 * Location     : G-11/4 Home, Islamabad
*/
using System.Collections.Generic;

namespace OOPBasics.DesignPatterns
{
    //Student Data Provider
    public static class StudentDataProvider
    {
        public static List<Student> GetData() =>
           new List<Student>
           {
                new Student { Id = 100, Name = "Altaf Dar",     Email="altaf.dar@gmail.com" },
                new Student { Id = 101, Name = "Martin Minro",  Email="martin.minro@yahoo.com" },
                new Student { Id = 102, Name = "Sara Dasner",   Email="sara.daner@microsoft.com" },
                new Student { Id = 103, Name = "Arika Gillani", Email="arika.gillani@gmail.com" },
                new Student { Id = 104, Name = "Amjad Kahn",    Email="amjad.khan@outlook.com" }
           };
    }
}
