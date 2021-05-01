using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public class FactoryClient
    {
        public static void Main___(string[] args)
        {
            Creator creator = new ConcreteCreator();

            Product product = creator.FactoryMethod(ProductType.ProductA);
            Console.WriteLine("Product " + product.GetType().Name + " created");

            product = creator.FactoryMethod(ProductType.ProductB);
            Console.WriteLine("Product " + product.GetType().Name + " created");

            Console.ReadKey();
        }
    }
}
