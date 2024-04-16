using System;

namespace SwapDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трехзначное число: ");
            int number = int.Parse(Console.ReadLine());

            int firstDigit = number / 100;
            int secondDigit = (number / 10) % 10;
            int thirdDigit = number % 10;

            int swappedNumber = secondDigit * 100 + firstDigit * 10 + thirdDigit;

            Console.WriteLine($"Число после перестановки: {swappedNumber}");
            Console.ReadLine();
        }
    }
}
