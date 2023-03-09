
using HashTable;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {


        Dictionary<int, string> myDitionary = new Dictionary<int, string>()
        {
            {1, "one" },
            {2, "two" },
            {3, "two" }
        };




        /*
        Hashtable table = new Hashtable();
        Student[] students = new Student[6];

        students[0] = new Student(1, "Anna", 57.3f);
        students[1] = new Student(2, "Tim", 51.4f);
        students[2] = new Student(3, "Tom", 67.3f);
        students[3] = new Student(4, "John", 87.3f);
        students[4] = new Student(1, "Dic", 97.3f);
        students[5] = new Student(5, "Ralph", 37.3f);

        foreach( Student s in students)
        {
            if (!table.ContainsKey(s.Id))
            {
                table.Add(s.Id, s);
                Console.WriteLine("Student sucesfuuly added ID: {0}", s.Id);
            }
            else
            {
                Console.WriteLine("Sorry student with the same ID already exist ID: {0}", s.Id);
            }
        }


        Student storetStudent1 = (Student)students[1];

        foreach ( DictionaryEntry entry in table)
        {
            Student temp = (Student)entry.Value;
            Console.WriteLine("Id: {0} Name: {1} GPA: {2}",temp.Id, temp.Name, temp.GPA);
        }

        foreach (Student value in table.Values)
        {
            Console.WriteLine("Id: {0} Name: {1} GPA: {2}", value.Id, value.Name, value.GPA);
        }

        Console.ReadKey();
        */
    }
}