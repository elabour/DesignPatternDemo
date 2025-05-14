using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehicle vehicle1 = VehicleFactory.GetVehicle("car");
            vehicle1.Drive(); // Output: Driving a car

            IVehicle vehicle2 = VehicleFactory.GetVehicle("bike");
            vehicle2.Drive(); // Output: Riding a bike
        }
    }
}
