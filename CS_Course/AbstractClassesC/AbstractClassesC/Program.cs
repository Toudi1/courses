


using AbstractClassesC;
using System.Net.Http.Headers;

Shape[] shapes = { new Cube(6), new Sphere(5) };

foreach (Shape shape in shapes)
{
    shape.GetInfo();
    Console.WriteLine("{0} has a volume of: {1}", shape.Name, shape.Volume());

    Cube iceCube = shape as Cube;
    if (iceCube == null)
    {
        Console.WriteLine("This shape is no cube");
    }

    if (shape is Cube)
    {
        Console.WriteLine("This shape is cube");
    }

    object cube1 = new Cube(3);
    Cube cube2 = (Cube)cube1;

    Console.WriteLine("{0} has a volume of: {1}",cube2.Name, cube2.Volume());

}


Console.ReadKey();