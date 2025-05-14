using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class CarBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();
        public void SetType() => _vehicle.Type = "Car";
        public void SetEngine() => _vehicle.Engine = "2000cc";
        public void SetWheels() => _vehicle.Wheels = 4;
        public Vehicle GetVehicle() => _vehicle;
    }
   
}
