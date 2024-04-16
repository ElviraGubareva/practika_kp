using System;

class Program
{
    static void Main()
    {
        double x1 = 0;
        double x2 = 1; 

        double y1 = Math.Abs(2 * Math.Pow(x1, 2) + Math.Sin(x1) + 1);
        double y2 = 2 * x2 + Math.Exp(x2);

        Console.WriteLine($"Значение функции y1 при x = {x1}: {y1}");
        Console.WriteLine($"Значение функции y2 при x = {x2}: {y2}");
        Console.ReadLine();
    }
}
