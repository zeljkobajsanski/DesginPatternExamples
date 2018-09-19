using System;

namespace DesignPatternExamples.Creational.FactoryMethod.LogisticsDemo
{
    public interface IVehicle
    {
        void Load();
        void Unload();
        void Drive();
    }

    public class Truck : IVehicle {
        public void Load()
        {
            Console.WriteLine("Loading cargo");
        }

        public void Unload()
        {
            Console.WriteLine("Unloading cargo");
        }

        public void Drive()
        {
            Console.WriteLine("Driving truck");
        }
    }

    public class Bus : IVehicle {
        public void Load()
        {
            Console.WriteLine("Loading passangers");
        }

        public void Unload()
        {
            Console.WriteLine("Unloading passangers");
        }

        public void Drive()
        {
            Console.WriteLine("Driving bus");
        }
    }
}