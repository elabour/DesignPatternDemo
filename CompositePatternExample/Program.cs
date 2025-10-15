using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePatternExample
{
    internal class Program
    {
        // Component (common interface)
        abstract class Item
        {
            public string Name { get; set; }
            public Item(string name) => Name = name;
            public abstract decimal GetPrice();
        }
        // Leaf
        class Product : Item
        {
            public decimal Price { get; set; }
            public Product(string name, decimal price) : base(name)
            {
                Price = price;
            }
            public override decimal GetPrice() {return Price;}
        }

        // Composite
        class Box : Item
        {
            private List<Item> _items = new List<Item>();
            public Box(string name) : base(name) { }
            public void Add(Item item) {_items.Add(item);}
            public void Remove(Item item) {_items.Remove(item);}
            public override decimal GetPrice()
            {
                decimal total = 0;
                foreach (var item in _items)
                {
                    total += item.GetPrice(); 
                }
                return total;
            }
        }
        static void Main(string[] args)
        {
            // Individual products
            var phone = new Product("Phone", 800m);
            var charger = new Product("Charger", 25m);
            var headphones = new Product("Headphones", 100m);

            // Small box (accessories)
            var smallBox = new Box("Accessories Box");
            smallBox.Add(charger);
            smallBox.Add(headphones);

            // Big box containing a phone and another box
            var bigBox = new Box("Big Box");
            bigBox.Add(phone);
            bigBox.Add(smallBox);
            // Display prices
            Console.WriteLine($"Price of Phone: {phone.GetPrice():C}");
            Console.WriteLine($"Price of Charger: {charger.GetPrice():C}");
            Console.WriteLine($"Price of Headphones: {headphones.GetPrice():C}");
            Console.WriteLine($"Total price of Small Box: {smallBox.GetPrice():C}");

            Console.WriteLine($"Total price of Big Box: {bigBox.GetPrice():C}");

        }
    }
}
