using System;

namespace DesignPatternExamples.Creational.FactoryMethod.LogisticsDemo
{
    public interface IVehicleFactory
    {
        IVehicle CreateVehicle();
    }

    public class TrucksFactory : IVehicleFactory {
        public IVehicle CreateVehicle()
        {
            return new Truck();
        }
    }

    public class BusFactory : IVehicleFactory {
        public IVehicle CreateVehicle()
        {
            return new Bus();
        }
    }

    public class FleetFactory : IVehicleFactory
    {
        private readonly Random _random = new Random(DateTime.Now.Millisecond);

        public IVehicle CreateVehicle()
        {
            return _random.Next(1) == 0 ? (IVehicle) new Truck() : new Bus();
        }
    }
}