using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FlyweightPatternExample
{
    internal class Program
    {
        // Flyweight: shared intrinsic state
        class TreeType
        {
            public string Name { get; }
            public string Color { get; }
            public string Texture { get; }
            public TreeType(string name, string color, string texture)
            {
                Name = name;
                Color = color;
                Texture = texture;
            }
            public void Draw(string canvas, int x, int y)
            {
                Console.WriteLine($"Drawing {Name} tree ({Color}, {Texture}) at ({x}, {y}) on {canvas}");
            }
        }
        // Flyweight Factory
      static class TreeFactory
        {
            private static readonly List<TreeType> treeTypes = new List<TreeType>();
            public static TreeType GetTreeType(string name, string color, string texture)
            {
                var type = treeTypes.Find(t => t.Name == name && t.Color == color && t.Texture == texture);
                if (type == null)
                {
                    type = new TreeType(name, color, texture);
                    treeTypes.Add(type);
                }
                return type;
            }
        }
        // Context: contains extrinsic state
        class Tree
        {
            private int x, y;
            private TreeType type;
            public Tree(int x, int y, TreeType type)
            {
                this.x = x;
                this.y = y;
                this.type = type;
            }
            public void Draw(string canvas)
            {
                type.Draw(canvas, x, y);
            }
        }
        // Client: uses flyweights
        class Forest
        {
            private readonly List<Tree> trees = new List<Tree>();
            public void PlantTree(int x, int y, string name, string color, string texture)
            {
                var type = TreeFactory.GetTreeType(name, color, texture);
                var tree = new Tree(x, y, type);
                trees.Add(tree);
            }
            public void Draw(string canvas)
            {
                foreach (var tree in trees)
                    tree.Draw(canvas);
            }
        }
        static void Main(string[] args)
        {
            Forest forest = new Forest();
            forest.PlantTree(10, 20, "Ticoma", "Green", "Rough");
            forest.PlantTree(15, 25, "Ticoma", "Green", "Rough");
            forest.PlantTree(50, 80, "OakTree", "Dark Green", "Smooth");
            forest.Draw("Main Canvas");
        }
    }
}
