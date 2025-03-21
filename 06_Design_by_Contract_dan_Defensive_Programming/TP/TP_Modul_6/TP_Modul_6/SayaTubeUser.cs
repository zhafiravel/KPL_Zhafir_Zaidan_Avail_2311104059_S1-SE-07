using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SayaTubeUser
{
    private int id;
    private string username;
    private List<SayaTubeVideo> uploadedVideos;

    public SayaTubeUser(string username)
    {
        Debug.Assert(username != null && username.Length <= 100, "Username harus tidak null dan maksimal 100 karakter");

        Random rand = new Random();
        this.id = rand.Next(10000, 99999); // Generate ID random 5 digit
        this.username = username;
        this.uploadedVideos = new List<SayaTubeVideo>();
    }

    public void AddVideo(SayaTubeVideo video)
    {
        Debug.Assert(video != null, "Video yang ditambahkan tidak boleh null");

        uploadedVideos.Add(video);
    }

    public int GetTotalVideoPlayCount()
    {
        int totalPlayCount = 0;
        foreach (var video in uploadedVideos)
        {
            totalPlayCount += video.GetPlayCount();
        }
        return totalPlayCount;
    }

    public void PrintAllVideoPlaycount()
    {
        Console.WriteLine($"User: {username}");

        int maxPrint = Math.Min(8, uploadedVideos.Count); // Maksimal print 8 video
        for (int i = 0; i < maxPrint; i++)
        {
            Console.WriteLine($"Video {i + 1} judul: {uploadedVideos[i].GetTitle()}");
        }
    }
}
