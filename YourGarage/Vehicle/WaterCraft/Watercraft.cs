using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.Vehicle;

namespace YourGarage.WaterCraft
{
    class Watercrafts : Vehicles
    {
        public bool IsWatercraft { get; set; } = true;

        public void CheckIsWaterCraft()
        {
            if (IsWatercraft == true)
            {
                Console.WriteLine($"This is a watercraft");
            }
        }

        public override void Driving()
        {
        }
    }
}
