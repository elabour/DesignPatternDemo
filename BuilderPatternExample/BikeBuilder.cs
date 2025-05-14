using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class BikeBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle = new Vehicle();
        public void SetType() => _vehicle.Type = "Bike";
        public void SetEngine() => _vehicle.Engine = "500cc";
        public void SetWheels() => _vehicle.Wheels = 2;
        public Vehicle GetVehicle() => _vehicle;
    }
    
}
