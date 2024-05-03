using System;

class Program
{
    public delegate double MyDelegate(double x);

    public static double Function1(double x)
    {
        return x * x;
    }

    public static double Function2(double x)
    {
        return Math.Sin(x);
    }

    public static double Function3(double x)
    {
        if (x == 0)
            throw new DivideByZeroException("Деление на ноль в функции 3");
        return 1 / x;
    }

    static void Main(string[] args)
    {
        MyDelegate myDelegate = Function1;
        myDelegate += Function2;
        myDelegate += Function3;

        double x = 0.5;
        try
        {
            foreach (MyDelegate del in myDelegate.GetInvocationList())
            {
                Console.WriteLine($"Результат: {del(x)}");
            }
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.ReadLine();
    }
}
