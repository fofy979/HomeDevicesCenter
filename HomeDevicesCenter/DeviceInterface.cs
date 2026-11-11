using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal interface DeviceInterface
    {
   
        decimal calcCostRepair();
        void StartRepair();
        void CompleteRepair();

    }
}
