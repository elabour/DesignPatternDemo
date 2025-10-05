using System;

namespace ProxyPattern
{
    // The proxy controls access to the RealImage, adding lazy loading behavior
    public class ImageProxy : IImage
    {
        private RealImage _realImage; // holds the real subject once created
        private readonly string _fileName;

        public ImageProxy(string fileName)
        {
            _fileName = fileName;
        }

        public void Display()
        {
            // Lazy initialization: only instantiate RealImage when first needed
            if (_realImage == null)
            {
                _realImage = new RealImage(_fileName);
            }
            _realImage.Display();
        }
    }
}
