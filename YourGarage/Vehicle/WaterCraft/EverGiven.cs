using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.WaterCraft;

namespace YourGarage.Vehicle.WaterCraft
{
    class EverGiven : Watercrafts
    {
        public bool IsStuck { get; set; } = true;
        public string Name { get; set; }

        public EverGiven(string name)
        {
            Name = name;
        }

        public void CheckIsStuck()
        {
            if (IsStuck == true)
            {
                Console.WriteLine($"This watercraft is stuck.");
            }
        }
    }
}
