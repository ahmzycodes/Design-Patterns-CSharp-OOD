using Shipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipment
{
    public abstract class Equipement
    {
        public abstract string GetName();

        public abstract bool CanUnload(Goods goods);
    }


    public class Excavator : Equipement
    {
        public override string GetName()
        {
            return "Excavator";
        }

        public override bool CanUnload(Goods goods)
        {
            if (goods.GetName() == "Coal")
                return true;
            return false;
        }
    }

        public class Crane : Equipement
        {
            public override string GetName()
            {
                return "Crane";
            }

            public override bool CanUnload(Goods goods)
            {
                if (goods.GetName() == "Coal" || goods.GetName() == "Cars")
                    return true;
                return false;
            }

        }

        public class Forklift : Equipement
        {
            public override string GetName()
            {
                return "Forklift";
            }

            public override bool CanUnload(Goods goods)
            {
                if (goods.GetName() == "Electronics")
                    return true;
                return false;
            }

        }
}
