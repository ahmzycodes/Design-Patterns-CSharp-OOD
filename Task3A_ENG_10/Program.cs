using System;

namespace Shipment
{
    class Program
    {
        static void Main(string[] args)
        {

            var pgnig = new PGNiG();
            var ford = new Ford();
            var xiaomi = new Xiaomi();

            Console.WriteLine("PGNiG");
            TransportGoods(pgnig.Goods(),pgnig.ShipmentMethod(),pgnig.Equipement());

            Console.WriteLine("Ford");
            TransportGoods(ford.Goods(),ford.ShipmentMethod(),ford.Equipement());

            Console.WriteLine("Xiaomi");
            TransportGoods(xiaomi.Goods(),xiaomi.ShipmentMethod(),xiaomi.Equipement());

            Console.WriteLine("Mixed");
            TransportGoods(ford.Goods(),xiaomi.ShipmentMethod(),pgnig.Equipement());
        }

        private static void TransportGoods(Goods goods, ShipmentMethod shipmentMethod, Equipement equipement)
        {
            Console.WriteLine($"{goods.GetName()} will arrive from {goods.GetOrigin()} by {shipmentMethod.GetName()}");
            Console.WriteLine($"Estimated time: {shipmentMethod.EstimateShipmentTime(goods)}");
            Console.WriteLine($"{equipement.GetName()} {(equipement.CanUnload(goods)?"will":"CANNOT")} unload the goods\n");
        }
    }
}
