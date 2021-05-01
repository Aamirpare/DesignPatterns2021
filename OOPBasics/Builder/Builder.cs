using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.BuilderPattern
{
    //Complext object and needs to be constructed step by step
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Part3 { get; set; }
    }

    //Abstraction
    public interface IBuilder
    {
        void AddPart1();
        IBuilder AddPart2();
        IBuilder AddPart3();
        Product GetProduct();
    }

    //Implementation
    public class ConcreteBuilder : IBuilder
    {
        Product product = new Product();
        public void AddPart1()
        {
            product.Part1 = "Part1";
            //return this;
        }

        public IBuilder AddPart2()
        {
            product.Part2 = "Part2";
            return this;
        }

        public IBuilder AddPart3()
        {
            product.Part3 = "Part3";
            return this;
        }

        public Product GetProduct()
        {
            return product;
        }
    }
    public class Director
    {
        readonly IBuilder Builder;
        public Director(IBuilder builder)
        {
            Builder = builder;
        }
        public void BuildMiniObject()
        {
            Builder.AddPart1();
        }

        public void BuildMegaObject()
        { 
            //Method chanining
            Builder.AddPart2().AddPart3();
            Builder.AddPart1();
        }

        public Product GetProduct()
        {
            return Builder.GetProduct();
        }
    }
    public class BuilderDemo
    {
        public static void Main___(string[] args)
        {
            Director director = new Director(new ConcreteBuilder());
            director.BuildMiniObject();
            var product = director.GetProduct();
           
            Console.WriteLine($"{product.Part1}, {product.Part2}, {product.Part3}");

            //director.BuildMiniObject();
            //var p = director.GetProduct();

            //Console.WriteLine($"{p.Part1}, {p.Part2}, {p.Part3}");


            Console.ReadKey();
        }

    }
}
