using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace OOPBasics.Singleton
{
    public sealed class Printer
    {
        private static int Count { get; set; }

        private static Printer Instance;

        static object locker = new object();
        private Printer()
        {
            Console.WriteLine($"Instance Count : {++Count}");
        }

        public void Print(string document) 
        {
            Console.WriteLine($"{document} ... printed");
        }

        public static Printer GetInstance()
        {
            if (Instance == null)
            {
                lock (locker)
                {
                    if (Instance == null)
                    {
                        Instance = new Printer();
                    }
                }
            }
           return Instance;
        }

        //public class Derived : Printer
        //{ 
        
        //}
    }

    public class ClientA
    {

        public void CreateInstance()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Client A document");
        }
    }

    public class ClientB
    {
        public void CreateInstance()
        {
            Printer printer = Printer.GetInstance();
            printer.Print("Client B document");
        }
    }

    public class SingletonDemo
    {

        public static void MethodA()
        {
            Printer p = Printer.GetInstance();
        }
        public static void MethodB()
        {
            Printer p = Printer.GetInstance();
        }
        public static void Main_000(string[] args)
        {
            //Printer client = Printer.GetInstance();
            //client.Print($"Client 1 document");

            //ClientA clientA = new ClientA();
            ////clientA.CreateInstance();

            //ClientB clientB = new ClientB();
            ////clientB.CreateInstance();

            //Parallel.Invoke(()=> MethodA(), ()=> MethodB());
            //Thread thread = new Thread(new ThreadStart(clientA.CreateInstance));
            //thread.Start();
            //Thread threadB = new Thread(new ThreadStart(clientB.CreateInstance));
            //threadB.Start();


            //Printer.Derived derived = new Printer.Derived();

            Console.ReadKey();
        }
    }
}
