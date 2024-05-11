using System;

class Program
{
    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main()
    {
        Console.Write("Введите значение a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Введите значение b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введите значение h: ");
        double h = double.Parse(Console.ReadLine());

        Console.WriteLine("x\tf(x)");

        // Цикл для вычисления и вывода значений функции f(x) = x^2 + 2x
        for (double x = a; x <= b; x += h)
        {
            double fx = x * x + 2 * x;
            Console.WriteLine($"{x}\t{fx}");
            Console.ReadLine();
        }
    }
}
