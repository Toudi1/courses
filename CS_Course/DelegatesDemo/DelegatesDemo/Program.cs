﻿

using DelegatesDemo;


internal class Program
{
    delegate bool FilterDelegate(Person p);
    private static void Main(string[] args)
    {
        Person p1 = new Person() { Name = "Damian", Age = 28 };
        Person p2 = new Person() { Name = "Karol", Age = 16 };
        Person p3 = new Person() { Name = "Kamil", Age = 25 };
        Person p4 = new Person() { Name = "Jan", Age = 78 };


        List<Person> people = new List<Person>() { p1, p2, p3, p4 };

        DisplayPeople("Kids",people,IsMinor);
        DisplayPeople("Kids", people, IsAdult);
        DisplayPeople("Kids", people, IsSenior);

        FilterDelegate filter = delegate (Person p)
        {
            return p.Age >= 22 && p.Age <= 30;
        };

        DisplayPeople("Betwene 20 and 30", people, filter);


        DisplayPeople("All people", people, delegate (Person p) { return true; });


        string searchKeyword = "K";
        DisplayPeople("age > 20 with search keyword: " + searchKeyword, people, p =>
        {
            if (p.Name.Contains(searchKeyword) && p.Age > 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        } );

        DisplayPeople("exacly 25: ", people, p => p.Age == 25);


        //Demo();
    }


    static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
    {
        Console.WriteLine(title);
        foreach (Person p in people)
        {
            if (filter(p))
            {
                Console.WriteLine("{0}, {1} years old", p.Name, p.Age);
            }
        }
    }

    void Demo()
    {
        //list of names
        List<string> names = new List<string>() { "Rafał", "Patryk", "Kamil", "Piotr" };


        Console.WriteLine("before");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        names.RemoveAll(Filter);

        Console.WriteLine("after");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }


        return;
    }
    // a method called Filter that takes a string
    static bool Filter(string s)
    {
        // returns whether the string s contains letter 'i'
        // the Contains method will return a boo which we will return as well
        return s.Contains("i");
    }
    static bool IsMinor(Person p)
    {
        return p.Age < 18;
    }
    static bool IsAdult(Person p)
    {
        return p.Age >= 18;
    }
    static bool IsSenior(Person p)
    {
        return p.Age >= 65;
    }
}