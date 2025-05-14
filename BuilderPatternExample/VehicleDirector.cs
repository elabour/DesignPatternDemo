using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public class VehicleDirector
    {
        public void Construct(IVehicleBuilder builder)
        {
            builder.SetType();
            builder.SetEngine();
            builder.SetWheels();
        }
    }
}
