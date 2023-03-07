namespace Upheads.DesignPattern.Library.CreationalPatterns.Builder
{
    public interface ITransportation
    {
        string GetLicensePlate();
        decimal GetLoadCapacity();
        string GetTripInfo();
    }
}