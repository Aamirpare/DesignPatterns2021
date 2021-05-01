using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics.AdapterPattern
{
    //Rectangle
    public class Rectangle
    {
        public double Width { get; set; }
        public double Length { get; set; }
    }

    //Existing Calculator
    public class Calculator
    {
        public double GetArea(Rectangle rect)
        {
            return rect.Width * rect.Length;
        }
    }

    //Triangle object to be adapted by Adapter Calculator
    public class Triangle
    {
        public double Base { get; set; }
        public double Height { get; set; }
    }

    //Adapter Calculator adaptes triangle for its area to be calculated.

    public interface IClient
    {
        double GetArea(Triangle triangle);
    }
    public class CalculatorAdapter: IClient
    {
        Calculator calculator { get; } = new Calculator();
        Rectangle Rectangle { get; } = new Rectangle();
        public double GetArea(Triangle triangle)
        {
            Rectangle.Width = triangle.Base;
            Rectangle.Length = 0.5 * triangle.Height;
            return calculator.GetArea(Rectangle);
        }
    }

    public class ExecuteDemo
    {
        public static void Main____(string[] args)
        {
            Calculator cal = new Calculator();
            var rectangle = new Rectangle { Length = 30, Width = 20 };
            var area = cal.GetArea(rectangle);
            Console.WriteLine($"Rectangle Area : {area}");

            IClient adapter = new CalculatorAdapter();
            var triangle = new Triangle() { Base = rectangle.Length, Height = rectangle.Width };
            area = adapter.GetArea(triangle);

            Console.WriteLine($"Triangle Area : { area }");
            Console.ReadKey();
        }
    }
}
