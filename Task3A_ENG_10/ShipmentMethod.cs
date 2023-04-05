using System;
using System.Collections.Generic;
using System.Text;

namespace Shipment
{
    public abstract class ShipmentMethod
    {
        public abstract string GetName();
        public abstract double EstimateShipmentTime(Goods goods);
    }

        public class Truck : ShipmentMethod
        {
            public override string GetName()
            {
                return "Truck";
            }

            public override double EstimateShipmentTime(Goods goods)
            {
                return Math.Sqrt((int)goods.GetOrigin());
            }

        }

        public class Ship : ShipmentMethod
        {
            public override string GetName()
            {
                return "Ship";
            }

            public override double EstimateShipmentTime(Goods goods)
            {
                return 0.5*(int)goods.GetOrigin();
            }

        }

        public class Plane : ShipmentMethod
        {
            public override string GetName()
            {
                return "Plane";
            }

            public override double EstimateShipmentTime(Goods goods)
            {
                return Math.Log((int)goods.GetOrigin());
            }

        }
}
