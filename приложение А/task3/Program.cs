using System;

namespace FormulaCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение b: ");
            double b = double.Parse(Console.ReadLine());

            // Вычисление по первой формуле (z1)
            double z1Numerator = Math.Sqrt((2 * b + 2) * Math.Sqrt(b * b - 4));
            double z1Denominator = Math.Sqrt(b * b - 4) + b + 2;
            double z1 = z1Numerator / z1Denominator;

            // Вычисление по второй формуле (z2)
            double z2 = 1 / Math.Sqrt(b + 2);

            Console.WriteLine($"Результат по первой формуле (z1): {z1}");
            Console.WriteLine($"Результат по второй формуле (z2): {z2}");
            Console.ReadLine();

        }
    }
}
