using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 789009, 3633639, 32524, -111, 999887};

        foreach (int num in numbers)
        {
            try
            {
                int count, sum;
                DigitCountSum(num, out count, out sum);
                Console.WriteLine("Число: {0}, Количество цифр: {1}, Сумма цифр: {2}", num, count, sum);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Ошибка: Деление на ноль.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Некорректный формат числа.");
            }
        }
    }

    static void DigitCountSum(int K, out int C, out int S)
    {
        if (K <= 0)
        {
            throw new ArgumentException("Число должно быть положительным.");
        }

        string numberStr = K.ToString();
        C = numberStr.Length;
        S = 0;

        foreach (char c in numberStr)
        {
            if (!char.IsDigit(c))
            {
                throw new FormatException("Число должно быть целым.");
            }
            int digit = c - '0';
            S += digit;
        }
        Console.ReadLine();
    }
}
