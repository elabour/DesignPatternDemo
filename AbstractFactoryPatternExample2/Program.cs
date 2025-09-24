using System;

namespace AbstractFactoryPatternExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            IProductFactory factory1 = new Factory1();
            ICar car1 = factory1.CreateCar();
            ITv tv1 = factory1.CreateTv();

            Console.WriteLine("Factory 1 products:");
            Console.WriteLine(car1.GetCar());
            Console.WriteLine(tv1.GetTv());

            Console.WriteLine();

            IProductFactory factory2 = new Factory2();
            ICar car2 = factory2.CreateCar();
            ITv tv2 = factory2.CreateTv();

            Console.WriteLine("Factory 2 products:");
            Console.WriteLine(car2.GetCar());
            Console.WriteLine(tv2.GetTv());

            Console.ReadKey();
        }
    }
}
