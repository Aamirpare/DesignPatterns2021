using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Prototype
{
    public interface ICloneable
    {
        ICloneable Clone();
    }

    public class Course : ICloneable
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public ICloneable Clone()
        {
            return (Course)this.MemberwiseClone();
        }
    }
    public class Student : ICloneable
    {
        public Course Course { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICloneable Clone()
        {
            return (Student)this.MemberwiseClone();
        }

    }
    public static class PrototypeDemo
    {
        public static void Main___(string[] args)
        {

            var course = new Course { CourseId = 100, Title = "Design Patterns" };

            //var c2 = course;
            //c2.CourseId = 90000;
            
            //var c3 = c2;
            
            //c3.CourseId = 490;
            //Console.WriteLine($"{c3.CourseId}  , {c2.CourseId} , {course.CourseId}");

            var student = new Student{ Id=90, Name= "Sara Khan", Course = course };
            var cs = (Student)student.Clone();

            cs.Id = 110;
            cs.Name = "Beenish Butt";
            cs.Course.Title = "Visual Programming";
            cs.Course.CourseId = 800;
            Console.WriteLine($"Id : {cs.Id}, Name : {cs.Name}, Course : {cs.Course.CourseId}, {cs.Course.Title}");
            Console.WriteLine($"Id : {student.Id}, Name : {student.Name}, Course : {student.Course.CourseId}, {student.Course.Title}");

            Console.ReadKey();
        }

    }



    public abstract class BasicCar
    {
        public string ModelName { get; set; } 
        public double Price { get; set; } 

        public static double SetPrice()
        {
            int price = 0;
            Random r = new Random();
            int p = r.Next(2000000, 5000000);
            price = p;
            return price;
        }
        public abstract BasicCar Clone();
    }
    public class Nano : BasicCar
    {
        public Nano(string name)
        {
            ModelName = name;
        }
        public override BasicCar Clone()
        {
            //Shallow Copy => deep copy
            return (Nano)this.MemberwiseClone();
        }
    }
    public class Ford : BasicCar
    {
        public Ford(string name)
        {
            ModelName = name;
        }
        public override BasicCar Clone()
        {
            //Alert : Dont assume that memberwiseclone() will copy down the layers
            return (Ford)this.MemberwiseClone();
        }
    }
    public class ExecuteDemo
    {
        public static void Main___(string[] args)
        {
 
            //Original Copy
            BasicCar nanoOriginalCopy = new Nano("Shampion Nano") { Price = 1000000 };
            BasicCar fordOriginalCopy = new Ford("Red Ford") { Price = 5000000 };

            BasicCar bc1;
            //Nano 
            bc1 = nanoOriginalCopy.Clone();
            bc1.Price = nanoOriginalCopy.Price + BasicCar.SetPrice();
            bc1.ModelName = "Red Chilli Mix";
            Console.WriteLine("Car is {0}, and it's price is {1}", bc1.ModelName, bc1.Price);
            Console.WriteLine("Car is {0}, and it's price is {1}", nanoOriginalCopy.ModelName, nanoOriginalCopy.Price);

            //Ford
            bc1 = fordOriginalCopy.Clone();
            bc1.Price = fordOriginalCopy.Price + BasicCar.SetPrice();

            Console.WriteLine("Car is {0}, and it's price is {1}", bc1.ModelName, bc1.Price);
            Console.WriteLine("Car is {0}, and it's price is {1}", fordOriginalCopy.ModelName, fordOriginalCopy.Price);

            Console.ReadKey();
        }
    }

}
