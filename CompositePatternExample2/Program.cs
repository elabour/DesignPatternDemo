using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternExample2
{


    // Component interface
    interface IShape
    {
        void Draw();
        void Move(int x, int y);
    }
    // Leaf 1
    class Circle : IShape
    {
        private int _x, _y, _radius;
        public Circle(int x, int y, int radius)
        {
            _x = x; _y = y; _radius = radius;
        }
        public void Draw()
        {
            Console.WriteLine($"Drawing Circle at ({_x}, {_y}) with radius {_radius}");
        }
        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
            Console.WriteLine($"Moved Circle to ({_x}, {_y})");
        }
    }

    // Leaf 2
    class Rectangle : IShape
    {
        private int _x, _y, _width, _height;

        public Rectangle(int x, int y, int width, int height)
        {
            _x = x; _y = y; _width = width; _height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing Rectangle at ({_x}, {_y}) with size {_width}x{_height}");
        }

        public void Move(int x, int y)
        {
            _x += x;
            _y += y;
            Console.WriteLine($"Moved Rectangle to ({_x}, {_y})");
        }
    }

    // Composite
    class CompoundGraphic : IShape
    {
        private List<IShape> _children = new List<IShape>();

        public void Add(IShape shape) {_children.Add(shape);}

        public void Remove(IShape shape)  { _children.Remove(shape);}

        public void Draw()
        {
            Console.WriteLine("Drawing CompoundGraphic:");
            foreach (var shape in _children)
            {
                shape.Draw();
            }
        }

        public void Move(int x, int y)
        {
            Console.WriteLine($"Moving CompoundGraphic by ({x}, {y})");
            foreach (var shape in _children)
            {
                shape.Move(x, y);
            }
        }
    }

    // Client
    class Program
    {
        static void Main()
        {
            // Create individual shapes
            IShape circle = new Circle(5, 5, 10);
            IShape rectangle = new Rectangle(0, 0, 20, 10);

            // Create compound shape
            CompoundGraphic compound = new CompoundGraphic();
            compound.Add(circle);
            compound.Add(rectangle);

            // Create nested compound shape
            CompoundGraphic group = new CompoundGraphic();
            group.Add(new Circle(50, 50, 15));
            group.Add(compound);

            // Client code treats everything as IShape
            group.Draw();
            Console.WriteLine();
            group.Move(10, 10);
        }
    }

}
