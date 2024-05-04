using System;
using System.Threading;
class Program
{
    static object lockObject = new object();
    static void Main()
    {
        Console.Write("Введите значение A: ");
        int A = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int N = Convert.ToInt32(Console.ReadLine());
        Thread t1 = new Thread(() => Sum(A, N));
        Thread t2 = new Thread(() => Sum(A, N));
        t1.Start();
        t2.Start();
        t1.Join();
        t2.Join();
        Thread t3 = new Thread(() => Multiply(A, N));
        t3.Start();
        t3.Join();

        Console.ReadLine();
    }
    static void Sum(int A, int N)
    {
        int sum = A;
        for (int i = 1; i <= N; i++)
        {
            sum += A;
        }
        Console.WriteLine($"Сумма: {sum}");
    }
    static void Multiply(int A, int N)
    {
        lock (lockObject)
        {
            int product = A;
            for (int i = 1; i <= N; i++)
            {
                product *= A;
            }
            Console.WriteLine($"Произведение: {product}");
        }
    }
}
