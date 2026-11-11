using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal class Washing:Device
    {

        private int capacityKg;
        public int CapacityKg { get { return capacityKg; }set { capacityKg = value; } }
        public Washing(string serial, string name, string model, decimal baseCostRepair,int capacityKg)
            : base(serial, name, model, baseCostRepair)
        { this.capacityKg = capacityKg; }
        public override string ToString()
        {
            return base.ToString()+",\tCapacity: "+capacityKg;
        }
        public override decimal calcCostRepair()
        {
            return BaseCostRepair + (decimal)(capacityKg * 0.5);
        }








    }
}
