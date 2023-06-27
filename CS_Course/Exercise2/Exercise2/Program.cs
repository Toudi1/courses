using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers1 = { 1, 1, 1, 2, 3, 4, 5, 1, 2 };
        SumOfTwo(numbers1, 2);

        Console.ReadKey();

    }
    public static int SumOfTwo(int[] nums, int SumToFind)
    {
        int numberOfPairs = 0;
        int firstValue = 0;
        int secondValue = 0;
        int rest = 0;
        Array.Sort(nums);
        List<int> collection = new List<int>(nums);
        int index = collection.IndexOf(SumToFind);
        
        while (collection.First() < SumToFind)
        {
            firstValue = collection.First();
            collection.Remove(firstValue);
            rest = SumToFind - firstValue;
            try
            {
                index = collection.IndexOf(rest);
                secondValue = collection.ElementAt(index);
                collection.RemoveAt(index);
                numberOfPairs++;
            }
            catch (Exception)
            {

            }
        }
        Console.WriteLine();
        Console.WriteLine(numberOfPairs);
        return numberOfPairs;
    }
}