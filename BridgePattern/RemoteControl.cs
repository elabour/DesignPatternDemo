using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class RemoteControl
    {
        protected IDevice _device;
        public RemoteControl(IDevice device)
        {
            _device = device;
        }
        public virtual void TurnOn() => _device.TurnOn();
        public virtual void TurnOff() => _device.TurnOff();
        public virtual void SetVolume(int level) =>
        _device.SetVolume(level);
    }
}
