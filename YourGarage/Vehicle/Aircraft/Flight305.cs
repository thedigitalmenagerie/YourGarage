using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.Aircraft;

namespace YourGarage.Vehicle.Aircraft
{
    class Flight305 : Aircrafts
    {
        public bool IsTheCoolestHijacking { get; set; }
        public string HijackerName { get; set; }

        public Flight305(string hijackerName)
        {
            HijackerName = hijackerName;
        }

        public void CheckCoolestHijacking()
        {
            if (IsTheCoolestHijacking == true)
            {
                Console.WriteLine($"This is the coolest plane hijacking.");
            }
        }
    }
}
