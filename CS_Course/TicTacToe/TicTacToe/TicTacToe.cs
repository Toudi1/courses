// See https://aka.ms/new-console-template for more information
int caseHolder = 0;
int playerNumber = 2;
int numberOfTurns = 0;
bool endGame = false;
string textInput = "";
string[,] board = new string[,]
{
    { "1", "2", "3" },
    { "4", "O", "6" },
    { "7", "8", "9" },
};



while (!endGame)
{
    switch (caseHolder)
    {
        case 0://initialize
            board = InicializeBoard(board);
            caseHolder = 1;
            break;
        case 1: // player move
            if (playerNumber == 1)
                playerNumber = 2;
            else
                playerNumber = 1;

            board = fillField(board, playerNumber);
            PrintBoar(board);
            if (numberOfTurns == 9) caseHolder = 99;
            if (CheckWin(board))
            {
                caseHolder = 100;
            }
            break;

        case 99:
            Console.WriteLine("It was a draw");
            caseHolder = 101;
            break;
        case 100:
            Console.WriteLine("Player {0} wins!",playerNumber);
            caseHolder = 101;
            break;

        case 101:// ending game?
            Console.WriteLine("Do you want to continue Y/N?");
            textInput = Console.ReadLine();
            if (textInput == "Y" || textInput == "y")
            {
                caseHolder = 0;
            }
            else if (textInput == "N" || textInput == "n")
            {
                endGame = true;
            }
            else Console.WriteLine("You entered wrong input");
            break;
        default:
            break;
    }


}



bool CheckWin(string[,] board)
{
    for (int i = 0; i < board.GetLength(0); i++)
    {
        if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
        {
            return true;
        }
        if (board[0, i] == board[1, i] && board[1, i] == board[2, i])
        {
            return true;
        }
    }
    if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
    {
        return true;
    }
    if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
    {
        return true;
    }
    return false;
}
void PrintBoar(string[,] board)
{
    Console.Clear();
    Console.WriteLine(
        "       |       |       " +
        "\n   {0}   |   {1}   |   {2}   " +
        "\n_______|_______|_______" +
        "\n       |       |       " +
        "\n   {3}   |   {4}   |   {5}   " +
        "\n_______|_______|_______" +
        "\n       |       |       " +
        "\n   {6}   |   {7}   |   {8}   " +
        "\n       |       |       ",
        board[0, 0], board[0, 1], board[0, 2],
        board[1, 0], board[1, 1], board[1, 2],
        board[2, 0], board[2, 1], board[2, 2]);
}

string[,] fillField(string[,] board, int player)
{
    bool entering = true;
    string fieldFill = "";
    if (player == 1)
    {
        fieldFill = "O";
    }else if (player == 2)
    {
        fieldFill = "X";
    }
    else
    {
        Console.WriteLine("SOMETHING WENT WRONG");
        return default;
    }
    while (entering)
    {
        Console.WriteLine("Player {0} {1}\nPlease enter field number you wat to fill (1-9):", playerNumber, fieldFill);
        if (int.TryParse(Console.ReadLine(), out int enteredNumber))
        {
            if (enteredNumber > 0 && enteredNumber < 10)
            {
                if (int.TryParse(board[((enteredNumber - 1) / 3), ((enteredNumber - 1) % 3)], out int asdf))
                {
                    board[((enteredNumber - 1) / 3), ((enteredNumber - 1) % 3)] = fieldFill;
                    entering = false;
                } else
                { 
                    Console.WriteLine("field was occupied");
                }
            }else
            {
                Console.WriteLine("You entered wrong number");
            }
        }else Console.WriteLine("You didn't enter number");
    }
    numberOfTurns++;
    PrintBoar(board);
    return board;
}
string[,] InicializeBoard (string[,] board)
{

    board = new string[,]
    {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" },
    };
    PrintBoar(board);
    return board;
}
