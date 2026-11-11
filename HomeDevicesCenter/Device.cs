using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal  abstract class Device:DeviceInterface
    {
        private  readonly string serial;
        private string name;
        private string model;
       
        private decimal baseCostRepair;
        private string status;
        //--------------------------
        public string  Serial{ get { return serial; } }
        public string Model { get { return model; }set { model = value; } }
        public string Name { get { return name; } set { name = value; } }
        public decimal BaseCostRepair  { get { return baseCostRepair; } set { baseCostRepair = value; } }
        public string Status { get { return status; } set { status = value; } }
        //-------------------------------------
        public Device(string serial, string name, string model, decimal baseCostRepair)
        {
        this.serial = serial;       
        this.name = name;
        this.model = model;
        this.baseCostRepair = baseCostRepair;
        status = "in wait";
       
        
        }

        //------------------------------------------------------
        public override string ToString()
        {
            return "serial: "+serial +"\t,name: "+name + "\t,model: " +model + "\t,baseCostRepair: " + baseCostRepair + "\t,Status: " +status;
        }
        //-----------------------
        public virtual string getStatusDescription()
        {
            return $"Serial Number: {serial}----Status: {status}";
        
        }

        //------------------------------------------------
       
        public virtual void StartRepair()
        { 
            string oldStatus = Status;
            Status = "in repair";
            OnStatusChanged(oldStatus, Status);
        }

        public virtual void CompleteRepair()
        {
            string oldStatus = Status;
            Status = "repaired";
            OnStatusChanged(oldStatus, Status);
        }
        public abstract decimal calcCostRepair();

        //-------------------------------

        // تعريف التفويض والحدث
        public delegate void StatusChangedEventHandler(object sender, StatusChangedEventArgs e);
        public event StatusChangedEventHandler StatusChanged;

        // دالة مساعدة لإطلاق الحدث
        protected virtual void OnStatusChanged(string oldStatus, string newStatus)
        {
            StatusChanged?.Invoke(this, new StatusChangedEventArgs(serial, oldStatus, newStatus));
        }
        //---------------------------------









    }
}
