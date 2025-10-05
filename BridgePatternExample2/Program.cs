using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePatternExample2
{
    public interface IColor
    {
        string FillColor();
    }

    // 2. Concrete Implementors
    public class RedColor : IColor
    {
        public string FillColor()
        {
            return "filled with red color";
        }
    }

    public class BlueColor : IColor
    {
        public string FillColor()
        {
            return "filled with blue color";
        }
    }

    // 3. Abstraction
    public abstract class Shape
    {
        // Bridge to the implementation
        protected readonly IColor color;

        protected Shape(IColor color)
        {
            this.color = color;
        }

        public abstract string ApplyColor();
    }

    // 4. Refined Abstractions
    public class Circle : Shape
    {
        public Circle(IColor color) : base(color)
        {
        }

        public override string ApplyColor()
        {
            return $"Circle {color.FillColor()}";
        }
    }
    public class Square : Shape
    {
        public Square(IColor color) : base(color)
        {
        }

        public override string ApplyColor()
        {
            return $"Square {color.FillColor()}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(new RedColor());
            Shape blueSquare = new Square(new BlueColor());
         
            Console.WriteLine(redCircle.ApplyColor());
            Console.WriteLine(blueSquare.ApplyColor());
       
        }
    }
}
