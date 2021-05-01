using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.AbstractFactoryPattern
{
    //Abstract Product 
    public abstract class ProductA
    {
        public string Name { get; set; }
    }

    //Concrete Product A1

    public class ProductA1 : ProductA
    {
    }

    //Concrete Product A2

    public class ProductA2 : ProductA
    {
    }
    public abstract class ProductB
    { 
    }
    public class ProductB1 : ProductB
    {
    }
    public class ProductB2 : ProductB
    {
    }

    // Abstract Factory Pattern
    public abstract class AbstractFactory
    {
        public abstract ProductA CreateProductA();
        public abstract ProductB CreateProductB();
    }

    //Concrete Factory

    public class ConcreteFactoryA : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            Console.WriteLine("Product A1 is created...");
            return new ProductA1();
        }

        public override ProductB CreateProductB()
        {
            Console.WriteLine("Product B1 is created...");
            return new ProductB1();
        }
    }

    public class ConcreteFactoryB : AbstractFactory
    {
        public override ProductA CreateProductA()
        {
            Console.WriteLine("Product A2 is created...");
            return new ProductA2();
        }

        public override ProductB CreateProductB()
        {
            Console.WriteLine("Product B2 is created...");

            return new ProductB2();
        }
    }



    public class Client
    {
        public AbstractFactory Factory { get; set; }
        public Client(AbstractFactory factory)
        {
            Factory = factory;
        }
    }

    public enum ProductType { A, B }

    public class Client2
    {
        public static AbstractFactory CreateFactory(ProductType type)
        {
            AbstractFactory factory = null;
            switch (type)
            {
                case ProductType.A:
                    factory = new ConcreteFactoryA();
                    break;
                case ProductType.B:
                    factory = new ConcreteFactoryB();
                    break;
                default: throw new Exception($"Invalid type {type.ToString()}");
            }
            return factory;
        }
    }

    public class AbstractFactoryDemo
    {
        public static void Demo1()
        {
            Client client = null;

            Console.WriteLine();
            Console.WriteLine("Creating Products in Concrete FactoryA");
            //Creating products in the concrete factoryA
            client = new Client(new ConcreteFactoryA());

            client.Factory.CreateProductA();
            client.Factory.CreateProductB();


            Console.WriteLine();
            Console.WriteLine("Creating Products in Concrete FactoryB");
            //Creating products in the concrete factoryB
            client = new Client(new ConcreteFactoryB());

            client.Factory.CreateProductA();
            client.Factory.CreateProductB();

        }
        public static void Demo2()
        {
            AbstractFactory factory = null;

            Console.WriteLine();
            Console.WriteLine("Creating Products in Concrete FactoryA");

            factory = Client2.CreateFactory(ProductType.A);
            factory.CreateProductA();
            factory.CreateProductB();

            Console.WriteLine();
            Console.WriteLine("Creating Products in Concrete FactoryB");

            factory = Client2.CreateFactory(ProductType.B);
            factory.CreateProductA();
            factory.CreateProductB();
        }
        public static void Mainxxxx(string[] args)
        {
            Demo1();
            Demo2();            
            Console.ReadKey();
        }
    }


}
