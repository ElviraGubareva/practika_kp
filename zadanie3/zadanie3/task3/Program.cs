using System;

class Program
{
    static double Min(double a, double b)
    {
        return a < b ? a : b;
    }

    static double Min(double a, double b, double c)
    {
        return Min(Min(a, b), c);
    }

    static void Main()
    {
        Console.WriteLine("Введите a1: ");
        double a1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите a2: ");
        double a2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите b2: ");
        double b2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Введите c2: ");
        double c2 = double.Parse(Console.ReadLine());

        double result = Min(a1, b1) * Min(a2, b2, c2);
        Console.WriteLine("Результат выражения Min(a1,b1) * Min(a2,b2,c2) = " + result);
        Console.ReadLine();
    }
}