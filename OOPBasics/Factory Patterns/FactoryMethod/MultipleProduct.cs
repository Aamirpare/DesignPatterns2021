using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public enum ProductType
    {
        ProductA, ProductB
    }
    public interface Product { }
    public class ConcreteProductA : Product { }
    public class ConcreteProductB : Product { }

    public abstract class Creator
    {
        public abstract Product FactoryMethod(ProductType type);
    }

    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod(ProductType type)
        {
            switch (type)
            {
                case ProductType.ProductA:
                    return new ConcreteProductA();

                case ProductType.ProductB:
                    return new ConcreteProductB();
                default:
                    throw new ArgumentException("Invalid type", type.ToString());

            }
        }
    }
}
