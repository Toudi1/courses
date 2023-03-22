


using System.Runtime.CompilerServices;

string[] lines = System.IO.File.ReadAllLines(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\input.txt");

using (StreamWriter file = new StreamWriter(@"D:\programowanie\GitCourses\courses\CS_Course\Sources\readTxt\output.txt", true))
{
	foreach (string line in lines)
	{
		if (line.Contains("split"))
		{
			string[] splited = line.Split();

            file.Write(splited[4] + " ");
        }
	}
}


Console.ReadKey();