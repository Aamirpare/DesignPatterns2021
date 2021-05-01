using System;

namespace OOPBasics.Lab1
{
    public class Benefits
    {
        public int Medical { get; set; }
        public int Education { get; set; }
    }
    public abstract class Employee 
    {
        // Field data.
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float CurrentPay { get; set; }

        public Benefits Benefits { get; set; }

        public virtual double CalculateBenefits()
        {
            double benefit = 0.2;
            return benefit;
        }

        // Constructors.
        //public Employee() { }
        public Employee(int id, string name, float pay)
        {
            Name = name;
            Id = id;
            CurrentPay = pay;
        }
        // Methods.
        public void GiveBonus(float amount)
        {
            CurrentPay += amount;
        }
        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Pay: {0}", CurrentPay);
        }

    }

    // Managers need to know their number of stock options.
    public class Manager : Employee
    {
        public Manager(int id, string name, float pay, int so) : base(id, name, pay)
        {
            this.StockOptions = so;
        }
        public int StockOptions { get; set; }
    }

    // Salespeople need to know their number of sales.
    class SalesPerson : Employee
    {
        public SalesPerson(int id, string name, float pay, int sn) : base(id, name, pay)
        {
            this.SalesNumber = sn;
        }
        public int SalesNumber { get; set; }

        public override double CalculateBenefits()
        {
            return base.CalculateBenefits() * 0.5;
        }
    }



    public class Singleton
    {
        public int Count { get; set; }
        private static Singleton instance { get; set; }
        private Singleton()
        {
            Count++;
            Console.WriteLine($"Instance Count : {Count}");
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }



    public class ClientA
    {

        public void UseSingleton()
        {
            Singleton singleton = Singleton.GetInstance();
        }
    }

    public class ClientB
    {

        public void UseSingleton()
        {
            Singleton singleton = Singleton.GetInstance();
        }
    }

    public class ExecuteDemo
    {
        public static void Main_employee(string[] args)
        {

            Singleton singleton = Singleton.GetInstance();

            ClientA clientA = new ClientA();
            clientA.UseSingleton();

            ClientB clientB = new ClientB();
            clientB.UseSingleton();


            //Manager manager = new Manager(90, "Aamir", 800, 9);

            //SalesPerson salesPerson = new SalesPerson(12, "Hajira", 8400, 100);

            //Employee[] employees = new Employee[]
            //{
            //  manager, salesPerson
            //};

            //foreach (var emp in employees)
            //{
            //    emp.CalculateBenefits();
            //}



            Console.ReadKey();
        }
    }
}
