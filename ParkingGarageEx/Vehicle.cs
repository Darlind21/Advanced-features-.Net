using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ParkingGarageEx
{
    internal class Vehicle : VehicleInfo
    {
        public DateTime CheckInTime { get; set; }
        public DateTime? CheckOutTime { get; set; }

        public int GetHours ()
        {
            DateTime checkoutTime = CheckOutTime ?? DateTime.Now;

            TimeSpan timeSpent = checkoutTime - CheckInTime;
            double hours= timeSpent.TotalHours; 
            //? pas timeSpent sherben per t kontrolluar pjesen a esht nullable apo jo 
            //dmth "kontrollo nese timeSpent eshte nullable dhe nqs s esht merr .TotalHours

            if (hours % 1 != 0)
            {
                hours++;
            }

            int result = Convert.ToInt32(Math.Floor(hours));
            return result;
        }
    }
}
