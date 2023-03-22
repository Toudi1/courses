
//example 1
string text = System.IO.File.ReadAllText(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\ExampleTekst.txt");



Console.WriteLine("Whole tekst id: {0}",text);

string[] lines = System.IO.File.ReadAllLines(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\ExampleTekst.txt");


Console.WriteLine("Line reader");

foreach (string lineTxt in lines)
{
    Console.WriteLine("\t" + lineTxt);

}

Console.ReadKey();