

using PolimorphismC;

var cars = new List<Car>
{
    new Audi(100, "White", "A4"),
    new BMW(200, "Black", "X5")

};

foreach (var car in cars)
{
    car.Repair();
}

Car bmwZ3 = new BMW(250, "White", "Z3");
Car audiA3 = new Audi(180, "Blasc", "A3");
bmwZ3.SetCarIDInfo(0123, "John Smith");
audiA3.SetCarIDInfo(1234, "Dick Johnson");
bmwZ3.GetCarIDInfo();
audiA3.GetCarIDInfo();


M3 myM3 = new M3(200, "red", "super");
myM3.Repair();

Console.ReadKey();