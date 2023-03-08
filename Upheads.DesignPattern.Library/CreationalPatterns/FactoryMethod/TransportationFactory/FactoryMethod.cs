namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder
{
    public enum TransportType
    {
        Truck,
        Ship,
    }

    public abstract class TransportationFactory
    {
        public abstract ITransportation Create(TransportType type);
    }

    class FactoryCreator : TransportationFactory
    {
        public override ITransportation Create(TransportType type)
        {
            switch (type)
            {
                case TransportType.Truck:
                    return new Truck();

                case TransportType.Ship:
                    return new Ship();

                default:
                    throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}