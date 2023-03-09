// See https://aka.ms/new-console-template for more information


using HelloWorld;
using ArrayStart;

string[,] board = new string[,] 
{ 
    { "X", "2", "X"},
    { "O", "X", "O"},
    { "X", "X", "X"}
};

Console.WriteLine("Horizontal: " + HorizontalCheck(board));
Console.WriteLine("Vertical: " + VerticalCheck(board));
Console.WriteLine("Diagonal: " + DiagonalCheck(board));



static bool HorizontalCheck(string[,] board)
{
    for (int i = 0; i < board.GetLength(0); i++)
    {
        for (int j = 0; j  < board.GetLength(1); j ++)
        {
            if (board[i, j] == "O" || board[i, j] == "X")
            {
                if (board[i, 0] == board[i, j])
                {
                    if (j == board.GetLength(1) - 1)
                    {
                        return true;
                    }
                }
                else break;
            }
            else break;
        }
    }
    return false;
}

bool VerticalCheck(string[,] board)
{
    for (int j = 0; j < board.GetLength(1); j++)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, j] == "O" || board[i, j] == "X")
            {
                if (board[0, j] == board[i, j])
                {
                    if (i == board.GetLength(0) - 1)
                    {
                        return true;
                    }
                }
                else break;
            }
            else break;
        }
    }
    return false;
}

bool DiagonalCheck(string[,] board)
{
    if (board.GetLength(0) == board.GetLength(1))
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, i] == "O" || board[i, i] == "X")
            {
                if (board[0, 0] == board[i, i])
                {
                    if (i == board.GetLength(0) - 1)
                    {
                        return true;
                    }
                }
                else break;
            }
            else break;
        }
        int j = board.GetLength(1);
        for (int i = 0; i < board.GetLength(0); i++)
        {
            j--;
            if (board[i, j] == "O" || board[i, j] == "X")
            {
                if (board[0, (board.GetLength(1) - 1)] == board[i, j])
                {
                    if (i == board.GetLength(0) - 1)
                    {
                        return true;
                    }
                }
                else break;
            }
            else break;
        }
        return false;
    }
    else return default;
}


/*
Console.WriteLine("Please enter some text:");
string enteredTxt = Console.ReadLine();
Console.WriteLine("Select the Data type to validate the input you have entered.");
Console.WriteLine("Press 1 for String");
Console.WriteLine("Press 2 for Integer");
Console.WriteLine("Press 3 for Boolean");
string selectedTxt = Console.ReadLine();
Console.WriteLine(selectedTxt);

if (int.TryParse(selectedTxt, out int selectedVal))
{
    switch (selectedVal)
    {
        case 1:
            char[] charArr = enteredTxt.ToCharArray();
            foreach (char ch in charArr) if (!char.IsLetter(ch))
                {
                    Console.WriteLine("there was a number in texst");
                    break;
                }
            break;
        case 2:
            if (!int.TryParse(enteredTxt, out int someRandomNumber)) Console.WriteLine("it was not a intiger");
            else Console.WriteLine("it was a intiger");
            break;
        case 3:
            if (bool.TryParse(enteredTxt, out bool boolVal))
                if (boolVal) Console.WriteLine("value was true");
                else Console.WriteLine("value was false");
            else Console.WriteLine("it was not a bool value");
            break;
        default:
            Console.WriteLine("You entered number out of range 1-3");
            break;

    }
}
else Console.WriteLine("You didn't enter number");


/*
// create object of my class
// en instacne of Human
Human denis = new Human("Denis", "Smith", "blue", 22);
denis.IntroduceMyself();

Human aga = new Human("aga", "Smith", 25);
aga.IntroduceMyself();


Human sara = new Human("sara", "Smith", "blue");
sara.IntroduceMyself();

Human diana = new Human("diana", "Smith");
diana.IntroduceMyself();

/*
string enteredText = "";
int enteredNumber = 0, sumScore = 0, counter = 0;
float averageScore = 0f;

while (true)
{
    Console.WriteLine("Enter the {0} score", counter + 1);
    enteredText = Console.ReadLine();
    if (!int.TryParse(enteredText, out enteredNumber))
    {
        Console.WriteLine("Wrong input");
        continue;
    }

    if (enteredNumber == -1)
    {
        averageScore = (float)sumScore / (float)counter;
        Console.WriteLine("average score of student is: {0}", averageScore);
        break;
    }
    if (0 <= enteredNumber && enteredNumber <= 20)
    {
        sumScore += enteredNumber;
        counter++;
    }
    else Console.WriteLine("{0} is out of range 0-20", enteredNumber);
}



/*
Console.WriteLine("Enter temperature:");
string temperature = Console.ReadLine();
int numTemp = 0;
string tekst;

if (int.TryParse(temperature, out numTemp))
{
    tekst = numTemp <= 15 ? "it is too cold here" : numTemp <= 28 ? "it is ok" : "it is hot here";
    Console.WriteLine(tekst);
}
else
    Console.WriteLine("Not a valid Temperature");

for (int i = 0; i < 5; i++)
{
    ;
}

/*
if(4%2 == 0)
{
    Console.WriteLine("Even");
}else
{
    Console.WriteLine("Odd");
}

string friend1 = "Jacek", friend2 = "Placek", friend3 = "Gacek";

GreetFriend(friend1);
GreetFriend(friend2);
GreetFriend(friend3);

Console.WriteLine(LowUpper(friend3));

Count(LowUpper(friend3));

Console.ReadLine();

void GreetFriend(string name)
{
    Console.WriteLine("Hi " + name + " my friend");
}

string LowUpper(string text)
{
    return text.ToLower() + text.ToUpper();
}

void Count(string s)
{
    int length = s.Length;
    Console.WriteLine("The amount of characters is " + length);
}

int number = 11;

if (number % 3 == 0)
{
    Console.WriteLine("Divisible by 3.");
}
else if (number % 7 == 0)
{
    Console.WriteLine("Divisible by 7.");
}
else if (number % 2 != 0)
{
    Console.WriteLine("Odd number.");
}
else if (number % 2 == 0)
{
    Console.WriteLine("Even number.");
}*/
Console.ReadLine();