using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.Vehicle;

namespace YourGarage.Car
{
    class Cars : Vehicles
    {
        public bool IsCar { get; set; }

        public void CheckIsCar()
        {
            if (IsCar == true)
            {
                Console.WriteLine($"This is a car");
            }
        }

        public override void Driving()
        {
        }
    }
}
