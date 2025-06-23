using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDevicesProject
{
    //Назначение: контракт для всего, что может быть подключено к хабу.
    public interface IConnectable
    {
        void Connect(SmartHub hub);
        void Disconnect();
    }
}
