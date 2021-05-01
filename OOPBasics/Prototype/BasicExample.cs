using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.Prototype
{

    /// <summary>
    /// Abstract base class for prototype pattern implementation
    /// </summary>
    public abstract class ProtoType
    {
        public abstract ProtoType Clone();
    }

    /// <summary>
    /// ConcreteProtoType1 class inherits from the ProtoType base class
    /// </summary>
    public class ConcreteProtoType1 : ProtoType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override ProtoType Clone()
        {
            return (ProtoType)this.MemberwiseClone();
        }
    }

    /// <summary>
    /// ConcreteProtoType2 class inherits from the ProtoType base class
    /// </summary>
    public class ConcreteProtoType2 : ProtoType
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override ProtoType Clone()
        {
            return (ProtoType)this.MemberwiseClone();
        }
    }


    /// <summary>
    /// Client that uses the ProtoType to create clones 
    /// rather than creating a new object using new keyword 
    /// </summary>
    public class Client
    {
        public static void Display(ProtoType p)
        {

            if( p.GetType() == typeof(ConcreteProtoType1))
            {
                var prototype = (ConcreteProtoType1)p;
                Console.WriteLine($"{prototype.GetType().Name} Information");
                Console.WriteLine($"Id : {prototype.Id}");
                Console.WriteLine($"Name : {prototype.Name}");
            }
            if (p.GetType() == typeof(ConcreteProtoType2))
            {
                var prototype = (ConcreteProtoType2)p;
                Console.WriteLine($"{prototype.GetType().Name} Information");
                Console.WriteLine($"Id : {prototype.Id}");
                Console.WriteLine($"Name : {prototype.Name}");
            }
            Console.WriteLine();
            
        }
       
        public static void Main_000(string[] args)
        {
            //Original copy of the ConcreteProtoType1
            ProtoType prototype = new ConcreteProtoType1 { Id = 10, Name = "Name of the ConcretePrototype1" };
            Display(prototype);

            //Cloned Copy of the ConcreteProtoType1 using Prototype
            var copy1 = (ConcreteProtoType1)prototype.Clone();
            Display(copy1);

            //Changed in the copy
            copy1.Id = 90;
            copy1.Name = "Good name for concrete 1";
            Display(copy1);
            Display(prototype);

            Console.WriteLine();
           
            //Original copy of the ConcreteProtoType2
            prototype = new ConcreteProtoType2 { Id = 11, Name = "Name of the ConcretePrototype2" };
            Display(prototype);

            //Cloned Copy of the ConcreteProtoType2 using Prototype
            var copy2 = (ConcreteProtoType2)prototype.Clone();
            Display(copy2);

            //Changed copy
            copy2.Id = 30;
            copy2.Name = "Good name for concrete 2";

            Display(copy2);
            Display(prototype);


            Console.ReadKey();
        }

        public static void Main_00(string[] args)
        {
            //Original copy of the ConcreteProtoType1
            ProtoType original = new ConcreteProtoType1 { Id = 10, Name = "Name of the ConcretePrototype1" };

            //Cloned Copy of the ConcreteProtoType1 using Prototype
            var prototype = original.Clone();

            //Original copy of the ConcreteProtoType2
            original = new ConcreteProtoType2 { Id = 11, Name = "Name of the ConcretePrototype2" };

            //Cloned Copy of the ConcreteProtoType2 using Prototype
            prototype = original.Clone();

            Console.ReadKey();
        }

    }

}
