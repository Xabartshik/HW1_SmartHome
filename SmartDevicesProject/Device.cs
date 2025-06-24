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
                
                _name = value ?? $"Device-{Id}";
                _name = _name.Trim();
                if (String.IsNullOrEmpty(_name)) {
                    throw new ArgumentException("Строка не может быть пустой");
                }
            }
        }
        protected SmartHub? currentHub;

        virtual public string GetStatus() {  return $"Device: {Name}"; }
        virtual public void UpdateHubReference(SmartHub? hub) { currentHub = hub; }
    }
}
