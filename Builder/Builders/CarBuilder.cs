﻿using Builder.Abstracts;
using Builder.Products;

namespace Builder.Builders
{
    /// <summary>
    /// The 'ConcreteBuilder2' class
    /// </summary>
    class CarBuilder : VehicleBuilder
    {
        public CarBuilder()
        {
            Vehicle = new Vehicle("Car");
        }

        public override void BuildFrame()
        {
            Vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            Vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            Vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            Vehicle["doors"] = "4";
        }
    }
}
