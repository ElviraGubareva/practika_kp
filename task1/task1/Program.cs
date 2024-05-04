using System;
using System.Threading;

class Program
{
    static AutoResetEvent autoEvent = new AutoResetEvent(false);

    static void Main()
    {
        Thread t1 = new Thread(PrintNumbers);
        t1.Name = "Thread 1";
        t1.Priority = ThreadPriority.Highest;

        Thread t2 = new Thread(PrintNumbers);
        t2.Name = "Thread 2";
        t2.Priority = ThreadPriority.AboveNormal;

        Thread t3 = new Thread(PrintNumbers);
        t3.Name = "Thread 3";
        t3.Priority = ThreadPriority.Normal;

        t1.Start(0);
        t2.Start(10);
        t3.Start(20);

        Console.ReadLine();
        Console.ReadLine();
    }

    static void PrintNumbers(object start)
    {
        int num = (int)start;
        for (int i = num; i < num + 10; i++)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {i}");
            Thread.Sleep(1000);
            if (i == num + 9)
            {
                autoEvent.Set();
            }
        }
    }
}
