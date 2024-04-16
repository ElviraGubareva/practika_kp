using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите целое число K (1 <= K <= 100): ");
        int K = int.Parse(Console.ReadLine());

        Console.Write("Введите целое число N (1 <= N <= 100): ");
        int N = int.Parse(Console.ReadLine());

        if (K >= 1 && K <= 100 && N >= 1 && N <= 100)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(K);
            }
        }
        else
        {
            Console.WriteLine("Введите корректные значения для K и N (1 <= K, N <= 100).");
        }
        Console.ReadLine();
    }
}
