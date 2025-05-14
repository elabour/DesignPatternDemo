using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDevice tv = new TV();
            RemoteControl tvRemote = new RemoteControl(tv);

            tvRemote.TurnOn();              // TV is ON
            tvRemote.SetVolume(15);         // TV volume set to 15
            tvRemote.TurnOff();             // TV is OFF

            IDevice pc = new PC();
            AdvancedRemoteControl pcRemote = new AdvancedRemoteControl(pc);
            pcRemote.TurnOn();   // PC is booting up
            pcRemote.SetVolume(20); // PC volume set to 20
            pcRemote.Mute();  // PC volume set to 0
            pcRemote.TurnOff(); // PC is shutting down
        }
    }
}
