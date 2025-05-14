using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person{Name="Ahmed",City="Misrata"};
            Person person2 = person1.Clone();
            Console.WriteLine($"Original: {person1.Name}, {person1.City}");
            Console.WriteLine($"Clone: {person2.Name}, {person2.City}");
            // Modify the clone
            person2.Name = "Ali";
          
            Console.WriteLine("After modifying the clone:");
            Console.WriteLine($"Original: {person1.Name}, {person1.City}");
            Console.WriteLine($"Clone: {person2.Name}, {person2.City}");
            Console.ReadKey();
        }
    }
}
