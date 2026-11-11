using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal class AirConditioner:Device
    {


        private double power;
        public double Power {  get { return power; } set { power = value; } }


        public AirConditioner(string serial, string name, string model, decimal baseCostRepair, double power)

     : base(serial, name, model, baseCostRepair) { this.power = power; }
        public override string ToString()
        {
            return base.ToString() + ",\tPower: " + power; 
        }
        public override decimal calcCostRepair()
        {
            return BaseCostRepair+(decimal)(power*0.2);
        }














    }
}
