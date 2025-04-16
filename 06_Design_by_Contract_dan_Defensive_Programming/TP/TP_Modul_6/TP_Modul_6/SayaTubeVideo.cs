using System;
using System.Diagnostics;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        // Validasi pre-kondisi
        Debug.Assert(title != null, "Judul tidak boleh null!");
        Debug.Assert(title.Length > 0 && title.Length <= 100, "Judul harus memiliki 1-100 karakter!");

        // Generate ID random 5 digit
        Random rand = new Random();
        this.id = rand.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        // Validasi pre-kondisi
        Debug.Assert(count > 0 && count <= 10000000, "Jumlah play count harus antara 1 - 10.000.000!");

        // Mencegah integer overflow
        checked
        {
            playCount += count;
        }
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID   : {id}");
        Console.WriteLine($"Title      : {title}");
        Console.WriteLine($"Play Count : {playCount}");
    }
}
