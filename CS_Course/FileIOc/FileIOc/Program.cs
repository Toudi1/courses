
//method 1
string[] lines = { "first 156", "second 258", "third 315"};

File.WriteAllLines(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\ExampleTekst2.txt", lines);



/*
//method 2
Console.WriteLine("Please give the file name:");
string fileName = Console.ReadLine();
Console.WriteLine("Please enter the tekst for the file:");
string input = Console.ReadLine();
File.WriteAllText(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\" + fileName + ".txt", input);
*/

//method 3

using (StreamWriter file = new StreamWriter(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\streamWriter1.txt"))
{
	foreach (string line in lines)
	{
		if (line.Contains("third"))
		{
			file.WriteLine(line);
		}
	}
}

using (StreamWriter file = new StreamWriter(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\streamWriter1.txt",true))
{
	file.WriteLine("Additional line");
}

    Console.ReadKey();