


using System.Text.RegularExpressions;

string pattern = @"\d";


Regex regex = new Regex(pattern);

string text = "Hi ther, my number is 135881";

MatchCollection matchCollection = regex.Matches(text);

Console.WriteLine("{0} hits found:\n {1}",matchCollection.Count,text);

foreach (Match hit in matchCollection)
{
    GroupCollection group = hit.Groups;
    Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
}


Console.ReadKey();

