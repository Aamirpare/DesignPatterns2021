using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Factory
{

    public class ExecuteDemo
    {
        public static void Mainxxx(string[] args)
        {
            ClientA client = new ClientA();
            client.DoAttendance();
            Console.ReadKey();
        }
    }
}
