using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YourGarage.Car;

namespace YourGarage.Vehicle.Car
{
    class AstonMartinDB5 : Cars
    {
        public bool IsJamesBondsCar { get; set; }
        public string Designer { get; set; }

        public AstonMartinDB5(string designer)
        {
            Designer = designer;
        }

        public void CheckJamesBondsCar()
        {
            if (IsJamesBondsCar == true)
            {
                Console.WriteLine($"This is James Bond's car.");
            }
        }

        public override void Driving()
        {
            base.Driving();
        }
    }
}
