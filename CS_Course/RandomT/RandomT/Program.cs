

Random dice = new Random();
int numEyes;

for (int i = 0; i < 10; i++)
{
    numEyes = dice.Next(1, 7);
    Console.WriteLine(numEyes);
}

Console.WriteLine("Please enter your question:");
Console.ReadLine();
Answer(dice.Next(1, 4));


Console.ReadKey();


 void Answer(int num)
{
    switch (num)
    {
        case 1:
            Console.WriteLine("Yes");
            break;
        case 2:
            Console.WriteLine("Maby");
            break;
        case 3:
            Console.WriteLine("No");
            break;

        default:
            Console.WriteLine("Something went wrong!");
            break;
    }
}