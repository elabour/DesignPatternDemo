using System;

namespace DecoratorPatternExample2
{
   // Step 1: Component interface
    public interface IShape
    {
        void Draw();
    }
    // Step 2: Concrete components
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Circle");
        }
    }
    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle");
        }
    }

    // Step 3: Base Decorator
    public abstract class ShapeDecorator : IShape
    {
        protected IShape _shape;

        public ShapeDecorator(IShape shape)
        {
            _shape = shape;
        }

        public virtual void Draw()
        {
            _shape.Draw(); // delegate to the wrapped shape
        }
    }

    // Step 4: Concrete decorators
    public class RedBorderDecorator : ShapeDecorator
    {
        public RedBorderDecorator(IShape shape) : base(shape) { }

        public override void Draw()
        {
            base.Draw();
            SetRedBorder();
        }

        private void SetRedBorder()
        {
            Console.WriteLine(" Added Red Border");
        }
    }

    public class ShadowDecorator : ShapeDecorator
    {
        public ShadowDecorator(IShape shape) : base(shape) { }

        public override void Draw()
        {
            base.Draw();
            AddShadow();
        }

        private void AddShadow()
        {
            Console.WriteLine(" Added Shadow Effect");
        }
    }

    // Step 5: Test the decorators
    public class Program
    {
        public static void Main()
        {
            // Create a simple circle
            IShape circle = new Circle();

            // Decorate with red border
            IShape redCircle = new RedBorderDecorator(circle);

            // Decorate with both red border and shadow
            IShape fancyRectangle = new ShadowDecorator(new RedBorderDecorator(new Rectangle()));

            Console.WriteLine("Simple Circle:");
            circle.Draw();

            Console.WriteLine("\nCircle with Red Border:");
            redCircle.Draw();

            Console.WriteLine("\nRectangle with Red Border and Shadow:");
            fancyRectangle.Draw();
        }
    }

}
