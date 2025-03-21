using System;

class Program
{
    static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Zhafir Zaidan Avail");

        for (int i = 1; i <= 10; i++)
        {
            SayaTubeVideo video = new SayaTubeVideo($"Review Film {i} oleh Zhafir Zaidan Avail");
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();

        // Agar terminal tidak langsung tertutup
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
