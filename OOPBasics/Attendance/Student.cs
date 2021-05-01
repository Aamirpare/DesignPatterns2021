namespace OOPBasics
{
    //Polymorphism
    public abstract class People
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public People()
        {
            Id = 0;
        }
        public abstract void Display();
       
        //{
        //    //System.Console.WriteLine("Id : " + Id + ", Full Name : " + FullName);
        //    System.Console.WriteLine($"Id : { Id }, Full Name : { FullName}");
        //}
    }
    public class Student : People
    {

        public override void Display()
        {
            System.Console.WriteLine($"Id : { Id }, Full Name : { FullName}");
        }
        public Student()
        {
            this.Id = 0;
        }
    }
    public class Admin : People
    {
        public override void Display()
        {
            System.Console.WriteLine($"Id : { Id }, Full Name : { FullName}");
        }
        public Admin()
        {
            this.Id = 90;
        }  
    }
    public class Coordinator : People
    {
        public override void Display()
        {
            System.Console.WriteLine($"Id : { Id }, Full Name : { FullName}");
        }
    }

}
