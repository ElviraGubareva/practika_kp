using System;

namespace ReverseDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int digit1 = number % 10;
            int digit2 = (number / 10) % 10;
            int digit3 = number / 100;

            int reversedNumber = digit1 * 100 + digit2 * 10 + digit3;

            Console.WriteLine($"Число, полученное при прочтении цифр справа налево: {reversedNumber}");
            Console.ReadLine();
        }
    }
}
