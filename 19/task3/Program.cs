using System;

class Program
{
    /// <summary>
    /// Метод для нахождения минимального значения из двух чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <returns>Минимальное значение из двух чисел.</returns>
    static double Min(double a, double b)
    {
        return a < b ? a : b;
    }

    /// <summary>
    /// Метод для нахождения минимального значения из трех чисел.
    /// </summary>
    /// <param name="a">Первое число.</param>
    /// <param name="b">Второе число.</param>
    /// <param name="c">Третье число.</param>
    /// <returns>Минимальное значение из трех чисел.</returns>
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
