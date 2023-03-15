

using InheritanceC;

Post post1 = new Post("thans for the birthday wishes", true, "John Doe");
Console.WriteLine(post1.ToString());

ImagePost imagePost1 = new ImagePost("Check out my new socks", "John Doe", "https://image.socks.com", true);
Console.WriteLine(imagePost1.ToString());

Console.ReadKey();


