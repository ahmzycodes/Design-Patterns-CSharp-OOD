# Shipment system

Your task is to create a goods shipment system.
Each shipment consists of following elements: Goods, ShipmentMethod and Equipement used to unload the goods.
We want to have ability to change details of given shipment in a simple way if needed, without the need to modify the main program.

## Project contains

1. Abstract classes
	* Goods, with GetName() returning Goods type as string, and GetOrigin() country of origin enumerable, the enumerable values correspond to distance to given country.
	* ShipmentMethod, with GetName() method returning shipment type as string and EstimatedShipmentTime().
	* Equipement, with GetName() returning type as string and CanUnload() method.
2. TransportGoods() function receiving all classes above
3. Main function.

## Supplier specification
You need to create specialized classes according to specification below.

### PGNiG
1. Goods: Coal, GetOrigin returns Poland
2. ShipmentMethod: Truck, EstimateShipmentTime() returns square root of distance to Origin country
3. Equipement: Excavator, CanUnload() returns true if goods type is Coal, false otherwise

### Ford

1. Goods: Cars, GetOrigin returns USA
2. ShipmentMethod: Ship, EstimateShipmentTime() returns half the distance to Origin country
3. Equipement: Crane, CanUnload() returns true if goods type is Cars or Coal, false otherwise

### Xiaomi

1. Goods: Electronics, GetOrigin returns China
2. ShipmentMethod: Plane, EstimateShipmentTime() returns logarithm of distance to Origin country
3. Equipement: Forklift, CanUnload() returns true if goods type is Electronics, false otherwise

## Task
1. Transport goods from different suppliers
2. Create a transport that ships Coal using Ship and is unloaded(or is it not?) using a Forklift

## Remarks:
1. You cannot edit existing classes and methods (except Main function)
2. You can create new classes and interfaces
3. Cannot use switch or dictionaries