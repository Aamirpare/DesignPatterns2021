using System.Collections.Generic;

namespace OOPBasics.Factory
{
    public class ClientA
    {
        public Student Student { get; set; }
        public ClientA()
        {
            Student = StudentFactory.Create(StudentType.Visiting);
            Student.Id = 90;
            Student.Name = "Waleed Ahmed";
            System.Console.WriteLine($"Id : {Student.Id}, Name : {Student.Name}");
        }
        public void DoAttendance()
        {
            List<Student> studentList = new List<Student>();
            for (int i = 0; i < 1; i++)
            {
                studentList.Add(StudentFactory.Create(StudentType.Serious));
            }
        }
    }
}
