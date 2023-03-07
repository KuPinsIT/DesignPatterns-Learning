using Upheads.DesignPattern.BuildingBlocks;
namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder
{
    public class FactoryMethodExecutor : PatternExecutor
    {
        public override string Name => "Factory - Creational Pattern";

        public override void Execute()
        {
            var factory = new FactoryCreator();

            ITransportation truck = factory.Create(TransportType.Truck);
            Console.WriteLine("License plate:" + truck.GetLicensePlate());
            Console.WriteLine("Load capacity: " + truck.GetLoadCapacity());
            Console.WriteLine("Trip info: " + truck.GetTripInfo());


            Console.WriteLine("\n\n===========================================\n\n");

            ITransportation ship = factory.Create(TransportType.Ship);
            Console.WriteLine("License plate:" + ship.GetLicensePlate());
            Console.WriteLine("Load capacity: " + ship.GetLoadCapacity());
            Console.WriteLine("Trip info: " + ship.GetTripInfo());

            Console.ReadLine();
        }
    }
}
