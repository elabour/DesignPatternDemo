using System;

namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Proxy pattern demo: lazy load a heavy image only on first use
            IImage image = new ImageProxy("HighResolutionPhoto.png");

            Console.WriteLine("Proxy created. Image not loaded yet.");

            Console.WriteLine("\nFirst display (triggers real load):");
            image.Display();

            Console.WriteLine("\nSecond display (uses cached real image):");
            image.Display();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
