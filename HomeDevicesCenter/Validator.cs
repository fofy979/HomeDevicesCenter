using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDevicesCenter
{
    internal static class Validator
    {
       
            // دالة للتحقق من الرقم التسلسلي
            public static bool IsValidSerialNumber(string serialNumber)
            {
                // الشرط: ما يكون فاضي وطوله على الأقل 5 أحرف
                return !string.IsNullOrWhiteSpace(serialNumber) && serialNumber.Length >= 5;
            }

            // دالة للتحقق من التكلفة
            public static bool IsValidCost(decimal cost)
            {
                return cost > 0;
            }

            // دالة للتحقق من السعة أو القدرة
            public static bool IsValidCapacity(int capacity)
            {
                return capacity > 0;
            }

            public static bool IsValidPower(double power)
            {
                return power > 0;
            }
        public static bool IsValidCountLegs(int countLegs)
        {
            return countLegs > 0;
        }
    }
}
