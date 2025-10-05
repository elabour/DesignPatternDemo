using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AdapterPatternExample.Program;

namespace AdapterPatternExample
{
    internal class Program
    {
        // Target interface - what client expects
        public interface IShape
        {
            double GetArea();
        }

        // Adaptee - existing class (Rectangle)
        public class Rectangle
        {
            public double Width { get; set; }
            public double Height { get; set; }
            public double GetArea() => Width * Height;
        }

        // Adapter - adapts Rectangle for Triangle area calculation
        public class TriangleAdapter : IShape
        {
            private readonly Rectangle _rectangle;
            public TriangleAdapter(double baseLength, double height)
            {
           _rectangle = new Rectangle { Width = baseLength, Height = height };
            }
            // area of triangle = ½ * base * height
            public double GetArea() => _rectangle.GetArea() / 2; 
        }

        static void Main(string[] args)
        {
            IShape triangle = new TriangleAdapter(10, 5);
            Console.WriteLine($"Triangle Area = {triangle.GetArea()}");
            // Output: Triangle Area = 25

        }
    }
}
