using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.DesignPatterns
{

    ///Product A 
    public abstract class ProductA
    {

    }

    public class ProductA1 : ProductA
    {

    }

    public class ProductA2 : ProductA
    {

    }

    ///Product B
    public class ProductB
    {

    }

    public class ProductB1 : ProductB
    {

    }

    public class ProductB2 : ProductB
    {

    }

    public interface AbstractFactory
    {
        ProductA CreateProductA();
        ProductB CreateProductB();
    }

    public class ConcreteFactoryA : AbstractFactory
    {
        public ProductA CreateProductA()
        {
            Console.WriteLine("ProductA1 is created in ConcreteFactoyA");
            return new ProductA1();
        }

        public ProductB CreateProductB()
        {
            Console.WriteLine("ProductB1 is created in ConcreteFactoyA");

            return new ProductB1();
        }
    }

    public class ConcreteFactoryB : AbstractFactory
    {
        public ProductA CreateProductA()
        {
            Console.WriteLine("ProductA2 is created in ConcreteFactoyB");

            return new ProductA2();
        }

        public ProductB CreateProductB()
        {
            Console.WriteLine("ProductB2 is created in ConcreteFactoyB");

            return new ProductB2();
        }
    }

    public class Client
    {
        public AbstractFactory Factory { set; get; }
        public Client(AbstractFactory fac)
        {
            Factory = fac;
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

    public class DemoAbstractFactory
    {
        public static void Main__(string[] args)
        {
            //DemoA();
            DemoB();
             Console.ReadKey();
        }

        private static void DemoA()
        {
            var clientA = new Client(new ConcreteFactoryA());
            var productA1 = clientA.Factory.CreateProductA();
            var prodcutB1 = clientA.Factory.CreateProductB();

            var clientB = new Client(new ConcreteFactoryB());
            var productA2 = clientB.Factory.CreateProductA();
            var prodcutB2 = clientB.Factory.CreateProductB();
        }

        public static void DemoB()
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
    }
}
