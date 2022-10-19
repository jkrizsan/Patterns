using FactoryMethod.Interfaces;

namespace FactoryMethod.Abstracts
{
    /// <summary>
    /// The Creator Abstract Class
    /// </summary>
    public abstract class VehicleFactory
    {
        public abstract IFactory GetVehicle(string Vehicle);
    }
}
