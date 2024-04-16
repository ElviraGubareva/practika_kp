using System;

namespace RealNumberInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое вещественное число: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Введите второе вещественное число: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Введите третье вещественное число: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"Первое число: {num1:F2}");
            Console.WriteLine($"Второе число: {num2:F2}");
            Console.WriteLine($"Третье число: {num3:F2}");
            Console.ReadLine();
        }
    }
}
