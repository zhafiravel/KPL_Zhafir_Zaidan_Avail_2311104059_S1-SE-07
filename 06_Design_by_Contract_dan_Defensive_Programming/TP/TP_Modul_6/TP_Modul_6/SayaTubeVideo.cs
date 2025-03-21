using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        Debug.Assert(title != null && title.Length <= 200, "Judul video harus tidak null dan maksimal 200 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // Generate ID random 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count <= 0 || count > 25000000)
        {
            Console.WriteLine("ERROR: Play count harus antara 1 hingga 25 juta!");
            return;
        }

        try
        {
            checked
            {
                playCount += count;
            }
        }
        catch (OverflowException)
        {
            Console.WriteLine("ERROR: Play count melebihi batas integer maksimum!");
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}
