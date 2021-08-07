using System;
using System.Collections.Generic;
using YourGarage.Car;
using YourGarage.Aircraft;
using YourGarage.WaterCraft;
using YourGarage.Vehicle.Aircraft;
using YourGarage.Vehicle.Car;
using YourGarage.Vehicle.WaterCraft;

namespace YourGarage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            Console.WriteLine($"These are vehicles that fly");
            // With a single `foreach`, have each vehicle Fly()
            var Aircrafts = new List<Aircrafts>() { new Flight191("Dan Booth"), new Flight305("Dale Cooper") };
            foreach ( var aircraft in Aircrafts)
            {
                aircraft.Flying();
            }

            // Build a collection of all vehicles that operate on roads
            Console.WriteLine($"These are all the vehicles that operate on roads.");
            // With a single `foreach`, have each road vehicle Drive()
            var Cars = new List<Cars>() { new AstonMartinDB5("Carrozzeria Touring Superleggera"), new TheDale("Dale Clifft") };
            foreach (var car in Cars)
            {
                car.Driving();
            }

            // Build a collection of all vehicles that operate on water
            Console.WriteLine($"These are all the vehicles that operate on water.");
            // With a single `foreach`, have each water vehicle Drive()
            var Watercrafts = new List<Watercrafts>() { new EverGiven("Ever Given"), new Titanic("Titanic") };
            foreach (var watercraft in Watercrafts)
            {
                watercraft.Driving();
            }
        }
    }
}
