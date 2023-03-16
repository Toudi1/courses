

using InheritanceC;

Post post1 = new Post("thans for the birthday wishes", true, "John Doe");
Console.WriteLine(post1.ToString());

ImagePost imagePost1 = new ImagePost("Check out my new socks", "John Doe", "https://image.socks.com", true);
Console.WriteLine(imagePost1.ToString());

VideoPost videoPost1 = new VideoPost("Check out my new video", "John Doe", "https://video.socks.com", 5, true);
Console.WriteLine(videoPost1.ToString());

videoPost1.Play();
Console.WriteLine("press any key to stop video");
Console.ReadKey();
videoPost1.Stop();

Console.ReadKey();


