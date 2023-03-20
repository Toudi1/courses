

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


Console.ReadKey();