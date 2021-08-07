using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.WaterCraft;

namespace YourGarage.Vehicle.WaterCraft
{
    class Titanic : Watercrafts
    {
        public bool HasCrashed { get; set; } = true;

        public string Name { get; set; }

        public Titanic(string name)
        {
            Name = name;
        }

        public void CheckHasCrashed()
        {
            if (HasCrashed == true)
            {
                Console.WriteLine($"This watercraft has crashed");
            }
        }
    }
}
