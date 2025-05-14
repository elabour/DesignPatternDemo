using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class TV : IDevice
    {
        public void TurnOn() => Console.WriteLine("TV is ON");
        public void TurnOff() => Console.WriteLine("TV is OFF");
        public void SetVolume(int level) =>
        Console.WriteLine($"TV volume set to {level}");
    }
}
