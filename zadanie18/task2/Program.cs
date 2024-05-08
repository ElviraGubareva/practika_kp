using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string path = "path_to_your_file.txt";
        int a = 10; 
        int b = 20; 
        PrintNumbersInOrder(path, a, b);
        Console.ReadLine();
    }

    static void PrintNumbersInOrder(string path, int a, int b)
    {
        Queue<int> inRange = new Queue<int>();
        Queue<int> lessThanA = new Queue<int>();
        Queue<int> greaterThanB = new Queue<int>();

        using (StreamReader sr = new StreamReader(path))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int number = int.Parse(line);
                if (number >= a && number <= b)
                {
                    inRange.Enqueue(number);
                }
                else if (number < a)
                {
                    lessThanA.Enqueue(number);
                }
                else
                {
                    greaterThanB.Enqueue(number);
                }
            }
        }

        Console.WriteLine("Numbers in range [" + a + ", " + b + "]:");
        PrintQueue(inRange);

        Console.WriteLine("Numbers less than " + a + ":");
        PrintQueue(lessThanA);

        Console.WriteLine("Numbers greater than " + b + ":");
        PrintQueue(greaterThanB);
    }

    static void PrintQueue(Queue<int> queue)
    {
        while (queue.Count > 0)
        {
            Console.WriteLine(queue.Dequeue());
        }
    }
}
