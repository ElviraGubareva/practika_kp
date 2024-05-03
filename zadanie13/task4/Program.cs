using System;

public class EventClass
{
    public delegate void MyEventDelegate(string message);
    public event MyEventDelegate MyEvent;

    public void TriggerEvent(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            throw new ArgumentException("Сообщение не может быть null или пустым.");
        }

        MyEvent?.Invoke(message);
    }
}

public class Observer1
{
    public void OnMyEvent(string message)
    {
        Console.WriteLine($"Observer1 received: {message}");
    }
}

public class Observer2
{
    public void OnMyEvent(string message)
    {
        Console.WriteLine($"Observer2 received: {message}");
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            EventClass eventClass = new EventClass();
            Observer1 observer1 = new Observer1();
            Observer2 observer2 = new Observer2();

            eventClass.MyEvent += observer1.OnMyEvent;
            eventClass.MyEvent += observer1.OnMyEvent;
            eventClass.MyEvent += observer2.OnMyEvent;

            eventClass.TriggerEvent("Hello, observers!");
            eventClass.MyEvent -= observer1.OnMyEvent;
            eventClass.TriggerEvent("");
        }
        catch (ArgumentException e)
        {
            Console.WriteLine(e.Message);
            Console.ReadLine();
        }
    }
}
