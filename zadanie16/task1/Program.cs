using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            string filePath = "g.txt"; 
            var numbers = File.ReadAllLines(filePath).Select(int.Parse);
            int evenCount = numbers.Count(n => n % 2 == 0);

            Console.WriteLine($"Количество четных чисел: {evenCount}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        Console.ReadLine();
    }
}
