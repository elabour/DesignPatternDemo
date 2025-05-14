using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternExample
{
    public interface IVehicleBuilder
    {
        void SetType();
        void SetEngine();
        void SetWheels();
        Vehicle GetVehicle();
    }
}
