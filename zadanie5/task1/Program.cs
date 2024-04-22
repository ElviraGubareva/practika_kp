using System;

class Program
{
    static void Main()
    {
        double[] array = { -1.5, 2.3, -3.7, 4.6, -5.9 };

        int negativeCount = 0;
        foreach (double number in array)
        {
            if (number < 0)
            {
                negativeCount++;
            }
        }

        Console.WriteLine("Количество отрицательных элементов: " + negativeCount);
        Console.ReadLine();
    }
}