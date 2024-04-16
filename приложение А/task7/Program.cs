using System;

namespace RectangleCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину прямоугольника (a): ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Введите ширину прямоугольника (b): ");
            double width = double.Parse(Console.ReadLine());

            double area = length * width;

            double perimeter = 2 * (length + width);

            double diagonal = Math.Sqrt(length * length + width * width);

            Console.WriteLine($"Площадь прямоугольника: {area:F2}");
            Console.WriteLine($"Периметр прямоугольника: {perimeter:F2}");
            Console.WriteLine($"Длина диагонали прямоугольника: {diagonal:F2}");
            Console.ReadLine();
        }
    }
}
