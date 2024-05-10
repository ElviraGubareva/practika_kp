using System;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 70, 54 };
        int sumLimit = 535;
        int productLimit = 535;

        Parallel.ForEach(numbers, (number, state) =>
        {
            int sum = 0;
            int product = 1;

            for (int i = 0; i <= number; i++)
            {
                sum += i;
                product *= i > 0 ? i : 1; 

                if (sum > sumLimit || product > productLimit)
                {
                    Console.WriteLine($"Прерывание выполнения для числа {number}. Сумма: {sum}, Произведение: {product}");
                    state.Break();
                    return;
                }
            }

            Console.WriteLine($"Число: {number}, Сумма: {sum}, Произведение: {product}");
        });

        Console.ReadLine(); 
    }
}
