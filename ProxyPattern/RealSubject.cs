using System;

namespace ProxyPattern
{
    // The real object that does the actual heavy work (e.g., loading a large image from disk)
    public class RealImage : IImage
    {
        private readonly string _fileName;

        public RealImage(string fileName)
        {
            _fileName = fileName;
            LoadFromDisk();
        }

        private void LoadFromDisk()
        {
            Console.WriteLine("Loading image from disk: " + _fileName);
        }

        public void Display()
        {
            Console.WriteLine("Displaying image: " + _fileName);
        }
    }
}
