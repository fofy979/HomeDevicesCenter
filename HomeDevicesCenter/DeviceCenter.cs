using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal class DeviceCenter
    {

      private List<Device> devices=new List<Device>();
        public List<Device> Devices{ get { return devices; } }

        //--------------------------

        // ========== أعضاء ثابتة ==========

        // خاصية ثابتة: إجمالي عدد الأجهزة اللي تم إنشاؤها في البرنامج كله
        public static int TotalDevicesCreated { get; private set; } = 0;

        // خاصية ثابتة: إجمالي تكاليف كل الأجهزة
        public static decimal TotalRepairValue { get; private set; } = 0;
        private void Device_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            Console.WriteLine("\n*** notification ***");
            Console.WriteLine($"serial: {e.SerialNumber}");
            Console.WriteLine($"old_status: {e.OldStatus}");
            Console.WriteLine($"new-status: {e.NewStatus}");
            Console.WriteLine($"change time: {e.ChangeTime}");
            Console.WriteLine("******\n");
        }
        //----------------------

        public void addDevice(Device device)
        {
            
            if (device is Refrigerator)
            {
                Refrigerator r = (Refrigerator)device;
                if (!Validator.IsValidCountLegs(r.Countlegs))
                {
                    Console.WriteLine("invalid countlegs"); return;
                }

            }
            //----------------------------
            if (device is AirConditioner)
            {
                AirConditioner r = (AirConditioner)device;
                if (!Validator.IsValidPower(r.Power))
                {
                    Console.WriteLine("invalid Power"); return;
                }

            }
            //-------------------------
            if (device is Washing)
            {
                Washing r = (Washing)device;
                if (!Validator.IsValidCapacity(r.CapacityKg))
                { Console.WriteLine("invalid capacity"); return; }

            }
            //--------------------------
            if (!Validator.IsValidSerialNumber(device.Serial))

            { Console.WriteLine("invalid Serial number,"); return; }
            //---------------------------
            if(!Validator.IsValidCost(device.BaseCostRepair))
            { Console.WriteLine("invalid Cost,"); return; }
            //-------------------------
            
            if (device != null)
            // الاشتراك في الحدث
            {
                device.StatusChanged += Device_StatusChanged;TotalDevicesCreated++;
                devices.Add(device); Console.WriteLine(device.ToString() + "\t add suessfully");
            }
            else
            { Console.WriteLine("device is null"); return; }



        }

        public void showAllDevices()
        {

            if (devices.Count == 0)
                Console.WriteLine("Actually No devices found ");
            else
                foreach (Device d in devices)
                {
                    Console.WriteLine(d.getStatusDescription()) ;
                    Console.WriteLine("Repair Cost :   "+d.calcCostRepair());
                    Console.WriteLine("------------------------------");
                
                
                }
        
        
        }
        //--------------------------

        public void startRepairBySerial(string serial)
        {
        
        Device d=devices.FirstOrDefault(a=>a.Serial==serial);
            if (d != null)
            { d.StartRepair(); Console.WriteLine($"Repair  device: {serial} started"); }
            else Console.WriteLine("device not found");


        }



        //----------------------------
        public void completeRepairBySerial(string serial)
        {

            Device d = devices.FirstOrDefault(a => a.Serial == serial);
            if (d != null)
            { d.CompleteRepair();TotalRepairValue += d.calcCostRepair();
             Console.WriteLine($"Repair  device:{serial} finished"); Console.WriteLine("Repair Cost:  "+d.calcCostRepair()); }
            else Console.WriteLine("device not found");


        }











    }
}
