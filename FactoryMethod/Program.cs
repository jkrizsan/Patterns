using FactoryMethod.Abstracts;
using FactoryMethod.Enums;
using FactoryMethod.Interfaces;
using System;

namespace FactoryMethod
{
    /// <summary>
    /// Factory Pattern Demo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            VehicleFactory factory = new ConcreteVehicleFactory();

            IFactory scooter = factory.GetVehicle(VehicleTypes.Scooter);
            scooter.Drive(10);

            IFactory bike = factory.GetVehicle(VehicleTypes.Bike);
            bike.Drive(20);

            Console.ReadKey();
        }
    }
}
