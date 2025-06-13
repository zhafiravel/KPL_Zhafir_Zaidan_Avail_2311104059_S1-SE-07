using System;
using System.Collections.Generic;

public class NewsAgency
{
    private List<ISubscriber> subscribers = new List<ISubscriber>();
    private string latestNews;

    public void Attach(ISubscriber subscriber)
    {
        subscribers.Add(subscriber);
        Console.WriteLine($"[NewsAgency] {subscriber.GetType().Name} berhasil berlangganan.");
    }

    public void Detach(ISubscriber subscriber)
    {
        subscribers.Remove(subscriber);
        Console.WriteLine($"[NewsAgency] {subscriber.GetType().Name} berhenti berlangganan.");
    }

    public void PublishNews(string news)
    {
        Console.WriteLine($"\n[NewsAgency] Berita Terbaru: {news}");
        latestNews = news;
        Notify();
    }

    public void Notify()
    {
        foreach (var subscriber in subscribers)
        {
            subscriber.Update(latestNews);
        }
    }
}
