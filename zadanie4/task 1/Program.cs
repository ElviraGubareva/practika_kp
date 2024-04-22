using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите значение x: ");
        string input = Console.ReadLine();

        try
        {
            double x = double.Parse(input);

            double y1 = CalculateExpression1(x);
            double y2 = CalculateExpression2(x);

            Console.WriteLine("Значение выражения y=1-(4/(4x+8)): " + y1);
            Console.WriteLine("Значение выражения y=tan^2(x)+1/(x-1): " + y2);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода данных. Введите корректное значение для x.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка. Деление на ноль.");
        }
        Console.ReadLine();
    }

    static double CalculateExpression1(double x)
    {
        if (4 * x + 8 == 0)
        {
            throw new DivideByZeroException();
        }

        return 1 - (4 / (4 * x + 8));
    }

    static double CalculateExpression2(double x)
    {
        if (x - 1 == 0)
        {
            throw new DivideByZeroException();
        }

        return Math.Tan(x) * Math.Tan(x) + 1 / (x - 1);
    }
}