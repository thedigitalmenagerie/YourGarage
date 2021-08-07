using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.Aircraft;

namespace YourGarage.Vehicle.Aircraft
{
    class Flight191: Aircrafts
    {
        public bool HasYoungestHijacker { get; set; }
        public string HijackerName { get; set; }

        public Flight191(string hijackerName)
        {
            HijackerName = hijackerName;
        }

        public void CheckHasYoungestHijacker()
        {
            if (HasYoungestHijacker == true)
            {
                Console.WriteLine($"This flight has the youngest hijacker.");
            }
        }
    }
}
