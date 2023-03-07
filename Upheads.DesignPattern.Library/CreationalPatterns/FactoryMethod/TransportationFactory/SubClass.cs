namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder
{
    public class Truck : ITransportation
    {
        public string GetLicensePlate()
        {
            return "TRUCK-9999";
        }

        public decimal GetLoadCapacity()
        {
            return 1000;
        }

        public string GetTripInfo()
        {
            return "Delivery to HCM city";
        }
    }

    public class Ship : ITransportation
    {
        public string GetLicensePlate()
        {
            return "SHIP-9999";
        }

        public decimal GetLoadCapacity()
        {
            return 2000;
        }

        public string GetTripInfo()
        {
            return "Delivery to Vung Tau city";
        }
    }
}