using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.Vehicle;

namespace YourGarage.Aircraft
{
    class Aircrafts : Vehicles
    {
        public bool IsAircraft { get; set; } = true;
        public object name { get; internal set; }

        public void Flying()
        {
            while (Fuel < 0)
            {
                --Fuel;
            }
        }

        public void Landing()
        {
            while (BatteryCapacity > 0)
            {
                --BatteryCapacity;
            }
        }

        public void CheckIsAirCraft()
        {
            if (IsAircraft == true)
            {
                Console.WriteLine($"This is an aircraft");
            }
        }

        public override void Driving()
        {
            throw new NotImplementedException();
        }
    }
}
