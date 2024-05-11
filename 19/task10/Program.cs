using System;
using System.IO;
using System.Linq;

class Program
{
    /// <summary>
    /// Главный метод программы.
    /// </summary>
    static void Main()
    {
        try
        {
            // Путь к файлу
            string filePath = "g.txt";

            // Чтение всех строк из файла и преобразование их в числа
            var numbers = File.ReadAllLines(filePath).Select(int.Parse);

            // Подсчет количества четных чисел
            int evenCount = numbers.Count(n => n % 2 == 0);

            Console.WriteLine($"Количество четных чисел: {evenCount}");
        }
        catch (Exception ex)
        {
            // Обработка исключений
            Console.WriteLine($"Произошла ошибка: {ex.Message}");
        }
        Console.ReadLine();
    }
}
