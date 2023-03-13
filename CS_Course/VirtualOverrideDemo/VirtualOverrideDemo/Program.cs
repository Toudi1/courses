// See https://aka.ms/new-console-template for more information

using VirtualOverrideDemo;

Dog dog = new Dog("Bella", 2);
Console.WriteLine($"{dog.Name} is {dog.Age} years old");
dog.MakeSound();
dog.Play();
dog.Eat();


Console.ReadKey();