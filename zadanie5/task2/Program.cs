using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[50];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(-100, 100); 
        }

        int lastNumber = numbers[numbers.Length - 1];

        int differentCount = 0;
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            if (numbers[i] != lastNumber)
            {
                differentCount++;
            }
        }

        Console.WriteLine("Количество чисел, отличных от последнего: " + differentCount);
        Console.ReadLine();
    }
}
