

using InterfaceDemo;

Ticket t1 = new Ticket(12);
Ticket t2 = new Ticket(10);
Ticket t3 = new Ticket(12);

Console.WriteLine(t1.Equals(t2));
Console.WriteLine(t1.Equals(t3));

Console.ReadKey();