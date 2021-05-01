using System;

namespace OOPBasics
{
    class Program
    {
        public int Price { get; set; }
        public static void DisplayContent<T>(T [] data)
        {
            foreach (var item in data)
            {
                Console.Write(item + ",  ");
            }
            Console.WriteLine();
        }

        static void Mainxxx(string[] args)
        {

            string[] names = { "apple", "Peach", "Orange" };

            int[] numbers = { 1, 2, 3, 5, 89 };


            DisplayContent(names);

            //ShowNames(names);

            //ShowNumbers(numbers);

            DisplayContent(numbers);

            Student student = new Student()
            {
                Id = 90,
                FullName = "Aamir"
            };

            
            Display(student);

            Admin admin = new Admin
            {
                Id = 10,
                FullName = "Sara"
            };

           
            Display(admin);

            Console.ReadKey();
        }

        private static void ShowNumbers(int[] numbers)
        {
            foreach (var n in numbers)
            {
                Console.Write(n + ",   ");
            }
        }

        private static void ShowNames(string[] names)
        {
            foreach (var n in names)
            {
                Console.Write(n + ",   ");
            }
        }

        public static void Display(People people)
        {
            //System.Console.WriteLine("Id : " + Id + ", Full Name : " + FullName);
            System.Console.WriteLine($"Id : { people.Id }, Full Name : { people.FullName}");
        }

        //public static void Display(Student people)
        //{
        //    //System.Console.WriteLine("Id : " + Id + ", Full Name : " + FullName);
        //    System.Console.WriteLine($"Id : { people.Id }, Full Name : { people.FullName}");
        //}

        //public static void Display(Admin people)
        //{
        //    //System.Console.WriteLine("Id : " + Id + ", Full Name : " + FullName);
        //    System.Console.WriteLine($"Id : { people.Id }, Full Name : { people.FullName}");
        //}

    }

    
}

