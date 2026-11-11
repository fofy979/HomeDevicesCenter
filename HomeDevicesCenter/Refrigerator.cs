using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal class Refrigerator:Device
    {

        private int countlegs;

        public int Countlegs { get { return countlegs; } set { countlegs = value; } }
        public Refrigerator(string serial, string name, string model, decimal baseCostRepair, int countlegs)
            : base(serial, name, model, baseCostRepair)
            { this.countlegs = countlegs; }
        public override string ToString()
        {
            return base.ToString()+ "\t,Countlegs: " + countlegs;
        }
        public override decimal calcCostRepair()
        {
            return BaseCostRepair + (decimal)(countlegs * 0.1);
        }






    }
}
