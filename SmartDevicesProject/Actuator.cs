using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDevicesProject
{
    internal class Actuator : Device, IConnectable
    {
        private bool _isActive = false;
        public bool IsActive { get { return _isActive; } set { _isActive = value; } }
        public void Connect(SmartHub hub)
        {
            UpdateHubReference(hub);
            currentHub.AddDevice();
            Console.WriteLine($"Actuator: {Name} is connected to {currentHub}");
        }

        public void Disconnect()
        {
            if (currentHub is null)
                throw new Exception("Device isn't connected to any hub.");
            currentHub.RemoveDevice();
            UpdateHubReference(null);
            Console.WriteLine($"Actuator: {Name} is disconnected from hub");
        }

        public void Toggle()
        {
            IsActive = !IsActive;
            if (_isActive) { Console.WriteLine($"Actuator {Name} → ON"); }
            else
            {
                Console.WriteLine($"Actuator {Name} → OFF");
            }

        }
        public override void GetStatus()
        {
            Console.WriteLine($"Actuator {Name}: State = {IsActive}");
        }
    }
}
