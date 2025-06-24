using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDevicesProject
{
    public class Device
    {
        public int Id { get; set; }
        private string _name;
        public string? Name { get { return _name; } 
            set {
                value ??= $"Device-{Id}";
                //На случай отправки "   " в качестве имени устройства
                _name = value.Trim() ?? $"Device-{Id}";
            }
        }
        protected SmartHub? currentHub;

        virtual public string GetStatus() {  return $"Device: {Name}"; }
        virtual public void UpdateHubReference(SmartHub? hub) { currentHub = hub; }
    }
}
