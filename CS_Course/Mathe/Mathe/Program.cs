

Console.WriteLine("Celling: " + Math.Ceiling(13.1));
Console.WriteLine("Celling: " + Math.Floor(13.1));

int num1 = 13;
int num2 = 8;

Console.WriteLine("Lower of num1 {0} and num2 {1} is {2}", num1, num2, Math.Min(num1,num2));
Console.WriteLine("Higher of num1 {0} and num2 {1} is {2}", num1, num2, Math.Max(num1,num2));

Console.WriteLine("3 to power of 5 is {0}",Math.Pow(3,5));
Console.WriteLine("PI is: {0}",Math.PI);

Console.WriteLine("Square root of 25 is: {0}",Math.Sqrt(25));
Console.WriteLine("Absolute of -32 is {0}", Math.Abs(-32));
Console.WriteLine("Cos of 1 is: {0}",Math.Cos(1));

Console.ReadKey();

string line = "21";

if (int.TryParse(line,out int number))
{
    Console.WriteLine(number);
    Console.WriteLine("Cos = {0}", Math.Cos(number));
    Console.WriteLine("Sin = {0}", Math.Sin(number));
    Console.WriteLine("Tg = {0}", Math.Tan(number));
}