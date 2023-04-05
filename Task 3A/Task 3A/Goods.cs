using Shipment;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shipment
{
    public enum Origin
    {
        Poland = 10,
        USA = 20,
        China = 30
    }
    public abstract class Goods
    {
        public abstract string GetName();
        public abstract Origin GetOrigin();
    }


    public class Coal : Goods
    {
        public override string GetName()
        {
            return "Coal";
        }

        public override Origin GetOrigin()
        {
            return Origin.Poland;
        }

    }

    public class Cars : Goods
        {
            public override string GetName()
            {
                return "Cars";
            }

            public override Origin GetOrigin()
            {
                return Origin.USA;
            }
         }

    public class Electronics : Goods
    {
        public override string GetName()
        {
            return "Electronics";
        }

        public override Origin GetOrigin()
        {
            return Origin.China;
        }
    }



}