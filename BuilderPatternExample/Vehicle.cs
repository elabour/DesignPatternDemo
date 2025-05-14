using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class Vehicle
    {
        public string Type { get; set; }
        public string Engine { get; set; }
        public int Wheels { get; set; }
        public void ShowInfo()
        {
        Console.WriteLine($"Type: {Type}," +
             $" Engine: {Engine}," +
             $" Wheels: {Wheels}");
        }
    }
}
