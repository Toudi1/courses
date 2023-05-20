

using LINQToObjectsAndQueryOperators;

UniversityManager um = new UniversityManager();

um.MaleStudents();
um.FemaleStudents();

um.SortStudentsByAge();

Console.WriteLine(" ");

um.AllStudentsFromBeijingTech();

Console.WriteLine(" ");

um.AllStudentsFromGivenUniversityId(1);

um.AllStudentsFromThatUni(1);

Console.WriteLine("Enter university id:");
string input = Console.ReadLine();
try
{
    int inputAsInt = Convert.ToInt32(input);
    um.AllStudentsFromThatUni(inputAsInt);
}
catch(Exception)
{
    Console.WriteLine("Wrong input!");
}


Console.ReadKey();

