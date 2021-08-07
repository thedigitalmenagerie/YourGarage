using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage.Vehicle
{
    abstract class Vehicles
    {
        public int Fuel { get; set; } = 12;
        public int BatteryCapacity { get; set; } = 100;
        public string Color { get; set; }
        public int PassengerOccupancy { get; set; }

        public void Refueling()
        {
            if (Fuel < 12)
            {
                Fuel = 12;
            }
        }
        public virtual void Driving()
        {
            while (Fuel > 0)
            {
                --Fuel;
            }
        }

        public void Braking()
        {
            while (BatteryCapacity > 0)
            {
                --BatteryCapacity;
            }
        }
    }
}
