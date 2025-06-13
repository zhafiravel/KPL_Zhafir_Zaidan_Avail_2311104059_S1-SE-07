using System;

public class SmsSubscriber : ISubscriber
{
    private string name;

    public SmsSubscriber(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"[SMS untuk {name}] Notifikasi: {message}");
    }
}
