internal class Program
{
    private static void Main(string[] args)
    {
        Book book;
        book("title",50);
        string title = book._title;
        Console.WriteLine("Hello, World!");
    }
}

public class Book
{
    public string _title { get; set; } = "Unknown";
    public int _pages { get; set; } = 1;
    public Book(string Title, int Pages)
    {
        _title = Title;
        if (Pages < 1) { _pages = Pages; }else { _pages = 1; }
    }
}