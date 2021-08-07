using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.Car;

namespace YourGarage.Vehicle.Car
{
    class TheDale : Cars
    {
        public bool HasThreeWheels { get; set; }

        public string Inventor { get; set; }

        public TheDale(string inventor)
        {
            Inventor = inventor;
        }

        public void CheckHasThreeWheels()
        {
            if (HasThreeWheels == true)
            {
                Console.WriteLine($"This car has three wheels.");
            }
        }
    }
}
