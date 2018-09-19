namespace DesignPatternExamples.Creational.FactoryMethod.LogisticsDemo
{
    public class Client
    {
        public void RunDemo()
        {
            IVehicleFactory factory = new BusFactory();
            IVehicle vehicle = factory.CreateVehicle();
            vehicle.Drive();
        }
    }
}