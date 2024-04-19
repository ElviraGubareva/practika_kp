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
            double result = CalculateFunction(x);

            Console.WriteLine("Значение функции: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Ошибка ввода данных. Введите корректное значение для x.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Ошибка. Деление на ноль.");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Значение x выходит за допустимый диапазон.");
        }
        Console.ReadLine();
    }

    static double CalculateFunction(double x)
    {
        if (x > 1)
        {
            throw new ArgumentOutOfRangeException();
        }
        else if (x > -1)
        {
            if (x == 0)
            {
                throw new DivideByZeroException();
            }
            return Math.Cos(x) / x;
        }
        else
        {
            return 5 * x + 2;
        }
    }
}
