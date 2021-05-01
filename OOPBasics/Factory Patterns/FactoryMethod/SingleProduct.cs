using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.FactoryMethod
{
    public class Product
    {
    }

    public class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine("Concreate product is created");
        }
    }
    public interface  Creator
    {
         Product FactoryMethod();
    }
    public class ConcreteCreator : Creator
    {
        public Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }

    ///================================Client=================
    public class ExecuteDemo
    {
        public static void Main_xsdaf(string[] args)
        {
            Creator creator = new ConcreteCreator();
            Product product = creator.FactoryMethod();
            
            Console.ReadKey();
        }
    }
}
