
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> numberList = new List<int>() { 9, 5, 13 };

        int[] numberArray = new int[] { 13, 15, 3, 7, 2 };

        Console.WriteLine("  ");

        CollectionSum(numberList);
        Console.WriteLine("  ");
        CollectionSum(numberArray);


    }
    static void CollectionSum(IEnumerable<int> anyCollection)
    {
        int sum = 0;

        foreach (int num in anyCollection)
        {
            sum += num;
        }
        Console.WriteLine("The sum is: " + sum);
    }
}