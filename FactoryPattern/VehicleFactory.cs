using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class VehicleFactory
    {
        public static IVehicle GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
            case "car":
            return new Car();
            case "bike":
            return new Bike();
            default:
           throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
