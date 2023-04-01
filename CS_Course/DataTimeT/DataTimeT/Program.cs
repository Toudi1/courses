

DateTime dateTime = new DateTime(2018, 5, 31);


Console.WriteLine("My birthday is {0}", dateTime);

// write current date
Console.WriteLine(DateTime.Today);

// write current time
Console.WriteLine(DateTime.Now);
// write tommorow date
Console.WriteLine("Tommorow will be: {0}",GetTommorow());

//write day of week
Console.WriteLine("Today is {0}", DateTime.Today.DayOfWeek);

// writ first day of year
Console.WriteLine(GetFirstDayOfYear(1998));

int days = DateTime.DaysInMonth(2000, 2);
Console.WriteLine("Days in Feb 2000: {0}", days);
 days = DateTime.DaysInMonth(2001, 2);
Console.WriteLine("Days in Feb 2001: {0}", days);
days = DateTime.DaysInMonth(2004, 2);
Console.WriteLine("Days in Feb 2004: {0}", days);

DateTime now = DateTime.Now;
Console.WriteLine("Minute: {0}",now.Minute);

Console.WriteLine("h:{0} m:{1} s:{2}",now.Hour,now.Minute,now.Second);

Console.WriteLine("Please enter a date in format: yyyy-mm-dd");
string input = Console.ReadLine();
if (DateTime.TryParse(input, out dateTime))
{
    Console.WriteLine(dateTime);
    TimeSpan daysPassed = now.Subtract(dateTime);
    Console.WriteLine("days passed since: {0}",daysPassed.Days);
}
else Console.WriteLine("Wrong input");


Console.ReadKey();



static DateTime GetTommorow()
{
    return DateTime.Today.AddDays(1);
}

static DateTime GetFirstDayOfYear(int year)
{
    return new DateTime(year, 1, 1);
}
