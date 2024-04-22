using System;

class FactorialCalculation
{
    static void Main()
    {
        Console.Write("Введите значение n: ");
        int n = Convert.ToInt32(Console.ReadLine());
        double result = CalculateFactorial(1, n + 5); 
        Console.WriteLine($"f({n}) = {result}");
        Console.ReadLine();
    }

    static double CalculateFactorial(double accumulator, int number)
    {
        if (number <= 1)
            return accumulator; 
        else
            return CalculateFactorial(accumulator / number, number - 1); 
    }
}
