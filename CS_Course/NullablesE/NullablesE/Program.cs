

int? num1 = null;
int? num2 = 1856;

double? num3 = new Double?();
double? num4 = 3.14157;
int num5;

bool? boolVal = new bool?();

Console.WriteLine("Our nullable number are: {0} {1} {2} {3}", num1, num2, num3, num4);
Console.WriteLine("Our nullable boolean value is: {0}", boolVal);

bool? isMale = null;

if (isMale == true)
{
    Console.WriteLine("User is male");
}else if (isMale == false)
{
    Console.WriteLine("User is female");
}else
{
    Console.WriteLine("No gender chosen");
}

double? num6 = 13.1;
double? num7 = null;
double num8;

if (num6 == null)
{
    num8 = 0.0;
}else
{
    num8 = (double)num6;
}
Console.WriteLine("Value of num8 is: {0}",num8);

num8 = num6 ?? 8.62;
Console.WriteLine("Value of num8 is: {0}", num8);
num8 = num7 ?? 3.5;
Console.WriteLine("Value of num8 is: {0}", num8);


Console.ReadKey();