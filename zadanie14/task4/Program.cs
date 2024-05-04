using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = Enumerable.Range(0, 100).ToArray(); 
        int threadCount = 4; 

        int[] partialSums = new int[threadCount];
        Thread[] threads = new Thread[threadCount];

        for (int i = 0; i < threadCount; i++)
        {
            int threadIndex = i;
            threads[i] = new Thread(() =>
            {
                int start = threadIndex * numbers.Length / threadCount;
                int end = (threadIndex + 1) * numbers.Length / threadCount;
                for (int j = start; j < end; j++)
                {
                    if (numbers[j] % 2 == 0)
                    {
                        partialSums[threadIndex] += numbers[j];
                    }
                }
            });

            threads[i].Start();
        }

        foreach (Thread thread in threads)
        {
            thread.Join();
        }

        int totalSum = partialSums.Sum();

        Console.WriteLine("Сумма четных чисел: " + totalSum);
        Console.ReadLine();
    }
}
