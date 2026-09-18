using System;
// Delegate declaration
public delegate void Notify();
class Publisher
{
    // Event declaration
    public event Notify OnMessage;
    public void SendMessage()
    {
        Console.WriteLine("Publisher: Sending Message...");
        if (OnMessage != null)
            OnMessage();
    }
}
class Subscriber
{
    public void ReceiveMessage()
    {
        Console.WriteLine("Subscriber: Message Received!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Publisher p = new Publisher();
        Subscriber s = new Subscriber();

        // Subscribe to the event
        p.OnMessage += s.ReceiveMessage;
        // Raise the event
        p.SendMessage();
        Console.ReadKey();
    }
}

