

using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Run k = new Run();

        IDictionary<int, string> dictionary = new Dictionary<int, string>();

        dictionary.Add(1, "One");
        dictionary.Add(2, "Two");
        dictionary.Add(3, "Three");
        dictionary.Add(4, "Four");

        foreach (KeyValuePair<int, string> kvp in dictionary)
        {
            Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
        }
        Console.WriteLine();
        Console.WriteLine(dictionary.Values);

    }
        public class Run
    {
        public static Func<float, float, float> Plus = (a, b) => a + b;
        public static Func<float, float, float> Minus = (a, b) => a - b;
        public static Func<float, float, float> Divide = (a, b) => a / b;
        public static Func<float, float, float> Multiply = (a, b) => a * b;


        public static Dictionary<string, Func<float, float, float>> Operators = new Dictionary<string, Func<float, float, float>>
        {
            {"+", Plus },
            {"-", Minus },
            {"/", Divide },
            {"*", Multiply }
        };
        public static Func<float, float, float> OperationGet(string s)
        {
            if (Operators.ContainsKey(s))
            {
                return Operators[s];
            }
            return null;
        }

    }
}
