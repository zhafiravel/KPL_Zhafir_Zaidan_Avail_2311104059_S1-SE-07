using System;

public class EmailSubscriber : ISubscriber
{
    private string name;

    public EmailSubscriber(string name)
    {
        this.name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"[Email untuk {name}] Notifikasi: {message}");
    }
}
