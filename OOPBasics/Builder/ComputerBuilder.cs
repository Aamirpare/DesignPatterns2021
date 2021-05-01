using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPBasics.DesignPatterns.BuilderPattern
{
    /// <summary>
    /// Product 
    /// </summary>
    public class Computer
    {
        public string Type { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string HDD { get; set; }

    }

    /// <summary>
    /// Builder Interface : Abstraction
    /// </summary>
    public interface IComputerBuilder
    {
        IComputerBuilder AddType(string type);
        IComputerBuilder AddProcessor(string processor);
        IComputerBuilder AddRam(string ram);
        IComputerBuilder AddHDD(string hdd);
        Computer GetComputer();
    }

    /// <summary>
    /// Concreate Builder : Implementation
    /// </summary>
    public class ComputerBuilder : IComputerBuilder
    {
        private readonly Computer computer = new Computer();
        public IComputerBuilder AddHDD(string hdd)
        {
            computer.HDD = hdd;
            return this; //Required for method chaining
        }

        public IComputerBuilder AddType(string type)
        {
            computer.Type = type;
            return this;
        }
        public IComputerBuilder AddProcessor(string processor)
        {
            computer.Processor = processor;
            return this;
        }

        public IComputerBuilder AddRam(string ram)
        {
            computer.Ram = ram;
            return this;
        }
        public Computer GetComputer()
        {
            return computer;
        }
    }
    public class SystemDirector
    {
        IComputerBuilder Builder { get; set; }
        public SystemDirector(IComputerBuilder builder)
        {
            Builder = builder;
        }

        public IComputerBuilder BuildWithFullConfiguration()
        {
            //Step 1
            Builder.AddHDD("500 GB");
            //Step 2
            Builder.AddType("Desktop");
            //Step 3
            Builder.AddRam("8 GB");
            //Step 4
            Builder.AddProcessor("Core I7");
            return Builder;
        }

        public IComputerBuilder BuildWithMediumConfig()
        {
            //Step 1
            Builder.AddHDD("250 GB").
                    AddRam("4 GB").
                    AddProcessor("Core I5");
            return Builder;
        }


        public Computer GetComputer()
        {
            return Builder.GetComputer();
        }
    }

    public class ExecuteDemo
    {
        public static void Main____(string[] args)
        {
            var builder = new ComputerBuilder();
            SystemDirector director = new SystemDirector(builder);
            director.BuildWithFullConfiguration();

            var system = builder.GetComputer();
            Console.WriteLine($"Ram : {system.Ram}, HDD : {system.HDD}, Processor : {system.Processor}");

            director.BuildWithMediumConfig();
            system = builder.GetComputer();
            Console.WriteLine($"Ram : {system.Ram}, HDD : {system.HDD}, Processor : {system.Processor}");
            Console.ReadKey();
        }
    }

}
