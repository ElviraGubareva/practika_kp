using System;

namespace ReverseDigits
{
    public class Program
    {
        /// <summary>
        /// Метод для инвертирования цифр в числе.
        /// </summary>
        /// <param name="number">Число, которое нужно инвертировать.</param>
        public static void InvDigits(ref int number)
        {
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = (reversedNumber * 10) + digit;
                number /= 10;
            }
            number = reversedNumber;
        }

        public static void Main(string[] args)
        {
            int num1 = 154325;
            int num2 = 98987654;
            int num3 = 1123456;
            int num4 = 45654;
            int num5 = 72340;

            InvDigits(ref num1);
            InvDigits(ref num2);
            InvDigits(ref num3);
            InvDigits(ref num4);
            InvDigits(ref num5);

            Console.WriteLine($"Обратный порядок цифр: {num1}, {num2}, {num3}, {num4}, {num5}");
            Console.ReadLine();
        }
    }
}
