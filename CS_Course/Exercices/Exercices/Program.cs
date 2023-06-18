internal class Program
{
    private static void Main(string[] args)
    {
        {
            Console.WriteLine(NotHungryCats("O~~O~O~O F O~O~"));
            Console.WriteLine(NotHungryCats("F O~ O~ ~O O~"));
            Console.WriteLine(NotHungryCats("~O~O~O~OF~O~OO~"));
            Console.ReadKey();
        }
    }

    public static int NotHungryCats(string kitchen)
    {
        int foodPosition = kitchen.IndexOf("F");
        int fullCats = 0;
        int numberOfTails = 0;
        int numberOfBodys = 0;

        for (int i = 0; i < kitchen.Length; i++)
        {
            if (kitchen[i] == '~')
            {
                numberOfTails++;
            }
            if (kitchen[i] == 'O')
            {
                numberOfBodys++;
            }
            if (numberOfBodys == 1 && numberOfTails == 1)
            {
                numberOfTails--;
                numberOfBodys--;
                if ((kitchen[i - 1] == 'O' && kitchen[i] == '~' && i < foodPosition) ||
                    (kitchen[i - 1] == '~' && kitchen[i] == 'O' && i > foodPosition))
                    fullCats++;
            }
        }
        return fullCats;
    }
    public static int NotHungryCatsSolution(string kitchen)
    {
        // split the map by position of food
        var cats = kitchen.Replace(" ", "").Split('F');

        // count on both sides
        var leftCount = cats[0].Where((x, i) => i % 2 == 1).Count(x => x == '~');
        var rightCount = cats[1].Where((x, i) => i % 2 == 0).Count(x => x == '~');

        return leftCount + rightCount;
    }
}
}