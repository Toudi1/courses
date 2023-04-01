


using System.Text.RegularExpressions;

string lines = File.ReadAllText(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\input2.txt");

string pattern = @"\d{3}|\d{2}";

Regex regex = new Regex(pattern);

MatchCollection matchCollection = regex.Matches(lines);

foreach (Match item in matchCollection)
{
    GroupCollection group = item.Groups;
    //Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
    if (int.TryParse(group[0].Value, out int number))
    {
        Console.Write((char)number);
    }
}



Console.ReadKey();