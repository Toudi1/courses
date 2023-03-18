

using InheritanceDemo2;

Chair officeChair = new Chair("Brown", "Wood");
Chair gamingChair = new Chair("Black", "Plastic");

Car damegedCar = new Car(99f, "Red");


damegedCar.DestroyablesNearby.Add(officeChair);
damegedCar.DestroyablesNearby.Add(gamingChair);

damegedCar.Destroy();



Console.ReadKey();
