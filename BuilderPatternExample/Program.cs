using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var director = new VehicleDirector();

            var carBuilder = new CarBuilder();
            director.Construct(carBuilder);
            Vehicle car = carBuilder.GetVehicle();
            car.ShowInfo(); 
            // Output: Type: Car, Engine: 2000cc, Wheels: 4

            var bikeBuilder = new BikeBuilder();
            director.Construct(bikeBuilder);
            Vehicle bike = bikeBuilder.GetVehicle();
            bike.ShowInfo();
            // Output: Type: Bike, Engine: 500cc, Wheels: 2
        }
    }
}
