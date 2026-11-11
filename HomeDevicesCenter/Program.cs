using HomeDevicesCenter;
//Console.OutputEncoding=System.Text.Encoding.UTF8;
//Console.InputEncoding=System.Text.Encoding.UTF8;
DeviceCenter center = new DeviceCenter();

Console.WriteLine("===== Home Devices Center =====\n");

// إنشاء أجهزة مختلفة
Refrigerator fridge = new Refrigerator("REF-1001", "Samsung", "RT38",150, 380);
Washing washer = new Washing("WM-2002", "LG", "F4V5", 120, 8);
AirConditioner ac = new AirConditioner("AC-3003", "Gree", "Fairy", 200, 1.5);

// إضافة الأجهزة للمركز
center.addDevice(fridge);
center.addDevice(washer);
center.addDevice(ac);


Console.WriteLine("\n----- show devices before refreshing -----");
center.showAllDevices();

// بدء صيانة أحد الأجهزة
Console.WriteLine("\n----- start fridgerator -----");
center.startRepairBySerial("REF-1001");

Console.WriteLine("\n----- start washing -----");
center.startRepairBySerial("WM-2002");
Console.WriteLine("\n----- start AirConditionar -----");
center.startRepairBySerial("AC-3003");
// إنهاء صيانة الثلاجة
Console.WriteLine("\n----- end repair fridgerator -----");
center.completeRepairBySerial("REF-1001");
//إنهاء صيانةالمكيف
Console.WriteLine("\n----- end repair AirConditionar -----");
center.completeRepairBySerial("AC-3003");

//----------
// عرض الأجهزة بعد التغيير
Console.WriteLine("\n----- show devices after refreshing -----");
center.showAllDevices();



// عرض الأعضاء الثابتة

Console.WriteLine($"\nCount of total  created devices: (Static): {DeviceCenter.TotalDevicesCreated}");

Console.WriteLine($"total-Cost-Repair of repaired device (Static): {DeviceCenter.TotalRepairValue}");


        
