using System;

namespace FormulaCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 6.4;

            double y1Numerator = Math.Exp(x) / Math.Cos(Math.Sqrt(x - 1));
            double y1Denominator = 2 * Math.Atan(x * x) / (1 - x);
            double y1 = y1Numerator + y1Denominator;

            double y2 = 1 / Math.Sqrt(x + 2);

            Console.WriteLine($"Результат по первой формуле (y1): {y1}");
            Console.WriteLine($"Результат по второй формуле (y2): {y2}");
            Console.ReadLine();
        }
    }
}
