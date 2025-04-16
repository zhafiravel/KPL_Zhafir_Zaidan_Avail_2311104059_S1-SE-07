using System;

class Program
{
    static void Main()
    {
        try
        {
            SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - Zhafir Zaidan Avail - 2311104059");

            video.PrintVideoDetails();

            video.IncreasePlayCount(100);
            video.PrintVideoDetails();

            video.IncreasePlayCount(10000001); 

            SayaTubeVideo videoError = new SayaTubeVideo(new string('A', 101));
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
