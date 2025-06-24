using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartDevicesProject
{
    public class Sensor : Device, IConnectable
    {
        private double _lastReading;
        public double LastReading { get { return _lastReading; } set { _lastReading = value; } }
        public void Connect(SmartHub hub)
        {
            UpdateHubReference(hub);
            currentHub.AddDevice();
            Console.WriteLine($"Sensor: {Name} is connected to {currentHub}");
        }

        public void Disconnect()
        {
            if (currentHub is null)
                throw new Exception("Device isn't connected to any hub.");
            currentHub.RemoveDevice();
            UpdateHubReference(null);
            Console.WriteLine($"Sensor: {Name} is disconnected from hub");
        }

        public void Record(double value)
        {
            LastReading = value;
        }

        public override string GetStatus()
        {
            return $"Sensor {Name}: Last = {_lastReading}";
        }
    }
}
