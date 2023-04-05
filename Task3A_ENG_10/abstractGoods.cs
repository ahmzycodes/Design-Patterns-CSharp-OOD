using System;
using System.Collections.Generic;
using System.Text;

namespace Shipment
{
    public abstract class abstractGoods
    {
        public abstract Goods Goods();
        public abstract ShipmentMethod ShipmentMethod();
        public abstract Equipement Equipement();
    }

    public class PGNiG : abstractGoods
    {
        public override Goods Goods()
        {
            return new Coal();
        }

        public override ShipmentMethod ShipmentMethod()
        {
            return new Truck();
        }

        public override Equipement Equipement()
        {
            return new Excavator();
        }
    }

    public class Ford : abstractGoods
    {
        public override Goods Goods()
        {
            return new Cars();
        }

        public override ShipmentMethod ShipmentMethod()
        {
            return new Ship();
        }

        public override Equipement Equipement()
        {
            return new Crane();
        }
    }

    public class Xiaomi : abstractGoods
    {
        public override Goods Goods()
        {
            return new Electronics();
        }

        public override ShipmentMethod ShipmentMethod()
        {
            return new Plane();
        }

        public override Equipement Equipement()
        {
            return new Forklift();
        }
    }
}
