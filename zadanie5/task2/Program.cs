using System;

class Program
{
    static void Main()
    {
        int[] numbers = new int[100];
        Random random = new Random();

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(1, 101);
        }

        int maxNumber = FindMaxNumber(numbers);

        int[] modifiedNumbers = new int[100];
        for (int i = 0; i < numbers.Length; i++)
        {
            modifiedNumbers[i] = numbers[i] == maxNumber ? 1 : 0;
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(numbers);

        Console.WriteLine("\nМодифицированный массив:");
        PrintArray(modifiedNumbers);

        Console.ReadLine();
    }

    static int FindMaxNumber(int[] array)
    {
        int max = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
    }
}
