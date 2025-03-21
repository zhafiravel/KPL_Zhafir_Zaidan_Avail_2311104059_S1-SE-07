using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 200)
            throw new ArgumentException("Judul tidak boleh kosong dan maksimal 200 karakter!");

        this.id = new Random().Next(10000, 99999); // Generate random 5 digit
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 25000000)
            throw new ArgumentException("Jumlah play count tidak valid!");

        checked { playCount += count; }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"ID: {id}, Title: {title}, Play Count: {playCount}");
    }

    public string GetTitle()
    {
        return title;
    }

    public int GetPlayCount()
    {
        return playCount;
    }
}
