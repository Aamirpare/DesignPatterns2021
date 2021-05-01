using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Adatapter
{
    public class Service
    {
        public void Recieve(int data)
        {
            Console.WriteLine($"Reached to the service {data}");
        }
    }
    public interface IClient
    {
        void Send(string data);
    }

    public class Adapter : IClient
    {
        Service service { get; set; } = new Service();
        public void Send(string data)
        {
            Console.WriteLine("Data received from client...");
            var x = Convert.ToInt32(data);
            service.Recieve(x);
        }
    }
    public class Client
    {
        public static void Main____(string[] args)
        {
            IClient client = new Adapter();
            client.Send("900");

            Console.ReadKey();
        }

    }

}
