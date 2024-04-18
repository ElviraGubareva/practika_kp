using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите значение h: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("x\tf(x)");

        for (double x = a; x <= b; x += h)
        {
            double fx = x * x + 2 * x;
            Console.WriteLine($"{x}\t{fx}");
            Console.ReadLine();
        }
    }
}
