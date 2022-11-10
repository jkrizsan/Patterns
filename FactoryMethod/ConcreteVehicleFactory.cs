using FactoryMethod.Abstracts;
using FactoryMethod.ConcreteProducts;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    public class ConcreteVehicleFactory : VehicleFactory
    {
        public override IFactory GetVehicle(VehicleTypes Vehicle)
        {
            switch (Vehicle)
            {
                case VehicleTypes.Scooter:
                    return new Scooter();
                case VehicleTypes.Bike:
                    return new Bike();
                default:
                    throw new ApplicationException(string.Format("Vehicle '{0}' cannot be created", Vehicle));
            }
        }
    }
}
