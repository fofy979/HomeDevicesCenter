using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal class StatusChangedEventArgs:EventArgs
    {

        public string SerialNumber { get; }
        public string OldStatus { get; }
        public string NewStatus { get; }
        public DateTime ChangeTime { get; }

        public StatusChangedEventArgs(string serialNumber, string oldStatus, string newStatus)
        {
            SerialNumber = serialNumber;
            OldStatus = oldStatus;
            NewStatus = newStatus;
            ChangeTime = DateTime.Now;
        }
















    }
}
