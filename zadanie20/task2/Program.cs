using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        double b = 10; 

        Task<double>[] tasks = new Task<double>[2];

        tasks[0] = Task.Run(() =>
        {
            Thread.Sleep(1000); 
            return Math.Sqrt(2 * b) + Math.Sqrt(Math.Pow(b, 2) - 4) / (Math.Sqrt(Math.Pow(b, 2) - 4) + b + 2);
        });

        tasks[1] = Task.Run(() =>
        {
            Thread.Sleep(2000); 
            return 1 / (Math.Sqrt(b + 2));
        });

        Task.WhenAll(tasks).ContinueWith(t =>
        {
            Console.WriteLine("Все задачи выполнены.");
            Console.WriteLine($"z1 = {tasks[0].Result}, z2 = {tasks[1].Result}");
        });

        Task.WhenAny(tasks).ContinueWith(t =>
        {
            Console.WriteLine("Хотя бы одна задача выполнена.");
        });

        Console.ReadLine(); 
    }
}
