
if (args.Length == 0)
{
    Console.WriteLine("Please provide arguments");
    Console.WriteLine("if you need help enter: help");
    Console.ReadKey();
    return;
}
//check if help is needed
if (args[0] == "help")
{
    Console.WriteLine("*********** Instructions:");
    Console.WriteLine("use on of the following commands followed by 2 numbers");
    Console.WriteLine("'add' : to add 2 numbers");
    Console.WriteLine("'sub' : to subtract 2 numbers");
    Console.WriteLine("*****************");
    //pause
    Console.ReadKey();
    return;
}
if (args.Length != 3)
{
    Console.WriteLine("Invalid arguments, please use help command for instructions");
    //pause
    Console.ReadKey();
    return;
}

bool isNum1Parsed = float.TryParse(args[1], out float num1);
bool isNum2Parsed = float.TryParse(args[2], out float num2);
if (!(isNum1Parsed && isNum2Parsed))
{
    Console.WriteLine("Invalid arguments, please use help command for instructions");
    //pause
    Console.ReadKey();
    return;
}
float result;

switch (args[0])
{
    case "add":
        result = num1 + num2;
        Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
        break;
    case "sub":
        result = num1 - num2;
        Console.WriteLine("{0} - {1} = {2}", num1, num2, result);
        break;
    default:
        Console.WriteLine("Invalid arguments, please use help command for instructions");
        //pause
        Console.ReadKey();
        break;
}


//Console.WriteLine("Hello " + args[0]);
//Console.ReadKey();

