using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class PC:IDevice
    {
        public void TurnOn() => Console.WriteLine("PC is booting up");
        public void TurnOff() => Console.WriteLine("PC is shutting down");
        public void SetVolume(int level) =>
        Console.WriteLine($"PC volume set to {level}");
    }
}
